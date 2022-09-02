using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace RenameMe
{
	// Token: 0x0200002D RID: 45
	public class config
	{
		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000023CF File Offset: 0x000005CF
		public static string subscription
		{
			[CompilerGenerated]
			set
			{
				config.<subscription>k__BackingField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023D7 File Offset: 0x000005D7
		public static string expiry
		{
			[CompilerGenerated]
			set
			{
				config.<expiry>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000023DF File Offset: 0x000005DF
		public static string timeleft
		{
			[CompilerGenerated]
			set
			{
				config.<timeleft>k__BackingField = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000023E7 File Offset: 0x000005E7
		public static string port
		{
			[CompilerGenerated]
			set
			{
				config.<port>k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000023EF File Offset: 0x000005EF
		public static string typeoflog
		{
			[CompilerGenerated]
			set
			{
				config.<typeoflog>k__BackingField = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000023F7 File Offset: 0x000005F7
		public static bool checkautofire
		{
			[CompilerGenerated]
			set
			{
				config.<checkautofire>k__BackingField = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000023FF File Offset: 0x000005FF
		public static string expirylefttime
		{
			[CompilerGenerated]
			set
			{
				config.<expirylefttime>k__BackingField = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002407 File Offset: 0x00000607
		public static string usernamee
		{
			[CompilerGenerated]
			set
			{
				config.<usernamee>k__BackingField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000240F File Offset: 0x0000060F
		public static string passwordd
		{
			[CompilerGenerated]
			set
			{
				config.<passwordd>k__BackingField = value;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005254 File Offset: 0x00003454
		// Note: this type is marked as 'beforefieldinit'.
		static config()
		{
			if (config.<>o__101.<>p__1 == null)
			{
				config.<>o__101.<>p__1 = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(config)));
			}
			Func<CallSite, object, double> target = config.<>o__101.<>p__1.Target;
			CallSite <>p__ = config.<>o__101.<>p__1;
			if (config.<>o__101.<>p__0 == null)
			{
				config.<>o__101.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToDouble", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.smooth = target(<>p__, config.<>o__101.<>p__0.Target(config.<>o__101.<>p__0, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.Speed, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__3 == null)
			{
				config.<>o__101.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target2 = config.<>o__101.<>p__3.Target;
			CallSite <>p__2 = config.<>o__101.<>p__3;
			if (config.<>o__101.<>p__2 == null)
			{
				config.<>o__101.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.fov_x = target2(<>p__2, config.<>o__101.<>p__2.Target(config.<>o__101.<>p__2, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.fovX, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__5 == null)
			{
				config.<>o__101.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target3 = config.<>o__101.<>p__5.Target;
			CallSite <>p__3 = config.<>o__101.<>p__5;
			if (config.<>o__101.<>p__4 == null)
			{
				config.<>o__101.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.fov_y = target3(<>p__3, config.<>o__101.<>p__4.Target(config.<>o__101.<>p__4, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.fovY, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__7 == null)
			{
				config.<>o__101.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target4 = config.<>o__101.<>p__7.Target;
			CallSite <>p__4 = config.<>o__101.<>p__7;
			if (config.<>o__101.<>p__6 == null)
			{
				config.<>o__101.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.shot_speed = target4(<>p__4, config.<>o__101.<>p__6.Target(config.<>o__101.<>p__6, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.TriggerDelay, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__9 == null)
			{
				config.<>o__101.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target5 = config.<>o__101.<>p__9.Target;
			CallSite <>p__5 = config.<>o__101.<>p__9;
			if (config.<>o__101.<>p__8 == null)
			{
				config.<>o__101.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.trigger_speed = target5(<>p__5, config.<>o__101.<>p__8.Target(config.<>o__101.<>p__8, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.FireRate, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__11 == null)
			{
				config.<>o__101.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target6 = config.<>o__101.<>p__11.Target;
			CallSite <>p__6 = config.<>o__101.<>p__11;
			if (config.<>o__101.<>p__10 == null)
			{
				config.<>o__101.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.headx = target6(<>p__6, config.<>o__101.<>p__10.Target(config.<>o__101.<>p__10, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.HeadOffsetX, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__13 == null)
			{
				config.<>o__101.<>p__13 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target7 = config.<>o__101.<>p__13.Target;
			CallSite <>p__7 = config.<>o__101.<>p__13;
			if (config.<>o__101.<>p__12 == null)
			{
				config.<>o__101.<>p__12 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.heady = target7(<>p__7, config.<>o__101.<>p__12.Target(config.<>o__101.<>p__12, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.HeadOffsetY, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__15 == null)
			{
				config.<>o__101.<>p__15 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target8 = config.<>o__101.<>p__15.Target;
			CallSite <>p__8 = config.<>o__101.<>p__15;
			if (config.<>o__101.<>p__14 == null)
			{
				config.<>o__101.<>p__14 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.bodyx = target8(<>p__8, config.<>o__101.<>p__14.Target(config.<>o__101.<>p__14, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.BodyOffsetX, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__17 == null)
			{
				config.<>o__101.<>p__17 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(config)));
			}
			Func<CallSite, object, int> target9 = config.<>o__101.<>p__17.Target;
			CallSite <>p__9 = config.<>o__101.<>p__17;
			if (config.<>o__101.<>p__16 == null)
			{
				config.<>o__101.<>p__16 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.bodyy = target9(<>p__9, config.<>o__101.<>p__16.Target(config.<>o__101.<>p__16, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.BodyOffsetY, BroadCastWrite.currentMode)));
			if (config.<>o__101.<>p__19 == null)
			{
				config.<>o__101.<>p__19 = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(config)));
			}
			Func<CallSite, object, double> target10 = config.<>o__101.<>p__19.Target;
			CallSite <>p__10 = config.<>o__101.<>p__19;
			if (config.<>o__101.<>p__18 == null)
			{
				config.<>o__101.<>p__18 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(config), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			config.sens = target10(<>p__10, config.<>o__101.<>p__18.Target(config.<>o__101.<>p__18, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.Sensi, BroadCastWrite.currentMode)));
		}

		// Token: 0x040002CF RID: 719
		public static config.user_data_class user_data = new config.user_data_class();

		// Token: 0x040002D1 RID: 721
		public static bool aimbot_state;

		// Token: 0x040002D2 RID: 722
		public static bool aimbot_state_checkbox;

		// Token: 0x040002D3 RID: 723
		public static double smooth;

		// Token: 0x040002D4 RID: 724
		public static double rcs_smooth;

		// Token: 0x040002D5 RID: 725
		public static bool aim_color_state;

		// Token: 0x040002D6 RID: 726
		public static bool triggerbot_state;

		// Token: 0x040002D7 RID: 727
		public static bool auto_fire_state;

		// Token: 0x040002D8 RID: 728
		public static bool aim_only_on_x_state;

		// Token: 0x040002D9 RID: 729
		public static bool smooth_state;

		// Token: 0x040002DA RID: 730
		public static bool trigger_force_hs_state;

		// Token: 0x040002DB RID: 731
		public static bool ignore_sky_skills;

		// Token: 0x040002DC RID: 732
		public static bool bone1_state;

		// Token: 0x040002DD RID: 733
		public static bool bone2_state;

		// Token: 0x040002DE RID: 734
		public static bool recoil_system_state;

		// Token: 0x040002DF RID: 735
		public static bool hip_fire_state;

		// Token: 0x040002E0 RID: 736
		public static int aimbot_on_of_key;

		// Token: 0x040002E1 RID: 737
		public static int triggerbot_on_of_key;

		// Token: 0x040002E2 RID: 738
		public static int aim_key;

		// Token: 0x040002E3 RID: 739
		public static int trigger_key;

		// Token: 0x040002E4 RID: 740
		public static int bone1_key;

		// Token: 0x040002E5 RID: 741
		public static int bone2_key;

		// Token: 0x040002E6 RID: 742
		public static string bone1_target;

		// Token: 0x040002E7 RID: 743
		public static string bone2_target;

		// Token: 0x040002E8 RID: 744
		public static string color;

		// Token: 0x040002E9 RID: 745
		public static int mov_x;

		// Token: 0x040002EA RID: 746
		public static int mov_y;

		// Token: 0x040002EB RID: 747
		public static int fov_x;

		// Token: 0x040002EC RID: 748
		public static int fov_y;

		// Token: 0x040002ED RID: 749
		public static int shot_speed;

		// Token: 0x040002EE RID: 750
		public static int trigger_speed;

		// Token: 0x040002EF RID: 751
		public static int screenWidth;

		// Token: 0x040002F0 RID: 752
		public static int screenHeight;

		// Token: 0x040002F1 RID: 753
		public static int extras;

		// Token: 0x040002F2 RID: 754
		public static int max_recoil;

		// Token: 0x040002F3 RID: 755
		public static double recoilspeed;

		// Token: 0x040002F4 RID: 756
		public static int headx;

		// Token: 0x040002F5 RID: 757
		public static int heady;

		// Token: 0x040002F6 RID: 758
		public static int bodyx;

		// Token: 0x040002F7 RID: 759
		public static int bodyy;

		// Token: 0x040002F8 RID: 760
		public static int uwux;

		// Token: 0x040002F9 RID: 761
		public static int uwuy;

		// Token: 0x040002FA RID: 762
		public static bool bodypartcheckboxselectiontruefalse;

		// Token: 0x040002FE RID: 766
		public static int weapon1_key;

		// Token: 0x040002FF RID: 767
		public static int weapon2_key;

		// Token: 0x04000300 RID: 768
		public static int weapon3_key;

		// Token: 0x04000301 RID: 769
		public static bool weapon1_state;

		// Token: 0x04000302 RID: 770
		public static bool weapon2_state;

		// Token: 0x04000303 RID: 771
		public static bool weapon3_state;

		// Token: 0x04000304 RID: 772
		public static int weapon1_value;

		// Token: 0x04000305 RID: 773
		public static int weapon2_value;

		// Token: 0x04000306 RID: 774
		public static int weapon3_value;

		// Token: 0x04000307 RID: 775
		public static double weapon1_speed;

		// Token: 0x04000308 RID: 776
		public static double weapon2_speed;

		// Token: 0x04000309 RID: 777
		public static double weapon3_speed;

		// Token: 0x0400030A RID: 778
		public static double sens;

		// Token: 0x0400030B RID: 779
		public static double sensitivity_x;

		// Token: 0x0400030C RID: 780
		public static double sensitivity_y;

		// Token: 0x0400030D RID: 781
		public static int color_int;

		// Token: 0x0400030E RID: 782
		public static int silent_key;

		// Token: 0x0400030F RID: 783
		public static int flick_key;

		// Token: 0x04000310 RID: 784
		public static bool flick_active;

		// Token: 0x04000311 RID: 785
		public static bool silent_active;

		// Token: 0x0200002E RID: 46
		public class user_data_class
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00002417 File Offset: 0x00000617
			// (set) Token: 0x06000096 RID: 150 RVA: 0x0000241F File Offset: 0x0000061F
			public string username { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00002428 File Offset: 0x00000628
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00002430 File Offset: 0x00000630
			public string ip { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00002439 File Offset: 0x00000639
			// (set) Token: 0x0600009A RID: 154 RVA: 0x00002441 File Offset: 0x00000641
			public string hwid { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600009B RID: 155 RVA: 0x0000244A File Offset: 0x0000064A
			// (set) Token: 0x0600009C RID: 156 RVA: 0x00002452 File Offset: 0x00000652
			public string createdate { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600009D RID: 157 RVA: 0x0000245B File Offset: 0x0000065B
			// (set) Token: 0x0600009E RID: 158 RVA: 0x00002463 File Offset: 0x00000663
			public string lastlogin { get; set; }
		}
	}
}
