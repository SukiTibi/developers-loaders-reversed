using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.CSharp.RuntimeBinder;
using RenameMe.Properties;

namespace RenameMe.UserControls
{
	// Token: 0x02000050 RID: 80
	public class UserControl2 : UserControl
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00002E7E File Offset: 0x0000107E
		public UserControl2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar6_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar7_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar5_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar9_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar8_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000248E File Offset: 0x0000068E
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar10_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar11_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000248E File Offset: 0x0000068E
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000248E File Offset: 0x0000068E
		private void label21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar12_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000F154 File Offset: 0x0000D354
		private void metroButton1_Click(object sender, EventArgs e)
		{
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.Speed, BroadCastWrite.currentMode, this.metroTrackBar1.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.TriggerDelay, BroadCastWrite.currentMode, this.metroTrackBar2.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.FireRate, BroadCastWrite.currentMode, this.metroTrackBar3.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.BodyOffsetY, BroadCastWrite.currentMode, this.metroTrackBar4.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.BodyOffsetX, BroadCastWrite.currentMode, this.metroTrackBar5.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.HeadOffsetX, BroadCastWrite.currentMode, this.metroTrackBar6.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.HeadOffsetY, BroadCastWrite.currentMode, this.metroTrackBar7.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.fovY, BroadCastWrite.currentMode, this.metroTrackBar8.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.fovX, BroadCastWrite.currentMode, this.metroTrackBar9.Value.ToString());
			BroadCastWrite.SetConfig(ParamExceptionID.CancelStub.Sensi, BroadCastWrite.currentMode, this.metroTrackBar10.Value.ToString());
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000F290 File Offset: 0x0000D490
		public void LoadConfigInFields(int currentMode)
		{
			MetroTrackBar metroTrackBar = this.metroTrackBar1;
			if (UserControl2.<>o__19.<>p__2 == null)
			{
				UserControl2.<>o__19.<>p__2 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target = UserControl2.<>o__19.<>p__2.Target;
			CallSite <>p__ = UserControl2.<>o__19.<>p__2;
			if (UserControl2.<>o__19.<>p__1 == null)
			{
				UserControl2.<>o__19.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target2 = UserControl2.<>o__19.<>p__1.Target;
			CallSite <>p__2 = UserControl2.<>o__19.<>p__1;
			Type typeFromHandle = typeof(Convert);
			if (UserControl2.<>o__19.<>p__0 == null)
			{
				UserControl2.<>o__19.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar.Value = target(<>p__, target2(<>p__2, typeFromHandle, UserControl2.<>o__19.<>p__0.Target(UserControl2.<>o__19.<>p__0, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Speed, currentMode))));
			MetroTrackBar metroTrackBar2 = this.metroTrackBar2;
			if (UserControl2.<>o__19.<>p__5 == null)
			{
				UserControl2.<>o__19.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target3 = UserControl2.<>o__19.<>p__5.Target;
			CallSite <>p__3 = UserControl2.<>o__19.<>p__5;
			if (UserControl2.<>o__19.<>p__4 == null)
			{
				UserControl2.<>o__19.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target4 = UserControl2.<>o__19.<>p__4.Target;
			CallSite <>p__4 = UserControl2.<>o__19.<>p__4;
			Type typeFromHandle2 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__3 == null)
			{
				UserControl2.<>o__19.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar2.Value = target3(<>p__3, target4(<>p__4, typeFromHandle2, UserControl2.<>o__19.<>p__3.Target(UserControl2.<>o__19.<>p__3, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.TriggerDelay, currentMode))));
			MetroTrackBar metroTrackBar3 = this.metroTrackBar3;
			if (UserControl2.<>o__19.<>p__8 == null)
			{
				UserControl2.<>o__19.<>p__8 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target5 = UserControl2.<>o__19.<>p__8.Target;
			CallSite <>p__5 = UserControl2.<>o__19.<>p__8;
			if (UserControl2.<>o__19.<>p__7 == null)
			{
				UserControl2.<>o__19.<>p__7 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target6 = UserControl2.<>o__19.<>p__7.Target;
			CallSite <>p__6 = UserControl2.<>o__19.<>p__7;
			Type typeFromHandle3 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__6 == null)
			{
				UserControl2.<>o__19.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar3.Value = target5(<>p__5, target6(<>p__6, typeFromHandle3, UserControl2.<>o__19.<>p__6.Target(UserControl2.<>o__19.<>p__6, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.FireRate, currentMode))));
			MetroTrackBar metroTrackBar4 = this.metroTrackBar4;
			if (UserControl2.<>o__19.<>p__11 == null)
			{
				UserControl2.<>o__19.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target7 = UserControl2.<>o__19.<>p__11.Target;
			CallSite <>p__7 = UserControl2.<>o__19.<>p__11;
			if (UserControl2.<>o__19.<>p__10 == null)
			{
				UserControl2.<>o__19.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target8 = UserControl2.<>o__19.<>p__10.Target;
			CallSite <>p__8 = UserControl2.<>o__19.<>p__10;
			Type typeFromHandle4 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__9 == null)
			{
				UserControl2.<>o__19.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar4.Value = target7(<>p__7, target8(<>p__8, typeFromHandle4, UserControl2.<>o__19.<>p__9.Target(UserControl2.<>o__19.<>p__9, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.BodyOffsetY, currentMode))));
			MetroTrackBar metroTrackBar5 = this.metroTrackBar5;
			if (UserControl2.<>o__19.<>p__14 == null)
			{
				UserControl2.<>o__19.<>p__14 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target9 = UserControl2.<>o__19.<>p__14.Target;
			CallSite <>p__9 = UserControl2.<>o__19.<>p__14;
			if (UserControl2.<>o__19.<>p__13 == null)
			{
				UserControl2.<>o__19.<>p__13 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target10 = UserControl2.<>o__19.<>p__13.Target;
			CallSite <>p__10 = UserControl2.<>o__19.<>p__13;
			Type typeFromHandle5 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__12 == null)
			{
				UserControl2.<>o__19.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar5.Value = target9(<>p__9, target10(<>p__10, typeFromHandle5, UserControl2.<>o__19.<>p__12.Target(UserControl2.<>o__19.<>p__12, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.BodyOffsetX, currentMode))));
			MetroTrackBar metroTrackBar6 = this.metroTrackBar6;
			if (UserControl2.<>o__19.<>p__17 == null)
			{
				UserControl2.<>o__19.<>p__17 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target11 = UserControl2.<>o__19.<>p__17.Target;
			CallSite <>p__11 = UserControl2.<>o__19.<>p__17;
			if (UserControl2.<>o__19.<>p__16 == null)
			{
				UserControl2.<>o__19.<>p__16 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target12 = UserControl2.<>o__19.<>p__16.Target;
			CallSite <>p__12 = UserControl2.<>o__19.<>p__16;
			Type typeFromHandle6 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__15 == null)
			{
				UserControl2.<>o__19.<>p__15 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar6.Value = target11(<>p__11, target12(<>p__12, typeFromHandle6, UserControl2.<>o__19.<>p__15.Target(UserControl2.<>o__19.<>p__15, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.HeadOffsetX, currentMode))));
			MetroTrackBar metroTrackBar7 = this.metroTrackBar7;
			if (UserControl2.<>o__19.<>p__20 == null)
			{
				UserControl2.<>o__19.<>p__20 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target13 = UserControl2.<>o__19.<>p__20.Target;
			CallSite <>p__13 = UserControl2.<>o__19.<>p__20;
			if (UserControl2.<>o__19.<>p__19 == null)
			{
				UserControl2.<>o__19.<>p__19 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target14 = UserControl2.<>o__19.<>p__19.Target;
			CallSite <>p__14 = UserControl2.<>o__19.<>p__19;
			Type typeFromHandle7 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__18 == null)
			{
				UserControl2.<>o__19.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar7.Value = target13(<>p__13, target14(<>p__14, typeFromHandle7, UserControl2.<>o__19.<>p__18.Target(UserControl2.<>o__19.<>p__18, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.HeadOffsetY, currentMode))));
			MetroTrackBar metroTrackBar8 = this.metroTrackBar8;
			if (UserControl2.<>o__19.<>p__23 == null)
			{
				UserControl2.<>o__19.<>p__23 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target15 = UserControl2.<>o__19.<>p__23.Target;
			CallSite <>p__15 = UserControl2.<>o__19.<>p__23;
			if (UserControl2.<>o__19.<>p__22 == null)
			{
				UserControl2.<>o__19.<>p__22 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target16 = UserControl2.<>o__19.<>p__22.Target;
			CallSite <>p__16 = UserControl2.<>o__19.<>p__22;
			Type typeFromHandle8 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__21 == null)
			{
				UserControl2.<>o__19.<>p__21 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar8.Value = target15(<>p__15, target16(<>p__16, typeFromHandle8, UserControl2.<>o__19.<>p__21.Target(UserControl2.<>o__19.<>p__21, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.fovY, currentMode))));
			MetroTrackBar metroTrackBar9 = this.metroTrackBar9;
			if (UserControl2.<>o__19.<>p__26 == null)
			{
				UserControl2.<>o__19.<>p__26 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target17 = UserControl2.<>o__19.<>p__26.Target;
			CallSite <>p__17 = UserControl2.<>o__19.<>p__26;
			if (UserControl2.<>o__19.<>p__25 == null)
			{
				UserControl2.<>o__19.<>p__25 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target18 = UserControl2.<>o__19.<>p__25.Target;
			CallSite <>p__18 = UserControl2.<>o__19.<>p__25;
			Type typeFromHandle9 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__24 == null)
			{
				UserControl2.<>o__19.<>p__24 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar9.Value = target17(<>p__17, target18(<>p__18, typeFromHandle9, UserControl2.<>o__19.<>p__24.Target(UserControl2.<>o__19.<>p__24, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.fovX, currentMode))));
			MetroTrackBar metroTrackBar10 = this.metroTrackBar10;
			if (UserControl2.<>o__19.<>p__29 == null)
			{
				UserControl2.<>o__19.<>p__29 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target19 = UserControl2.<>o__19.<>p__29.Target;
			CallSite <>p__19 = UserControl2.<>o__19.<>p__29;
			if (UserControl2.<>o__19.<>p__28 == null)
			{
				UserControl2.<>o__19.<>p__28 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target20 = UserControl2.<>o__19.<>p__28.Target;
			CallSite <>p__20 = UserControl2.<>o__19.<>p__28;
			Type typeFromHandle10 = typeof(Convert);
			if (UserControl2.<>o__19.<>p__27 == null)
			{
				UserControl2.<>o__19.<>p__27 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			metroTrackBar10.Value = target19(<>p__19, target20(<>p__20, typeFromHandle10, UserControl2.<>o__19.<>p__27.Target(UserControl2.<>o__19.<>p__27, BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Sensi, currentMode))));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000FC78 File Offset: 0x0000DE78
		private void UserControl2_Load(object sender, EventArgs e)
		{
			if (UserControl2.<>o__20.<>p__1 == null)
			{
				UserControl2.<>o__20.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl2)));
			}
			Func<CallSite, object, int> target = UserControl2.<>o__20.<>p__1.Target;
			CallSite <>p__ = UserControl2.<>o__20.<>p__1;
			if (UserControl2.<>o__20.<>p__0 == null)
			{
				UserControl2.<>o__20.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl2), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			BroadCastWrite.currentMode = target(<>p__, UserControl2.<>o__20.<>p__0.Target(UserControl2.<>o__20.<>p__0, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Config, -1)));
			this.LoadConfigInFields(BroadCastWrite.currentMode);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.label2.Text = this.metroTrackBar1.Value.ToString();
			config.smooth = Convert.ToDouble(this.metroTrackBar1.Value) / 100.0 / 2.0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000FD90 File Offset: 0x0000DF90
		private void metroTrackBar9_ValueChanged(object sender, EventArgs e)
		{
			this.label17.Text = this.metroTrackBar9.Value.ToString();
			config.fov_x = this.metroTrackBar9.Value;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000FDCC File Offset: 0x0000DFCC
		private void metroTrackBar8_ValueChanged(object sender, EventArgs e)
		{
			this.label15.Text = this.metroTrackBar8.Value.ToString();
			config.fov_y = this.metroTrackBar8.Value;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000FE08 File Offset: 0x0000E008
		private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
		{
			this.label3.Text = this.metroTrackBar2.Value.ToString();
			config.shot_speed = this.metroTrackBar2.Value;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000FE44 File Offset: 0x0000E044
		private void metroTrackBar3_ValueChanged(object sender, EventArgs e)
		{
			this.label5.Text = this.metroTrackBar3.Value.ToString();
			config.trigger_speed = this.metroTrackBar3.Value;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002E8C File Offset: 0x0000108C
		private void metroTrackBar10_ValueChanged(object sender, EventArgs e)
		{
			config.sens = Convert.ToDouble(this.metroTrackBar10.Value) / 100.0 * 2.0;
			this.label20.Text = Convert.ToString(config.sens);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000FE80 File Offset: 0x0000E080
		private void metroTrackBar6_ValueChanged(object sender, EventArgs e)
		{
			this.label11.Text = (this.metroTrackBar6.Value - 25).ToString();
			config.headx = this.metroTrackBar6.Value - 25;
			config.uwux = config.headx;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000FECC File Offset: 0x0000E0CC
		private void metroTrackBar7_ValueChanged(object sender, EventArgs e)
		{
			this.label13.Text = (this.metroTrackBar7.Value - 25).ToString();
			config.heady = this.metroTrackBar7.Value - 25;
			config.uwuy = config.heady;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000FF18 File Offset: 0x0000E118
		private void metroTrackBar5_ValueChanged(object sender, EventArgs e)
		{
			this.label9.Text = (this.metroTrackBar5.Value - 25).ToString();
			config.bodyx = this.metroTrackBar5.Value - 25;
			config.uwux = config.bodyx;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000FF64 File Offset: 0x0000E164
		private void metroTrackBar4_ValueChanged(object sender, EventArgs e)
		{
			this.label7.Text = (this.metroTrackBar4.Value - 25).ToString();
			config.bodyy = this.metroTrackBar4.Value - 25;
			config.uwuy = config.bodyy;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002ECC File Offset: 0x000010CC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		private void InitializeComponent()
		{
			this.label20 = new Label();
			this.metroTrackBar10 = new MetroTrackBar();
			this.label7 = new Label();
			this.metroTrackBar4 = new MetroTrackBar();
			this.label9 = new Label();
			this.metroTrackBar5 = new MetroTrackBar();
			this.label13 = new Label();
			this.metroTrackBar7 = new MetroTrackBar();
			this.label11 = new Label();
			this.metroTrackBar6 = new MetroTrackBar();
			this.label15 = new Label();
			this.metroTrackBar8 = new MetroTrackBar();
			this.label17 = new Label();
			this.metroTrackBar9 = new MetroTrackBar();
			this.metroTrackBar1 = new MetroTrackBar();
			this.label2 = new Label();
			this.metroTrackBar2 = new MetroTrackBar();
			this.label3 = new Label();
			this.metroTrackBar3 = new MetroTrackBar();
			this.label5 = new Label();
			this.metroButton1 = new MetroButton();
			this.label4 = new Label();
			base.SuspendLayout();
			this.label20.AutoSize = true;
			this.label20.BackColor = Color.FromArgb(19, 19, 19);
			this.label20.Font = new Font("Segoe UI", 10f);
			this.label20.ForeColor = Color.DarkViolet;
			this.label20.Location = new Point(308, 230);
			this.label20.Name = "label20";
			this.label20.Size = new Size(36, 19);
			this.label20.TabIndex = 32;
			this.label20.Text = "0.45";
			this.metroTrackBar10.BackColor = Color.Transparent;
			this.metroTrackBar10.ForeColor = Color.BlueViolet;
			this.metroTrackBar10.Location = new Point(17, 252);
			this.metroTrackBar10.Name = "metroTrackBar10";
			this.metroTrackBar10.Size = new Size(327, 22);
			this.metroTrackBar10.Style = 12;
			this.metroTrackBar10.TabIndex = 31;
			this.metroTrackBar10.Text = "metroTrackBar10";
			this.metroTrackBar10.Theme = 2;
			this.metroTrackBar10.UseCustomBackColor = true;
			this.metroTrackBar10.Value = 21;
			this.metroTrackBar10.ValueChanged += this.metroTrackBar10_ValueChanged;
			this.metroTrackBar10.Scroll += this.metroTrackBar10_Scroll;
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.FromArgb(19, 19, 19);
			this.label7.Font = new Font("Segoe UI", 10f);
			this.label7.ForeColor = Color.DarkViolet;
			this.label7.Location = new Point(304, 407);
			this.label7.Name = "label7";
			this.label7.Size = new Size(31, 19);
			this.label7.TabIndex = 19;
			this.label7.Text = "-10";
			this.metroTrackBar4.BackColor = Color.Transparent;
			this.metroTrackBar4.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar4.Location = new Point(183, 429);
			this.metroTrackBar4.Maximum = 50;
			this.metroTrackBar4.Name = "metroTrackBar4";
			this.metroTrackBar4.Size = new Size(152, 22);
			this.metroTrackBar4.Style = 12;
			this.metroTrackBar4.TabIndex = 18;
			this.metroTrackBar4.Text = "metroTrackBar4";
			this.metroTrackBar4.Theme = 2;
			this.metroTrackBar4.UseCustomBackColor = true;
			this.metroTrackBar4.Value = 15;
			this.metroTrackBar4.ValueChanged += this.metroTrackBar4_ValueChanged;
			this.metroTrackBar4.Scroll += this.metroTrackBar4_Scroll;
			this.label9.AutoSize = true;
			this.label9.BackColor = Color.FromArgb(19, 19, 19);
			this.label9.Font = new Font("Segoe UI", 10f);
			this.label9.ForeColor = Color.DarkViolet;
			this.label9.Location = new Point(142, 407);
			this.label9.Name = "label9";
			this.label9.Size = new Size(23, 19);
			this.label9.TabIndex = 16;
			this.label9.Text = "-1";
			this.metroTrackBar5.BackColor = Color.Transparent;
			this.metroTrackBar5.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar5.Location = new Point(17, 429);
			this.metroTrackBar5.Maximum = 50;
			this.metroTrackBar5.Name = "metroTrackBar5";
			this.metroTrackBar5.Size = new Size(152, 22);
			this.metroTrackBar5.Style = 12;
			this.metroTrackBar5.TabIndex = 15;
			this.metroTrackBar5.Text = "metroTrackBar5";
			this.metroTrackBar5.Theme = 2;
			this.metroTrackBar5.UseCustomBackColor = true;
			this.metroTrackBar5.Value = 24;
			this.metroTrackBar5.ValueChanged += this.metroTrackBar5_ValueChanged;
			this.metroTrackBar5.Scroll += this.metroTrackBar5_Scroll;
			this.label13.AutoSize = true;
			this.label13.BackColor = Color.FromArgb(19, 19, 19);
			this.label13.Font = new Font("Segoe UI", 10f);
			this.label13.ForeColor = Color.DarkViolet;
			this.label13.Location = new Point(314, 338);
			this.label13.Name = "label13";
			this.label13.Size = new Size(23, 19);
			this.label13.TabIndex = 13;
			this.label13.Text = "-3";
			this.metroTrackBar7.BackColor = Color.Transparent;
			this.metroTrackBar7.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar7.Location = new Point(183, 368);
			this.metroTrackBar7.Maximum = 50;
			this.metroTrackBar7.Name = "metroTrackBar7";
			this.metroTrackBar7.Size = new Size(152, 22);
			this.metroTrackBar7.Style = 12;
			this.metroTrackBar7.TabIndex = 12;
			this.metroTrackBar7.Text = "metroTrackBar7";
			this.metroTrackBar7.Theme = 2;
			this.metroTrackBar7.UseCustomBackColor = true;
			this.metroTrackBar7.Value = 22;
			this.metroTrackBar7.ValueChanged += this.metroTrackBar7_ValueChanged;
			this.metroTrackBar7.Scroll += this.metroTrackBar7_Scroll;
			this.label11.AutoSize = true;
			this.label11.BackColor = Color.FromArgb(19, 19, 19);
			this.label11.Font = new Font("Segoe UI", 10f);
			this.label11.ForeColor = Color.DarkViolet;
			this.label11.Location = new Point(146, 338);
			this.label11.Name = "label11";
			this.label11.Size = new Size(23, 19);
			this.label11.TabIndex = 2;
			this.label11.Text = "-1";
			this.metroTrackBar6.BackColor = Color.Transparent;
			this.metroTrackBar6.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar6.Location = new Point(17, 368);
			this.metroTrackBar6.Maximum = 50;
			this.metroTrackBar6.Name = "metroTrackBar6";
			this.metroTrackBar6.Size = new Size(152, 22);
			this.metroTrackBar6.Style = 3;
			this.metroTrackBar6.TabIndex = 1;
			this.metroTrackBar6.Text = "metroTrackBar6";
			this.metroTrackBar6.Theme = 2;
			this.metroTrackBar6.UseCustomBackColor = true;
			this.metroTrackBar6.Value = 24;
			this.metroTrackBar6.ValueChanged += this.metroTrackBar6_ValueChanged;
			this.metroTrackBar6.Scroll += this.metroTrackBar6_Scroll;
			this.label15.AutoSize = true;
			this.label15.BackColor = Color.FromArgb(19, 19, 19);
			this.label15.Font = new Font("Segoe UI", 10f);
			this.label15.ForeColor = Color.DarkViolet;
			this.label15.Location = new Point(319, 92);
			this.label15.Name = "label15";
			this.label15.Size = new Size(25, 19);
			this.label15.TabIndex = 25;
			this.label15.Text = "40";
			this.metroTrackBar8.BackColor = Color.Transparent;
			this.metroTrackBar8.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar8.Location = new Point(192, 114);
			this.metroTrackBar8.Maximum = 600;
			this.metroTrackBar8.Name = "metroTrackBar8";
			this.metroTrackBar8.Size = new Size(152, 22);
			this.metroTrackBar8.Style = 12;
			this.metroTrackBar8.TabIndex = 24;
			this.metroTrackBar8.Text = "metroTrackBar8";
			this.metroTrackBar8.Theme = 2;
			this.metroTrackBar8.UseCustomBackColor = true;
			this.metroTrackBar8.Value = 40;
			this.metroTrackBar8.ValueChanged += this.metroTrackBar8_ValueChanged;
			this.metroTrackBar8.Scroll += this.metroTrackBar8_Scroll;
			this.label17.AutoSize = true;
			this.label17.BackColor = Color.FromArgb(19, 19, 19);
			this.label17.Font = new Font("Segoe UI", 10f);
			this.label17.ForeColor = Color.DarkViolet;
			this.label17.Location = new Point(132, 92);
			this.label17.Name = "label17";
			this.label17.Size = new Size(33, 19);
			this.label17.TabIndex = 22;
			this.label17.Text = "127";
			this.metroTrackBar9.BackColor = Color.Transparent;
			this.metroTrackBar9.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar9.Location = new Point(17, 114);
			this.metroTrackBar9.Maximum = 900;
			this.metroTrackBar9.Name = "metroTrackBar9";
			this.metroTrackBar9.Size = new Size(152, 22);
			this.metroTrackBar9.Style = 12;
			this.metroTrackBar9.TabIndex = 21;
			this.metroTrackBar9.Text = "metroTrackBar9";
			this.metroTrackBar9.Theme = 2;
			this.metroTrackBar9.UseCustomBackColor = true;
			this.metroTrackBar9.Value = 127;
			this.metroTrackBar9.ValueChanged += this.metroTrackBar9_ValueChanged;
			this.metroTrackBar9.Scroll += this.metroTrackBar9_Scroll;
			this.metroTrackBar1.BackColor = Color.Transparent;
			this.metroTrackBar1.BackgroundImageLayout = ImageLayout.None;
			this.metroTrackBar1.ForeColor = Color.SlateBlue;
			this.metroTrackBar1.Location = new Point(22, 54);
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new Size(322, 22);
			this.metroTrackBar1.Style = 12;
			this.metroTrackBar1.TabIndex = 1;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = 2;
			this.metroTrackBar1.UseCustomBackColor = true;
			this.metroTrackBar1.Value = 70;
			this.metroTrackBar1.ValueChanged += this.metroTrackBar1_ValueChanged;
			this.metroTrackBar1.Scroll += this.metroTrackBar1_Scroll;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(19, 19, 19);
			this.label2.Font = new Font("Segoe UI", 10f);
			this.label2.ForeColor = Color.DarkViolet;
			this.label2.Location = new Point(319, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(25, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "70";
			this.label2.Click += this.label2_Click;
			this.metroTrackBar2.BackColor = Color.Transparent;
			this.metroTrackBar2.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar2.Location = new Point(17, 170);
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new Size(327, 22);
			this.metroTrackBar2.Style = 12;
			this.metroTrackBar2.TabIndex = 6;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.Theme = 2;
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.ValueChanged += this.metroTrackBar2_ValueChanged;
			this.metroTrackBar2.Scroll += this.metroTrackBar2_Scroll;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(19, 19, 19);
			this.label3.Font = new Font("Segoe UI", 10f);
			this.label3.ForeColor = Color.DarkViolet;
			this.label3.Location = new Point(319, 148);
			this.label3.Name = "label3";
			this.label3.Size = new Size(25, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "50";
			this.metroTrackBar3.BackColor = Color.Transparent;
			this.metroTrackBar3.ForeColor = Color.DarkSlateBlue;
			this.metroTrackBar3.Location = new Point(17, 210);
			this.metroTrackBar3.Name = "metroTrackBar3";
			this.metroTrackBar3.Size = new Size(327, 22);
			this.metroTrackBar3.Style = 12;
			this.metroTrackBar3.TabIndex = 9;
			this.metroTrackBar3.Text = "metroTrackBar3";
			this.metroTrackBar3.Theme = 2;
			this.metroTrackBar3.UseCustomBackColor = true;
			this.metroTrackBar3.ValueChanged += this.metroTrackBar3_ValueChanged;
			this.metroTrackBar3.Scroll += this.metroTrackBar3_Scroll;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.FromArgb(19, 19, 19);
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.DarkViolet;
			this.label5.Location = new Point(319, 195);
			this.label5.Name = "label5";
			this.label5.Size = new Size(25, 19);
			this.label5.TabIndex = 10;
			this.label5.Text = "50";
			this.metroButton1.BackColor = Color.Transparent;
			this.metroButton1.FontWeight = 0;
			this.metroButton1.ForeColor = Color.WhiteSmoke;
			this.metroButton1.Highlight = true;
			this.metroButton1.Location = new Point(2, 489);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new Size(367, 23);
			this.metroButton1.Style = 12;
			this.metroButton1.TabIndex = 33;
			this.metroButton1.Text = "SaveConfig";
			this.metroButton1.Theme = 2;
			this.metroButton1.UseCustomBackColor = true;
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += this.metroButton1_Click;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.FromArgb(19, 19, 19);
			this.label4.Font = new Font("Microsoft Sans Serif", 9f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(72, 404);
			this.label4.Name = "label4";
			this.label4.Size = new Size(15, 15);
			this.label4.TabIndex = 35;
			this.label4.Text = "X";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			this.BackgroundImage = Resources.aimbot_settings;
			base.Controls.Add(this.label4);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.metroTrackBar4);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.metroTrackBar3);
			base.Controls.Add(this.metroTrackBar10);
			base.Controls.Add(this.metroTrackBar5);
			base.Controls.Add(this.metroTrackBar2);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroTrackBar1);
			base.Controls.Add(this.metroTrackBar7);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.metroTrackBar9);
			base.Controls.Add(this.metroTrackBar6);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.metroTrackBar8);
			base.Controls.Add(this.label17);
			this.Font = new Font("Microsoft Sans Serif", 8.49f);
			base.Name = "UserControl2";
			base.Size = new Size(370, 515);
			base.Load += this.UserControl2_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000413 RID: 1043
		private IContainer components;

		// Token: 0x04000414 RID: 1044
		private Label label15;

		// Token: 0x04000415 RID: 1045
		private MetroTrackBar metroTrackBar8;

		// Token: 0x04000416 RID: 1046
		private Label label17;

		// Token: 0x04000417 RID: 1047
		private MetroTrackBar metroTrackBar9;

		// Token: 0x04000418 RID: 1048
		private Label label7;

		// Token: 0x04000419 RID: 1049
		private MetroTrackBar metroTrackBar4;

		// Token: 0x0400041A RID: 1050
		private Label label9;

		// Token: 0x0400041B RID: 1051
		private MetroTrackBar metroTrackBar5;

		// Token: 0x0400041C RID: 1052
		private Label label13;

		// Token: 0x0400041D RID: 1053
		private MetroTrackBar metroTrackBar7;

		// Token: 0x0400041E RID: 1054
		private Label label11;

		// Token: 0x0400041F RID: 1055
		private MetroTrackBar metroTrackBar6;

		// Token: 0x04000420 RID: 1056
		private Label label20;

		// Token: 0x04000421 RID: 1057
		private MetroTrackBar metroTrackBar10;

		// Token: 0x04000422 RID: 1058
		private MetroTrackBar metroTrackBar1;

		// Token: 0x04000423 RID: 1059
		private Label label2;

		// Token: 0x04000424 RID: 1060
		private MetroTrackBar metroTrackBar2;

		// Token: 0x04000425 RID: 1061
		private Label label3;

		// Token: 0x04000426 RID: 1062
		private MetroTrackBar metroTrackBar3;

		// Token: 0x04000427 RID: 1063
		private Label label5;

		// Token: 0x04000428 RID: 1064
		private MetroButton metroButton1;

		// Token: 0x04000429 RID: 1065
		private Label label4;
	}
}
