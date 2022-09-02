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
using System.Threading;

namespace RenameMe
{
	// Token: 0x02000035 RID: 53
	public class api
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00005AD0 File Offset: 0x00003CD0
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

		// Token: 0x060000AE RID: 174 RVA: 0x00005B64 File Offset: 0x00003D64
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

		// Token: 0x060000AF RID: 175 RVA: 0x000024BA File Offset: 0x000006BA
		public void Checkinit()
		{
			if (!this.initzalized)
			{
				if (false)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
					return;
				}
				api.error("Please initialize first");
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005CE8 File Offset: 0x00003EE8
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

		// Token: 0x060000B1 RID: 177 RVA: 0x00005E44 File Offset: 0x00004044
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

		// Token: 0x060000B2 RID: 178 RVA: 0x00005F88 File Offset: 0x00004188
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

		// Token: 0x060000B3 RID: 179 RVA: 0x000060A8 File Offset: 0x000042A8
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

		// Token: 0x060000B4 RID: 180 RVA: 0x000061D4 File Offset: 0x000043D4
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

		// Token: 0x060000B5 RID: 181 RVA: 0x000062AC File Offset: 0x000044AC
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

		// Token: 0x060000B6 RID: 182 RVA: 0x000063B4 File Offset: 0x000045B4
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

		// Token: 0x060000B7 RID: 183 RVA: 0x000064B4 File Offset: 0x000046B4
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

		// Token: 0x060000B8 RID: 184 RVA: 0x0000658C File Offset: 0x0000478C
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

		// Token: 0x060000B9 RID: 185 RVA: 0x0000669C File Offset: 0x0000489C
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

		// Token: 0x060000BA RID: 186 RVA: 0x0000679C File Offset: 0x0000499C
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

		// Token: 0x060000BB RID: 187 RVA: 0x000068B0 File Offset: 0x00004AB0
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

		// Token: 0x060000BC RID: 188 RVA: 0x000069BC File Offset: 0x00004BBC
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

		// Token: 0x060000BD RID: 189 RVA: 0x00006B04 File Offset: 0x00004D04
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

		// Token: 0x060000BE RID: 190 RVA: 0x00006C08 File Offset: 0x00004E08
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

		// Token: 0x060000BF RID: 191 RVA: 0x00006CF0 File Offset: 0x00004EF0
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

		// Token: 0x060000C0 RID: 192 RVA: 0x00006D60 File Offset: 0x00004F60
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

		// Token: 0x060000C1 RID: 193 RVA: 0x00006DB0 File Offset: 0x00004FB0
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
					Thread.Sleep(1000);
					result = api.req(post_data);
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00006E48 File Offset: 0x00005048
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006EAC File Offset: 0x000050AC
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006F20 File Offset: 0x00005120
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000024DC File Offset: 0x000006DC
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000330 RID: 816
		public string name;

		// Token: 0x04000331 RID: 817
		public string ownerid;

		// Token: 0x04000332 RID: 818
		public string secret;

		// Token: 0x04000333 RID: 819
		public string version;

		// Token: 0x04000334 RID: 820
		private string sessionid;

		// Token: 0x04000335 RID: 821
		private string enckey;

		// Token: 0x04000336 RID: 822
		private bool initzalized;

		// Token: 0x04000337 RID: 823
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000338 RID: 824
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000339 RID: 825
		public api.response_class response = new api.response_class();

		// Token: 0x0400033A RID: 826
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000036 RID: 54
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002500 File Offset: 0x00000700
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002508 File Offset: 0x00000708
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002511 File Offset: 0x00000711
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002519 File Offset: 0x00000719
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00002522 File Offset: 0x00000722
			// (set) Token: 0x060000CB RID: 203 RVA: 0x0000252A File Offset: 0x0000072A
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00002533 File Offset: 0x00000733
			// (set) Token: 0x060000CD RID: 205 RVA: 0x0000253B File Offset: 0x0000073B
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000CE RID: 206 RVA: 0x00002544 File Offset: 0x00000744
			// (set) Token: 0x060000CF RID: 207 RVA: 0x0000254C File Offset: 0x0000074C
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002555 File Offset: 0x00000755
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000255D File Offset: 0x0000075D
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002566 File Offset: 0x00000766
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000256E File Offset: 0x0000076E
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002577 File Offset: 0x00000777
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000257F File Offset: 0x0000077F
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002588 File Offset: 0x00000788
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002590 File Offset: 0x00000790
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000037 RID: 55
		public class msg
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002599 File Offset: 0x00000799
			// (set) Token: 0x060000DA RID: 218 RVA: 0x000025A1 File Offset: 0x000007A1
			public string message { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000DB RID: 219 RVA: 0x000025AA File Offset: 0x000007AA
			// (set) Token: 0x060000DC RID: 220 RVA: 0x000025B2 File Offset: 0x000007B2
			public string author { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000DD RID: 221 RVA: 0x000025BB File Offset: 0x000007BB
			// (set) Token: 0x060000DE RID: 222 RVA: 0x000025C3 File Offset: 0x000007C3
			public string timestamp { get; set; }
		}

		// Token: 0x02000038 RID: 56
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x000025CC File Offset: 0x000007CC
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x000025D4 File Offset: 0x000007D4
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x000025DD File Offset: 0x000007DD
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x000025E5 File Offset: 0x000007E5
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000025EE File Offset: 0x000007EE
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x000025F6 File Offset: 0x000007F6
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000025FF File Offset: 0x000007FF
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002607 File Offset: 0x00000807
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002610 File Offset: 0x00000810
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002618 File Offset: 0x00000818
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00002621 File Offset: 0x00000821
			// (set) Token: 0x060000EB RID: 235 RVA: 0x00002629 File Offset: 0x00000829
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000039 RID: 57
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000ED RID: 237 RVA: 0x00002632 File Offset: 0x00000832
			// (set) Token: 0x060000EE RID: 238 RVA: 0x0000263A File Offset: 0x0000083A
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000EF RID: 239 RVA: 0x00002643 File Offset: 0x00000843
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000264B File Offset: 0x0000084B
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002654 File Offset: 0x00000854
			// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000265C File Offset: 0x0000085C
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002665 File Offset: 0x00000865
			// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000266D File Offset: 0x0000086D
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002676 File Offset: 0x00000876
			// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000267E File Offset: 0x0000087E
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002687 File Offset: 0x00000887
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000268F File Offset: 0x0000088F
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200003A RID: 58
		public class app_data_class
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00002698 File Offset: 0x00000898
			// (set) Token: 0x060000FB RID: 251 RVA: 0x000026A0 File Offset: 0x000008A0
			public string numUsers { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000FC RID: 252 RVA: 0x000026A9 File Offset: 0x000008A9
			// (set) Token: 0x060000FD RID: 253 RVA: 0x000026B1 File Offset: 0x000008B1
			public string numOnlineUsers { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000FE RID: 254 RVA: 0x000026BA File Offset: 0x000008BA
			// (set) Token: 0x060000FF RID: 255 RVA: 0x000026C2 File Offset: 0x000008C2
			public string numKeys { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000026CB File Offset: 0x000008CB
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000026D3 File Offset: 0x000008D3
			public string version { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000102 RID: 258 RVA: 0x000026DC File Offset: 0x000008DC
			// (set) Token: 0x06000103 RID: 259 RVA: 0x000026E4 File Offset: 0x000008E4
			public string customerPanelLink { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000104 RID: 260 RVA: 0x000026ED File Offset: 0x000008ED
			// (set) Token: 0x06000105 RID: 261 RVA: 0x000026F5 File Offset: 0x000008F5
			public string downloadLink { get; set; }
		}

		// Token: 0x0200003B RID: 59
		public class user_data_class
		{
			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000107 RID: 263 RVA: 0x000026FE File Offset: 0x000008FE
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00002706 File Offset: 0x00000906
			public string username { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000109 RID: 265 RVA: 0x0000270F File Offset: 0x0000090F
			// (set) Token: 0x0600010A RID: 266 RVA: 0x00002717 File Offset: 0x00000917
			public string ip { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600010B RID: 267 RVA: 0x00002720 File Offset: 0x00000920
			// (set) Token: 0x0600010C RID: 268 RVA: 0x00002728 File Offset: 0x00000928
			public string hwid { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00002731 File Offset: 0x00000931
			// (set) Token: 0x0600010E RID: 270 RVA: 0x00002739 File Offset: 0x00000939
			public string createdate { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00002742 File Offset: 0x00000942
			// (set) Token: 0x06000110 RID: 272 RVA: 0x0000274A File Offset: 0x0000094A
			public string lastlogin { get; set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000111 RID: 273 RVA: 0x00002753 File Offset: 0x00000953
			// (set) Token: 0x06000112 RID: 274 RVA: 0x0000275B File Offset: 0x0000095B
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200003C RID: 60
		public class Data
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00002764 File Offset: 0x00000964
			// (set) Token: 0x06000115 RID: 277 RVA: 0x0000276C File Offset: 0x0000096C
			public string subscription { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000116 RID: 278 RVA: 0x00002775 File Offset: 0x00000975
			// (set) Token: 0x06000117 RID: 279 RVA: 0x0000277D File Offset: 0x0000097D
			public string expiry { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000118 RID: 280 RVA: 0x00002786 File Offset: 0x00000986
			// (set) Token: 0x06000119 RID: 281 RVA: 0x0000278E File Offset: 0x0000098E
			public string timeleft { get; set; }
		}

		// Token: 0x0200003D RID: 61
		public class response_class
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00002797 File Offset: 0x00000997
			// (set) Token: 0x0600011C RID: 284 RVA: 0x0000279F File Offset: 0x0000099F
			public bool success { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000027A8 File Offset: 0x000009A8
			// (set) Token: 0x0600011E RID: 286 RVA: 0x000027B0 File Offset: 0x000009B0
			public string message { get; set; }
		}
	}
}
