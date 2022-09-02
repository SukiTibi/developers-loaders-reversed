using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

namespace unknown
{
	// Token: 0x02000015 RID: 21
	public class Config
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000AE14 File Offset: 0x00009014
		[return: Dynamic]
		public static dynamic GetConfigFile(Settings.CONFIG conf, int mode)
		{
			if (Config.configIni.KeyExists(conf.ToString(), mode.ToString()))
			{
				return Config.configIni.Read(conf.ToString(), mode.ToString());
			}
			Config.configIni.Write(conf.ToString(), "0", mode.ToString());
			return 0;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000AE8C File Offset: 0x0000908C
		[return: Dynamic]
		public static dynamic GetConfig(Settings.CONFIG conf, int mode)
		{
			ConfigContainer configContainer = Config.value.FirstOrDefault((ConfigContainer x) => x.config == conf && x.mode == mode);
			if (configContainer == null)
			{
				object configFile = Config.GetConfigFile(conf, mode);
				Config.value.Add(new ConfigContainer
				{
					config = conf,
					mode = mode,
					value = configFile
				});
				configContainer = Config.value.FirstOrDefault((ConfigContainer x) => x.config == conf && x.mode == mode);
				if (configContainer == null)
				{
					return -1;
				}
			}
			return configContainer.value;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000AF30 File Offset: 0x00009130
		public static void SetConfig(Settings.CONFIG conf, int mode, dynamic val)
		{
			try
			{
				if (Config.<>o__23.<>p__1 == null)
				{
					Config.<>o__23.<>p__1 = CallSite<Action<CallSite, IniFile, string, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(Config), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Action<CallSite, IniFile, string, object, string> target = Config.<>o__23.<>p__1.Target;
				CallSite <>p__ = Config.<>o__23.<>p__1;
				IniFile arg = Config.configIni;
				string arg2 = conf.ToString();
				if (Config.<>o__23.<>p__0 == null)
				{
					Config.<>o__23.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(Config), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, arg2, Config.<>o__23.<>p__0.Target(Config.<>o__23.<>p__0, val), mode.ToString());
				ConfigContainer configContainer = Config.value.FirstOrDefault((ConfigContainer x) => x.config == conf && x.mode == mode);
				if (configContainer != null)
				{
					configContainer.value = val;
				}
				else
				{
					Config.value.Add(new ConfigContainer
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

		// Token: 0x060000EF RID: 239 RVA: 0x0000B0F4 File Offset: 0x000092F4
		static Config()
		{
			Config.colorMode = false;
			Config.TriggerAimbot = false;
			Config.myHWID = "";
			Config.purple = false;
			Config.yellow = false;
			Config.currentMode = 0;
			Config.configIni = new IniFile("Config.ini");
			Config.value = new List<ConfigContainer>();
			Config.CPUID = "";
			Config.BIOSID = "";
			Config.BASEID = "";
			Config.DISKID = "";
			Config.VIDEOID = "";
			Config.MACID = "";
		}

		// Token: 0x040000BD RID: 189
		public static bool colorMode;

		// Token: 0x040000BE RID: 190
		public static string version = "BRUTALITY";

		// Token: 0x040000BF RID: 191
		public static bool yellow;

		// Token: 0x040000C0 RID: 192
		public static bool purple;

		// Token: 0x040000C1 RID: 193
		public static bool AimbotStatus = false;

		// Token: 0x040000C2 RID: 194
		public static bool ESPStatus = false;

		// Token: 0x040000C3 RID: 195
		public static bool AppleStatus = false;

		// Token: 0x040000C4 RID: 196
		public static bool SHITRECStatus = false;

		// Token: 0x040000C5 RID: 197
		public static bool BlueBerryStatus = false;

		// Token: 0x040000C6 RID: 198
		public static bool FovDraw = false;

		// Token: 0x040000C7 RID: 199
		public static bool TriggerAimbot;

		// Token: 0x040000C8 RID: 200
		public static string myHWID;

		// Token: 0x040000C9 RID: 201
		public static int currentMode;

		// Token: 0x040000CA RID: 202
		private static IniFile configIni;

		// Token: 0x040000CB RID: 203
		public static List<ConfigContainer> value;

		// Token: 0x040000CC RID: 204
		public static string CPUID;

		// Token: 0x040000CD RID: 205
		public static string BIOSID;

		// Token: 0x040000CE RID: 206
		public static string BASEID;

		// Token: 0x040000CF RID: 207
		public static string DISKID;

		// Token: 0x040000D0 RID: 208
		public static string VIDEOID;

		// Token: 0x040000D1 RID: 209
		public static string MACID;
	}
}
