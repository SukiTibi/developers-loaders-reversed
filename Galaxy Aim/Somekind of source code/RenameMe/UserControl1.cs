using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.CSharp.RuntimeBinder;
using RenameMe.Properties;

namespace RenameMe
{
	// Token: 0x0200004D RID: 77
	public class UserControl1 : UserControl
	{
		// Token: 0x060001D9 RID: 473
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int ArrowKeys);

		// Token: 0x060001DA RID: 474 RVA: 0x00002D7F File Offset: 0x00000F7F
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000BE84 File Offset: 0x0000A084
		public void loadConfig(int currentMode)
		{
			ListControl listControl = this.metroComboBox2;
			if (UserControl1.<>o__2.<>p__1 == null)
			{
				UserControl1.<>o__2.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target = UserControl1.<>o__2.<>p__1.Target;
			CallSite <>p__ = UserControl1.<>o__2.<>p__1;
			if (UserControl1.<>o__2.<>p__0 == null)
			{
				UserControl1.<>o__2.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			listControl.SelectedIndex = target(<>p__, UserControl1.<>o__2.<>p__0.Target(UserControl1.<>o__2.<>p__0, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Color, BroadCastWrite.currentMode)));
			ListControl aimbotCombo = this.AimbotCombo;
			if (UserControl1.<>o__2.<>p__3 == null)
			{
				UserControl1.<>o__2.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target2 = UserControl1.<>o__2.<>p__3.Target;
			CallSite <>p__2 = UserControl1.<>o__2.<>p__3;
			if (UserControl1.<>o__2.<>p__2 == null)
			{
				UserControl1.<>o__2.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			aimbotCombo.SelectedIndex = target2(<>p__2, UserControl1.<>o__2.<>p__2.Target(UserControl1.<>o__2.<>p__2, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Aimkey, BroadCastWrite.currentMode)));
			ListControl silentaimCombo = this.SilentaimCombo;
			if (UserControl1.<>o__2.<>p__5 == null)
			{
				UserControl1.<>o__2.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target3 = UserControl1.<>o__2.<>p__5.Target;
			CallSite <>p__3 = UserControl1.<>o__2.<>p__5;
			if (UserControl1.<>o__2.<>p__4 == null)
			{
				UserControl1.<>o__2.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			silentaimCombo.SelectedIndex = target3(<>p__3, UserControl1.<>o__2.<>p__4.Target(UserControl1.<>o__2.<>p__4, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.SilentKey, BroadCastWrite.currentMode)));
			ListControl flickbotCombo = this.FlickbotCombo;
			if (UserControl1.<>o__2.<>p__7 == null)
			{
				UserControl1.<>o__2.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target4 = UserControl1.<>o__2.<>p__7.Target;
			CallSite <>p__4 = UserControl1.<>o__2.<>p__7;
			if (UserControl1.<>o__2.<>p__6 == null)
			{
				UserControl1.<>o__2.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			flickbotCombo.SelectedIndex = target4(<>p__4, UserControl1.<>o__2.<>p__6.Target(UserControl1.<>o__2.<>p__6, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.FlickKey, BroadCastWrite.currentMode)));
			ListControl triggerbotCombo = this.TriggerbotCombo;
			if (UserControl1.<>o__2.<>p__9 == null)
			{
				UserControl1.<>o__2.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target5 = UserControl1.<>o__2.<>p__9.Target;
			CallSite <>p__5 = UserControl1.<>o__2.<>p__9;
			if (UserControl1.<>o__2.<>p__8 == null)
			{
				UserControl1.<>o__2.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			triggerbotCombo.SelectedIndex = target5(<>p__5, UserControl1.<>o__2.<>p__8.Target(UserControl1.<>o__2.<>p__8, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.TriggerKey, BroadCastWrite.currentMode)));
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C220 File Offset: 0x0000A420
		private void UserControl1_Load(object sender, EventArgs e)
		{
			if (UserControl1.<>o__3.<>p__1 == null)
			{
				UserControl1.<>o__3.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(UserControl1)));
			}
			Func<CallSite, object, int> target = UserControl1.<>o__3.<>p__1.Target;
			CallSite <>p__ = UserControl1.<>o__3.<>p__1;
			if (UserControl1.<>o__3.<>p__0 == null)
			{
				UserControl1.<>o__3.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(UserControl1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			BroadCastWrite.currentMode = target(<>p__, UserControl1.<>o__3.<>p__0.Target(UserControl1.<>o__3.<>p__0, typeof(Convert), BroadCastWrite.GetConfigFile(ParamExceptionID.CancelStub.Config, -1)));
			this.loadConfig(BroadCastWrite.currentMode);
			config.bone1_target = "BODY";
			config.bone2_target = "NECK";
			config.color = "Purple";
			this.metroComboBox2.Text = this.metroComboBox2.Items[1].ToString();
			this.buttonHead2.Hide();
			this.pictureBoxHead2.Hide();
			this.buttonBody2.Hide();
			this.pictureBoxBody2.Hide();
			this.buttonBody.Hide();
			this.pictureBoxBody.Hide();
			this.buttonNeck.Hide();
			this.pictureBoxNeck.Hide();
			this.timer1.Start();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000C388 File Offset: 0x0000A588
		public void timer1_Tick(object sender, EventArgs e)
		{
			if (UserControl1.GetAsyncKeyState(config.triggerbot_on_of_key) < 0)
			{
				this.metroCheckBox2.Checked = !this.metroCheckBox2.Checked;
				while (UserControl1.GetAsyncKeyState(config.triggerbot_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			if (UserControl1.GetAsyncKeyState(config.aimbot_on_of_key) < 0)
			{
				this.metroCheckBox1.Checked = !this.metroCheckBox1.Checked;
				while (UserControl1.GetAsyncKeyState(config.aimbot_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			if (UserControl1.GetAsyncKeyState(config.bone1_key) < 0)
			{
				this.metroCheckBox7.Checked = true;
				this.metroCheckBox8.Checked = false;
				while (UserControl1.GetAsyncKeyState(config.bone1_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			if (UserControl1.GetAsyncKeyState(config.bone2_key) < 0)
			{
				this.metroCheckBox8.Checked = true;
				this.metroCheckBox7.Checked = false;
				while (UserControl1.GetAsyncKeyState(config.bone2_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000C484 File Offset: 0x0000A684
		private void buttonNeck_Click(object sender, EventArgs e)
		{
			config.bone2_target = "HEAD";
			config.uwux = config.headx;
			config.uwuy = config.heady;
			this.buttonNeck2.Hide();
			this.pictureBoxNeck2.Hide();
			this.buttonHead2.Show();
			this.pictureBoxHead2.Show();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000248E File Offset: 0x0000068E
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		private int get_key()
		{
			for (int i = 0; i < 150; i++)
			{
				foreach (int num in this.list_characters)
				{
					if (UserControl1.GetAsyncKeyState(num) < 0)
					{
						return num;
					}
				}
				Thread.Sleep(10);
			}
			return 180;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000C52C File Offset: 0x0000A72C
		private string get_name_of_key(int key)
		{
			switch (key)
			{
			case 1:
				return "[ LeftCLick ]";
			case 2:
				return "[ RightClick ]";
			case 3:
			case 4:
			case 7:
			case 8:
				break;
			case 5:
				return "[ XButton1 ]";
			case 6:
				return "[ XButton2 ]";
			case 9:
				return "[ TAB ]";
			default:
				switch (key)
				{
				case 16:
					return "[ SHIFT ]";
				case 17:
					return "[ CTRL ]";
				case 18:
					return "[ ALT ]";
				default:
					switch (key)
					{
					case 65:
						return "[ A ]";
					case 66:
						return "[ B ]";
					case 67:
						return "[ C ]";
					case 68:
						return "[ D ]";
					case 69:
						return "[ E ]";
					case 70:
						return "[ F ]";
					case 71:
						return "[ G ]";
					case 72:
						return "[ H ]";
					case 73:
						return "[ I ]";
					case 74:
						return "[ J ]";
					case 75:
						return "[ K ]";
					case 76:
						return "[ L ]";
					case 77:
						return "[ M ]";
					case 78:
						return "[ N ]";
					case 79:
						return "[ O ]";
					case 80:
						return "[ P ]";
					case 81:
						return "[ Q ]";
					case 82:
						return "[ R ]";
					case 83:
						return "[ S ]";
					case 84:
						return "[ T ]";
					case 85:
						return "[ U ]";
					case 86:
						return "[ V ]";
					case 87:
						return "[ W ]";
					case 88:
						return "[ X ]";
					case 89:
						return "[ Y ]";
					case 90:
						return "[ Z ]";
					}
					break;
				}
				break;
			}
			return "[ waiting... ]";
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000248E File Offset: 0x0000068E
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000248E File Offset: 0x0000068E
		private void Picture_UserControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000248E File Offset: 0x0000068E
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002DA5 File Offset: 0x00000FA5
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox2.Checked)
			{
				config.triggerbot_state = true;
				return;
			}
			config.triggerbot_state = false;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002DC1 File Offset: 0x00000FC1
		private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox3.Checked)
			{
				config.aim_only_on_x_state = true;
				return;
			}
			config.aim_only_on_x_state = false;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002DDD File Offset: 0x00000FDD
		private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox6.Checked)
			{
				config.smooth_state = true;
				return;
			}
			config.smooth_state = false;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox7.Checked)
			{
				config.bone1_state = true;
				if (config.bone1_target == "HEAD")
				{
					config.uwux = 0;
					config.uwuy = -5;
				}
				else if (config.bone1_target == "NECK")
				{
					config.uwux = 0;
					config.uwuy = -7;
				}
				else if (config.bone1_target == "BODY")
				{
					config.uwux = 0;
					config.uwuy = -8;
				}
			}
			else
			{
				config.bone1_state = false;
			}
			if (config.bone1_state || config.bone2_state)
			{
				config.bodypartcheckboxselectiontruefalse = true;
				return;
			}
			config.bodypartcheckboxselectiontruefalse = false;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000C768 File Offset: 0x0000A968
		private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox8.Checked)
			{
				config.bone2_state = true;
				if (config.bone2_target == "HEAD")
				{
					config.uwux = 0;
					config.uwuy = -5;
				}
				else if (config.bone2_target == "NECK")
				{
					config.uwux = 0;
					config.uwuy = -7;
				}
				else if (config.bone2_target == "BODY")
				{
					config.uwux = 0;
					config.uwuy = -8;
				}
			}
			else
			{
				config.bone2_state = false;
			}
			if (config.bone1_state || config.bone2_state)
			{
				config.bodypartcheckboxselectiontruefalse = true;
				return;
			}
			config.bodypartcheckboxselectiontruefalse = false;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000248E File Offset: 0x0000068E
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000248E File Offset: 0x0000068E
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000248E File Offset: 0x0000068E
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000248E File Offset: 0x0000068E
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000248E File Offset: 0x0000068E
		private void label19_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000248E File Offset: 0x0000068E
		private void label20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002DF9 File Offset: 0x00000FF9
		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			config.color = this.metroComboBox2.Text;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002E0B File Offset: 0x0000100B
		private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox1.Checked)
			{
				config.aimbot_state_checkbox = true;
				return;
			}
			config.aimbot_state_checkbox = false;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000248E File Offset: 0x0000068E
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000248E File Offset: 0x0000068E
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000248E File Offset: 0x0000068E
		private void label21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBoxBody_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBoxBody2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002E27 File Offset: 0x00001027
		private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox9.Checked)
			{
				config.flick_active = true;
				return;
			}
			config.flick_active = false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000248E File Offset: 0x0000068E
		private void label22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000248E File Offset: 0x0000068E
		private void label23_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002E43 File Offset: 0x00001043
		private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox9.Checked)
			{
				config.silent_active = true;
				return;
			}
			config.silent_active = false;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000248E File Offset: 0x0000068E
		private void label27_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002DC1 File Offset: 0x00000FC1
		private void metroCheckBox3_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox3.Checked)
			{
				config.aim_only_on_x_state = true;
				return;
			}
			config.aim_only_on_x_state = false;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002E43 File Offset: 0x00001043
		private void metroCheckBox10_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox9.Checked)
			{
				config.silent_active = true;
				return;
			}
			config.silent_active = false;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000248E File Offset: 0x0000068E
		private void label10_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002E0B File Offset: 0x0000100B
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox1.Checked)
			{
				config.aimbot_state_checkbox = true;
				return;
			}
			config.aimbot_state_checkbox = false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002E27 File Offset: 0x00001027
		private void metroCheckBox9_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox9.Checked)
			{
				config.flick_active = true;
				return;
			}
			config.flick_active = false;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002DA5 File Offset: 0x00000FA5
		private void metroCheckBox2_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox2.Checked)
			{
				config.triggerbot_state = true;
				return;
			}
			config.triggerbot_state = false;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		private void metroCheckBox7_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox7.Checked)
			{
				config.bone1_state = true;
				if (config.bone1_target == "HEAD")
				{
					config.uwux = 0;
					config.uwuy = -5;
				}
				else if (config.bone1_target == "NECK")
				{
					config.uwux = 0;
					config.uwuy = -7;
				}
				else if (config.bone1_target == "BODY")
				{
					config.uwux = 0;
					config.uwuy = -8;
				}
			}
			else
			{
				config.bone1_state = false;
			}
			if (config.bone1_state || config.bone2_state)
			{
				config.bodypartcheckboxselectiontruefalse = true;
				return;
			}
			config.bodypartcheckboxselectiontruefalse = false;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000C768 File Offset: 0x0000A968
		private void metroCheckBox8_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.metroCheckBox8.Checked)
			{
				config.bone2_state = true;
				if (config.bone2_target == "HEAD")
				{
					config.uwux = 0;
					config.uwuy = -5;
				}
				else if (config.bone2_target == "NECK")
				{
					config.uwux = 0;
					config.uwuy = -7;
				}
				else if (config.bone2_target == "BODY")
				{
					config.uwux = 0;
					config.uwuy = -8;
				}
			}
			else
			{
				config.bone2_state = false;
			}
			if (config.bone1_state || config.bone2_state)
			{
				config.bodypartcheckboxselectiontruefalse = true;
				return;
			}
			config.bodypartcheckboxselectiontruefalse = false;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000248E File Offset: 0x0000068E
		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000248E File Offset: 0x0000068E
		private void label3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000248E File Offset: 0x0000068E
		private void label21_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000248E File Offset: 0x0000068E
		private void label27_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000248E File Offset: 0x0000068E
		private void buttonBody_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000248E File Offset: 0x0000068E
		private void buttonHead_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000C80C File Offset: 0x0000AA0C
		private void buttonBody2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "NECK";
			config.uwux = 0;
			config.uwuy = -8;
			this.buttonBody2.Hide();
			this.pictureBoxBody2.Hide();
			this.buttonNeck2.Show();
			this.pictureBoxNeck2.Show();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000C85C File Offset: 0x0000AA5C
		private void buttonNeck2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "HEAD";
			config.uwux = 0;
			config.uwuy = -5;
			this.buttonNeck2.Hide();
			this.pictureBoxNeck2.Hide();
			this.buttonHead2.Show();
			this.pictureBoxHead2.Show();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		private void buttonHead2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "BODY";
			config.uwux = 0;
			config.uwuy = -12;
			this.buttonHead2.Hide();
			this.pictureBoxHead2.Hide();
			this.buttonBody2.Show();
			this.pictureBoxBody2.Show();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		private void buttonHead_Click_1(object sender, EventArgs e)
		{
			config.bone2_target = "BODY";
			config.uwux = 0;
			config.uwuy = -12;
			this.buttonHead.Hide();
			this.pictureBoxHead.Hide();
			this.buttonBody.Show();
			this.pictureBoxBody.Show();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000C94C File Offset: 0x0000AB4C
		private void metroCheckBox7_CheckedChanged_2(object sender, EventArgs e)
		{
			if (this.metroCheckBox7.Checked)
			{
				config.bone1_state = true;
				if (config.bone1_target == "HEAD")
				{
					config.uwux = 0;
					config.uwuy = -4;
				}
				else if (config.bone1_target == "NECK")
				{
					config.uwux = 0;
					config.uwuy = -7;
				}
				else if (config.bone1_target == "BODY")
				{
					config.uwux = 0;
					config.uwuy = -12;
				}
			}
			else
			{
				config.bone1_state = false;
			}
			if (config.bone1_state || config.bone2_state)
			{
				config.bodypartcheckboxselectiontruefalse = true;
				return;
			}
			config.bodypartcheckboxselectiontruefalse = false;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		private void buttonBody_Click_1(object sender, EventArgs e)
		{
			config.bone2_target = "NECK";
			config.uwux = 0;
			config.uwuy = -7;
			this.buttonBody.Hide();
			this.pictureBoxBody.Hide();
			this.buttonNeck.Show();
			this.pictureBoxNeck.Show();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000CA40 File Offset: 0x0000AC40
		private void buttonNeck_Click_1(object sender, EventArgs e)
		{
			config.bone2_target = "HEAD";
			config.uwux = 0;
			config.uwuy = -4;
			this.buttonNeck.Hide();
			this.pictureBoxNeck.Hide();
			this.buttonHead.Show();
			this.pictureBoxHead.Show();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000CA90 File Offset: 0x0000AC90
		private void metroButton1_Click(object sender, EventArgs e)
		{
			ParamExceptionID.CancelStub conf = ParamExceptionID.CancelStub.Color;
			object val = this.metroComboBox2.SelectedIndex.ToString();
			BroadCastWrite.SetConfig(conf, BroadCastWrite.currentMode, val);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
		private void AimbotCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ParamExceptionID.CancelStub conf = ParamExceptionID.CancelStub.Aimkey;
			object val = this.AimbotCombo.SelectedIndex.ToString();
			BroadCastWrite.SetConfig(conf, BroadCastWrite.currentMode, val);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		private void FlickbotCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ParamExceptionID.CancelStub conf = ParamExceptionID.CancelStub.FlickKey;
			object val = this.FlickbotCombo.SelectedIndex.ToString();
			BroadCastWrite.SetConfig(conf, BroadCastWrite.currentMode, val);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000CB20 File Offset: 0x0000AD20
		private void SilentaimCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ParamExceptionID.CancelStub conf = ParamExceptionID.CancelStub.SilentKey;
			object val = this.SilentaimCombo.SelectedIndex.ToString();
			BroadCastWrite.SetConfig(conf, BroadCastWrite.currentMode, val);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000CB50 File Offset: 0x0000AD50
		private void TriggerbotCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ParamExceptionID.CancelStub conf = ParamExceptionID.CancelStub.TriggerKey;
			object val = this.TriggerbotCombo.SelectedIndex.ToString();
			BroadCastWrite.SetConfig(conf, BroadCastWrite.currentMode, val);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002E5F File Offset: 0x0000105F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000CB80 File Offset: 0x0000AD80
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UserControl1));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxBody2 = new PictureBox();
			this.pictureBoxNeck2 = new PictureBox();
			this.pictureBoxHead2 = new PictureBox();
			this.label27 = new Label();
			this.metroCheckBox10 = new MetroCheckBox();
			this.label22 = new Label();
			this.metroCheckBox9 = new MetroCheckBox();
			this.label10 = new Label();
			this.label11 = new Label();
			this.metroCheckBox2 = new MetroCheckBox();
			this.metroCheckBox1 = new MetroCheckBox();
			this.metroComboBox2 = new MetroComboBox();
			this.metroCheckBox6 = new MetroCheckBox();
			this.metroCheckBox3 = new MetroCheckBox();
			this.label19 = new Label();
			this.label20 = new Label();
			this.label7 = new Label();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.buttonHead2 = new PictureBox();
			this.buttonBody2 = new PictureBox();
			this.buttonNeck2 = new PictureBox();
			this.pictureBoxNeck = new PictureBox();
			this.pictureBoxBody = new PictureBox();
			this.metroCheckBox8 = new MetroCheckBox();
			this.metroCheckBox7 = new MetroCheckBox();
			this.label9 = new Label();
			this.buttonBody = new Button();
			this.buttonNeck = new Button();
			this.buttonHead = new Button();
			this.pictureBoxHead = new PictureBox();
			this.panel4 = new Panel();
			this.metroButton1 = new MetroButton();
			this.AimbotCombo = new MetroComboBox();
			this.FlickbotCombo = new MetroComboBox();
			this.SilentaimCombo = new MetroComboBox();
			this.TriggerbotCombo = new MetroComboBox();
			this.panel5 = new Panel();
			this.metroLabel1 = new MetroLabel();
			((ISupportInitialize)this.pictureBoxBody2).BeginInit();
			((ISupportInitialize)this.pictureBoxNeck2).BeginInit();
			((ISupportInitialize)this.pictureBoxHead2).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.buttonHead2).BeginInit();
			((ISupportInitialize)this.buttonBody2).BeginInit();
			((ISupportInitialize)this.buttonNeck2).BeginInit();
			((ISupportInitialize)this.pictureBoxNeck).BeginInit();
			((ISupportInitialize)this.pictureBoxBody).BeginInit();
			((ISupportInitialize)this.pictureBoxHead).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += this.timer1_Tick;
			this.pictureBoxBody2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxBody2.Image = (Image)componentResourceManager.GetObject("pictureBoxBody2.Image");
			this.pictureBoxBody2.Location = new Point(3, 0);
			this.pictureBoxBody2.Name = "pictureBoxBody2";
			this.pictureBoxBody2.Size = new Size(139, 170);
			this.pictureBoxBody2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBody2.TabIndex = 38;
			this.pictureBoxBody2.TabStop = false;
			this.pictureBoxBody2.Click += this.pictureBoxBody2_Click;
			this.pictureBoxNeck2.Image = (Image)componentResourceManager.GetObject("pictureBoxNeck2.Image");
			this.pictureBoxNeck2.Location = new Point(4, 0);
			this.pictureBoxNeck2.Name = "pictureBoxNeck2";
			this.pictureBoxNeck2.Size = new Size(139, 168);
			this.pictureBoxNeck2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxNeck2.TabIndex = 24;
			this.pictureBoxNeck2.TabStop = false;
			this.pictureBoxHead2.Image = (Image)componentResourceManager.GetObject("pictureBoxHead2.Image");
			this.pictureBoxHead2.Location = new Point(4, 0);
			this.pictureBoxHead2.Name = "pictureBoxHead2";
			this.pictureBoxHead2.Size = new Size(139, 168);
			this.pictureBoxHead2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxHead2.TabIndex = 38;
			this.pictureBoxHead2.TabStop = false;
			this.label27.AutoSize = true;
			this.label27.BackColor = Color.Transparent;
			this.label27.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label27.ForeColor = Color.Purple;
			this.label27.Location = new Point(19, 55);
			this.label27.Name = "label27";
			this.label27.Size = new Size(54, 17);
			this.label27.TabIndex = 138;
			this.label27.Text = "[  KEY  ]";
			this.label27.Click += this.label27_Click_1;
			this.metroCheckBox10.AutoSize = true;
			this.metroCheckBox10.BackColor = Color.Transparent;
			this.metroCheckBox10.BackgroundImage = (Image)componentResourceManager.GetObject("metroCheckBox10.BackgroundImage");
			this.metroCheckBox10.Checked = true;
			this.metroCheckBox10.CheckState = CheckState.Checked;
			this.metroCheckBox10.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox10.Location = new Point(31, 100);
			this.metroCheckBox10.Name = "metroCheckBox10";
			this.metroCheckBox10.Size = new Size(26, 15);
			this.metroCheckBox10.Style = 12;
			this.metroCheckBox10.TabIndex = 136;
			this.metroCheckBox10.Text = " ";
			this.metroCheckBox10.Theme = 2;
			this.metroCheckBox10.UseCustomBackColor = true;
			this.metroCheckBox10.UseSelectable = true;
			this.metroCheckBox10.Visible = false;
			this.metroCheckBox10.CheckedChanged += this.metroCheckBox10_CheckedChanged_1;
			this.label22.AutoSize = true;
			this.label22.BackColor = Color.Transparent;
			this.label22.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label22.ForeColor = Color.Purple;
			this.label22.Location = new Point(19, 31);
			this.label22.Name = "label22";
			this.label22.Size = new Size(54, 17);
			this.label22.TabIndex = 134;
			this.label22.Text = "[  KEY  ]";
			this.label22.Click += this.label21_Click_1;
			this.metroCheckBox9.AutoSize = true;
			this.metroCheckBox9.BackColor = Color.Transparent;
			this.metroCheckBox9.BackgroundImage = (Image)componentResourceManager.GetObject("metroCheckBox9.BackgroundImage");
			this.metroCheckBox9.Checked = true;
			this.metroCheckBox9.CheckState = CheckState.Checked;
			this.metroCheckBox9.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox9.Location = new Point(31, 74);
			this.metroCheckBox9.Name = "metroCheckBox9";
			this.metroCheckBox9.Size = new Size(26, 15);
			this.metroCheckBox9.Style = 12;
			this.metroCheckBox9.TabIndex = 132;
			this.metroCheckBox9.Text = " ";
			this.metroCheckBox9.Theme = 2;
			this.metroCheckBox9.UseCustomBackColor = true;
			this.metroCheckBox9.UseSelectable = true;
			this.metroCheckBox9.Visible = false;
			this.metroCheckBox9.CheckedChanged += this.metroCheckBox9_CheckedChanged_1;
			this.label10.AutoSize = true;
			this.label10.BackColor = Color.Transparent;
			this.label10.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.Purple;
			this.label10.Location = new Point(19, 82);
			this.label10.Name = "label10";
			this.label10.Size = new Size(54, 17);
			this.label10.TabIndex = 128;
			this.label10.Text = "[  KEY  ]";
			this.label10.Click += this.label10_Click_1;
			this.label11.AutoSize = true;
			this.label11.BackColor = Color.Transparent;
			this.label11.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.Purple;
			this.label11.Location = new Point(19, 4);
			this.label11.Name = "label11";
			this.label11.Size = new Size(54, 17);
			this.label11.TabIndex = 130;
			this.label11.Text = "[  KEY  ]";
			this.label11.Click += this.label3_Click_1;
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.BackColor = Color.Transparent;
			this.metroCheckBox2.BackgroundImage = (Image)componentResourceManager.GetObject("metroCheckBox2.BackgroundImage");
			this.metroCheckBox2.Checked = true;
			this.metroCheckBox2.CheckState = CheckState.Checked;
			this.metroCheckBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox2.Location = new Point(31, 127);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new Size(26, 15);
			this.metroCheckBox2.Style = 12;
			this.metroCheckBox2.TabIndex = 124;
			this.metroCheckBox2.Text = " ";
			this.metroCheckBox2.Theme = 2;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox2.CheckedChanged += this.metroCheckBox2_CheckedChanged_1;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.BackColor = Color.Transparent;
			this.metroCheckBox1.BackgroundImage = (Image)componentResourceManager.GetObject("metroCheckBox1.BackgroundImage");
			this.metroCheckBox1.Checked = true;
			this.metroCheckBox1.CheckState = CheckState.Checked;
			this.metroCheckBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox1.Location = new Point(30, 47);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(26, 15);
			this.metroCheckBox1.Style = 12;
			this.metroCheckBox1.TabIndex = 123;
			this.metroCheckBox1.Text = " ";
			this.metroCheckBox1.Theme = 2;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += this.metroCheckBox1_CheckedChanged;
			this.metroComboBox2.BackColor = Color.FromArgb(19, 19, 19);
			this.metroComboBox2.ForeColor = Color.BlueViolet;
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Yellow",
				"Purple",
				"Red",
				"AntiAstra"
			});
			this.metroComboBox2.Location = new Point(92, 188);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.RightToLeft = RightToLeft.No;
			this.metroComboBox2.Size = new Size(185, 29);
			this.metroComboBox2.Style = 12;
			this.metroComboBox2.TabIndex = 44;
			this.metroComboBox2.Theme = 2;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.UseStyleColors = true;
			this.metroComboBox2.SelectedIndexChanged += this.metroComboBox2_SelectedIndexChanged;
			this.metroCheckBox6.AutoSize = true;
			this.metroCheckBox6.BackColor = Color.Transparent;
			this.metroCheckBox6.Checked = true;
			this.metroCheckBox6.CheckState = CheckState.Checked;
			this.metroCheckBox6.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox6.Location = new Point(13, 5);
			this.metroCheckBox6.Name = "metroCheckBox6";
			this.metroCheckBox6.Size = new Size(26, 15);
			this.metroCheckBox6.Style = 12;
			this.metroCheckBox6.TabIndex = 19;
			this.metroCheckBox6.Text = " ";
			this.metroCheckBox6.Theme = 2;
			this.metroCheckBox6.UseCustomBackColor = true;
			this.metroCheckBox6.UseSelectable = true;
			this.metroCheckBox6.CheckedChanged += this.metroCheckBox6_CheckedChanged;
			this.metroCheckBox3.AutoSize = true;
			this.metroCheckBox3.BackColor = Color.FromArgb(19, 19, 19);
			this.metroCheckBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox3.Location = new Point(13, 26);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new Size(26, 15);
			this.metroCheckBox3.Style = 12;
			this.metroCheckBox3.TabIndex = 53;
			this.metroCheckBox3.Text = " ";
			this.metroCheckBox3.Theme = 2;
			this.metroCheckBox3.UseCustomBackColor = true;
			this.metroCheckBox3.UseSelectable = true;
			this.metroCheckBox3.CheckedChanged += this.metroCheckBox3_CheckedChanged_1;
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Segoe UI", 12f);
			this.label19.ForeColor = Color.FromArgb(102, 102, 102);
			this.label19.Location = new Point(133, 315);
			this.label19.Name = "label19";
			this.label19.Size = new Size(0, 21);
			this.label19.TabIndex = 141;
			this.label19.Visible = false;
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Segoe UI", 12f);
			this.label20.ForeColor = Color.FromArgb(102, 102, 102);
			this.label20.Location = new Point(305, 316);
			this.label20.Name = "label20";
			this.label20.Size = new Size(0, 21);
			this.label20.TabIndex = 142;
			this.label20.Visible = false;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI", 12f);
			this.label7.ForeColor = Color.FromArgb(102, 102, 102);
			this.label7.Location = new Point(185, 247);
			this.label7.Name = "label7";
			this.label7.Size = new Size(0, 21);
			this.label7.TabIndex = 143;
			this.label7.Visible = false;
			this.panel1.BackgroundImage = (Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label22);
			this.panel1.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel1.Location = new Point(22, 172);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(50, 63);
			this.panel1.TabIndex = 144;
			this.panel1.Visible = false;
			this.panel1.Paint += this.panel1_Paint_1;
			this.panel2.BackgroundImage = (Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel2.Location = new Point(22, 42);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(38, 103);
			this.panel2.TabIndex = 145;
			this.panel3.BackgroundImage = (Image)componentResourceManager.GetObject("panel3.BackgroundImage");
			this.panel3.Controls.Add(this.metroCheckBox6);
			this.panel3.Controls.Add(this.metroCheckBox3);
			this.panel3.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel3.Location = new Point(123, 233);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(38, 51);
			this.panel3.TabIndex = 146;
			this.buttonHead2.Image = (Image)componentResourceManager.GetObject("buttonHead2.Image");
			this.buttonHead2.Location = new Point(34, 369);
			this.buttonHead2.Name = "buttonHead2";
			this.buttonHead2.Size = new Size(167, 48);
			this.buttonHead2.TabIndex = 152;
			this.buttonHead2.TabStop = false;
			this.buttonHead2.Click += this.buttonHead2_Click;
			this.buttonBody2.Image = (Image)componentResourceManager.GetObject("buttonBody2.Image");
			this.buttonBody2.Location = new Point(34, 369);
			this.buttonBody2.Name = "buttonBody2";
			this.buttonBody2.Size = new Size(164, 50);
			this.buttonBody2.TabIndex = 153;
			this.buttonBody2.TabStop = false;
			this.buttonBody2.Click += this.buttonBody2_Click;
			this.buttonNeck2.Image = (Image)componentResourceManager.GetObject("buttonNeck2.Image");
			this.buttonNeck2.Location = new Point(34, 367);
			this.buttonNeck2.Name = "buttonNeck2";
			this.buttonNeck2.Size = new Size(164, 50);
			this.buttonNeck2.TabIndex = 154;
			this.buttonNeck2.TabStop = false;
			this.buttonNeck2.Click += this.buttonNeck2_Click;
			this.pictureBoxNeck.Location = new Point(252, 498);
			this.pictureBoxNeck.Name = "pictureBoxNeck";
			this.pictureBoxNeck.Size = new Size(10, 10);
			this.pictureBoxNeck.TabIndex = 155;
			this.pictureBoxNeck.TabStop = false;
			this.pictureBoxNeck.Visible = false;
			this.pictureBoxBody.Location = new Point(270, 498);
			this.pictureBoxBody.Name = "pictureBoxBody";
			this.pictureBoxBody.Size = new Size(10, 10);
			this.pictureBoxBody.TabIndex = 156;
			this.pictureBoxBody.TabStop = false;
			this.pictureBoxBody.Visible = false;
			this.metroCheckBox8.AutoSize = true;
			this.metroCheckBox8.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox8.Location = new Point(334, 495);
			this.metroCheckBox8.Name = "metroCheckBox8";
			this.metroCheckBox8.Size = new Size(26, 15);
			this.metroCheckBox8.Style = 3;
			this.metroCheckBox8.TabIndex = 157;
			this.metroCheckBox8.Text = " ";
			this.metroCheckBox8.Theme = 2;
			this.metroCheckBox8.UseCustomBackColor = true;
			this.metroCheckBox8.UseSelectable = true;
			this.metroCheckBox8.Visible = false;
			this.metroCheckBox7.AutoSize = true;
			this.metroCheckBox7.Checked = true;
			this.metroCheckBox7.CheckState = CheckState.Checked;
			this.metroCheckBox7.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox7.Location = new Point(334, 495);
			this.metroCheckBox7.Name = "metroCheckBox7";
			this.metroCheckBox7.Size = new Size(26, 15);
			this.metroCheckBox7.Style = 3;
			this.metroCheckBox7.TabIndex = 158;
			this.metroCheckBox7.Text = " ";
			this.metroCheckBox7.Theme = 2;
			this.metroCheckBox7.UseCustomBackColor = true;
			this.metroCheckBox7.UseSelectable = true;
			this.metroCheckBox7.Visible = false;
			this.metroCheckBox7.CheckedChanged += this.metroCheckBox7_CheckedChanged_2;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.FromArgb(153, 153, 153);
			this.label9.Location = new Point(4, 469);
			this.label9.Name = "label9";
			this.label9.Size = new Size(0, 17);
			this.label9.TabIndex = 159;
			this.label9.Visible = false;
			this.buttonBody.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonBody.FlatAppearance.BorderSize = 0;
			this.buttonBody.FlatStyle = FlatStyle.Flat;
			this.buttonBody.Font = new Font("Segoe UI", 10f);
			this.buttonBody.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonBody.Location = new Point(318, 498);
			this.buttonBody.Name = "buttonBody";
			this.buttonBody.Size = new Size(10, 10);
			this.buttonBody.TabIndex = 161;
			this.buttonBody.UseVisualStyleBackColor = false;
			this.buttonBody.Visible = false;
			this.buttonBody.Click += this.buttonBody_Click_1;
			this.buttonNeck.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonNeck.FlatAppearance.BorderSize = 0;
			this.buttonNeck.FlatStyle = FlatStyle.Flat;
			this.buttonNeck.Font = new Font("Segoe UI", 10f);
			this.buttonNeck.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonNeck.Location = new Point(302, 498);
			this.buttonNeck.Name = "buttonNeck";
			this.buttonNeck.Size = new Size(10, 10);
			this.buttonNeck.TabIndex = 162;
			this.buttonNeck.UseVisualStyleBackColor = false;
			this.buttonNeck.Visible = false;
			this.buttonNeck.Click += this.buttonNeck_Click_1;
			this.buttonHead.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonHead.FlatAppearance.BorderSize = 0;
			this.buttonHead.FlatStyle = FlatStyle.Flat;
			this.buttonHead.Font = new Font("Segoe UI", 10f);
			this.buttonHead.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonHead.Location = new Point(286, 498);
			this.buttonHead.Name = "buttonHead";
			this.buttonHead.Size = new Size(10, 10);
			this.buttonHead.TabIndex = 160;
			this.buttonHead.Text = "Head";
			this.buttonHead.UseVisualStyleBackColor = false;
			this.buttonHead.Visible = false;
			this.buttonHead.Click += this.buttonHead_Click_1;
			this.pictureBoxHead.Location = new Point(236, 498);
			this.pictureBoxHead.Name = "pictureBoxHead";
			this.pictureBoxHead.Size = new Size(10, 10);
			this.pictureBoxHead.TabIndex = 163;
			this.pictureBoxHead.TabStop = false;
			this.pictureBoxHead.Visible = false;
			this.panel4.BackgroundImage = (Image)componentResourceManager.GetObject("panel4.BackgroundImage");
			this.panel4.Controls.Add(this.pictureBoxHead2);
			this.panel4.Controls.Add(this.pictureBoxNeck2);
			this.panel4.Controls.Add(this.pictureBoxBody2);
			this.panel4.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel4.Location = new Point(211, 307);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(146, 168);
			this.panel4.TabIndex = 164;
			this.metroButton1.BackColor = Color.Transparent;
			this.metroButton1.FontWeight = 0;
			this.metroButton1.ForeColor = Color.WhiteSmoke;
			this.metroButton1.Highlight = true;
			this.metroButton1.Location = new Point(37, 434);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new Size(161, 26);
			this.metroButton1.Style = 12;
			this.metroButton1.TabIndex = 165;
			this.metroButton1.Text = "SaveConfig";
			this.metroButton1.Theme = 2;
			this.metroButton1.UseCustomBackColor = true;
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += this.metroButton1_Click;
			this.AimbotCombo.BackColor = Color.FromArgb(19, 19, 19);
			this.AimbotCombo.FontSize = 0;
			this.AimbotCombo.FontWeight = 0;
			this.AimbotCombo.ForeColor = Color.BlueViolet;
			this.AimbotCombo.FormattingEnabled = true;
			this.AimbotCombo.IntegralHeight = false;
			this.AimbotCombo.ItemHeight = 19;
			this.AimbotCombo.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock",
				"V"
			});
			this.AimbotCombo.Location = new Point(260, 37);
			this.AimbotCombo.Name = "AimbotCombo";
			this.AimbotCombo.RightToLeft = RightToLeft.No;
			this.AimbotCombo.Size = new Size(92, 25);
			this.AimbotCombo.TabIndex = 166;
			this.AimbotCombo.Theme = 2;
			this.AimbotCombo.UseCustomBackColor = true;
			this.AimbotCombo.UseCustomForeColor = true;
			this.AimbotCombo.UseSelectable = true;
			this.AimbotCombo.UseStyleColors = true;
			this.AimbotCombo.SelectedIndexChanged += this.AimbotCombo_SelectedIndexChanged;
			this.FlickbotCombo.BackColor = Color.FromArgb(19, 19, 19);
			this.FlickbotCombo.FontSize = 0;
			this.FlickbotCombo.FontWeight = 0;
			this.FlickbotCombo.ForeColor = Color.BlueViolet;
			this.FlickbotCombo.FormattingEnabled = true;
			this.FlickbotCombo.IntegralHeight = false;
			this.FlickbotCombo.ItemHeight = 19;
			this.FlickbotCombo.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock",
				"V"
			});
			this.FlickbotCombo.Location = new Point(260, 67);
			this.FlickbotCombo.Name = "FlickbotCombo";
			this.FlickbotCombo.RightToLeft = RightToLeft.No;
			this.FlickbotCombo.Size = new Size(92, 25);
			this.FlickbotCombo.TabIndex = 167;
			this.FlickbotCombo.Theme = 2;
			this.FlickbotCombo.UseCustomBackColor = true;
			this.FlickbotCombo.UseCustomForeColor = true;
			this.FlickbotCombo.UseSelectable = true;
			this.FlickbotCombo.UseStyleColors = true;
			this.FlickbotCombo.Visible = false;
			this.FlickbotCombo.SelectedIndexChanged += this.FlickbotCombo_SelectedIndexChanged;
			this.SilentaimCombo.BackColor = Color.FromArgb(19, 19, 19);
			this.SilentaimCombo.FontSize = 0;
			this.SilentaimCombo.FontWeight = 0;
			this.SilentaimCombo.ForeColor = Color.BlueViolet;
			this.SilentaimCombo.FormattingEnabled = true;
			this.SilentaimCombo.IntegralHeight = false;
			this.SilentaimCombo.ItemHeight = 19;
			this.SilentaimCombo.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock",
				"V"
			});
			this.SilentaimCombo.Location = new Point(260, 96);
			this.SilentaimCombo.Name = "SilentaimCombo";
			this.SilentaimCombo.RightToLeft = RightToLeft.No;
			this.SilentaimCombo.Size = new Size(92, 25);
			this.SilentaimCombo.TabIndex = 168;
			this.SilentaimCombo.Theme = 2;
			this.SilentaimCombo.UseCustomBackColor = true;
			this.SilentaimCombo.UseCustomForeColor = true;
			this.SilentaimCombo.UseSelectable = true;
			this.SilentaimCombo.UseStyleColors = true;
			this.SilentaimCombo.Visible = false;
			this.SilentaimCombo.SelectedIndexChanged += this.SilentaimCombo_SelectedIndexChanged;
			this.TriggerbotCombo.BackColor = Color.FromArgb(19, 19, 19);
			this.TriggerbotCombo.FontSize = 0;
			this.TriggerbotCombo.FontWeight = 0;
			this.TriggerbotCombo.ForeColor = Color.BlueViolet;
			this.TriggerbotCombo.FormattingEnabled = true;
			this.TriggerbotCombo.IntegralHeight = false;
			this.TriggerbotCombo.ItemHeight = 19;
			this.TriggerbotCombo.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock",
				"V"
			});
			this.TriggerbotCombo.Location = new Point(260, 127);
			this.TriggerbotCombo.Name = "TriggerbotCombo";
			this.TriggerbotCombo.RightToLeft = RightToLeft.No;
			this.TriggerbotCombo.Size = new Size(92, 25);
			this.TriggerbotCombo.TabIndex = 169;
			this.TriggerbotCombo.Theme = 2;
			this.TriggerbotCombo.UseCustomBackColor = true;
			this.TriggerbotCombo.UseCustomForeColor = true;
			this.TriggerbotCombo.UseSelectable = true;
			this.TriggerbotCombo.UseStyleColors = true;
			this.TriggerbotCombo.SelectedIndexChanged += this.TriggerbotCombo_SelectedIndexChanged;
			this.panel5.BackgroundImage = Resources.seeee;
			this.panel5.Controls.Add(this.metroLabel1);
			this.panel5.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel5.Location = new Point(21, 65);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(331, 56);
			this.panel5.TabIndex = 170;
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new Point(30, 18);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new Size(265, 19);
			this.metroLabel1.Style = 1;
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "FLICK AND SILENT TEMPORARY REMOVED";
			this.metroLabel1.Theme = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(19, 19, 19);
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.TriggerbotCombo);
			base.Controls.Add(this.SilentaimCombo);
			base.Controls.Add(this.FlickbotCombo);
			base.Controls.Add(this.AimbotCombo);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.pictureBoxHead);
			base.Controls.Add(this.buttonBody);
			base.Controls.Add(this.buttonNeck);
			base.Controls.Add(this.buttonHead);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.metroCheckBox7);
			base.Controls.Add(this.metroCheckBox8);
			base.Controls.Add(this.pictureBoxBody);
			base.Controls.Add(this.pictureBoxNeck);
			base.Controls.Add(this.buttonBody2);
			base.Controls.Add(this.buttonNeck2);
			base.Controls.Add(this.buttonHead2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.metroCheckBox10);
			base.Controls.Add(this.metroComboBox2);
			base.Controls.Add(this.metroCheckBox9);
			base.Controls.Add(this.metroCheckBox2);
			base.Controls.Add(this.metroCheckBox1);
			base.Controls.Add(this.panel2);
			base.Name = "UserControl1";
			base.Size = new Size(370, 515);
			base.Load += this.UserControl1_Load;
			((ISupportInitialize)this.pictureBoxBody2).EndInit();
			((ISupportInitialize)this.pictureBoxNeck2).EndInit();
			((ISupportInitialize)this.pictureBoxHead2).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.buttonHead2).EndInit();
			((ISupportInitialize)this.buttonBody2).EndInit();
			((ISupportInitialize)this.buttonNeck2).EndInit();
			((ISupportInitialize)this.pictureBoxNeck).EndInit();
			((ISupportInitialize)this.pictureBoxBody).EndInit();
			((ISupportInitialize)this.pictureBoxHead).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003DC RID: 988
		private int[] list_characters = new int[]
		{
			1,
			2,
			5,
			6,
			9,
			16,
			17,
			18,
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90
		};

		// Token: 0x040003DD RID: 989
		private IContainer components;

		// Token: 0x040003DE RID: 990
		private PictureBox pictureBoxNeck2;

		// Token: 0x040003DF RID: 991
		private PictureBox pictureBoxHead2;

		// Token: 0x040003E0 RID: 992
		private PictureBox pictureBoxBody2;

		// Token: 0x040003E1 RID: 993
		public System.Windows.Forms.Timer timer1;

		// Token: 0x040003E2 RID: 994
		private Label label27;

		// Token: 0x040003E3 RID: 995
		private MetroCheckBox metroCheckBox10;

		// Token: 0x040003E4 RID: 996
		private Label label22;

		// Token: 0x040003E5 RID: 997
		private MetroCheckBox metroCheckBox9;

		// Token: 0x040003E6 RID: 998
		private Label label10;

		// Token: 0x040003E7 RID: 999
		private Label label11;

		// Token: 0x040003E8 RID: 1000
		private MetroCheckBox metroCheckBox2;

		// Token: 0x040003E9 RID: 1001
		private MetroCheckBox metroCheckBox1;

		// Token: 0x040003EA RID: 1002
		private MetroCheckBox metroCheckBox3;

		// Token: 0x040003EB RID: 1003
		private MetroCheckBox metroCheckBox6;

		// Token: 0x040003EC RID: 1004
		private MetroComboBox metroComboBox2;

		// Token: 0x040003ED RID: 1005
		private Label label19;

		// Token: 0x040003EE RID: 1006
		private Label label20;

		// Token: 0x040003EF RID: 1007
		private Label label7;

		// Token: 0x040003F0 RID: 1008
		private Panel panel1;

		// Token: 0x040003F1 RID: 1009
		private Panel panel2;

		// Token: 0x040003F2 RID: 1010
		private Panel panel3;

		// Token: 0x040003F3 RID: 1011
		private PictureBox buttonHead2;

		// Token: 0x040003F4 RID: 1012
		private PictureBox buttonBody2;

		// Token: 0x040003F5 RID: 1013
		private PictureBox buttonNeck2;

		// Token: 0x040003F6 RID: 1014
		private PictureBox pictureBoxNeck;

		// Token: 0x040003F7 RID: 1015
		private PictureBox pictureBoxBody;

		// Token: 0x040003F8 RID: 1016
		private MetroCheckBox metroCheckBox8;

		// Token: 0x040003F9 RID: 1017
		private MetroCheckBox metroCheckBox7;

		// Token: 0x040003FA RID: 1018
		private Label label9;

		// Token: 0x040003FB RID: 1019
		private Button buttonBody;

		// Token: 0x040003FC RID: 1020
		private Button buttonNeck;

		// Token: 0x040003FD RID: 1021
		private Button buttonHead;

		// Token: 0x040003FE RID: 1022
		private PictureBox pictureBoxHead;

		// Token: 0x040003FF RID: 1023
		private Panel panel4;

		// Token: 0x04000400 RID: 1024
		private MetroButton metroButton1;

		// Token: 0x04000401 RID: 1025
		private MetroComboBox AimbotCombo;

		// Token: 0x04000402 RID: 1026
		private MetroComboBox FlickbotCombo;

		// Token: 0x04000403 RID: 1027
		private MetroComboBox SilentaimCombo;

		// Token: 0x04000404 RID: 1028
		public MetroComboBox TriggerbotCombo;

		// Token: 0x04000405 RID: 1029
		private Panel panel5;

		// Token: 0x04000406 RID: 1030
		private MetroLabel metroLabel1;
	}
}
