namespace RenameMe
{
	// Token: 0x02000043 RID: 67
	public partial class GalaStore : global::System.Windows.Forms.Form
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00002C06 File Offset: 0x00000E06
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009210 File Offset: 0x00007410
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RenameMe.GalaStore));
			this.Button_Top_Panel = new global::System.Windows.Forms.Button();
			this.Button2_Top_Panel = new global::System.Windows.Forms.Button();
			this.Top_Panel = new global::System.Windows.Forms.Panel();
			this.Picture_Top_Panel = new global::System.Windows.Forms.PictureBox();
			this.usuario = new global::System.Windows.Forms.Label();
			this.Button_Panel = new global::System.Windows.Forms.Panel();
			this.metroToggle1 = new global::MetroFramework.Controls.MetroToggle();
			this.label3 = new global::System.Windows.Forms.Label();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tempo = new global::System.Windows.Forms.Label();
			this.Button3_Button_Panel = new global::System.Windows.Forms.Button();
			this.Button2_Button_Panel = new global::System.Windows.Forms.Button();
			this.Button_Button_Panel = new global::System.Windows.Forms.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.userControl11 = new global::RenameMe.UserControl1();
			this.userControl31 = new global::RenameMe.UserControls.UserControl3();
			this.userControl21 = new global::RenameMe.UserControls.UserControl2();
			this.metroLabel1 = new global::MetroFramework.Controls.MetroLabel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.Top_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Top_Panel).BeginInit();
			this.Button_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.Button_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button_Top_Panel.FlatAppearance.BorderSize = 0;
			this.Button_Top_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button_Top_Panel.Location = new global::System.Drawing.Point(345, 0);
			this.Button_Top_Panel.Name = "Button_Top_Panel";
			this.Button_Top_Panel.Size = new global::System.Drawing.Size(25, 26);
			this.Button_Top_Panel.TabIndex = 2;
			this.Button_Top_Panel.Text = "X";
			this.Button_Top_Panel.UseVisualStyleBackColor = true;
			this.Button_Top_Panel.Click += new global::System.EventHandler(this.Button_Top_Panel_Click);
			this.Button2_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button2_Top_Panel.FlatAppearance.BorderSize = 0;
			this.Button2_Top_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button2_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button2_Top_Panel.Location = new global::System.Drawing.Point(320, 0);
			this.Button2_Top_Panel.Name = "Button2_Top_Panel";
			this.Button2_Top_Panel.Size = new global::System.Drawing.Size(25, 26);
			this.Button2_Top_Panel.TabIndex = 3;
			this.Button2_Top_Panel.Text = "_";
			this.Button2_Top_Panel.UseVisualStyleBackColor = true;
			this.Button2_Top_Panel.Click += new global::System.EventHandler(this.Button2_Top_Panel_Click);
			this.Top_Panel.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.Top_Panel.Controls.Add(this.Picture_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button2_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button_Top_Panel);
			this.Top_Panel.Controls.Add(this.usuario);
			this.Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Top_Panel.Location = new global::System.Drawing.Point(186, 0);
			this.Top_Panel.Name = "Top_Panel";
			this.Top_Panel.Size = new global::System.Drawing.Size(370, 26);
			this.Top_Panel.TabIndex = 1;
			this.Top_Panel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Top_Panel_Paint);
			this.Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Picture_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Picture_Top_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.Picture_Top_Panel.Name = "Picture_Top_Panel";
			this.Picture_Top_Panel.Size = new global::System.Drawing.Size(5, 26);
			this.Picture_Top_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture_Top_Panel.TabIndex = 2;
			this.Picture_Top_Panel.TabStop = false;
			this.Picture_Top_Panel.Click += new global::System.EventHandler(this.Picture_Top_Panel_Click);
			this.usuario.AutoSize = true;
			this.usuario.BackColor = global::System.Drawing.Color.Transparent;
			this.usuario.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.usuario.ForeColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.usuario.Location = new global::System.Drawing.Point(33, 6);
			this.usuario.Name = "usuario";
			this.usuario.Size = new global::System.Drawing.Size(63, 14);
			this.usuario.TabIndex = 59;
			this.usuario.Text = "Userlogin";
			this.usuario.Visible = false;
			this.Button_Panel.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.Button_Panel.BackgroundImage = global::RenameMe.Properties.Resources.lateral1;
			this.Button_Panel.Controls.Add(this.metroToggle1);
			this.Button_Panel.Controls.Add(this.label3);
			this.Button_Panel.Controls.Add(this.pictureBox5);
			this.Button_Panel.Controls.Add(this.label1);
			this.Button_Panel.Controls.Add(this.tempo);
			this.Button_Panel.Controls.Add(this.Button3_Button_Panel);
			this.Button_Panel.Controls.Add(this.Button2_Button_Panel);
			this.Button_Panel.Controls.Add(this.Button_Button_Panel);
			this.Button_Panel.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Button_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.Button_Panel.Name = "Button_Panel";
			this.Button_Panel.Size = new global::System.Drawing.Size(186, 540);
			this.Button_Panel.TabIndex = 0;
			this.Button_Panel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Button_Panel_Paint);
			this.metroToggle1.AutoSize = true;
			this.metroToggle1.Location = new global::System.Drawing.Point(46, 489);
			this.metroToggle1.Name = "metroToggle1";
			this.metroToggle1.Size = new global::System.Drawing.Size(80, 17);
			this.metroToggle1.Style = 12;
			this.metroToggle1.TabIndex = 6;
			this.metroToggle1.Text = "Off";
			this.metroToggle1.Theme = 2;
			this.metroToggle1.UseCustomBackColor = true;
			this.metroToggle1.UseCustomForeColor = true;
			this.metroToggle1.UseSelectable = true;
			this.metroToggle1.UseStyleColors = true;
			this.metroToggle1.CheckedChanged += new global::System.EventHandler(this.metroToggle1_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(43, 519);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(85, 14);
			this.label3.TabIndex = 57;
			this.label3.Text = "StreamMode";
			this.pictureBox5.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox5.Location = new global::System.Drawing.Point(66, 163);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(48, 34);
			this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 58;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new global::System.EventHandler(this.pictureBox5_Click);
			this.pictureBox5.MouseEnter += new global::System.EventHandler(this.pictureBox5_MouseEnter);
			this.pictureBox5.MouseLeave += new global::System.EventHandler(this.pictureBox5_MouseLeave);
			this.pictureBox5.MouseHover += new global::System.EventHandler(this.pictureBox5_MouseHover);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(14, 217);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(108, 14);
			this.label1.TabIndex = 53;
			this.label1.Text = "Days Remaining:";
			this.label1.Visible = false;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.tempo.AutoSize = true;
			this.tempo.BackColor = global::System.Drawing.Color.Transparent;
			this.tempo.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tempo.ForeColor = global::System.Drawing.Color.White;
			this.tempo.Location = new global::System.Drawing.Point(121, 217);
			this.tempo.Name = "tempo";
			this.tempo.Size = new global::System.Drawing.Size(36, 14);
			this.tempo.TabIndex = 52;
			this.tempo.Text = "Days";
			this.tempo.Visible = false;
			this.tempo.Click += new global::System.EventHandler(this.tempo_Click);
			this.Button3_Button_Panel.BackColor = global::System.Drawing.Color.Transparent;
			this.Button3_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button3_Button_Panel.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.Button3_Button_Panel.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.Button3_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button3_Button_Panel.Font = new global::System.Drawing.Font("Segoe Print", 14.25f, global::System.Drawing.FontStyle.Bold);
			this.Button3_Button_Panel.ForeColor = global::System.Drawing.Color.Transparent;
			this.Button3_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button3_Button_Panel.Location = new global::System.Drawing.Point(-1, 320);
			this.Button3_Button_Panel.Name = "Button3_Button_Panel";
			this.Button3_Button_Panel.Size = new global::System.Drawing.Size(186, 52);
			this.Button3_Button_Panel.TabIndex = 4;
			this.Button3_Button_Panel.UseVisualStyleBackColor = false;
			this.Button3_Button_Panel.Click += new global::System.EventHandler(this.Button3_Button_Panel_Click);
			this.Button2_Button_Panel.BackColor = global::System.Drawing.Color.Transparent;
			this.Button2_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button2_Button_Panel.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.Button2_Button_Panel.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.Button2_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2_Button_Panel.Font = new global::System.Drawing.Font("Segoe Print", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2_Button_Panel.ForeColor = global::System.Drawing.Color.Transparent;
			this.Button2_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button2_Button_Panel.Location = new global::System.Drawing.Point(0, 246);
			this.Button2_Button_Panel.Name = "Button2_Button_Panel";
			this.Button2_Button_Panel.Size = new global::System.Drawing.Size(186, 37);
			this.Button2_Button_Panel.TabIndex = 3;
			this.Button2_Button_Panel.UseVisualStyleBackColor = false;
			this.Button2_Button_Panel.Click += new global::System.EventHandler(this.Button2_Button_Panel_Click);
			this.Button_Button_Panel.BackColor = global::System.Drawing.Color.Transparent;
			this.Button_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button_Button_Panel.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.Button_Button_Panel.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.Button_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button_Button_Panel.Font = new global::System.Drawing.Font("Segoe Print", 14.25f, global::System.Drawing.FontStyle.Bold);
			this.Button_Button_Panel.ForeColor = global::System.Drawing.Color.Transparent;
			this.Button_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button_Button_Panel.Location = new global::System.Drawing.Point(3, 401);
			this.Button_Button_Panel.Name = "Button_Button_Panel";
			this.Button_Button_Panel.Size = new global::System.Drawing.Size(186, 52);
			this.Button_Button_Panel.TabIndex = 2;
			this.Button_Button_Panel.UseVisualStyleBackColor = false;
			this.Button_Button_Panel.Click += new global::System.EventHandler(this.Button_Button_Panel_Click);
			this.pictureBox2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(5, 25);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.userControl11.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.userControl11.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("userControl11.BackgroundImage");
			this.userControl11.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.userControl11.Location = new global::System.Drawing.Point(186, 26);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new global::System.Drawing.Size(370, 514);
			this.userControl11.TabIndex = 2;
			this.userControl11.Load += new global::System.EventHandler(this.userControl11_Load);
			this.userControl31.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			this.userControl31.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("userControl31.BackgroundImage");
			this.userControl31.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.userControl31.Location = new global::System.Drawing.Point(0, 0);
			this.userControl31.Name = "userControl31";
			this.userControl31.Size = new global::System.Drawing.Size(556, 540);
			this.userControl31.TabIndex = 4;
			this.userControl31.Load += new global::System.EventHandler(this.userControl31_Load);
			this.userControl21.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			this.userControl21.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("userControl21.BackgroundImage");
			this.userControl21.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.userControl21.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.49f);
			this.userControl21.Location = new global::System.Drawing.Point(0, 0);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new global::System.Drawing.Size(556, 540);
			this.userControl21.TabIndex = 3;
			this.userControl21.Load += new global::System.EventHandler(this.userControl21_Load);
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new global::System.Drawing.Point(30, 18);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new global::System.Drawing.Size(265, 19);
			this.metroLabel1.Style = 1;
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "FLICK AND SILENT TEMPORARY REMOVED";
			this.metroLabel1.Theme = 2;
			this.panel5.BackgroundImage = global::RenameMe.Properties.Resources.seeee;
			this.panel5.Controls.Add(this.metroLabel1);
			this.panel5.ForeColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.panel5.Location = new global::System.Drawing.Point(213, 91);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(331, 56);
			this.panel5.TabIndex = 171;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			base.ClientSize = new global::System.Drawing.Size(556, 540);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.userControl11);
			base.Controls.Add(this.Top_Panel);
			base.Controls.Add(this.Button_Panel);
			base.Controls.Add(this.userControl31);
			base.Controls.Add(this.userControl21);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "GalaStore";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GALAXY";
			base.Load += new global::System.EventHandler(this.Main_Form_Load);
			this.Top_Panel.ResumeLayout(false);
			this.Top_Panel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Top_Panel).EndInit();
			this.Button_Panel.ResumeLayout(false);
			this.Button_Panel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040003AE RID: 942
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003AF RID: 943
		private global::RenameMe.UserControls.UserControl3 userControl31;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.Button Button_Button_Panel;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.Panel Button_Panel;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.Button Button3_Button_Panel;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.Button Button2_Button_Panel;

		// Token: 0x040003B4 RID: 948
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040003B5 RID: 949
		private global::RenameMe.UserControls.UserControl2 userControl21;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.Label tempo;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Forms.Button Button_Top_Panel;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.Button Button2_Top_Panel;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Forms.PictureBox Picture_Top_Panel;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.Panel Top_Panel;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003BE RID: 958
		private global::RenameMe.UserControl1 userControl11;

		// Token: 0x040003BF RID: 959
		private global::MetroFramework.Controls.MetroToggle metroToggle1;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.Label usuario;

		// Token: 0x040003C1 RID: 961
		private global::MetroFramework.Controls.MetroLabel metroLabel1;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Forms.Panel panel5;
	}
}
