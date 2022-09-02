using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using WindowsFormsApp1.Properties;

namespace unknown
{
	// Token: 0x0200001B RID: 27
	public partial class eocrimeoucremesenaodevesnaoteme : Form
	{
		// Token: 0x06000103 RID: 259
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000104 RID: 260
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000105 RID: 261
		[DllImport("User32.Dll")]
		private static extern bool PostMessageA(IntPtr hWnd, uint msg, int wParam, int lParam);

		// Token: 0x06000106 RID: 262
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000107 RID: 263
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000108 RID: 264
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000109 RID: 265
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x0600010A RID: 266
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x0600010B RID: 267 RVA: 0x00002751 File Offset: 0x00000951
		public eocrimeoucremesenaodevesnaoteme()
		{
			new WebClient();
			this.InitializeComponent();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000B364 File Offset: 0x00009564
		private void checkonline()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("https://google.com/"))
					{
					}
				}
			}
			catch
			{
				MessageBox.Show("Conecte a uma rede antes de continuar", "Galaxy");
				Application.Exit();
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000B3E0 File Offset: 0x000095E0
		private void HWIDCheck_Load(object sender, EventArgs e)
		{
			if (Settings.Default.Username != string.Empty)
			{
				this.login.Text = Settings.Default.Username;
				this.senha.Text = Settings.Default.Password;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000C19C File Offset: 0x0000A39C
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.Usernamedbg = this.login.Text;
			if (this.lembrar.Checked && this.lembrar.Checked)
			{
				Settings.Default.Username = this.login.Text;
				Settings.Default.Password = this.senha.Text;
				Settings.Default.Save();
			}
			if (!this.lembrar.Checked)
			{
				Settings.Default.Username = this.login.Text;
				Settings.Default.Password = this.senha.Text;
				Settings.Default.Save();
			}
			string b = "1";
			string b2 = "1";
			if (this.login.Text == b && this.senha.Text == b2)
			{
				base.Hide();
				new bagulhotensodaquebradaloko264812
				{
					Enabled = true
				}.ShowDialog();
				base.Close();
				base.Dispose();
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002518 File Offset: 0x00000718
		private void label3_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000024B5 File Offset: 0x000006B5
		private void label4_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002520 File Offset: 0x00000720
		private void HWIDCheck_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002784 File Offset: 0x00000984
		private void HWIDCheck_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				eocrimeoucremesenaodevesnaoteme.ReleaseCapture();
				eocrimeoucremesenaodevesnaoteme.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002520 File Offset: 0x00000720
		private void senha_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002520 File Offset: 0x00000720
		private void Galaxy_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002520 File Offset: 0x00000720
		private void lembrar_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002520 File Offset: 0x00000720
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002520 File Offset: 0x00000720
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040000DD RID: 221
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040000DE RID: 222
		public const int HT_CAPTION = 2;
	}
}
