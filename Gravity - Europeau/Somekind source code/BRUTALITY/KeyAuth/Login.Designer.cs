namespace KeyAuth
{
	// Token: 0x02000010 RID: 16
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002522 File Offset: 0x00000722
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004620 File Offset: 0x00002820
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lembrar = new global::System.Windows.Forms.CheckBox();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneButton();
			this.u = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.password = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.key = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.RgstrBtn = new global::Siticone.UI.WinForms.SiticoneButton();
			new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f);
			this.label9.ForeColor = global::System.Drawing.Color.Black;
			this.label9.Location = new global::System.Drawing.Point(249, 9);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(16, 22);
			this.label9.TabIndex = 8;
			this.label9.Text = "-";
			this.label9.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.Black;
			this.label8.Location = new global::System.Drawing.Point(271, 12);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(15, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "X";
			this.label8.Click += new global::System.EventHandler(this.label3_Click);
			this.lembrar.AutoSize = true;
			this.lembrar.BackColor = global::System.Drawing.Color.Transparent;
			this.lembrar.Checked = true;
			this.lembrar.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.lembrar.ForeColor = global::System.Drawing.Color.Lavender;
			this.lembrar.Location = new global::System.Drawing.Point(48, 329);
			this.lembrar.Name = "lembrar";
			this.lembrar.Size = new global::System.Drawing.Size(77, 17);
			this.lembrar.TabIndex = 60;
			this.lembrar.Text = "Remember";
			this.lembrar.UseVisualStyleBackColor = false;
			this.LoginBtn.Animated = false;
			this.LoginBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderRadius = 30;
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.LoginBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(48, 366);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.PressedColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.ShadowDecoration.BorderRadius = 0;
			this.LoginBtn.ShadowDecoration.Color = global::System.Drawing.Color.Transparent;
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(91, 46);
			this.LoginBtn.TabIndex = 64;
			this.LoginBtn.Text = "siticoneButton1";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click);
			this.u.BackColor = global::System.Drawing.Color.Transparent;
			this.u.BorderColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.u.BorderRadius = 15;
			this.u.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.u.DefaultText = "";
			this.u.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.u.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.u.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.u.DisabledState.Parent = this.u;
			this.u.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.u.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.u.FocusedState.Parent = this.u;
			this.u.ForeColor = global::System.Drawing.Color.Black;
			this.u.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.u.HoveredState.Parent = this.u;
			this.u.Location = new global::System.Drawing.Point(48, 183);
			this.u.Name = "u";
			this.u.PasswordChar = '\0';
			this.u.PlaceholderForeColor = global::System.Drawing.Color.Empty;
			this.u.PlaceholderText = "";
			this.u.SelectedText = "";
			this.u.ShadowDecoration.Parent = this.u;
			this.u.Size = new global::System.Drawing.Size(196, 33);
			this.u.TabIndex = 65;
			this.u.TextChanged += new global::System.EventHandler(this.u_TextChanged);
			this.password.BackColor = global::System.Drawing.Color.Transparent;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.password.BorderRadius = 15;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.FocusedState.Parent = this.password;
			this.password.ForeColor = global::System.Drawing.Color.Black;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(48, 232);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.PlaceholderForeColor = global::System.Drawing.Color.Empty;
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(196, 37);
			this.password.TabIndex = 66;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.key.BorderRadius = 15;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.FocusedState.Parent = this.key;
			this.key.ForeColor = global::System.Drawing.Color.Transparent;
			this.key.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.HoveredState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(48, 286);
			this.key.Name = "key";
			this.key.PasswordChar = '*';
			this.key.PlaceholderForeColor = global::System.Drawing.Color.Empty;
			this.key.PlaceholderText = "";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(196, 37);
			this.key.TabIndex = 67;
			this.RgstrBtn.Animated = false;
			this.RgstrBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.BorderRadius = 30;
			this.RgstrBtn.BorderThickness = 1;
			this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
			this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
			this.RgstrBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
			this.RgstrBtn.Location = new global::System.Drawing.Point(150, 366);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.PressedColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.ShadowDecoration.BorderRadius = 0;
			this.RgstrBtn.ShadowDecoration.Color = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
			this.RgstrBtn.Size = new global::System.Drawing.Size(94, 49);
			this.RgstrBtn.TabIndex = 68;
			this.RgstrBtn.Text = "siticoneButton1";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.BackgroundImage = global::herhe.Properties.Resources.mais1;
			base.ClientSize = new global::System.Drawing.Size(298, 433);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.key);
			base.Controls.Add(this.password);
			base.Controls.Add(this.u);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.lembrar);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003B RID: 59
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.CheckBox lembrar;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneButton LoginBtn;

		// Token: 0x04000041 RID: 65
		private global::Siticone.UI.WinForms.SiticoneTextBox u;

		// Token: 0x04000042 RID: 66
		private global::Siticone.UI.WinForms.SiticoneButton RgstrBtn;

		// Token: 0x04000043 RID: 67
		private global::Siticone.UI.WinForms.SiticoneTextBox key;

		// Token: 0x04000044 RID: 68
		private global::Siticone.UI.WinForms.SiticoneTextBox password;
	}
}
