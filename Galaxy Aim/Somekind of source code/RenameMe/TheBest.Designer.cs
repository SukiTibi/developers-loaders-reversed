namespace RenameMe
{
	// Token: 0x02000041 RID: 65
	public partial class TheBest : global::System.Windows.Forms.Form
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0000285E File Offset: 0x00000A5E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00007450 File Offset: 0x00005650
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RenameMe.TheBest));
			this.button1 = new global::System.Windows.Forms.Button();
			this.lembrar = new global::System.Windows.Forms.CheckBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.login = new global::System.Windows.Forms.TextBox();
			this.senha = new global::System.Windows.Forms.TextBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(76, 2, 132);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.Color.Silver;
			this.button1.Location = new global::System.Drawing.Point(92, 349);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(191, 35);
			this.button1.TabIndex = 81;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_2);
			this.lembrar.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.lembrar.AutoSize = true;
			this.lembrar.BackColor = global::System.Drawing.Color.Transparent;
			this.lembrar.Checked = true;
			this.lembrar.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.lembrar.ForeColor = global::System.Drawing.Color.Silver;
			this.lembrar.Location = new global::System.Drawing.Point(91, 316);
			this.lembrar.Name = "lembrar";
			this.lembrar.Size = new global::System.Drawing.Size(77, 17);
			this.lembrar.TabIndex = 82;
			this.lembrar.Text = "Remember";
			this.lembrar.UseVisualStyleBackColor = false;
			this.lembrar.Visible = false;
			this.label20.AutoSize = true;
			this.label20.BackColor = global::System.Drawing.Color.Transparent;
			this.label20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.ForeColor = global::System.Drawing.Color.DarkSlateBlue;
			this.label20.Location = new global::System.Drawing.Point(304, 4);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(29, 29);
			this.label20.TabIndex = 89;
			this.label20.Text = "--";
			this.label20.Click += new global::System.EventHandler(this.label20_Click);
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f);
			this.label19.ForeColor = global::System.Drawing.Color.DarkSlateBlue;
			this.label19.Location = new global::System.Drawing.Point(336, 5);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(30, 29);
			this.label19.TabIndex = 88;
			this.label19.Text = "X";
			this.label19.Click += new global::System.EventHandler(this.label19_Click);
			this.login.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.login.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.login.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.login.ForeColor = global::System.Drawing.Color.Silver;
			this.login.Location = new global::System.Drawing.Point(90, 201);
			this.login.Name = "login";
			this.login.Size = new global::System.Drawing.Size(192, 29);
			this.login.TabIndex = 90;
			this.login.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.senha.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.senha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.senha.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.senha.ForeColor = global::System.Drawing.Color.Silver;
			this.senha.Location = new global::System.Drawing.Point(90, 268);
			this.senha.Name = "senha";
			this.senha.PasswordChar = '*';
			this.senha.Size = new global::System.Drawing.Size(192, 29);
			this.senha.TabIndex = 91;
			this.senha.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.senha.UseSystemPasswordChar = true;
			this.senha.TextChanged += new global::System.EventHandler(this.senha_TextChanged_1);
			this.pictureBox4.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.pictureBox4.Image = global::RenameMe.Properties.Resources.eye_2_64;
			this.pictureBox4.Location = new global::System.Drawing.Point(244, 268);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(37, 28);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 87;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click_1);
			this.pictureBox3.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.pictureBox3.Image = global::RenameMe.Properties.Resources.lock_32;
			this.pictureBox3.Location = new global::System.Drawing.Point(89, 269);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(41, 28);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 86;
			this.pictureBox3.TabStop = false;
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.pictureBox2.Image = global::RenameMe.Properties.Resources.user_64;
			this.pictureBox2.Location = new global::System.Drawing.Point(90, 202);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(41, 28);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 85;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::RenameMe.Properties.Resources.DiscordServer;
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(364, 477);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 80;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(375, 526);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.senha);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.login);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.lembrar);
			base.Controls.Add(this.pictureBox1);
			this.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TheBest";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.HWIDCheck_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.HWIDCheck_KeyDown);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.HWIDCheck_MouseDown);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.CheckBox lembrar;

		// Token: 0x04000373 RID: 883
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.TextBox login;

		// Token: 0x04000377 RID: 887
		private global::System.Windows.Forms.TextBox senha;

		// Token: 0x04000378 RID: 888
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400037B RID: 891
		private global::System.ComponentModel.IContainer components;
	}
}
