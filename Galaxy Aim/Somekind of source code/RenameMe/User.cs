using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows;

namespace RenameMe
{
	// Token: 0x02000022 RID: 34
	internal class User
	{
		// Token: 0x17000006 RID: 6
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002383 File Offset: 0x00000583
		public static string Username
		{
			[CompilerGenerated]
			set
			{
				User.<Username>k__BackingField = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000238B File Offset: 0x0000058B
		public static string Password
		{
			[CompilerGenerated]
			set
			{
				User.<Password>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002393 File Offset: 0x00000593
		public static string HWID
		{
			[CompilerGenerated]
			set
			{
				User.<HWID>k__BackingField = value;
			}
		}

		// Token: 0x02000023 RID: 35
		internal class API
		{
			// Token: 0x06000061 RID: 97 RVA: 0x00004CC0 File Offset: 0x00002EC0
			public static bool Login(string userlogin, string passlogin)
			{
				if (string.IsNullOrWhiteSpace(userlogin) || string.IsNullOrWhiteSpace(passlogin))
				{
					MessageBox.Show(TokenizerWrapper.SpaceNull, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Hand);
					Environment.Exit(0);
				}
				new string[0];
				bool result;
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					string currentDirectory = Directory.GetCurrentDirectory();
					WebClient webClient2 = new WebClient();
					string value = WindowsIdentity.GetCurrent().User.Value;
					string text = webClient2.DownloadString(string.Concat(new string[]
					{
						TokenizerWrapper.ApiUrl,
						"?usuario=",
						userlogin,
						"&senha=",
						passlogin,
						"&hwid=",
						value,
						"&v=",
						TokenizerWrapper.Version
					}));
					string text2 = webClient2.DownloadString(string.Concat(new string[]
					{
						TokenizerWrapper.ApiUrl,
						"plan.php?user=",
						userlogin,
						"&senha=",
						passlogin
					}));
					if (text.Contains("sucess_login"))
					{
						if (text2.Equals(TokenizerWrapper.Plan) || text2.Equals(TokenizerWrapper.PlanDuplo))
						{
							return true;
						}
						MessageBox.Show(TokenizerWrapper.PlanMSG, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					else if (text.Contains("hwid_error"))
					{
						MessageBox.Show(TokenizerWrapper.HwidError, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Hand);
						Environment.Exit(0);
					}
					else if (text.Contains("login_expired"))
					{
						MessageBox.Show(TokenizerWrapper.Expire, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Environment.Exit(0);
					}
					else
					{
						if (text.Contains("fail_login"))
						{
							MessageBox.Show(TokenizerWrapper.IncorrectAd, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Hand);
							return false;
						}
						MessageBox.Show(TokenizerWrapper.NewVersion, TokenizerWrapper.AppName, MessageBoxButton.OK, MessageBoxImage.Asterisk);
						webClient2.DownloadFile(text, currentDirectory + "\\GalaxyUpdate.rar");
						Thread.Sleep(2000);
						Process.Start(currentDirectory + "\\GalaxyUpdate.rar");
						MessageBox.Show("Nova versao,extraia o arquivo GalaxyUpdate.rar\nNew version,Extract GalaxyUpdate.rar", "Galaxy AutoUpdater");
						Environment.Exit(0);
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x02000024 RID: 36
		internal class Encryption
		{
			// Token: 0x06000063 RID: 99 RVA: 0x00004EF4 File Offset: 0x000030F4
			public static string EncryptString(string plainText, byte[] key, byte[] iv)
			{
				Aes aes = Aes.Create();
				aes.Mode = CipherMode.CBC;
				aes.Key = key;
				aes.IV = iv;
				MemoryStream memoryStream = new MemoryStream();
				ICryptoTransform transform = aes.CreateEncryptor();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(plainText);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				return Convert.ToBase64String(array, 0, array.Length);
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00004F70 File Offset: 0x00003170
			public static string DecryptString(string cipherText, byte[] key, byte[] iv)
			{
				Aes aes = Aes.Create();
				aes.Mode = CipherMode.CBC;
				aes.Key = key;
				aes.IV = iv;
				MemoryStream memoryStream = new MemoryStream();
				ICryptoTransform transform = aes.CreateDecryptor();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				string result = string.Empty;
				try
				{
					byte[] array = Convert.FromBase64String(cipherText);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					byte[] array2 = memoryStream.ToArray();
					result = Encoding.ASCII.GetString(array2, 0, array2.Length);
				}
				finally
				{
					memoryStream.Close();
					cryptoStream.Close();
				}
				return result;
			}

			// Token: 0x06000065 RID: 101 RVA: 0x0000500C File Offset: 0x0000320C
			public static string Decode(string text)
			{
				text = text.Replace('_', '/').Replace('-', '+');
				int num = text.Length % 4;
				if (num != 2)
				{
					if (num == 3)
					{
						text += "=";
					}
				}
				else
				{
					text += "==";
				}
				return Encoding.UTF8.GetString(Convert.FromBase64String(text));
			}
		}
	}
}
