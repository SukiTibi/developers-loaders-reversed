using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

namespace RenameMe
{
	// Token: 0x02000018 RID: 24
	public class BroadCastWrite
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000226A File Offset: 0x0000046A
		public static string color
		{
			[CompilerGenerated]
			set
			{
				BroadCastWrite.<color>k__BackingField = value;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004890 File Offset: 0x00002A90
		[return: Dynamic]
		public static dynamic GetConfigFile(ParamExceptionID.CancelStub conf, int mode)
		{
			if (BroadCastWrite.configIni.KeyExists(conf.ToString(), mode.ToString()))
			{
				return BroadCastWrite.configIni.Read(conf.ToString(), mode.ToString());
			}
			BroadCastWrite.configIni.Write(conf.ToString(), "0", mode.ToString());
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004908 File Offset: 0x00002B08
		[return: Dynamic]
		public static dynamic GetConfig(ParamExceptionID.CancelStub conf, int mode)
		{
			UtilsParserDescriptor utilsParserDescriptor = BroadCastWrite.value.FirstOrDefault((UtilsParserDescriptor x) => x.config == conf && x.mode == mode);
			if (utilsParserDescriptor == null)
			{
				object configFile = BroadCastWrite.GetConfigFile(conf, mode);
				BroadCastWrite.value.Add(new UtilsParserDescriptor
				{
					config = conf,
					mode = mode,
					value = configFile
				});
				utilsParserDescriptor = BroadCastWrite.value.FirstOrDefault((UtilsParserDescriptor x) => x.config == conf && x.mode == mode);
				if (utilsParserDescriptor == null)
				{
					return -1;
				}
			}
			return utilsParserDescriptor.value;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000049AC File Offset: 0x00002BAC
		public static void SetConfig(ParamExceptionID.CancelStub conf, int mode, dynamic val)
		{
			try
			{
				if (BroadCastWrite.<>o__32.<>p__1 == null)
				{
					BroadCastWrite.<>o__32.<>p__1 = CallSite<Action<CallSite, ClientDatabase, string, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(BroadCastWrite), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Action<CallSite, ClientDatabase, string, object, string> target = BroadCastWrite.<>o__32.<>p__1.Target;
				CallSite <>p__ = BroadCastWrite.<>o__32.<>p__1;
				ClientDatabase arg = BroadCastWrite.configIni;
				string arg2 = conf.ToString();
				if (BroadCastWrite.<>o__32.<>p__0 == null)
				{
					BroadCastWrite.<>o__32.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(BroadCastWrite), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, arg2, BroadCastWrite.<>o__32.<>p__0.Target(BroadCastWrite.<>o__32.<>p__0, val), mode.ToString());
				UtilsParserDescriptor utilsParserDescriptor = BroadCastWrite.value.FirstOrDefault((UtilsParserDescriptor x) => x.config == conf && x.mode == mode);
				if (utilsParserDescriptor != null)
				{
					utilsParserDescriptor.value = val;
				}
				else
				{
					BroadCastWrite.value.Add(new UtilsParserDescriptor
					{
						config = conf,
						mode = mode,
						value = val
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat(new string[]
				{
					"Error: Can't set configuration '",
					conf.ToString(),
					"' in mode '",
					mode.ToString(),
					"' ",
					ex.ToString()
				}));
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004B70 File Offset: 0x00002D70
		static BroadCastWrite()
		{
			BroadCastWrite.version = "Galaxy";
			BroadCastWrite.AimbotStatus = false;
			BroadCastWrite.ESPStatus = false;
			BroadCastWrite.AppleStatus = false;
			BroadCastWrite.RCSStatus = false;
			BroadCastWrite.BlueBerryStatus = false;
			BroadCastWrite.FovDraw = false;
			BroadCastWrite.colorMode = false;
			BroadCastWrite.TriggerAimbot = false;
			BroadCastWrite.myHWID = "";
			BroadCastWrite.purple = false;
			BroadCastWrite.antiastra = false;
			BroadCastWrite.aimonoff = false;
			BroadCastWrite.yellow = false;
			BroadCastWrite.currentMode = 0;
			BroadCastWrite.configIni = new ClientDatabase("Config.ini");
			BroadCastWrite.value = new List<UtilsParserDescriptor>();
		}

		// Token: 0x0400027C RID: 636
		public static bool aimonoff;

		// Token: 0x0400027D RID: 637
		public static bool antiastra;

		// Token: 0x0400027E RID: 638
		public static bool colorMode;

		// Token: 0x0400027F RID: 639
		public static string version;

		// Token: 0x04000280 RID: 640
		public static bool yellow;

		// Token: 0x04000281 RID: 641
		public static bool purple;

		// Token: 0x04000282 RID: 642
		public static bool AimbotStatus;

		// Token: 0x04000283 RID: 643
		public static bool ESPStatus;

		// Token: 0x04000284 RID: 644
		public static bool AppleStatus;

		// Token: 0x04000285 RID: 645
		public static bool RCSStatus;

		// Token: 0x04000286 RID: 646
		public static bool BlueBerryStatus;

		// Token: 0x04000287 RID: 647
		public static bool FovDraw;

		// Token: 0x04000288 RID: 648
		public static bool TriggerAimbot;

		// Token: 0x04000289 RID: 649
		public static string myHWID;

		// Token: 0x0400028A RID: 650
		public static bool counterstrafe = false;

		// Token: 0x0400028B RID: 651
		public static int currentMode;

		// Token: 0x0400028D RID: 653
		private static ClientDatabase configIni;

		// Token: 0x0400028E RID: 654
		public static List<UtilsParserDescriptor> value;

		// Token: 0x0400028F RID: 655
		public static string CPUID;

		// Token: 0x04000290 RID: 656
		public static string BIOSID;

		// Token: 0x04000291 RID: 657
		public static string BASEID;

		// Token: 0x04000292 RID: 658
		public static string DISKID;

		// Token: 0x04000293 RID: 659
		public static string VIDEOID;

		// Token: 0x04000294 RID: 660
		public static string MACID;

		// Token: 0x04000295 RID: 661
		public static string login;

		// Token: 0x04000296 RID: 662
		public static string password;
	}
}
