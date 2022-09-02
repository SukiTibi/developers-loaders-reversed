using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using RenameMe.Properties;

namespace RenameMe
{
	// Token: 0x02000041 RID: 65
	public partial class TheBest : Form
	{
		// Token: 0x0600012C RID: 300
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x0600012D RID: 301
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600012E RID: 302
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600012F RID: 303
		[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
		private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

		// Token: 0x06000130 RID: 304
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000131 RID: 305
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000132 RID: 306
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000133 RID: 307
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x06000134 RID: 308
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000135 RID: 309 RVA: 0x00002800 File Offset: 0x00000A00
		public TheBest()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000734C File Offset: 0x0000554C
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

		// Token: 0x06000137 RID: 311 RVA: 0x00002823 File Offset: 0x00000A23
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[TheBest.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000073C8 File Offset: 0x000055C8
		private void HWIDCheck_Load(object sender, EventArgs e)
		{
			TheBest.KeyAuthApp.init();
			if (TheBest.KeyAuthApp.checkblack())
			{
				MemoryImporter.FindPattern();
				MemoryImporter.HexValueCalculator();
				MemoryImporter.BinaryConstPagePool();
				Environment.Exit(0);
			}
			this.Text = TheBest.RandomString(10);
			if (Settings.Default.Username != string.Empty)
			{
				this.login.Text = Settings.Default.Username;
				this.senha.Text = Settings.Default.Password;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000248E File Offset: 0x0000068E
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000287D File Offset: 0x00000A7D
		private void label3_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000248E File Offset: 0x0000068E
		private void HWIDCheck_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002885 File Offset: 0x00000A85
		private void HWIDCheck_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				TheBest.ReleaseCapture();
				TheBest.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000248E File Offset: 0x0000068E
		private void senha_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000248E File Offset: 0x0000068E
		private void Galaxy_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000248E File Offset: 0x0000068E
		private void lembrar_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000248E File Offset: 0x0000068E
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002885 File Offset: 0x00000A85
		private void Name_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				TheBest.ReleaseCapture();
				TheBest.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000248E File Offset: 0x0000068E
		private void button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000028AD File Offset: 0x00000AAD
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/GALAXYSTOREVALO");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000028BA File Offset: 0x00000ABA
		private void label5_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/galaxystorebr");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000248E File Offset: 0x0000068E
		private void login_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00007D5C File Offset: 0x00005F5C
		private void button1_Click_2(object sender, EventArgs e)
		{
			Settings.Default.Usernamedbg = this.login.Text;
			if (this.lembrar.Checked)
			{
				IniFile iniFile = new IniFile("Config.ini");
				iniFile.Write("User", this.login.Text, "LOADER");
				iniFile.Write("Pass", this.senha.Text, "LOADER");
			}
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
			string text = this.login.Text;
			string text2 = this.senha.Text;
			if (User.API.Login(text, text2))
			{
				base.Hide();
				GalaStore galaStore = new GalaStore();
				GalaStore.userloginn = text;
				galaStore.Enabled = true;
				galaStore.ShowDialog();
				base.Close();
				base.Dispose();
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000028C7 File Offset: 0x00000AC7
		private void label20_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000287D File Offset: 0x00000A7D
		private void label19_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000028D0 File Offset: 0x00000AD0
		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			this.senha.UseSystemPasswordChar = !this.senha.UseSystemPasswordChar;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000248E File Offset: 0x0000068E
		private void senha_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0400036C RID: 876
		public static api KeyAuthApp = new api("GalaxyAim", "2UAmqboOzm", "d061c4e0e20f6a497f9879462877cb83bb03558b533081dad91ecb7a2b907bf4", "1.0");

		// Token: 0x0400036D RID: 877
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400036E RID: 878
		public const int HT_CAPTION = 2;

		// Token: 0x04000379 RID: 889
		public static string name = Environment.UserName;

		// Token: 0x0400037A RID: 890
		private string HWID = WindowsIdentity.GetCurrent().User.Value;

		// Token: 0x0400037C RID: 892
		private static Random random = new Random();
	}
}
