using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using RenameMe.Properties;

namespace RenameMe.UserControls
{
	// Token: 0x02000053 RID: 83
	public class UserControl3 : UserControl
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002EEB File Offset: 0x000010EB
		public UserControl3()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000113B0 File Offset: 0x0000F5B0
		private void UserControl3_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
			this.metroComboBox1.Text = this.metroComboBox1.Items[0].ToString();
			this.metroComboBox2.Text = this.metroComboBox2.Items[1].ToString();
			this.metroComboBox3.Text = this.metroComboBox3.Items[2].ToString();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002F11 File Offset: 0x00001111
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox2.Checked)
			{
				config.hip_fire_state = true;
				return;
			}
			config.hip_fire_state = false;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002F2D File Offset: 0x0000112D
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox1.Checked)
			{
				config.recoil_system_state = true;
				return;
			}
			config.recoil_system_state = false;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001142C File Offset: 0x0000F62C
		private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
			config.rcs_smooth = (double)(this.metroTrackBar2.Value / 100 * 2);
			this.label3.Text = this.metroTrackBar2.Value.ToString();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00011470 File Offset: 0x0000F670
		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.metroCheckBox7.Checked)
			{
				config.weapon2_state = false;
				return;
			}
			config.weapon2_state = true;
			switch (this.metroComboBox2.SelectedIndex)
			{
			case 0:
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				config.max_recoil = 43;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001157C File Offset: 0x0000F77C
		private void metroCheckBox3_CheckedChanged_1(object sender, EventArgs e)
		{
			if (!this.metroCheckBox3.Checked)
			{
				config.weapon1_state = false;
				return;
			}
			config.weapon1_state = true;
			switch (this.metroComboBox1.SelectedIndex)
			{
			case 0:
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				config.max_recoil = 43;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00011688 File Offset: 0x0000F888
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.metroCheckBox4.Checked)
			{
				config.weapon3_state = false;
				return;
			}
			config.weapon3_state = true;
			switch (this.metroComboBox3.SelectedIndex)
			{
			case 0:
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				config.max_recoil = 43;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00011794 File Offset: 0x0000F994
		private void allhide1()
		{
			this.pictureBoxARES1.Hide();
			this.pictureBoxBULLDOG1.Hide();
			this.pictureBoxFRENZY1.Hide();
			this.pictureBoxODIN1.Hide();
			this.pictureBoxPHANTOM1.Hide();
			this.pictureBoxSPECTRE1.Hide();
			this.pictureBoxSTINGER1.Hide();
			this.pictureBoxVANDAL1.Hide();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000117FC File Offset: 0x0000F9FC
		private void allhide2()
		{
			this.pictureBoxARES2.Hide();
			this.pictureBoxBULLDOG2.Hide();
			this.pictureBoxFRENZY2.Hide();
			this.pictureBoxODIN2.Hide();
			this.pictureBoxPHANTOM2.Hide();
			this.pictureBoxSPECTRE2.Hide();
			this.pictureBoxSTINGER2.Hide();
			this.pictureBoxVANDAL2.Hide();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00011864 File Offset: 0x0000FA64
		private void allhide3()
		{
			this.pictureBoxARES3.Hide();
			this.pictureBoxBULLDOG3.Hide();
			this.pictureBoxFRENZY3.Hide();
			this.pictureBoxODIN3.Hide();
			this.pictureBoxPHANTOM3.Hide();
			this.pictureBoxSPECTRE3.Hide();
			this.pictureBoxSTINGER3.Hide();
			this.pictureBoxVANDAL3.Hide();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000118CC File Offset: 0x0000FACC
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide1();
			switch (this.metroComboBox1.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES1.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				this.pictureBoxBULLDOG1.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				this.pictureBoxFRENZY1.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				this.pictureBoxODIN1.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				this.pictureBoxPHANTOM1.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				this.pictureBoxSPECTRE1.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				this.pictureBoxSTINGER1.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				this.pictureBoxVANDAL1.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00011A1C File Offset: 0x0000FC1C
		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide2();
			switch (this.metroComboBox2.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES2.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				this.pictureBoxBULLDOG2.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				this.pictureBoxFRENZY2.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				this.pictureBoxODIN2.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				this.pictureBoxPHANTOM2.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				this.pictureBoxSPECTRE2.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				this.pictureBoxSTINGER2.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				this.pictureBoxVANDAL2.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00011B6C File Offset: 0x0000FD6C
		private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide3();
			switch (this.metroComboBox3.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES3.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				return;
			case 1:
				this.pictureBoxBULLDOG3.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				return;
			case 2:
				this.pictureBoxFRENZY3.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				return;
			case 3:
				this.pictureBoxODIN3.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				return;
			case 4:
				this.pictureBoxPHANTOM3.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				return;
			case 5:
				this.pictureBoxSPECTRE3.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				return;
			case 6:
				this.pictureBoxSTINGER3.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				return;
			case 7:
				this.pictureBoxVANDAL3.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00011CBC File Offset: 0x0000FEBC
		private void label10_Click(object sender, EventArgs e)
		{
			this.label11.ForeColor = Color.DarkSlateBlue;
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(15);
			}
			int key = this.get_key();
			this.label10.Text = this.get_name_of_key(key);
			if (key != 0)
			{
				config.weapon1_key = 1;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00011D10 File Offset: 0x0000FF10
		private void label7_Click(object sender, EventArgs e)
		{
			this.label11.ForeColor = Color.DarkSlateBlue;
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(15);
			}
			int key = this.get_key();
			this.label7.Text = this.get_name_of_key(key);
			if (key != 0)
			{
				config.weapon2_key = 1;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00011D64 File Offset: 0x0000FF64
		private void label12_Click(object sender, EventArgs e)
		{
			this.label11.ForeColor = Color.DarkSlateBlue;
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(15);
			}
			int key = this.get_key();
			this.label12.Text = this.get_name_of_key(key);
			if (key != 0)
			{
				config.weapon3_key = 1;
			}
		}

		// Token: 0x0600024C RID: 588
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int ArrowKeys);

		// Token: 0x0600024D RID: 589 RVA: 0x0000248E File Offset: 0x0000068E
		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		private int get_key()
		{
			for (int i = 0; i < 500; i++)
			{
				foreach (int num in this.list_characters)
				{
					if (UserControl3.GetAsyncKeyState(num) < 0)
					{
						return num;
					}
				}
				Thread.Sleep(10);
			}
			return 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00011E04 File Offset: 0x00010004
		private string get_name_of_key(int key)
		{
			switch (key)
			{
			case 1:
				return "[ Left ]";
			case 2:
				return "[ Right ]";
			case 3:
			case 4:
			case 7:
			case 8:
				break;
			case 5:
				return "[ X1 ]";
			case 6:
				return "[ X2 ]";
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
			return "[ KEY ]";
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00011F9C File Offset: 0x0001019C
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (UserControl3.GetAsyncKeyState(config.weapon1_key) < 0)
			{
				this.metroCheckBox3.Checked = true;
				this.metroCheckBox7.Checked = false;
				this.metroCheckBox4.Checked = false;
				while (UserControl3.GetAsyncKeyState(config.weapon1_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			if (UserControl3.GetAsyncKeyState(config.weapon2_key) < 0)
			{
				this.metroCheckBox3.Checked = false;
				this.metroCheckBox7.Checked = true;
				this.metroCheckBox4.Checked = false;
				while (UserControl3.GetAsyncKeyState(config.weapon2_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			if (UserControl3.GetAsyncKeyState(config.weapon3_key) < 0)
			{
				this.metroCheckBox3.Checked = false;
				this.metroCheckBox7.Checked = false;
				this.metroCheckBox4.Checked = true;
				while (UserControl3.GetAsyncKeyState(config.weapon3_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000248E File Offset: 0x0000068E
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBoxVANDAL2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBoxFRENZY3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBoxVANDAL1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002F49 File Offset: 0x00001149
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00012080 File Offset: 0x00010280
		private void InitializeComponent()
		{
			this.components = new Container();
			this.metroTrackBar2 = new MetroTrackBar();
			this.pictureBoxVANDAL1 = new PictureBox();
			this.pictureBoxSTINGER1 = new PictureBox();
			this.pictureBoxSPECTRE1 = new PictureBox();
			this.pictureBoxARES1 = new PictureBox();
			this.pictureBoxBULLDOG1 = new PictureBox();
			this.pictureBoxFRENZY1 = new PictureBox();
			this.pictureBoxODIN1 = new PictureBox();
			this.pictureBoxPHANTOM1 = new PictureBox();
			this.metroComboBox1 = new MetroComboBox();
			this.metroCheckBox3 = new MetroCheckBox();
			this.label10 = new Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.metroCheckBox1 = new MetroCheckBox();
			this.metroCheckBox2 = new MetroCheckBox();
			this.label3 = new Label();
			this.pictureBoxBULLDOG2 = new PictureBox();
			this.pictureBoxPHANTOM2 = new PictureBox();
			this.pictureBoxARES2 = new PictureBox();
			this.pictureBoxVANDAL2 = new PictureBox();
			this.pictureBoxSPECTRE2 = new PictureBox();
			this.pictureBoxSTINGER2 = new PictureBox();
			this.pictureBoxFRENZY2 = new PictureBox();
			this.pictureBoxBULLDOG3 = new PictureBox();
			this.pictureBoxSTINGER3 = new PictureBox();
			this.pictureBoxFRENZY3 = new PictureBox();
			this.pictureBoxPHANTOM3 = new PictureBox();
			this.pictureBoxSPECTRE3 = new PictureBox();
			this.pictureBoxARES3 = new PictureBox();
			this.pictureBoxODIN3 = new PictureBox();
			this.pictureBoxVANDAL3 = new PictureBox();
			this.label9 = new Label();
			this.label12 = new Label();
			this.metroCheckBox7 = new MetroCheckBox();
			this.label7 = new Label();
			this.label11 = new Label();
			this.metroCheckBox4 = new MetroCheckBox();
			this.metroComboBox2 = new MetroComboBox();
			this.metroComboBox3 = new MetroComboBox();
			this.pictureBoxODIN2 = new PictureBox();
			this.panel2 = new Panel();
			this.panel1 = new Panel();
			((ISupportInitialize)this.pictureBoxVANDAL1).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER1).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE1).BeginInit();
			((ISupportInitialize)this.pictureBoxARES1).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG1).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY1).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN1).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM1).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG2).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM2).BeginInit();
			((ISupportInitialize)this.pictureBoxARES2).BeginInit();
			((ISupportInitialize)this.pictureBoxVANDAL2).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE2).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER2).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY2).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG3).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER3).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY3).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM3).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE3).BeginInit();
			((ISupportInitialize)this.pictureBoxARES3).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN3).BeginInit();
			((ISupportInitialize)this.pictureBoxVANDAL3).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN2).BeginInit();
			base.SuspendLayout();
			this.metroTrackBar2.BackColor = Color.Transparent;
			this.metroTrackBar2.Location = new Point(28, 130);
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new Size(299, 22);
			this.metroTrackBar2.Style = 3;
			this.metroTrackBar2.TabIndex = 13;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.Theme = 2;
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.Value = 60;
			this.metroTrackBar2.Scroll += this.metroTrackBar2_Scroll;
			this.pictureBoxVANDAL1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxVANDAL1.Image = Resources.Vandal;
			this.pictureBoxVANDAL1.Location = new Point(227, 215);
			this.pictureBoxVANDAL1.Name = "pictureBoxVANDAL1";
			this.pictureBoxVANDAL1.Size = new Size(100, 30);
			this.pictureBoxVANDAL1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL1.TabIndex = 46;
			this.pictureBoxVANDAL1.TabStop = false;
			this.pictureBoxVANDAL1.Click += this.pictureBoxVANDAL1_Click;
			this.pictureBoxSTINGER1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSTINGER1.Image = Resources.Stinger;
			this.pictureBoxSTINGER1.Location = new Point(227, 214);
			this.pictureBoxSTINGER1.Name = "pictureBoxSTINGER1";
			this.pictureBoxSTINGER1.Size = new Size(100, 30);
			this.pictureBoxSTINGER1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER1.TabIndex = 45;
			this.pictureBoxSTINGER1.TabStop = false;
			this.pictureBoxSPECTRE1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSPECTRE1.Image = Resources.Spectre;
			this.pictureBoxSPECTRE1.Location = new Point(227, 215);
			this.pictureBoxSPECTRE1.Name = "pictureBoxSPECTRE1";
			this.pictureBoxSPECTRE1.Size = new Size(100, 30);
			this.pictureBoxSPECTRE1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE1.TabIndex = 44;
			this.pictureBoxSPECTRE1.TabStop = false;
			this.pictureBoxARES1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxARES1.Image = Resources.Ares;
			this.pictureBoxARES1.Location = new Point(227, 214);
			this.pictureBoxARES1.Name = "pictureBoxARES1";
			this.pictureBoxARES1.Size = new Size(100, 30);
			this.pictureBoxARES1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES1.TabIndex = 38;
			this.pictureBoxARES1.TabStop = false;
			this.pictureBoxBULLDOG1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxBULLDOG1.Image = Resources.Bulldog;
			this.pictureBoxBULLDOG1.Location = new Point(227, 214);
			this.pictureBoxBULLDOG1.Name = "pictureBoxBULLDOG1";
			this.pictureBoxBULLDOG1.Size = new Size(100, 30);
			this.pictureBoxBULLDOG1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG1.TabIndex = 40;
			this.pictureBoxBULLDOG1.TabStop = false;
			this.pictureBoxFRENZY1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxFRENZY1.Image = Resources.Frenzy1;
			this.pictureBoxFRENZY1.Location = new Point(227, 215);
			this.pictureBoxFRENZY1.Name = "pictureBoxFRENZY1";
			this.pictureBoxFRENZY1.Size = new Size(100, 30);
			this.pictureBoxFRENZY1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY1.TabIndex = 41;
			this.pictureBoxFRENZY1.TabStop = false;
			this.pictureBoxODIN1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxODIN1.Image = Resources.Odin;
			this.pictureBoxODIN1.Location = new Point(227, 215);
			this.pictureBoxODIN1.Name = "pictureBoxODIN1";
			this.pictureBoxODIN1.Size = new Size(100, 30);
			this.pictureBoxODIN1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN1.TabIndex = 42;
			this.pictureBoxODIN1.TabStop = false;
			this.pictureBoxPHANTOM1.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxPHANTOM1.Image = Resources.Phantom1;
			this.pictureBoxPHANTOM1.Location = new Point(227, 215);
			this.pictureBoxPHANTOM1.Name = "pictureBoxPHANTOM1";
			this.pictureBoxPHANTOM1.Size = new Size(100, 30);
			this.pictureBoxPHANTOM1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM1.TabIndex = 43;
			this.pictureBoxPHANTOM1.TabStop = false;
			this.metroComboBox1.BackColor = Color.FromArgb(19, 19, 19);
			this.metroComboBox1.ForeColor = Color.BlueViolet;
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.IntegralHeight = false;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox1.Location = new Point(42, 215);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.PromptText = "Select";
			this.metroComboBox1.RightToLeft = RightToLeft.No;
			this.metroComboBox1.Size = new Size(96, 29);
			this.metroComboBox1.Style = 3;
			this.metroComboBox1.TabIndex = 39;
			this.metroComboBox1.Theme = 2;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.UseStyleColors = true;
			this.metroComboBox1.SelectedIndexChanged += this.metroComboBox1_SelectedIndexChanged;
			this.metroCheckBox3.AutoSize = true;
			this.metroCheckBox3.BackColor = Color.FromArgb(19, 19, 19);
			this.metroCheckBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox3.Location = new Point(40, 185);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new Size(26, 15);
			this.metroCheckBox3.Style = 12;
			this.metroCheckBox3.TabIndex = 30;
			this.metroCheckBox3.Text = " ";
			this.metroCheckBox3.Theme = 2;
			this.metroCheckBox3.UseCustomBackColor = true;
			this.metroCheckBox3.UseSelectable = true;
			this.metroCheckBox3.CheckedChanged += this.metroCheckBox3_CheckedChanged_1;
			this.label10.AutoSize = true;
			this.label10.BackColor = Color.FromArgb(19, 19, 19);
			this.label10.Font = new Font("Segoe UI", 12f);
			this.label10.ForeColor = Color.BlueViolet;
			this.label10.Location = new Point(245, 185);
			this.label10.Name = "label10";
			this.label10.Size = new Size(54, 21);
			this.label10.TabIndex = 36;
			this.label10.Text = "[ KEY ]";
			this.label10.Visible = false;
			this.label10.Click += this.label10_Click;
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += this.timer1_Tick;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.BackColor = Color.FromArgb(19, 19, 19);
			this.metroCheckBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox1.Location = new Point(40, 36);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(26, 15);
			this.metroCheckBox1.Style = 12;
			this.metroCheckBox1.TabIndex = 7;
			this.metroCheckBox1.Text = " ";
			this.metroCheckBox1.Theme = 2;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += this.metroCheckBox1_CheckedChanged;
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.BackColor = Color.FromArgb(19, 19, 19);
			this.metroCheckBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox2.Location = new Point(40, 59);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new Size(26, 15);
			this.metroCheckBox2.Style = 12;
			this.metroCheckBox2.TabIndex = 8;
			this.metroCheckBox2.Text = " ";
			this.metroCheckBox2.Theme = 2;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox2.CheckedChanged += this.metroCheckBox2_CheckedChanged;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(19, 19, 19);
			this.label3.Font = new Font("Segoe UI", 10f);
			this.label3.ForeColor = Color.DarkViolet;
			this.label3.Location = new Point(302, 108);
			this.label3.Name = "label3";
			this.label3.Size = new Size(25, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "60";
			this.pictureBoxBULLDOG2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxBULLDOG2.Location = new Point(19, 390);
			this.pictureBoxBULLDOG2.Name = "pictureBoxBULLDOG2";
			this.pictureBoxBULLDOG2.Size = new Size(100, 30);
			this.pictureBoxBULLDOG2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG2.TabIndex = 46;
			this.pictureBoxBULLDOG2.TabStop = false;
			this.pictureBoxBULLDOG2.Visible = false;
			this.pictureBoxPHANTOM2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxPHANTOM2.Location = new Point(19, 424);
			this.pictureBoxPHANTOM2.Name = "pictureBoxPHANTOM2";
			this.pictureBoxPHANTOM2.Size = new Size(100, 30);
			this.pictureBoxPHANTOM2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM2.TabIndex = 46;
			this.pictureBoxPHANTOM2.TabStop = false;
			this.pictureBoxPHANTOM2.Visible = false;
			this.pictureBoxARES2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxARES2.Location = new Point(121, 390);
			this.pictureBoxARES2.Name = "pictureBoxARES2";
			this.pictureBoxARES2.Size = new Size(100, 30);
			this.pictureBoxARES2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES2.TabIndex = 46;
			this.pictureBoxARES2.TabStop = false;
			this.pictureBoxARES2.Visible = false;
			this.pictureBoxVANDAL2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxVANDAL2.Location = new Point(121, 426);
			this.pictureBoxVANDAL2.Name = "pictureBoxVANDAL2";
			this.pictureBoxVANDAL2.Size = new Size(100, 30);
			this.pictureBoxVANDAL2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL2.TabIndex = 47;
			this.pictureBoxVANDAL2.TabStop = false;
			this.pictureBoxVANDAL2.Visible = false;
			this.pictureBoxVANDAL2.Click += this.pictureBoxVANDAL2_Click;
			this.pictureBoxSPECTRE2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSPECTRE2.Location = new Point(19, 352);
			this.pictureBoxSPECTRE2.Name = "pictureBoxSPECTRE2";
			this.pictureBoxSPECTRE2.Size = new Size(100, 30);
			this.pictureBoxSPECTRE2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE2.TabIndex = 46;
			this.pictureBoxSPECTRE2.TabStop = false;
			this.pictureBoxSPECTRE2.Visible = false;
			this.pictureBoxSTINGER2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSTINGER2.Location = new Point(19, 318);
			this.pictureBoxSTINGER2.Name = "pictureBoxSTINGER2";
			this.pictureBoxSTINGER2.Size = new Size(100, 30);
			this.pictureBoxSTINGER2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER2.TabIndex = 46;
			this.pictureBoxSTINGER2.TabStop = false;
			this.pictureBoxSTINGER2.Visible = false;
			this.pictureBoxFRENZY2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxFRENZY2.Location = new Point(19, 282);
			this.pictureBoxFRENZY2.Name = "pictureBoxFRENZY2";
			this.pictureBoxFRENZY2.Size = new Size(100, 30);
			this.pictureBoxFRENZY2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY2.TabIndex = 46;
			this.pictureBoxFRENZY2.TabStop = false;
			this.pictureBoxFRENZY2.Visible = false;
			this.pictureBoxBULLDOG3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxBULLDOG3.Location = new Point(19, 464);
			this.pictureBoxBULLDOG3.Name = "pictureBoxBULLDOG3";
			this.pictureBoxBULLDOG3.Size = new Size(100, 30);
			this.pictureBoxBULLDOG3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG3.TabIndex = 47;
			this.pictureBoxBULLDOG3.TabStop = false;
			this.pictureBoxBULLDOG3.Visible = false;
			this.pictureBoxSTINGER3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSTINGER3.Location = new Point(121, 354);
			this.pictureBoxSTINGER3.Name = "pictureBoxSTINGER3";
			this.pictureBoxSTINGER3.Size = new Size(100, 30);
			this.pictureBoxSTINGER3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER3.TabIndex = 47;
			this.pictureBoxSTINGER3.TabStop = false;
			this.pictureBoxSTINGER3.Visible = false;
			this.pictureBoxFRENZY3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxFRENZY3.Location = new Point(121, 318);
			this.pictureBoxFRENZY3.Name = "pictureBoxFRENZY3";
			this.pictureBoxFRENZY3.Size = new Size(100, 30);
			this.pictureBoxFRENZY3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY3.TabIndex = 47;
			this.pictureBoxFRENZY3.TabStop = false;
			this.pictureBoxFRENZY3.Visible = false;
			this.pictureBoxFRENZY3.Click += this.pictureBoxFRENZY3_Click;
			this.pictureBoxPHANTOM3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxPHANTOM3.Location = new Point(121, 282);
			this.pictureBoxPHANTOM3.Name = "pictureBoxPHANTOM3";
			this.pictureBoxPHANTOM3.Size = new Size(100, 30);
			this.pictureBoxPHANTOM3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM3.TabIndex = 47;
			this.pictureBoxPHANTOM3.TabStop = false;
			this.pictureBoxPHANTOM3.Visible = false;
			this.pictureBoxSPECTRE3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxSPECTRE3.Location = new Point(227, 429);
			this.pictureBoxSPECTRE3.Name = "pictureBoxSPECTRE3";
			this.pictureBoxSPECTRE3.Size = new Size(100, 30);
			this.pictureBoxSPECTRE3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE3.TabIndex = 47;
			this.pictureBoxSPECTRE3.TabStop = false;
			this.pictureBoxSPECTRE3.Visible = false;
			this.pictureBoxARES3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxARES3.Location = new Point(227, 390);
			this.pictureBoxARES3.Name = "pictureBoxARES3";
			this.pictureBoxARES3.Size = new Size(100, 30);
			this.pictureBoxARES3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES3.TabIndex = 47;
			this.pictureBoxARES3.TabStop = false;
			this.pictureBoxARES3.Visible = false;
			this.pictureBoxODIN3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxODIN3.Location = new Point(227, 354);
			this.pictureBoxODIN3.Name = "pictureBoxODIN3";
			this.pictureBoxODIN3.Size = new Size(100, 30);
			this.pictureBoxODIN3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN3.TabIndex = 47;
			this.pictureBoxODIN3.TabStop = false;
			this.pictureBoxODIN3.Visible = false;
			this.pictureBoxVANDAL3.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxVANDAL3.Location = new Point(227, 282);
			this.pictureBoxVANDAL3.Name = "pictureBoxVANDAL3";
			this.pictureBoxVANDAL3.Size = new Size(100, 30);
			this.pictureBoxVANDAL3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL3.TabIndex = 48;
			this.pictureBoxVANDAL3.TabStop = false;
			this.pictureBoxVANDAL3.Visible = false;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.BlueViolet;
			this.label9.Location = new Point(210, 466);
			this.label9.Name = "label9";
			this.label9.Size = new Size(75, 17);
			this.label9.TabIndex = 31;
			this.label9.Text = "2- Weapon";
			this.label9.Visible = false;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI", 12f);
			this.label12.ForeColor = Color.BlueViolet;
			this.label12.Location = new Point(291, 494);
			this.label12.Name = "label12";
			this.label12.Size = new Size(54, 21);
			this.label12.TabIndex = 36;
			this.label12.Text = "[ KEY ]";
			this.label12.Visible = false;
			this.label12.Click += this.label12_Click;
			this.metroCheckBox7.AutoSize = true;
			this.metroCheckBox7.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox7.Location = new Point(178, 468);
			this.metroCheckBox7.Name = "metroCheckBox7";
			this.metroCheckBox7.Size = new Size(26, 15);
			this.metroCheckBox7.Style = 3;
			this.metroCheckBox7.TabIndex = 30;
			this.metroCheckBox7.Text = " ";
			this.metroCheckBox7.Theme = 2;
			this.metroCheckBox7.UseCustomBackColor = true;
			this.metroCheckBox7.UseSelectable = true;
			this.metroCheckBox7.Visible = false;
			this.metroCheckBox7.CheckedChanged += this.metroCheckBox7_CheckedChanged;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI", 12f);
			this.label7.ForeColor = Color.BlueViolet;
			this.label7.Location = new Point(291, 492);
			this.label7.Name = "label7";
			this.label7.Size = new Size(54, 21);
			this.label7.TabIndex = 36;
			this.label7.Text = "[ KEY ]";
			this.label7.Visible = false;
			this.label7.Click += this.label7_Click;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label11.ForeColor = Color.BlueViolet;
			this.label11.Location = new Point(210, 464);
			this.label11.Name = "label11";
			this.label11.Size = new Size(75, 17);
			this.label11.TabIndex = 31;
			this.label11.Text = "3- Weapon";
			this.label11.Visible = false;
			this.metroCheckBox4.AutoSize = true;
			this.metroCheckBox4.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox4.Location = new Point(178, 466);
			this.metroCheckBox4.Name = "metroCheckBox4";
			this.metroCheckBox4.Size = new Size(26, 15);
			this.metroCheckBox4.Style = 3;
			this.metroCheckBox4.TabIndex = 30;
			this.metroCheckBox4.Text = " ";
			this.metroCheckBox4.Theme = 2;
			this.metroCheckBox4.UseCustomBackColor = true;
			this.metroCheckBox4.UseSelectable = true;
			this.metroCheckBox4.Visible = false;
			this.metroCheckBox4.CheckedChanged += this.metroCheckBox4_CheckedChanged;
			this.metroComboBox2.BackColor = Color.FromArgb(19, 19, 19);
			this.metroComboBox2.ForeColor = Color.BlueViolet;
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox2.Location = new Point(189, 486);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.PromptText = "Select";
			this.metroComboBox2.RightToLeft = RightToLeft.No;
			this.metroComboBox2.Size = new Size(96, 29);
			this.metroComboBox2.Style = 3;
			this.metroComboBox2.TabIndex = 40;
			this.metroComboBox2.Theme = 2;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.UseStyleColors = true;
			this.metroComboBox2.Visible = false;
			this.metroComboBox2.SelectedIndexChanged += this.metroComboBox2_SelectedIndexChanged;
			this.metroComboBox3.BackColor = Color.FromArgb(19, 19, 19);
			this.metroComboBox3.ForeColor = Color.BlueViolet;
			this.metroComboBox3.FormattingEnabled = true;
			this.metroComboBox3.IntegralHeight = false;
			this.metroComboBox3.ItemHeight = 23;
			this.metroComboBox3.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox3.Location = new Point(189, 484);
			this.metroComboBox3.Name = "metroComboBox3";
			this.metroComboBox3.PromptText = "Select";
			this.metroComboBox3.RightToLeft = RightToLeft.No;
			this.metroComboBox3.Size = new Size(96, 29);
			this.metroComboBox3.Style = 3;
			this.metroComboBox3.TabIndex = 41;
			this.metroComboBox3.Theme = 2;
			this.metroComboBox3.UseCustomBackColor = true;
			this.metroComboBox3.UseCustomForeColor = true;
			this.metroComboBox3.UseSelectable = true;
			this.metroComboBox3.UseStyleColors = true;
			this.metroComboBox3.Visible = false;
			this.metroComboBox3.SelectedIndexChanged += this.metroComboBox3_SelectedIndexChanged;
			this.pictureBoxODIN2.BackColor = Color.FromArgb(19, 19, 19);
			this.pictureBoxODIN2.Location = new Point(227, 318);
			this.pictureBoxODIN2.Name = "pictureBoxODIN2";
			this.pictureBoxODIN2.Size = new Size(100, 30);
			this.pictureBoxODIN2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN2.TabIndex = 46;
			this.pictureBoxODIN2.TabStop = false;
			this.pictureBoxODIN2.Visible = false;
			this.panel2.BackgroundImage = Resources.seeee;
			this.panel2.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel2.Location = new Point(249, 179);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(60, 27);
			this.panel2.TabIndex = 146;
			this.panel1.BackgroundImage = Resources.seeee;
			this.panel1.ForeColor = Color.FromArgb(19, 19, 19);
			this.panel1.Location = new Point(31, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(147, 27);
			this.panel1.TabIndex = 147;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			this.BackgroundImage = Resources.recoil_settings1;
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.pictureBoxODIN2);
			base.Controls.Add(this.metroComboBox3);
			base.Controls.Add(this.metroComboBox2);
			base.Controls.Add(this.metroCheckBox4);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.metroCheckBox7);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.pictureBoxVANDAL3);
			base.Controls.Add(this.pictureBoxODIN3);
			base.Controls.Add(this.pictureBoxARES3);
			base.Controls.Add(this.pictureBoxSPECTRE3);
			base.Controls.Add(this.pictureBoxPHANTOM3);
			base.Controls.Add(this.pictureBoxFRENZY3);
			base.Controls.Add(this.pictureBoxSTINGER3);
			base.Controls.Add(this.pictureBoxBULLDOG3);
			base.Controls.Add(this.pictureBoxFRENZY2);
			base.Controls.Add(this.pictureBoxSTINGER2);
			base.Controls.Add(this.pictureBoxSPECTRE2);
			base.Controls.Add(this.pictureBoxVANDAL2);
			base.Controls.Add(this.pictureBoxARES2);
			base.Controls.Add(this.pictureBoxPHANTOM2);
			base.Controls.Add(this.pictureBoxVANDAL1);
			base.Controls.Add(this.pictureBoxBULLDOG2);
			base.Controls.Add(this.pictureBoxSTINGER1);
			base.Controls.Add(this.pictureBoxSPECTRE1);
			base.Controls.Add(this.pictureBoxPHANTOM1);
			base.Controls.Add(this.pictureBoxODIN1);
			base.Controls.Add(this.metroCheckBox3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBoxFRENZY1);
			base.Controls.Add(this.pictureBoxBULLDOG1);
			base.Controls.Add(this.metroTrackBar2);
			base.Controls.Add(this.metroComboBox1);
			base.Controls.Add(this.metroCheckBox1);
			base.Controls.Add(this.metroCheckBox2);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.pictureBoxARES1);
			base.Name = "UserControl3";
			base.Size = new Size(370, 515);
			base.Load += this.UserControl3_Load;
			((ISupportInitialize)this.pictureBoxVANDAL1).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER1).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE1).EndInit();
			((ISupportInitialize)this.pictureBoxARES1).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG1).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY1).EndInit();
			((ISupportInitialize)this.pictureBoxODIN1).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM1).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG2).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM2).EndInit();
			((ISupportInitialize)this.pictureBoxARES2).EndInit();
			((ISupportInitialize)this.pictureBoxVANDAL2).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE2).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER2).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY2).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG3).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER3).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY3).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM3).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE3).EndInit();
			((ISupportInitialize)this.pictureBoxARES3).EndInit();
			((ISupportInitialize)this.pictureBoxODIN3).EndInit();
			((ISupportInitialize)this.pictureBoxVANDAL3).EndInit();
			((ISupportInitialize)this.pictureBoxODIN2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400044A RID: 1098
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

		// Token: 0x0400044B RID: 1099
		private IContainer components;

		// Token: 0x0400044C RID: 1100
		private MetroTrackBar metroTrackBar2;

		// Token: 0x0400044D RID: 1101
		private MetroCheckBox metroCheckBox3;

		// Token: 0x0400044E RID: 1102
		private PictureBox pictureBoxARES1;

		// Token: 0x0400044F RID: 1103
		private Label label10;

		// Token: 0x04000450 RID: 1104
		private MetroComboBox metroComboBox1;

		// Token: 0x04000451 RID: 1105
		private PictureBox pictureBoxBULLDOG1;

		// Token: 0x04000452 RID: 1106
		private PictureBox pictureBoxFRENZY1;

		// Token: 0x04000453 RID: 1107
		private PictureBox pictureBoxODIN1;

		// Token: 0x04000454 RID: 1108
		private PictureBox pictureBoxPHANTOM1;

		// Token: 0x04000455 RID: 1109
		private PictureBox pictureBoxSPECTRE1;

		// Token: 0x04000456 RID: 1110
		private PictureBox pictureBoxSTINGER1;

		// Token: 0x04000457 RID: 1111
		private PictureBox pictureBoxVANDAL1;

		// Token: 0x04000458 RID: 1112
		private System.Windows.Forms.Timer timer1;

		// Token: 0x04000459 RID: 1113
		private MetroCheckBox metroCheckBox1;

		// Token: 0x0400045A RID: 1114
		private MetroCheckBox metroCheckBox2;

		// Token: 0x0400045B RID: 1115
		private Label label3;

		// Token: 0x0400045C RID: 1116
		private PictureBox pictureBoxBULLDOG2;

		// Token: 0x0400045D RID: 1117
		private PictureBox pictureBoxPHANTOM2;

		// Token: 0x0400045E RID: 1118
		private PictureBox pictureBoxARES2;

		// Token: 0x0400045F RID: 1119
		private PictureBox pictureBoxVANDAL2;

		// Token: 0x04000460 RID: 1120
		private PictureBox pictureBoxSPECTRE2;

		// Token: 0x04000461 RID: 1121
		private PictureBox pictureBoxSTINGER2;

		// Token: 0x04000462 RID: 1122
		private PictureBox pictureBoxFRENZY2;

		// Token: 0x04000463 RID: 1123
		private PictureBox pictureBoxBULLDOG3;

		// Token: 0x04000464 RID: 1124
		private PictureBox pictureBoxSTINGER3;

		// Token: 0x04000465 RID: 1125
		private PictureBox pictureBoxFRENZY3;

		// Token: 0x04000466 RID: 1126
		private PictureBox pictureBoxPHANTOM3;

		// Token: 0x04000467 RID: 1127
		private PictureBox pictureBoxSPECTRE3;

		// Token: 0x04000468 RID: 1128
		private PictureBox pictureBoxARES3;

		// Token: 0x04000469 RID: 1129
		private PictureBox pictureBoxODIN3;

		// Token: 0x0400046A RID: 1130
		private PictureBox pictureBoxVANDAL3;

		// Token: 0x0400046B RID: 1131
		private Label label9;

		// Token: 0x0400046C RID: 1132
		private Label label12;

		// Token: 0x0400046D RID: 1133
		private MetroCheckBox metroCheckBox7;

		// Token: 0x0400046E RID: 1134
		private Label label7;

		// Token: 0x0400046F RID: 1135
		private Label label11;

		// Token: 0x04000470 RID: 1136
		private MetroCheckBox metroCheckBox4;

		// Token: 0x04000471 RID: 1137
		private MetroComboBox metroComboBox2;

		// Token: 0x04000472 RID: 1138
		private MetroComboBox metroComboBox3;

		// Token: 0x04000473 RID: 1139
		private PictureBox pictureBoxODIN2;

		// Token: 0x04000474 RID: 1140
		private Panel panel2;

		// Token: 0x04000475 RID: 1141
		private Panel panel1;
	}
}
