using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using herhe.Properties;
using Siticone.UI.WinForms;
using unknown;
using WindowsFormsApp1.Properties;

namespace KeyAuth
{
	// Token: 0x02000010 RID: 16
	public partial class Login : Form
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000024A7 File Offset: 0x000006A7
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000024B5 File Offset: 0x000006B5
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000042A4 File Offset: 0x000024A4
		private void Login_Load(object sender, EventArgs e)
		{
			if (WindowsFormsApp1.Properties.Settings.Default.Username != string.Empty)
			{
				this.u.Text = WindowsFormsApp1.Properties.Settings.Default.Username;
				this.password.Text = WindowsFormsApp1.Properties.Settings.Default.Password;
			}
			Login.KeyAuthApp.init();
			if (!Login.KeyAuthApp.response.success)
			{
				MessageBox.Show(Login.KeyAuthApp.response.message);
				Environment.Exit(0);
			}
			if (Login.KeyAuthApp.response.message == "invalidver")
			{
				if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					if (dialogResult != DialogResult.Yes)
					{
						if (dialogResult != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string text = Application.ExecutablePath;
							string str = Login.random_string();
							text = text.Replace(".exe", "-" + str + ".exe");
							webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, text);
							Process.Start(text);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
				Thread.Sleep(2500);
				Environment.Exit(0);
			}
			Thread.Sleep(1500);
			Login.KeyAuthApp.check();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000446C File Offset: 0x0000266C
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024BE File Offset: 0x000006BE
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.u.Text, this.key.Text);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000044C8 File Offset: 0x000026C8
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			WindowsFormsApp1.Properties.Settings.Default.Usernamedbg = this.u.Text;
			if (this.lembrar.Checked && this.lembrar.Checked)
			{
				WindowsFormsApp1.Properties.Settings.Default.Username = this.u.Text;
				WindowsFormsApp1.Properties.Settings.Default.Password = this.password.Text;
				WindowsFormsApp1.Properties.Settings.Default.Save();
			}
			if (!this.lembrar.Checked)
			{
				WindowsFormsApp1.Properties.Settings.Default.Username = this.u.Text;
				WindowsFormsApp1.Properties.Settings.Default.Password = this.password.Text;
				WindowsFormsApp1.Properties.Settings.Default.Save();
			}
			Login.KeyAuthApp.init();
			Login.KeyAuthApp.login(this.u.Text, this.password.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new bagulhotensodaquebradaloko264812().Show();
				base.Hide();
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000045C4 File Offset: 0x000027C4
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.u.Text, this.password.Text, this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new bagulhotensodaquebradaloko264812().Show();
				base.Hide();
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000024E0 File Offset: 0x000006E0
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new bagulhotensodaquebradaloko264812().Show();
				base.Hide();
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002518 File Offset: 0x00000718
		private void label3_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002518 File Offset: 0x00000718
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002520 File Offset: 0x00000720
		private void lembrar_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002520 File Offset: 0x00000720
		private void lembrar_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002520 File Offset: 0x00000720
		private void u_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400003A RID: 58
		public static api KeyAuthApp = new api("Gravity", "L5tb1c1Hz3", "883c77aef36d85e37ffc58753c4a786e69fad5509a970735a288ce9664c55f92", "1.0");
	}
}
