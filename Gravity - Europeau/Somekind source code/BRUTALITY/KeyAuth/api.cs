using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class api
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002A48 File Offset: 0x00000C48
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002ADC File Offset: 0x00000CDC
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000215A File Offset: 0x0000035A
		public static bool IsDebugRelease
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000215D File Offset: 0x0000035D
		public void Checkinit()
		{
			if (!this.initzalized)
			{
				if (api.IsDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
					return;
				}
				api.error("Please initialize first");
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C60 File Offset: 0x00000E60
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002DBC File Offset: 0x00000FBC
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F00 File Offset: 0x00001100
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003020 File Offset: 0x00001220
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000314C File Offset: 0x0000134C
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003224 File Offset: 0x00001424
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000332C File Offset: 0x0000152C
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000342C File Offset: 0x0000162C
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003504 File Offset: 0x00001704
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.message;
			}
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003614 File Offset: 0x00001814
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.messages;
			}
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003714 File Offset: 0x00001914
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003828 File Offset: 0x00001A28
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003934 File Offset: 0x00001B34
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A7C File Offset: 0x00001C7C
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return encryption.str_to_byte_arr(response_structure.contents);
			}
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003B80 File Offset: 0x00001D80
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.req(nameValueCollection);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C68 File Offset: 0x00001E68
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D28 File Offset: 0x00001F28
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003DC4 File Offset: 0x00001FC4
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003E28 File Offset: 0x00002028
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003E9C File Offset: 0x0000209C
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			return Convert.ToString((d - DateTime.Now).Days);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002183 File Offset: 0x00000383
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000004 RID: 4
		public string name;

		// Token: 0x04000005 RID: 5
		public string ownerid;

		// Token: 0x04000006 RID: 6
		public string secret;

		// Token: 0x04000007 RID: 7
		public string version;

		// Token: 0x04000008 RID: 8
		private string sessionid;

		// Token: 0x04000009 RID: 9
		private string enckey;

		// Token: 0x0400000A RID: 10
		private bool initzalized;

		// Token: 0x0400000B RID: 11
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400000C RID: 12
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000D RID: 13
		public api.response_class response = new api.response_class();

		// Token: 0x0400000E RID: 14
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000006 RID: 6
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002A RID: 42 RVA: 0x000021A7 File Offset: 0x000003A7
			// (set) Token: 0x0600002B RID: 43 RVA: 0x000021AF File Offset: 0x000003AF
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600002C RID: 44 RVA: 0x000021B8 File Offset: 0x000003B8
			// (set) Token: 0x0600002D RID: 45 RVA: 0x000021C0 File Offset: 0x000003C0
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600002E RID: 46 RVA: 0x000021C9 File Offset: 0x000003C9
			// (set) Token: 0x0600002F RID: 47 RVA: 0x000021D1 File Offset: 0x000003D1
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000030 RID: 48 RVA: 0x000021DA File Offset: 0x000003DA
			// (set) Token: 0x06000031 RID: 49 RVA: 0x000021E2 File Offset: 0x000003E2
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000032 RID: 50 RVA: 0x000021EB File Offset: 0x000003EB
			// (set) Token: 0x06000033 RID: 51 RVA: 0x000021F3 File Offset: 0x000003F3
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000034 RID: 52 RVA: 0x000021FC File Offset: 0x000003FC
			// (set) Token: 0x06000035 RID: 53 RVA: 0x00002204 File Offset: 0x00000404
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000036 RID: 54 RVA: 0x0000220D File Offset: 0x0000040D
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002215 File Offset: 0x00000415
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000038 RID: 56 RVA: 0x0000221E File Offset: 0x0000041E
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00002226 File Offset: 0x00000426
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003A RID: 58 RVA: 0x0000222F File Offset: 0x0000042F
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002237 File Offset: 0x00000437
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000007 RID: 7
		public class msg
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00002240 File Offset: 0x00000440
			// (set) Token: 0x0600003E RID: 62 RVA: 0x00002248 File Offset: 0x00000448
			public string message { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002251 File Offset: 0x00000451
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00002259 File Offset: 0x00000459
			public string author { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00002262 File Offset: 0x00000462
			// (set) Token: 0x06000042 RID: 66 RVA: 0x0000226A File Offset: 0x0000046A
			public string timestamp { get; set; }
		}

		// Token: 0x02000008 RID: 8
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002273 File Offset: 0x00000473
			// (set) Token: 0x06000045 RID: 69 RVA: 0x0000227B File Offset: 0x0000047B
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002284 File Offset: 0x00000484
			// (set) Token: 0x06000047 RID: 71 RVA: 0x0000228C File Offset: 0x0000048C
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000048 RID: 72 RVA: 0x00002295 File Offset: 0x00000495
			// (set) Token: 0x06000049 RID: 73 RVA: 0x0000229D File Offset: 0x0000049D
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600004A RID: 74 RVA: 0x000022A6 File Offset: 0x000004A6
			// (set) Token: 0x0600004B RID: 75 RVA: 0x000022AE File Offset: 0x000004AE
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600004C RID: 76 RVA: 0x000022B7 File Offset: 0x000004B7
			// (set) Token: 0x0600004D RID: 77 RVA: 0x000022BF File Offset: 0x000004BF
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600004E RID: 78 RVA: 0x000022C8 File Offset: 0x000004C8
			// (set) Token: 0x0600004F RID: 79 RVA: 0x000022D0 File Offset: 0x000004D0
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000009 RID: 9
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000051 RID: 81 RVA: 0x000022D9 File Offset: 0x000004D9
			// (set) Token: 0x06000052 RID: 82 RVA: 0x000022E1 File Offset: 0x000004E1
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000053 RID: 83 RVA: 0x000022EA File Offset: 0x000004EA
			// (set) Token: 0x06000054 RID: 84 RVA: 0x000022F2 File Offset: 0x000004F2
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000055 RID: 85 RVA: 0x000022FB File Offset: 0x000004FB
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00002303 File Offset: 0x00000503
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000057 RID: 87 RVA: 0x0000230C File Offset: 0x0000050C
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00002314 File Offset: 0x00000514
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000059 RID: 89 RVA: 0x0000231D File Offset: 0x0000051D
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00002325 File Offset: 0x00000525
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600005B RID: 91 RVA: 0x0000232E File Offset: 0x0000052E
			// (set) Token: 0x0600005C RID: 92 RVA: 0x00002336 File Offset: 0x00000536
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class app_data_class
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600005E RID: 94 RVA: 0x0000233F File Offset: 0x0000053F
			// (set) Token: 0x0600005F RID: 95 RVA: 0x00002347 File Offset: 0x00000547
			public string numUsers { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002350 File Offset: 0x00000550
			// (set) Token: 0x06000061 RID: 97 RVA: 0x00002358 File Offset: 0x00000558
			public string numOnlineUsers { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00002361 File Offset: 0x00000561
			// (set) Token: 0x06000063 RID: 99 RVA: 0x00002369 File Offset: 0x00000569
			public string numKeys { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002372 File Offset: 0x00000572
			// (set) Token: 0x06000065 RID: 101 RVA: 0x0000237A File Offset: 0x0000057A
			public string version { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002383 File Offset: 0x00000583
			// (set) Token: 0x06000067 RID: 103 RVA: 0x0000238B File Offset: 0x0000058B
			public string customerPanelLink { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00002394 File Offset: 0x00000594
			// (set) Token: 0x06000069 RID: 105 RVA: 0x0000239C File Offset: 0x0000059C
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class user_data_class
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600006B RID: 107 RVA: 0x000023A5 File Offset: 0x000005A5
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000023AD File Offset: 0x000005AD
			public string username { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600006D RID: 109 RVA: 0x000023B6 File Offset: 0x000005B6
			// (set) Token: 0x0600006E RID: 110 RVA: 0x000023BE File Offset: 0x000005BE
			public string ip { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600006F RID: 111 RVA: 0x000023C7 File Offset: 0x000005C7
			// (set) Token: 0x06000070 RID: 112 RVA: 0x000023CF File Offset: 0x000005CF
			public string hwid { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000071 RID: 113 RVA: 0x000023D8 File Offset: 0x000005D8
			// (set) Token: 0x06000072 RID: 114 RVA: 0x000023E0 File Offset: 0x000005E0
			public string createdate { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000073 RID: 115 RVA: 0x000023E9 File Offset: 0x000005E9
			// (set) Token: 0x06000074 RID: 116 RVA: 0x000023F1 File Offset: 0x000005F1
			public string lastlogin { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000075 RID: 117 RVA: 0x000023FA File Offset: 0x000005FA
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00002402 File Offset: 0x00000602
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class Data
		{
			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000078 RID: 120 RVA: 0x0000240B File Offset: 0x0000060B
			// (set) Token: 0x06000079 RID: 121 RVA: 0x00002413 File Offset: 0x00000613
			public string subscription { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600007A RID: 122 RVA: 0x0000241C File Offset: 0x0000061C
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002424 File Offset: 0x00000624
			public string expiry { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600007C RID: 124 RVA: 0x0000242D File Offset: 0x0000062D
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00002435 File Offset: 0x00000635
			public string timeleft { get; set; }
		}

		// Token: 0x0200000D RID: 13
		public class response_class
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600007F RID: 127 RVA: 0x0000243E File Offset: 0x0000063E
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00002446 File Offset: 0x00000646
			public bool success { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000081 RID: 129 RVA: 0x0000244F File Offset: 0x0000064F
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00002457 File Offset: 0x00000657
			public string message { get; set; }
		}
	}
}
