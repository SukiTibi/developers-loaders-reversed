using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace unknown
{
	// Token: 0x0200001A RID: 26
	public class DebugWindow : MetroSetForm
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00002712 File Offset: 0x00000912
		public DebugWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002520 File Offset: 0x00000720
		private void DebugWindow_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002520 File Offset: 0x00000720
		public void AddDebugLine(string line)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002720 File Offset: 0x00000920
		public void ClearDebugConsole()
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002732 File Offset: 0x00000932
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000B1AC File Offset: 0x000093AC
		private void InitializeComponent()
		{
			this.listBox1 = new ListBox();
			base.SuspendLayout();
			this.listBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = SystemColors.ScrollBar;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new Point(5, 65);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(305, 320);
			this.listBox1.TabIndex = 1;
			base.AutoScaleMode = AutoScaleMode.None;
			base.BackgroundColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(315, 409);
			base.ControlBox = false;
			base.Controls.Add(this.listBox1);
			base.Enabled = false;
			this.MaximumSize = new Size(315, 409);
			this.MinimumSize = new Size(315, 409);
			base.Name = "DebugWindow";
			base.Padding = new Padding(2, 70, 2, 2);
			base.ShowHeader = true;
			base.ShowInTaskbar = false;
			base.ShowLeftRect = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.Manual;
			base.Style = 1;
			this.Text = "DEBUG";
			base.TextColor = Color.White;
			base.ThemeName = "MetroDark";
			base.TopMost = true;
			base.UseSlideAnimation = true;
			base.Load += this.DebugWindow_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x040000DB RID: 219
		private IContainer components;

		// Token: 0x040000DC RID: 220
		private ListBox listBox1;
	}
}
