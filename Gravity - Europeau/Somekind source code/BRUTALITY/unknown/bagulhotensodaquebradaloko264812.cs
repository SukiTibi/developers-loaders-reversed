using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using herhe.Properties;
using KeyAuth;
using MetroSet_UI.Components;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using Microsoft.CSharp.RuntimeBinder;

namespace unknown
{
	// Token: 0x02000011 RID: 17
	public class bagulhotensodaquebradaloko264812 : MetroSetForm
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00002561 File Offset: 0x00000761
		public bagulhotensodaquebradaloko264812()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002520 File Offset: 0x00000720
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005374 File Offset: 0x00003574
		private void InitializeComponent()
		{
			this.components = new Container();
			this.styleManager1 = new StyleManager();
			this.updateButton = new MetroSetButton();
			this.metroSetComboBox2 = new MetroSetComboBox();
			this.flicktext = new Label();
			this.metroSetSwitch6 = new MetroSetSwitch();
			this.triglabel = new Label();
			this.metroSetComboBox1 = new MetroSetComboBox();
			this.AppleSwitch = new MetroSetSwitch();
			this.label32 = new Label();
			this.BlueBerrySwitch = new MetroSetSwitch();
			this.label30 = new Label();
			this.metroSetSwitch3 = new MetroSetSwitch();
			this.AimOff = new Label();
			this.metroSetSwitch2 = new MetroSetSwitch();
			this.AimbotKeyCombo = new MetroSetComboBox();
			this.label34 = new Label();
			this.metroSetSwitch1 = new MetroSetSwitch();
			this.leonardoPorts = new MetroSetComboBox();
			this.label19 = new Label();
			this.label20 = new Label();
			this.currentModeCombo = new MetroSetComboBox();
			this.notifyIcon1 = new NotifyIcon(this.components);
			this.metroSetButton1 = new MetroSetButton();
			this.BlueBerryUpdate = new MetroSetButton();
			this.metroSetButton2 = new MetroSetButton();
			this.UpdateRes = new MetroSetButton();
			this.label36 = new Label();
			this.label37 = new Label();
			this.fovYField = new TextBox();
			this.ingameSens = new TextBox();
			this.jitter = new TextBox();
			this.headshotOffsetField = new TextBox();
			this.fovXField = new TextBox();
			this.maxRecoilField = new TextBox();
			this.recoilMultiplierField = new TextBox();
			this.holdingTimeBox = new TextBox();
			this.BlueBerryFOVXField = new TextBox();
			this.BlueBerryFOVYField = new TextBox();
			this.rcsSpeed = new TextBox();
			this.AppleFOVY = new TextBox();
			this.assistJitter = new TextBox();
			this.BlueBerryMaxCountField = new TextBox();
			this.assistSens = new TextBox();
			this.BlueBerryHSOffsetField = new TextBox();
			this.resolutionXField = new TextBox();
			this.AppleFOVX = new TextBox();
			this.triggerDelay = new TextBox();
			this.flickSens = new TextBox();
			this.flickFovY = new TextBox();
			this.flickFovX = new TextBox();
			this.followTime = new TextBox();
			this.flickJitter = new TextBox();
			this.flickHO = new TextBox();
			this.resolutionYField = new TextBox();
			base.SuspendLayout();
			this.styleManager1.CustomTheme = "C:\\Users\\GALAXY\\Desktop\\MetroSet Theme.xml";
			this.styleManager1.MetroForm = this;
			this.styleManager1.Style = 2;
			this.styleManager1.ThemeAuthor = "Narwin";
			this.styleManager1.ThemeName = "MetroDark";
			this.updateButton.Cursor = Cursors.Hand;
			this.updateButton.DisabledBackColor = Color.Empty;
			this.updateButton.DisabledBorderColor = Color.Empty;
			this.updateButton.DisabledForeColor = Color.Transparent;
			this.updateButton.Font = new Font("Bahnschrift Condensed", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.updateButton.HoverBorderColor = Color.Transparent;
			this.updateButton.HoverColor = Color.Transparent;
			this.updateButton.HoverTextColor = Color.Empty;
			this.updateButton.IsDerivedStyle = true;
			this.updateButton.Location = new Point(33, 412);
			this.updateButton.Name = "updateButton";
			this.updateButton.NormalBorderColor = Color.Transparent;
			this.updateButton.NormalColor = Color.Empty;
			this.updateButton.NormalTextColor = Color.Empty;
			this.updateButton.PressBorderColor = Color.Empty;
			this.updateButton.PressColor = Color.Empty;
			this.updateButton.PressTextColor = Color.Empty;
			this.updateButton.Size = new Size(915, 33);
			this.updateButton.Style = 2;
			this.updateButton.StyleManager = this.styleManager1;
			this.updateButton.TabIndex = 64;
			this.updateButton.Text = "Save Config";
			this.updateButton.ThemeAuthor = "Narwin";
			this.updateButton.ThemeName = "MetroDark";
			this.updateButton.Click += this.updateButton_Click;
			this.metroSetComboBox2.AllowDrop = true;
			this.metroSetComboBox2.ArrowColor = Color.HotPink;
			this.metroSetComboBox2.BackColor = Color.Transparent;
			this.metroSetComboBox2.BackgroundColor = Color.White;
			this.metroSetComboBox2.BorderColor = SystemColors.ActiveCaptionText;
			this.metroSetComboBox2.CausesValidation = false;
			this.metroSetComboBox2.DisabledBackColor = Color.Red;
			this.metroSetComboBox2.DisabledBorderColor = Color.FromArgb(109, 109, 109);
			this.metroSetComboBox2.DisabledForeColor = Color.FromArgb(109, 109, 109);
			this.metroSetComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
			this.metroSetComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.metroSetComboBox2.Font = new Font("Microsoft Sans Serif", 11f);
			this.metroSetComboBox2.FormattingEnabled = true;
			this.metroSetComboBox2.IsDerivedStyle = true;
			this.metroSetComboBox2.ItemHeight = 20;
			this.metroSetComboBox2.Location = new Point(808, 161);
			this.metroSetComboBox2.Name = "metroSetComboBox2";
			this.metroSetComboBox2.SelectedItemBackColor = Color.FromArgb(120, 31, 255);
			this.metroSetComboBox2.SelectedItemForeColor = Color.White;
			this.metroSetComboBox2.Size = new Size(122, 26);
			this.metroSetComboBox2.Style = 2;
			this.metroSetComboBox2.StyleManager = this.styleManager1;
			this.metroSetComboBox2.TabIndex = 67;
			this.metroSetComboBox2.ThemeAuthor = "Narwin";
			this.metroSetComboBox2.ThemeName = "MetroDark";
			this.metroSetComboBox2.SelectedIndexChanged += this.metroSetComboBox2_SelectedIndexChanged;
			this.flicktext.AutoSize = true;
			this.flicktext.BackColor = Color.Transparent;
			this.flicktext.Font = new Font("Bahnschrift Condensed", 12f);
			this.flicktext.ForeColor = Color.White;
			this.flicktext.Location = new Point(723, 149);
			this.flicktext.Name = "flicktext";
			this.flicktext.Size = new Size(24, 19);
			this.flicktext.TabIndex = 75;
			this.flicktext.Text = "Off";
			this.metroSetSwitch6.BackColor = Color.Transparent;
			this.metroSetSwitch6.BackgroundColor = Color.Transparent;
			this.metroSetSwitch6.BorderColor = Color.Empty;
			this.metroSetSwitch6.CheckColor = Color.White;
			this.metroSetSwitch6.CheckState = 0;
			this.metroSetSwitch6.Cursor = Cursors.Hand;
			this.metroSetSwitch6.DisabledBorderColor = Color.MediumSlateBlue;
			this.metroSetSwitch6.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
			this.metroSetSwitch6.DisabledUnCheckColor = Color.DarkSlateBlue;
			this.metroSetSwitch6.IsDerivedStyle = true;
			this.metroSetSwitch6.Location = new Point(651, 147);
			this.metroSetSwitch6.Name = "metroSetSwitch6";
			this.metroSetSwitch6.Size = new Size(58, 22);
			this.metroSetSwitch6.Style = 2;
			this.metroSetSwitch6.StyleManager = this.styleManager1;
			this.metroSetSwitch6.Switched = false;
			this.metroSetSwitch6.SymbolColor = Color.White;
			this.metroSetSwitch6.TabIndex = 74;
			this.metroSetSwitch6.Text = "AimbotSwitch";
			this.metroSetSwitch6.ThemeAuthor = "Narwin";
			this.metroSetSwitch6.ThemeName = "MetroDark";
			this.metroSetSwitch6.UnCheckColor = Color.Gray;
			this.metroSetSwitch6.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch6_SwitchedChanged);
			this.triglabel.AutoSize = true;
			this.triglabel.BackColor = Color.Transparent;
			this.triglabel.Font = new Font("Bahnschrift Condensed", 12f);
			this.triglabel.ForeColor = Color.White;
			this.triglabel.Location = new Point(570, 149);
			this.triglabel.Name = "triglabel";
			this.triglabel.Size = new Size(24, 19);
			this.triglabel.TabIndex = 74;
			this.triglabel.Text = "Off";
			this.metroSetComboBox1.AllowDrop = true;
			this.metroSetComboBox1.ArrowColor = Color.HotPink;
			this.metroSetComboBox1.BackColor = Color.Transparent;
			this.metroSetComboBox1.BackgroundColor = Color.White;
			this.metroSetComboBox1.BorderColor = SystemColors.ActiveCaptionText;
			this.metroSetComboBox1.CausesValidation = false;
			this.metroSetComboBox1.DisabledBackColor = Color.White;
			this.metroSetComboBox1.DisabledBorderColor = Color.White;
			this.metroSetComboBox1.DisabledForeColor = Color.White;
			this.metroSetComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
			this.metroSetComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.metroSetComboBox1.Font = new Font("Microsoft Sans Serif", 11f);
			this.metroSetComboBox1.FormattingEnabled = true;
			this.metroSetComboBox1.IsDerivedStyle = true;
			this.metroSetComboBox1.ItemHeight = 20;
			this.metroSetComboBox1.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock"
			});
			this.metroSetComboBox1.Location = new Point(561, 104);
			this.metroSetComboBox1.Name = "metroSetComboBox1";
			this.metroSetComboBox1.SelectedItemBackColor = Color.FromArgb(120, 31, 255);
			this.metroSetComboBox1.SelectedItemForeColor = Color.White;
			this.metroSetComboBox1.Size = new Size(83, 26);
			this.metroSetComboBox1.Style = 2;
			this.metroSetComboBox1.StyleManager = this.styleManager1;
			this.metroSetComboBox1.TabIndex = 67;
			this.metroSetComboBox1.ThemeAuthor = "Narwin";
			this.metroSetComboBox1.ThemeName = "MetroDark";
			this.metroSetComboBox1.SelectedIndexChanged += this.metroSetComboBox1_SelectedIndexChanged;
			this.AppleSwitch.BackColor = Color.Transparent;
			this.AppleSwitch.BackgroundColor = Color.Transparent;
			this.AppleSwitch.BorderColor = Color.Empty;
			this.AppleSwitch.CheckColor = Color.White;
			this.AppleSwitch.CheckState = 0;
			this.AppleSwitch.Cursor = Cursors.Hand;
			this.AppleSwitch.DisabledBorderColor = Color.MediumSlateBlue;
			this.AppleSwitch.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
			this.AppleSwitch.DisabledUnCheckColor = Color.DarkSlateBlue;
			this.AppleSwitch.IsDerivedStyle = true;
			this.AppleSwitch.Location = new Point(499, 147);
			this.AppleSwitch.Name = "AppleSwitch";
			this.AppleSwitch.Size = new Size(58, 22);
			this.AppleSwitch.Style = 2;
			this.AppleSwitch.StyleManager = this.styleManager1;
			this.AppleSwitch.Switched = false;
			this.AppleSwitch.SymbolColor = Color.White;
			this.AppleSwitch.TabIndex = 15;
			this.AppleSwitch.Text = "AimbotSwitch";
			this.AppleSwitch.ThemeAuthor = "Narwin";
			this.AppleSwitch.ThemeName = "MetroDark";
			this.AppleSwitch.UnCheckColor = Color.Gray;
			this.AppleSwitch.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.AppleSwitch_SwitchedChanged);
			this.label32.AutoSize = true;
			this.label32.BackColor = Color.Transparent;
			this.label32.Font = new Font("Bahnschrift Condensed", 12f);
			this.label32.ForeColor = Color.White;
			this.label32.Location = new Point(419, 150);
			this.label32.Name = "label32";
			this.label32.Size = new Size(24, 19);
			this.label32.TabIndex = 69;
			this.label32.Text = "Off";
			this.label32.Click += this.label32_Click;
			this.BlueBerrySwitch.BackColor = Color.Transparent;
			this.BlueBerrySwitch.BackgroundColor = Color.Transparent;
			this.BlueBerrySwitch.BorderColor = Color.Empty;
			this.BlueBerrySwitch.CheckColor = Color.White;
			this.BlueBerrySwitch.CheckState = 0;
			this.BlueBerrySwitch.Cursor = Cursors.Hand;
			this.BlueBerrySwitch.DisabledBorderColor = Color.MediumSlateBlue;
			this.BlueBerrySwitch.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
			this.BlueBerrySwitch.DisabledUnCheckColor = Color.DarkSlateBlue;
			this.BlueBerrySwitch.IsDerivedStyle = true;
			this.BlueBerrySwitch.Location = new Point(348, 147);
			this.BlueBerrySwitch.Name = "BlueBerrySwitch";
			this.BlueBerrySwitch.Size = new Size(58, 22);
			this.BlueBerrySwitch.Style = 2;
			this.BlueBerrySwitch.StyleManager = this.styleManager1;
			this.BlueBerrySwitch.Switched = false;
			this.BlueBerrySwitch.SymbolColor = Color.White;
			this.BlueBerrySwitch.TabIndex = 15;
			this.BlueBerrySwitch.Text = "AimbotSwitch";
			this.BlueBerrySwitch.ThemeAuthor = "Narwin";
			this.BlueBerrySwitch.ThemeName = "MetroDark";
			this.BlueBerrySwitch.UnCheckColor = Color.Gray;
			this.BlueBerrySwitch.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.BlueBerrySwitch_SwitchedChanged);
			this.label30.AutoSize = true;
			this.label30.BackColor = Color.Transparent;
			this.label30.Font = new Font("Bahnschrift Condensed", 12f);
			this.label30.ForeColor = Color.White;
			this.label30.Location = new Point(269, 148);
			this.label30.Name = "label30";
			this.label30.Size = new Size(24, 19);
			this.label30.TabIndex = 68;
			this.label30.Text = "Off";
			this.label30.Click += this.label30_Click_1;
			this.metroSetSwitch3.BackColor = Color.Transparent;
			this.metroSetSwitch3.BackgroundColor = Color.Transparent;
			this.metroSetSwitch3.BorderColor = Color.Empty;
			this.metroSetSwitch3.CheckColor = Color.White;
			this.metroSetSwitch3.CheckState = 0;
			this.metroSetSwitch3.Cursor = Cursors.Hand;
			this.metroSetSwitch3.DisabledBorderColor = Color.MediumSlateBlue;
			this.metroSetSwitch3.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
			this.metroSetSwitch3.DisabledUnCheckColor = Color.DarkSlateBlue;
			this.metroSetSwitch3.IsDerivedStyle = true;
			this.metroSetSwitch3.Location = new Point(197, 147);
			this.metroSetSwitch3.Name = "metroSetSwitch3";
			this.metroSetSwitch3.Size = new Size(58, 22);
			this.metroSetSwitch3.Style = 2;
			this.metroSetSwitch3.StyleManager = this.styleManager1;
			this.metroSetSwitch3.Switched = false;
			this.metroSetSwitch3.SymbolColor = Color.White;
			this.metroSetSwitch3.TabIndex = 15;
			this.metroSetSwitch3.Text = "AimbotSwitch";
			this.metroSetSwitch3.ThemeAuthor = "Narwin";
			this.metroSetSwitch3.ThemeName = "MetroDark";
			this.metroSetSwitch3.UnCheckColor = SystemColors.GrayText;
			this.metroSetSwitch3.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch3_SwitchedChanged);
			this.AimOff.AutoSize = true;
			this.AimOff.BackColor = Color.Transparent;
			this.AimOff.Font = new Font("Bahnschrift Condensed", 12f);
			this.AimOff.ForeColor = Color.White;
			this.AimOff.Location = new Point(115, 150);
			this.AimOff.Name = "AimOff";
			this.AimOff.Size = new Size(24, 19);
			this.AimOff.TabIndex = 67;
			this.AimOff.Text = "Off";
			this.AimOff.Click += this.AimOff_Click;
			this.metroSetSwitch2.BackColor = Color.Transparent;
			this.metroSetSwitch2.BackgroundColor = Color.Transparent;
			this.metroSetSwitch2.BorderColor = Color.Empty;
			this.metroSetSwitch2.CheckColor = Color.White;
			this.metroSetSwitch2.CheckState = 0;
			this.metroSetSwitch2.Cursor = Cursors.Hand;
			this.metroSetSwitch2.DisabledBorderColor = Color.MediumSlateBlue;
			this.metroSetSwitch2.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
			this.metroSetSwitch2.DisabledUnCheckColor = Color.DarkSlateBlue;
			this.metroSetSwitch2.IsDerivedStyle = true;
			this.metroSetSwitch2.Location = new Point(45, 148);
			this.metroSetSwitch2.Name = "metroSetSwitch2";
			this.metroSetSwitch2.Size = new Size(58, 22);
			this.metroSetSwitch2.Style = 2;
			this.metroSetSwitch2.StyleManager = this.styleManager1;
			this.metroSetSwitch2.Switched = false;
			this.metroSetSwitch2.SymbolColor = Color.White;
			this.metroSetSwitch2.TabIndex = 15;
			this.metroSetSwitch2.Text = "AimbotSwitch";
			this.metroSetSwitch2.ThemeAuthor = "Narwin";
			this.metroSetSwitch2.ThemeName = "MetroDark";
			this.metroSetSwitch2.UnCheckColor = SystemColors.GrayText;
			this.metroSetSwitch2.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch2_SwitchedChanged);
			this.AimbotKeyCombo.AllowDrop = true;
			this.AimbotKeyCombo.ArrowColor = Color.HotPink;
			this.AimbotKeyCombo.BackColor = Color.Transparent;
			this.AimbotKeyCombo.BackgroundColor = Color.White;
			this.AimbotKeyCombo.BorderColor = SystemColors.ActiveCaptionText;
			this.AimbotKeyCombo.CausesValidation = false;
			this.AimbotKeyCombo.DisabledBackColor = Color.FromArgb(204, 204, 204);
			this.AimbotKeyCombo.DisabledBorderColor = Color.FromArgb(155, 155, 155);
			this.AimbotKeyCombo.DisabledForeColor = Color.FromArgb(136, 136, 136);
			this.AimbotKeyCombo.DrawMode = DrawMode.OwnerDrawFixed;
			this.AimbotKeyCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			this.AimbotKeyCombo.Font = new Font("Microsoft Sans Serif", 11f);
			this.AimbotKeyCombo.FormattingEnabled = true;
			this.AimbotKeyCombo.IsDerivedStyle = true;
			this.AimbotKeyCombo.ItemHeight = 20;
			this.AimbotKeyCombo.Items.AddRange(new object[]
			{
				"Mouse 1",
				"Mouse 2",
				"Mouse 3",
				"Mouse 4",
				"Mouse 5",
				"Shift",
				"Alt",
				"CTRL",
				"Caps Lock"
			});
			this.AimbotKeyCombo.Location = new Point(101, 104);
			this.AimbotKeyCombo.Name = "AimbotKeyCombo";
			this.AimbotKeyCombo.SelectedItemBackColor = Color.FromArgb(120, 31, 255);
			this.AimbotKeyCombo.SelectedItemForeColor = Color.White;
			this.AimbotKeyCombo.Size = new Size(78, 26);
			this.AimbotKeyCombo.Style = 2;
			this.AimbotKeyCombo.StyleManager = this.styleManager1;
			this.AimbotKeyCombo.TabIndex = 14;
			this.AimbotKeyCombo.ThemeAuthor = "Narwin";
			this.AimbotKeyCombo.ThemeName = "MetroDark";
			this.AimbotKeyCombo.SelectedIndexChanged += this.AimbotKeyCombo_SelectedIndexChanged;
			this.label34.AutoSize = true;
			this.label34.BackColor = Color.Transparent;
			this.label34.Font = new Font("Bahnschrift Condensed", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label34.ForeColor = Color.Yellow;
			this.label34.Location = new Point(167, 24);
			this.label34.Name = "label34";
			this.label34.Size = new Size(42, 17);
			this.label34.TabIndex = 69;
			this.label34.Text = "YELLOW";
			this.label34.Click += this.label34_Click;
			this.metroSetSwitch1.BackColor = Color.Transparent;
			this.metroSetSwitch1.BackgroundColor = Color.Transparent;
			this.metroSetSwitch1.BorderColor = Color.Transparent;
			this.metroSetSwitch1.CheckColor = Color.FromArgb(66, 28, 239);
			this.metroSetSwitch1.CheckState = 0;
			this.metroSetSwitch1.Cursor = Cursors.Hand;
			this.metroSetSwitch1.DisabledBorderColor = Color.FromArgb(85, 85, 85);
			this.metroSetSwitch1.DisabledCheckColor = Color.FromArgb(66, 28, 239);
			this.metroSetSwitch1.DisabledUnCheckColor = Color.FromArgb(200, 205, 205, 205);
			this.metroSetSwitch1.IsDerivedStyle = true;
			this.metroSetSwitch1.Location = new Point(156, 43);
			this.metroSetSwitch1.Name = "metroSetSwitch1";
			this.metroSetSwitch1.Size = new Size(58, 22);
			this.metroSetSwitch1.Style = 2;
			this.metroSetSwitch1.StyleManager = this.styleManager1;
			this.metroSetSwitch1.Switched = false;
			this.metroSetSwitch1.SymbolColor = Color.White;
			this.metroSetSwitch1.TabIndex = 66;
			this.metroSetSwitch1.Text = "AimbotSwitch";
			this.metroSetSwitch1.ThemeAuthor = "Narwin";
			this.metroSetSwitch1.ThemeName = "MetroDark";
			this.metroSetSwitch1.UnCheckColor = Color.Yellow;
			this.metroSetSwitch1.SwitchedChanged += new MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch1_SwitchedChanged);
			this.leonardoPorts.AllowDrop = true;
			this.leonardoPorts.ArrowColor = Color.HotPink;
			this.leonardoPorts.BackColor = Color.Transparent;
			this.leonardoPorts.BackgroundColor = Color.White;
			this.leonardoPorts.BorderColor = SystemColors.ActiveCaptionText;
			this.leonardoPorts.CausesValidation = false;
			this.leonardoPorts.DisabledBackColor = Color.FromArgb(80, 80, 80);
			this.leonardoPorts.DisabledBorderColor = Color.FromArgb(109, 109, 109);
			this.leonardoPorts.DisabledForeColor = Color.FromArgb(109, 109, 109);
			this.leonardoPorts.DrawMode = DrawMode.OwnerDrawFixed;
			this.leonardoPorts.DropDownStyle = ComboBoxStyle.DropDownList;
			this.leonardoPorts.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.leonardoPorts.FormattingEnabled = true;
			this.leonardoPorts.IsDerivedStyle = true;
			this.leonardoPorts.ItemHeight = 20;
			this.leonardoPorts.Location = new Point(12, 59);
			this.leonardoPorts.Name = "leonardoPorts";
			this.leonardoPorts.SelectedItemBackColor = Color.FromArgb(120, 31, 255);
			this.leonardoPorts.SelectedItemForeColor = Color.White;
			this.leonardoPorts.Size = new Size(121, 26);
			this.leonardoPorts.Style = 2;
			this.leonardoPorts.StyleManager = this.styleManager1;
			this.leonardoPorts.TabIndex = 33;
			this.leonardoPorts.ThemeAuthor = "Narwin";
			this.leonardoPorts.ThemeName = "MetroDark";
			this.leonardoPorts.SelectedIndexChanged += this.leonardoPorts_SelectedIndexChanged;
			this.label19.AutoSize = true;
			this.label19.BackColor = Color.Transparent;
			this.label19.BorderStyle = BorderStyle.FixedSingle;
			this.label19.ForeColor = Color.White;
			this.label19.Location = new Point(953, 4);
			this.label19.Name = "label19";
			this.label19.Size = new Size(17, 16);
			this.label19.TabIndex = 59;
			this.label19.Text = "X";
			this.label19.Click += this.label19_Click_1;
			this.label20.AutoSize = true;
			this.label20.BackColor = Color.Transparent;
			this.label20.BorderStyle = BorderStyle.FixedSingle;
			this.label20.ForeColor = Color.White;
			this.label20.Location = new Point(933, 4);
			this.label20.Name = "label20";
			this.label20.Size = new Size(14, 16);
			this.label20.TabIndex = 60;
			this.label20.Text = "-";
			this.label20.Click += this.label20_Click;
			this.currentModeCombo.AllowDrop = true;
			this.currentModeCombo.ArrowColor = Color.HotPink;
			this.currentModeCombo.BackColor = Color.Transparent;
			this.currentModeCombo.BackgroundColor = Color.White;
			this.currentModeCombo.BorderColor = SystemColors.ActiveCaptionText;
			this.currentModeCombo.CausesValidation = false;
			this.currentModeCombo.DisabledBackColor = Color.FromArgb(80, 80, 80);
			this.currentModeCombo.DisabledBorderColor = Color.FromArgb(109, 109, 109);
			this.currentModeCombo.DisabledForeColor = Color.FromArgb(109, 109, 109);
			this.currentModeCombo.DrawMode = DrawMode.OwnerDrawVariable;
			this.currentModeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			this.currentModeCombo.Font = new Font("Microsoft Sans Serif", 11f);
			this.currentModeCombo.FormattingEnabled = true;
			this.currentModeCombo.IsDerivedStyle = true;
			this.currentModeCombo.ItemHeight = 20;
			this.currentModeCombo.Items.AddRange(new object[]
			{
				"Mode 1 (F1)",
				"Mode 2 (F2)",
				"Mode 3 (F3)"
			});
			this.currentModeCombo.Location = new Point(849, 55);
			this.currentModeCombo.Name = "currentModeCombo";
			this.currentModeCombo.SelectedItemBackColor = Color.FromArgb(120, 31, 255);
			this.currentModeCombo.SelectedItemForeColor = Color.White;
			this.currentModeCombo.Size = new Size(121, 26);
			this.currentModeCombo.Style = 2;
			this.currentModeCombo.StyleManager = this.styleManager1;
			this.currentModeCombo.TabIndex = 35;
			this.currentModeCombo.ThemeAuthor = "Narwin";
			this.currentModeCombo.ThemeName = "MetroDark";
			this.currentModeCombo.SelectedIndexChanged += this.currentModeCombo_SelectedIndexChanged;
			this.notifyIcon1.Text = "BitTorrent 7.10.5\r\n(0) downloading, 0(0) seeding";
			this.notifyIcon1.MouseClick += this.notifyIcon1_MouseClick;
			this.metroSetButton1.Cursor = Cursors.Hand;
			this.metroSetButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
			this.metroSetButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
			this.metroSetButton1.DisabledForeColor = Color.Gray;
			this.metroSetButton1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.metroSetButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
			this.metroSetButton1.HoverColor = Color.FromArgb(95, 207, 255);
			this.metroSetButton1.HoverTextColor = Color.White;
			this.metroSetButton1.IsDerivedStyle = true;
			this.metroSetButton1.Location = new Point(-1, 32);
			this.metroSetButton1.Name = "metroSetButton1";
			this.metroSetButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
			this.metroSetButton1.NormalColor = Color.FromArgb(65, 177, 225);
			this.metroSetButton1.NormalTextColor = Color.White;
			this.metroSetButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
			this.metroSetButton1.PressColor = Color.FromArgb(35, 147, 195);
			this.metroSetButton1.PressTextColor = Color.White;
			this.metroSetButton1.Size = new Size(10, 44);
			this.metroSetButton1.Style = 2;
			this.metroSetButton1.StyleManager = this.styleManager1;
			this.metroSetButton1.TabIndex = 64;
			this.metroSetButton1.Text = "UPDATE";
			this.metroSetButton1.ThemeAuthor = "Narwin";
			this.metroSetButton1.ThemeName = "MetroDark";
			this.metroSetButton1.Visible = false;
			this.metroSetButton1.Click += this.metroSetButton1_Click;
			this.BlueBerryUpdate.Cursor = Cursors.Hand;
			this.BlueBerryUpdate.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
			this.BlueBerryUpdate.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
			this.BlueBerryUpdate.DisabledForeColor = Color.Gray;
			this.BlueBerryUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BlueBerryUpdate.HoverBorderColor = Color.FromArgb(95, 207, 255);
			this.BlueBerryUpdate.HoverColor = Color.FromArgb(95, 207, 255);
			this.BlueBerryUpdate.HoverTextColor = Color.White;
			this.BlueBerryUpdate.IsDerivedStyle = true;
			this.BlueBerryUpdate.Location = new Point(0, 32);
			this.BlueBerryUpdate.Name = "BlueBerryUpdate";
			this.BlueBerryUpdate.NormalBorderColor = Color.FromArgb(65, 177, 225);
			this.BlueBerryUpdate.NormalColor = Color.FromArgb(65, 177, 225);
			this.BlueBerryUpdate.NormalTextColor = Color.White;
			this.BlueBerryUpdate.PressBorderColor = Color.FromArgb(35, 147, 195);
			this.BlueBerryUpdate.PressColor = Color.FromArgb(35, 147, 195);
			this.BlueBerryUpdate.PressTextColor = Color.White;
			this.BlueBerryUpdate.Size = new Size(10, 44);
			this.BlueBerryUpdate.Style = 2;
			this.BlueBerryUpdate.StyleManager = this.styleManager1;
			this.BlueBerryUpdate.TabIndex = 64;
			this.BlueBerryUpdate.Text = "UPDATE";
			this.BlueBerryUpdate.ThemeAuthor = "Narwin";
			this.BlueBerryUpdate.ThemeName = "MetroDark";
			this.BlueBerryUpdate.Visible = false;
			this.BlueBerryUpdate.Click += this.BlueBerryUpdate_Click;
			this.metroSetButton2.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
			this.metroSetButton2.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
			this.metroSetButton2.DisabledForeColor = Color.Gray;
			this.metroSetButton2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.metroSetButton2.HoverBorderColor = Color.FromArgb(95, 207, 255);
			this.metroSetButton2.HoverColor = Color.FromArgb(95, 207, 255);
			this.metroSetButton2.HoverTextColor = Color.White;
			this.metroSetButton2.IsDerivedStyle = true;
			this.metroSetButton2.Location = new Point(-1, 32);
			this.metroSetButton2.Name = "metroSetButton2";
			this.metroSetButton2.NormalBorderColor = Color.FromArgb(65, 177, 225);
			this.metroSetButton2.NormalColor = Color.FromArgb(65, 177, 225);
			this.metroSetButton2.NormalTextColor = Color.White;
			this.metroSetButton2.PressBorderColor = Color.FromArgb(35, 147, 195);
			this.metroSetButton2.PressColor = Color.FromArgb(35, 147, 195);
			this.metroSetButton2.PressTextColor = Color.White;
			this.metroSetButton2.Size = new Size(10, 44);
			this.metroSetButton2.Style = 2;
			this.metroSetButton2.StyleManager = this.styleManager1;
			this.metroSetButton2.TabIndex = 64;
			this.metroSetButton2.Text = "UPDATE";
			this.metroSetButton2.ThemeAuthor = "Narwin";
			this.metroSetButton2.ThemeName = "MetroDark";
			this.metroSetButton2.Visible = false;
			this.metroSetButton2.Click += this.metroSetButton2_Click;
			this.UpdateRes.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
			this.UpdateRes.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
			this.UpdateRes.DisabledForeColor = Color.Gray;
			this.UpdateRes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.UpdateRes.HoverBorderColor = Color.FromArgb(95, 207, 255);
			this.UpdateRes.HoverColor = Color.FromArgb(95, 207, 255);
			this.UpdateRes.HoverTextColor = Color.White;
			this.UpdateRes.IsDerivedStyle = true;
			this.UpdateRes.Location = new Point(-1, 32);
			this.UpdateRes.Name = "UpdateRes";
			this.UpdateRes.NormalBorderColor = Color.FromArgb(65, 177, 225);
			this.UpdateRes.NormalColor = Color.FromArgb(65, 177, 225);
			this.UpdateRes.NormalTextColor = Color.White;
			this.UpdateRes.PressBorderColor = Color.FromArgb(35, 147, 195);
			this.UpdateRes.PressColor = Color.FromArgb(35, 147, 195);
			this.UpdateRes.PressTextColor = Color.White;
			this.UpdateRes.Size = new Size(10, 44);
			this.UpdateRes.Style = 2;
			this.UpdateRes.StyleManager = this.styleManager1;
			this.UpdateRes.TabIndex = 64;
			this.UpdateRes.Text = "UPDATE";
			this.UpdateRes.ThemeAuthor = "Narwin";
			this.UpdateRes.ThemeName = "MetroDark";
			this.UpdateRes.Visible = false;
			this.UpdateRes.Click += this.UpdateRes_Click;
			this.label36.AutoSize = true;
			this.label36.BackColor = Color.Transparent;
			this.label36.ForeColor = Color.Snow;
			this.label36.Location = new Point(743, 35);
			this.label36.Name = "label36";
			this.label36.Size = new Size(0, 14);
			this.label36.TabIndex = 74;
			this.label37.AutoSize = true;
			this.label37.BackColor = Color.Transparent;
			this.label37.ForeColor = Color.Snow;
			this.label37.Location = new Point(744, 62);
			this.label37.Name = "label37";
			this.label37.Size = new Size(0, 14);
			this.label37.TabIndex = 75;
			this.label37.Click += this.label37_Click;
			this.fovYField.BackColor = Color.FromArgb(24, 20, 20);
			this.fovYField.BorderStyle = BorderStyle.None;
			this.fovYField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.fovYField.ForeColor = Color.Fuchsia;
			this.fovYField.Location = new Point(45, 205);
			this.fovYField.Multiline = true;
			this.fovYField.Name = "fovYField";
			this.fovYField.Size = new Size(65, 26);
			this.fovYField.TabIndex = 76;
			this.fovYField.TextAlign = HorizontalAlignment.Center;
			this.ingameSens.BackColor = Color.FromArgb(24, 20, 20);
			this.ingameSens.BorderStyle = BorderStyle.None;
			this.ingameSens.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.ingameSens.ForeColor = Color.Fuchsia;
			this.ingameSens.Location = new Point(45, 270);
			this.ingameSens.Multiline = true;
			this.ingameSens.Name = "ingameSens";
			this.ingameSens.Size = new Size(65, 26);
			this.ingameSens.TabIndex = 77;
			this.ingameSens.TextAlign = HorizontalAlignment.Center;
			this.jitter.BackColor = Color.FromArgb(24, 20, 20);
			this.jitter.BorderStyle = BorderStyle.None;
			this.jitter.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.jitter.ForeColor = Color.Fuchsia;
			this.jitter.Location = new Point(118, 270);
			this.jitter.Multiline = true;
			this.jitter.Name = "jitter";
			this.jitter.Size = new Size(65, 26);
			this.jitter.TabIndex = 78;
			this.jitter.TextAlign = HorizontalAlignment.Center;
			this.headshotOffsetField.BackColor = Color.FromArgb(24, 20, 20);
			this.headshotOffsetField.BorderStyle = BorderStyle.None;
			this.headshotOffsetField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.headshotOffsetField.ForeColor = Color.Fuchsia;
			this.headshotOffsetField.Location = new Point(80, 336);
			this.headshotOffsetField.Multiline = true;
			this.headshotOffsetField.Name = "headshotOffsetField";
			this.headshotOffsetField.Size = new Size(65, 26);
			this.headshotOffsetField.TabIndex = 79;
			this.headshotOffsetField.TextAlign = HorizontalAlignment.Center;
			this.fovXField.BackColor = Color.FromArgb(24, 20, 20);
			this.fovXField.BorderStyle = BorderStyle.None;
			this.fovXField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.fovXField.ForeColor = Color.Fuchsia;
			this.fovXField.Location = new Point(117, 205);
			this.fovXField.Multiline = true;
			this.fovXField.Name = "fovXField";
			this.fovXField.Size = new Size(65, 26);
			this.fovXField.TabIndex = 80;
			this.fovXField.TextAlign = HorizontalAlignment.Center;
			this.maxRecoilField.BackColor = Color.FromArgb(24, 20, 20);
			this.maxRecoilField.BorderStyle = BorderStyle.None;
			this.maxRecoilField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.maxRecoilField.ForeColor = Color.Fuchsia;
			this.maxRecoilField.Location = new Point(270, 203);
			this.maxRecoilField.Multiline = true;
			this.maxRecoilField.Name = "maxRecoilField";
			this.maxRecoilField.Size = new Size(65, 26);
			this.maxRecoilField.TabIndex = 81;
			this.maxRecoilField.TextAlign = HorizontalAlignment.Center;
			this.recoilMultiplierField.BackColor = Color.FromArgb(24, 20, 20);
			this.recoilMultiplierField.BorderStyle = BorderStyle.None;
			this.recoilMultiplierField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.recoilMultiplierField.ForeColor = Color.Fuchsia;
			this.recoilMultiplierField.Location = new Point(198, 203);
			this.recoilMultiplierField.Multiline = true;
			this.recoilMultiplierField.Name = "recoilMultiplierField";
			this.recoilMultiplierField.Size = new Size(65, 26);
			this.recoilMultiplierField.TabIndex = 81;
			this.recoilMultiplierField.TextAlign = HorizontalAlignment.Center;
			this.holdingTimeBox.BackColor = Color.FromArgb(24, 20, 20);
			this.holdingTimeBox.BorderStyle = BorderStyle.None;
			this.holdingTimeBox.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.holdingTimeBox.ForeColor = Color.Fuchsia;
			this.holdingTimeBox.Location = new Point(198, 268);
			this.holdingTimeBox.Multiline = true;
			this.holdingTimeBox.Name = "holdingTimeBox";
			this.holdingTimeBox.Size = new Size(65, 26);
			this.holdingTimeBox.TabIndex = 82;
			this.holdingTimeBox.TextAlign = HorizontalAlignment.Center;
			this.BlueBerryFOVXField.BackColor = Color.FromArgb(24, 20, 20);
			this.BlueBerryFOVXField.BorderStyle = BorderStyle.None;
			this.BlueBerryFOVXField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BlueBerryFOVXField.ForeColor = Color.Fuchsia;
			this.BlueBerryFOVXField.Location = new Point(421, 204);
			this.BlueBerryFOVXField.Multiline = true;
			this.BlueBerryFOVXField.Name = "BlueBerryFOVXField";
			this.BlueBerryFOVXField.Size = new Size(65, 26);
			this.BlueBerryFOVXField.TabIndex = 83;
			this.BlueBerryFOVXField.TextAlign = HorizontalAlignment.Center;
			this.BlueBerryFOVYField.BackColor = Color.FromArgb(24, 20, 20);
			this.BlueBerryFOVYField.BorderStyle = BorderStyle.None;
			this.BlueBerryFOVYField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BlueBerryFOVYField.ForeColor = Color.Fuchsia;
			this.BlueBerryFOVYField.Location = new Point(349, 204);
			this.BlueBerryFOVYField.Multiline = true;
			this.BlueBerryFOVYField.Name = "BlueBerryFOVYField";
			this.BlueBerryFOVYField.Size = new Size(65, 26);
			this.BlueBerryFOVYField.TabIndex = 84;
			this.BlueBerryFOVYField.TextAlign = HorizontalAlignment.Center;
			this.rcsSpeed.BackColor = Color.FromArgb(24, 20, 20);
			this.rcsSpeed.BorderStyle = BorderStyle.None;
			this.rcsSpeed.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.rcsSpeed.ForeColor = Color.Fuchsia;
			this.rcsSpeed.Location = new Point(270, 269);
			this.rcsSpeed.Multiline = true;
			this.rcsSpeed.Name = "rcsSpeed";
			this.rcsSpeed.Size = new Size(65, 26);
			this.rcsSpeed.TabIndex = 85;
			this.rcsSpeed.TextAlign = HorizontalAlignment.Center;
			this.AppleFOVY.BackColor = Color.FromArgb(24, 20, 20);
			this.AppleFOVY.BorderStyle = BorderStyle.None;
			this.AppleFOVY.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.AppleFOVY.ForeColor = Color.Fuchsia;
			this.AppleFOVY.Location = new Point(500, 206);
			this.AppleFOVY.Multiline = true;
			this.AppleFOVY.Name = "AppleFOVY";
			this.AppleFOVY.Size = new Size(65, 26);
			this.AppleFOVY.TabIndex = 86;
			this.AppleFOVY.TextAlign = HorizontalAlignment.Center;
			this.assistJitter.BackColor = Color.FromArgb(24, 20, 20);
			this.assistJitter.BorderStyle = BorderStyle.None;
			this.assistJitter.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.assistJitter.ForeColor = Color.Fuchsia;
			this.assistJitter.Location = new Point(421, 269);
			this.assistJitter.Multiline = true;
			this.assistJitter.Name = "assistJitter";
			this.assistJitter.Size = new Size(65, 26);
			this.assistJitter.TabIndex = 87;
			this.assistJitter.TextAlign = HorizontalAlignment.Center;
			this.BlueBerryMaxCountField.BackColor = Color.FromArgb(24, 20, 20);
			this.BlueBerryMaxCountField.BorderStyle = BorderStyle.None;
			this.BlueBerryMaxCountField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BlueBerryMaxCountField.ForeColor = Color.Fuchsia;
			this.BlueBerryMaxCountField.Location = new Point(419, 334);
			this.BlueBerryMaxCountField.Multiline = true;
			this.BlueBerryMaxCountField.Name = "BlueBerryMaxCountField";
			this.BlueBerryMaxCountField.Size = new Size(65, 26);
			this.BlueBerryMaxCountField.TabIndex = 88;
			this.BlueBerryMaxCountField.TextAlign = HorizontalAlignment.Center;
			this.assistSens.BackColor = Color.FromArgb(24, 20, 20);
			this.assistSens.BorderStyle = BorderStyle.None;
			this.assistSens.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.assistSens.ForeColor = Color.Fuchsia;
			this.assistSens.Location = new Point(349, 269);
			this.assistSens.Multiline = true;
			this.assistSens.Name = "assistSens";
			this.assistSens.Size = new Size(65, 26);
			this.assistSens.TabIndex = 89;
			this.assistSens.TextAlign = HorizontalAlignment.Center;
			this.BlueBerryHSOffsetField.BackColor = Color.FromArgb(24, 20, 20);
			this.BlueBerryHSOffsetField.BorderStyle = BorderStyle.None;
			this.BlueBerryHSOffsetField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BlueBerryHSOffsetField.ForeColor = Color.Fuchsia;
			this.BlueBerryHSOffsetField.Location = new Point(348, 334);
			this.BlueBerryHSOffsetField.Multiline = true;
			this.BlueBerryHSOffsetField.Name = "BlueBerryHSOffsetField";
			this.BlueBerryHSOffsetField.Size = new Size(64, 26);
			this.BlueBerryHSOffsetField.TabIndex = 90;
			this.BlueBerryHSOffsetField.TextAlign = HorizontalAlignment.Center;
			this.resolutionXField.BackColor = Color.FromArgb(24, 20, 20);
			this.resolutionXField.BorderStyle = BorderStyle.None;
			this.resolutionXField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.resolutionXField.ForeColor = Color.Fuchsia;
			this.resolutionXField.Location = new Point(804, 246);
			this.resolutionXField.Multiline = true;
			this.resolutionXField.Name = "resolutionXField";
			this.resolutionXField.Size = new Size(134, 19);
			this.resolutionXField.TabIndex = 91;
			this.resolutionXField.TextAlign = HorizontalAlignment.Center;
			this.AppleFOVX.BackColor = Color.FromArgb(24, 20, 20);
			this.AppleFOVX.BorderStyle = BorderStyle.None;
			this.AppleFOVX.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.AppleFOVX.ForeColor = Color.Fuchsia;
			this.AppleFOVX.Location = new Point(573, 206);
			this.AppleFOVX.Multiline = true;
			this.AppleFOVX.Name = "AppleFOVX";
			this.AppleFOVX.Size = new Size(65, 26);
			this.AppleFOVX.TabIndex = 92;
			this.AppleFOVX.TextAlign = HorizontalAlignment.Center;
			this.triggerDelay.BackColor = Color.FromArgb(24, 20, 20);
			this.triggerDelay.BorderStyle = BorderStyle.None;
			this.triggerDelay.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.triggerDelay.ForeColor = Color.Fuchsia;
			this.triggerDelay.Location = new Point(500, 270);
			this.triggerDelay.Multiline = true;
			this.triggerDelay.Name = "triggerDelay";
			this.triggerDelay.Size = new Size(65, 26);
			this.triggerDelay.TabIndex = 91;
			this.triggerDelay.TextAlign = HorizontalAlignment.Center;
			this.flickSens.BackColor = Color.FromArgb(24, 20, 20);
			this.flickSens.BorderStyle = BorderStyle.None;
			this.flickSens.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.flickSens.ForeColor = Color.Fuchsia;
			this.flickSens.Location = new Point(652, 269);
			this.flickSens.Multiline = true;
			this.flickSens.Name = "flickSens";
			this.flickSens.Size = new Size(65, 26);
			this.flickSens.TabIndex = 93;
			this.flickSens.TextAlign = HorizontalAlignment.Center;
			this.flickFovY.BackColor = Color.FromArgb(24, 20, 20);
			this.flickFovY.BorderStyle = BorderStyle.None;
			this.flickFovY.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.flickFovY.ForeColor = Color.Fuchsia;
			this.flickFovY.Location = new Point(652, 205);
			this.flickFovY.Multiline = true;
			this.flickFovY.Name = "flickFovY";
			this.flickFovY.Size = new Size(65, 26);
			this.flickFovY.TabIndex = 94;
			this.flickFovY.TextAlign = HorizontalAlignment.Center;
			this.flickFovX.BackColor = Color.FromArgb(24, 20, 20);
			this.flickFovX.BorderStyle = BorderStyle.None;
			this.flickFovX.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.flickFovX.ForeColor = Color.Fuchsia;
			this.flickFovX.Location = new Point(725, 204);
			this.flickFovX.Multiline = true;
			this.flickFovX.Name = "flickFovX";
			this.flickFovX.Size = new Size(65, 26);
			this.flickFovX.TabIndex = 91;
			this.flickFovX.TextAlign = HorizontalAlignment.Center;
			this.followTime.BackColor = Color.FromArgb(24, 20, 20);
			this.followTime.BorderStyle = BorderStyle.None;
			this.followTime.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.followTime.ForeColor = Color.Fuchsia;
			this.followTime.Location = new Point(724, 334);
			this.followTime.Multiline = true;
			this.followTime.Name = "followTime";
			this.followTime.Size = new Size(65, 29);
			this.followTime.TabIndex = 95;
			this.followTime.TextAlign = HorizontalAlignment.Center;
			this.flickJitter.BackColor = Color.FromArgb(24, 20, 20);
			this.flickJitter.BorderStyle = BorderStyle.None;
			this.flickJitter.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.flickJitter.ForeColor = Color.Fuchsia;
			this.flickJitter.Location = new Point(724, 269);
			this.flickJitter.Multiline = true;
			this.flickJitter.Name = "flickJitter";
			this.flickJitter.Size = new Size(65, 26);
			this.flickJitter.TabIndex = 96;
			this.flickJitter.TextAlign = HorizontalAlignment.Center;
			this.flickHO.BackColor = Color.FromArgb(24, 20, 20);
			this.flickHO.BorderStyle = BorderStyle.None;
			this.flickHO.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.flickHO.ForeColor = Color.Fuchsia;
			this.flickHO.Location = new Point(654, 335);
			this.flickHO.Multiline = true;
			this.flickHO.Name = "flickHO";
			this.flickHO.Size = new Size(64, 26);
			this.flickHO.TabIndex = 97;
			this.flickHO.TextAlign = HorizontalAlignment.Center;
			this.resolutionYField.BackColor = Color.FromArgb(24, 20, 20);
			this.resolutionYField.BorderStyle = BorderStyle.None;
			this.resolutionYField.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.resolutionYField.ForeColor = Color.Fuchsia;
			this.resolutionYField.Location = new Point(804, 310);
			this.resolutionYField.Multiline = true;
			this.resolutionYField.Name = "resolutionYField";
			this.resolutionYField.Size = new Size(135, 19);
			this.resolutionYField.TabIndex = 91;
			this.resolutionYField.TextAlign = HorizontalAlignment.Center;
			base.AccessibleRole = AccessibleRole.MenuBar;
			base.AllowResize = false;
			this.BackColor = Color.FromArgb(24, 20, 20);
			base.BackgroundColor = Color.FromArgb(17, 17, 17);
			this.BackgroundImage = Resources.newsgravity2;
			base.BorderColor = Color.FromArgb(66, 28, 239);
			base.ClientSize = new Size(980, 470);
			base.Controls.Add(this.flickHO);
			base.Controls.Add(this.flickJitter);
			base.Controls.Add(this.followTime);
			base.Controls.Add(this.flickFovY);
			base.Controls.Add(this.flickSens);
			base.Controls.Add(this.AppleFOVX);
			base.Controls.Add(this.triggerDelay);
			base.Controls.Add(this.flickFovX);
			base.Controls.Add(this.resolutionYField);
			base.Controls.Add(this.resolutionXField);
			base.Controls.Add(this.BlueBerryHSOffsetField);
			base.Controls.Add(this.assistSens);
			base.Controls.Add(this.BlueBerryMaxCountField);
			base.Controls.Add(this.assistJitter);
			base.Controls.Add(this.AppleFOVY);
			base.Controls.Add(this.rcsSpeed);
			base.Controls.Add(this.BlueBerryFOVYField);
			base.Controls.Add(this.BlueBerryFOVXField);
			base.Controls.Add(this.holdingTimeBox);
			base.Controls.Add(this.recoilMultiplierField);
			base.Controls.Add(this.maxRecoilField);
			base.Controls.Add(this.fovXField);
			base.Controls.Add(this.headshotOffsetField);
			base.Controls.Add(this.jitter);
			base.Controls.Add(this.ingameSens);
			base.Controls.Add(this.fovYField);
			base.Controls.Add(this.flicktext);
			base.Controls.Add(this.triglabel);
			base.Controls.Add(this.label32);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.AimOff);
			base.Controls.Add(this.updateButton);
			base.Controls.Add(this.metroSetComboBox2);
			base.Controls.Add(this.metroSetSwitch3);
			base.Controls.Add(this.AimbotKeyCombo);
			base.Controls.Add(this.metroSetSwitch6);
			base.Controls.Add(this.metroSetComboBox1);
			base.Controls.Add(this.metroSetSwitch2);
			base.Controls.Add(this.BlueBerrySwitch);
			base.Controls.Add(this.label37);
			base.Controls.Add(this.AppleSwitch);
			base.Controls.Add(this.label36);
			base.Controls.Add(this.label34);
			base.Controls.Add(this.metroSetSwitch1);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.UpdateRes);
			base.Controls.Add(this.metroSetButton2);
			base.Controls.Add(this.BlueBerryUpdate);
			base.Controls.Add(this.currentModeCombo);
			base.Controls.Add(this.leonardoPorts);
			base.Controls.Add(this.metroSetButton1);
			this.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			base.HeaderColor = Color.FromArgb(66, 28, 239);
			base.Name = "bagulhotensodaquebradaloko264812";
			base.ShowIcon = false;
			base.SmallLineColor1 = Color.Empty;
			base.SmallLineColor2 = Color.Empty;
			base.SmallRectThickness = 5;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Style = 2;
			base.StyleManager = this.styleManager1;
			this.Text = ".";
			base.TextColor = Color.White;
			base.ThemeName = "MetroDark";
			base.FormClosing += this.bagulhotensodaquebradaloko264812_FormClosing;
			base.Load += this.MainScreen_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008FD4 File Offset: 0x000071D4
		private void MainScreen_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.check();
			this.label36.Text = " " + Login.KeyAuthApp.user_data.username;
			this.label37.Text = " " + Login.KeyAuthApp.expirydaysleft();
			this.HotKeySystem();
			bagulhotensodaquebradaloko264812._debugWindow = new DebugWindow();
			bagulhotensodaquebradaloko264812._debugWindow.Enabled = true;
			bagulhotensodaquebradaloko264812._debugWindow.Hide();
			foreach (string item in SerialPort.GetPortNames())
			{
				this.leonardoPorts.Items.Add(item);
			}
			int num = 0;
			Screen[] allScreens = Screen.AllScreens;
			for (int j = 0; j < allScreens.Length; j++)
			{
				this.metroSetComboBox2.Items.Add(string.Format("Monitor [{0}]", num));
				num++;
			}
			new PixelSearcher();
			if (bagulhotensodaquebradaloko264812.<>o__61.<>p__1 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__61.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, int> target = bagulhotensodaquebradaloko264812.<>o__61.<>p__1.Target;
			CallSite <>p__ = bagulhotensodaquebradaloko264812.<>o__61.<>p__1;
			if (bagulhotensodaquebradaloko264812.<>o__61.<>p__0 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__61.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Config.currentMode = target(<>p__, bagulhotensodaquebradaloko264812.<>o__61.<>p__0.Target(bagulhotensodaquebradaloko264812.<>o__61.<>p__0, typeof(Convert), Config.GetConfigFile(Settings.CONFIG.CHEAT_CURRENT_MODE, -1)));
			this.LoadConfigInFields(Config.currentMode);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000917C File Offset: 0x0000737C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970L, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002520 File Offset: 0x00000720
		private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002520 File Offset: 0x00000720
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000091B0 File Offset: 0x000073B0
		private void AimbotKeyCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.CONFIG conf = Settings.CONFIG.AIMBOT_HOTKEY;
			object val = this.AimbotKeyCombo.SelectedIndex.ToString();
			Config.SetConfig(conf, Config.currentMode, val);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002520 File Offset: 0x00000720
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002520 File Offset: 0x00000720
		private void jitter_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002520 File Offset: 0x00000720
		private void siticoneMaterialTextBox9_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002520 File Offset: 0x00000720
		private void label19_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000091E0 File Offset: 0x000073E0
		public void LoadConfigInFields(int currentMode)
		{
			Control control = this.resolutionXField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__1 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target = bagulhotensodaquebradaloko264812.<>o__70.<>p__1.Target;
			CallSite <>p__ = bagulhotensodaquebradaloko264812.<>o__70.<>p__1;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__0 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control.Text = target(<>p__, bagulhotensodaquebradaloko264812.<>o__70.<>p__0.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__0, Config.GetConfigFile(Settings.CONFIG.CHEAT_RESOLUTION_X, currentMode)));
			Control control2 = this.resolutionYField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__3 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target2 = bagulhotensodaquebradaloko264812.<>o__70.<>p__3.Target;
			CallSite <>p__2 = bagulhotensodaquebradaloko264812.<>o__70.<>p__3;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__2 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control2.Text = target2(<>p__2, bagulhotensodaquebradaloko264812.<>o__70.<>p__2.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__2, Config.GetConfigFile(Settings.CONFIG.CHEAT_RESOLUTION_Y, currentMode)));
			Control control3 = this.recoilMultiplierField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__5 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target3 = bagulhotensodaquebradaloko264812.<>o__70.<>p__5.Target;
			CallSite <>p__3 = bagulhotensodaquebradaloko264812.<>o__70.<>p__5;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__4 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control3.Text = target3(<>p__3, bagulhotensodaquebradaloko264812.<>o__70.<>p__4.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__4, Config.GetConfigFile(Settings.CONFIG.RCS_MULTIPLIER, currentMode)));
			Control control4 = this.maxRecoilField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__7 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target4 = bagulhotensodaquebradaloko264812.<>o__70.<>p__7.Target;
			CallSite <>p__4 = bagulhotensodaquebradaloko264812.<>o__70.<>p__7;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__6 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control4.Text = target4(<>p__4, bagulhotensodaquebradaloko264812.<>o__70.<>p__6.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__6, Config.GetConfigFile(Settings.CONFIG.RCS_MAX_RECOIL, currentMode)));
			ListControl aimbotKeyCombo = this.AimbotKeyCombo;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__9 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, int> target5 = bagulhotensodaquebradaloko264812.<>o__70.<>p__9.Target;
			CallSite <>p__5 = bagulhotensodaquebradaloko264812.<>o__70.<>p__9;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__8 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			aimbotKeyCombo.SelectedIndex = target5(<>p__5, bagulhotensodaquebradaloko264812.<>o__70.<>p__8.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__8, typeof(Convert), Config.GetConfigFile(Settings.CONFIG.AIMBOT_HOTKEY, currentMode)));
			ListControl listControl = this.metroSetComboBox1;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__11 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, int> target6 = bagulhotensodaquebradaloko264812.<>o__70.<>p__11.Target;
			CallSite <>p__6 = bagulhotensodaquebradaloko264812.<>o__70.<>p__11;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__10 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			listControl.SelectedIndex = target6(<>p__6, bagulhotensodaquebradaloko264812.<>o__70.<>p__10.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__10, typeof(Convert), Config.GetConfigFile(Settings.CONFIG.TRIGGER_HOTKEY, currentMode)));
			Control control5 = this.fovXField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__13 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__13 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target7 = bagulhotensodaquebradaloko264812.<>o__70.<>p__13.Target;
			CallSite <>p__7 = bagulhotensodaquebradaloko264812.<>o__70.<>p__13;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__12 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control5.Text = target7(<>p__7, bagulhotensodaquebradaloko264812.<>o__70.<>p__12.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__12, Config.GetConfigFile(Settings.CONFIG.AIMBOT_FOV_X, currentMode)));
			Control control6 = this.fovYField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__15 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target8 = bagulhotensodaquebradaloko264812.<>o__70.<>p__15.Target;
			CallSite <>p__8 = bagulhotensodaquebradaloko264812.<>o__70.<>p__15;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__14 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control6.Text = target8(<>p__8, bagulhotensodaquebradaloko264812.<>o__70.<>p__14.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__14, Config.GetConfigFile(Settings.CONFIG.AIMBOT_FOV_Y, currentMode)));
			Control control7 = this.headshotOffsetField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__17 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target9 = bagulhotensodaquebradaloko264812.<>o__70.<>p__17.Target;
			CallSite <>p__9 = bagulhotensodaquebradaloko264812.<>o__70.<>p__17;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__16 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control7.Text = target9(<>p__9, bagulhotensodaquebradaloko264812.<>o__70.<>p__16.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__16, Config.GetConfigFile(Settings.CONFIG.AIMBOT_HEADSHOT_OFFSET, currentMode)));
			Control control8 = this.holdingTimeBox;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__19 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__19 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target10 = bagulhotensodaquebradaloko264812.<>o__70.<>p__19.Target;
			CallSite <>p__10 = bagulhotensodaquebradaloko264812.<>o__70.<>p__19;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__18 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control8.Text = target10(<>p__10, bagulhotensodaquebradaloko264812.<>o__70.<>p__18.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__18, Config.GetConfigFile(Settings.CONFIG.RCS_HOLDINGTIME, currentMode)));
			Control blueBerryFOVXField = this.BlueBerryFOVXField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__21 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__21 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target11 = bagulhotensodaquebradaloko264812.<>o__70.<>p__21.Target;
			CallSite <>p__11 = bagulhotensodaquebradaloko264812.<>o__70.<>p__21;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__20 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			blueBerryFOVXField.Text = target11(<>p__11, bagulhotensodaquebradaloko264812.<>o__70.<>p__20.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__20, Config.GetConfigFile(Settings.CONFIG.ASSIST_FOV_X, currentMode)));
			Control blueBerryFOVYField = this.BlueBerryFOVYField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__23 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__23 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target12 = bagulhotensodaquebradaloko264812.<>o__70.<>p__23.Target;
			CallSite <>p__12 = bagulhotensodaquebradaloko264812.<>o__70.<>p__23;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__22 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__22 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			blueBerryFOVYField.Text = target12(<>p__12, bagulhotensodaquebradaloko264812.<>o__70.<>p__22.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__22, Config.GetConfigFile(Settings.CONFIG.ASSIST_FOV_Y, currentMode)));
			Control blueBerryHSOffsetField = this.BlueBerryHSOffsetField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__25 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__25 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target13 = bagulhotensodaquebradaloko264812.<>o__70.<>p__25.Target;
			CallSite <>p__13 = bagulhotensodaquebradaloko264812.<>o__70.<>p__25;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__24 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__24 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			blueBerryHSOffsetField.Text = target13(<>p__13, bagulhotensodaquebradaloko264812.<>o__70.<>p__24.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__24, Config.GetConfigFile(Settings.CONFIG.ASSIST_HEADSHOT_OFFSET, currentMode)));
			Control blueBerryMaxCountField = this.BlueBerryMaxCountField;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__27 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__27 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target14 = bagulhotensodaquebradaloko264812.<>o__70.<>p__27.Target;
			CallSite <>p__14 = bagulhotensodaquebradaloko264812.<>o__70.<>p__27;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__26 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__26 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			blueBerryMaxCountField.Text = target14(<>p__14, bagulhotensodaquebradaloko264812.<>o__70.<>p__26.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__26, Config.GetConfigFile(Settings.CONFIG.ASSIST_MAX_COUNT, currentMode)));
			Control control9 = this.triggerDelay;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__29 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__29 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target15 = bagulhotensodaquebradaloko264812.<>o__70.<>p__29.Target;
			CallSite <>p__15 = bagulhotensodaquebradaloko264812.<>o__70.<>p__29;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__28 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__28 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control9.Text = target15(<>p__15, bagulhotensodaquebradaloko264812.<>o__70.<>p__28.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__28, Config.GetConfigFile(Settings.CONFIG.TRIGGER_DELAY, currentMode)));
			Control appleFOVX = this.AppleFOVX;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__31 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__31 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target16 = bagulhotensodaquebradaloko264812.<>o__70.<>p__31.Target;
			CallSite <>p__16 = bagulhotensodaquebradaloko264812.<>o__70.<>p__31;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__30 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__30 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			appleFOVX.Text = target16(<>p__16, bagulhotensodaquebradaloko264812.<>o__70.<>p__30.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__30, Config.GetConfigFile(Settings.CONFIG.TRIGGER_FOVX, currentMode)));
			Control appleFOVY = this.AppleFOVY;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__33 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__33 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target17 = bagulhotensodaquebradaloko264812.<>o__70.<>p__33.Target;
			CallSite <>p__17 = bagulhotensodaquebradaloko264812.<>o__70.<>p__33;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__32 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__32 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			appleFOVY.Text = target17(<>p__17, bagulhotensodaquebradaloko264812.<>o__70.<>p__32.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__32, Config.GetConfigFile(Settings.CONFIG.TRIGGER_FOVY, currentMode)));
			Control control10 = this.flickFovX;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__35 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__35 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target18 = bagulhotensodaquebradaloko264812.<>o__70.<>p__35.Target;
			CallSite <>p__18 = bagulhotensodaquebradaloko264812.<>o__70.<>p__35;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__34 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__34 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control10.Text = target18(<>p__18, bagulhotensodaquebradaloko264812.<>o__70.<>p__34.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__34, Config.GetConfigFile(Settings.CONFIG.FLICK_FOV_X, currentMode)));
			Control control11 = this.flickFovY;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__37 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__37 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target19 = bagulhotensodaquebradaloko264812.<>o__70.<>p__37.Target;
			CallSite <>p__19 = bagulhotensodaquebradaloko264812.<>o__70.<>p__37;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__36 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__36 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control11.Text = target19(<>p__19, bagulhotensodaquebradaloko264812.<>o__70.<>p__36.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__36, Config.GetConfigFile(Settings.CONFIG.FLICK_FOV_Y, currentMode)));
			Control control12 = this.flickHO;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__39 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__39 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target20 = bagulhotensodaquebradaloko264812.<>o__70.<>p__39.Target;
			CallSite <>p__20 = bagulhotensodaquebradaloko264812.<>o__70.<>p__39;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__38 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__38 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control12.Text = target20(<>p__20, bagulhotensodaquebradaloko264812.<>o__70.<>p__38.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__38, Config.GetConfigFile(Settings.CONFIG.FLICK_HEADSHOT_OFFSET, currentMode)));
			Control control13 = this.followTime;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__41 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__41 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target21 = bagulhotensodaquebradaloko264812.<>o__70.<>p__41.Target;
			CallSite <>p__21 = bagulhotensodaquebradaloko264812.<>o__70.<>p__41;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__40 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__40 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control13.Text = target21(<>p__21, bagulhotensodaquebradaloko264812.<>o__70.<>p__40.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__40, Config.GetConfigFile(Settings.CONFIG.FLICK_FOLLOW_TIME, currentMode)));
			Control control14 = this.rcsSpeed;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__43 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__43 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target22 = bagulhotensodaquebradaloko264812.<>o__70.<>p__43.Target;
			CallSite <>p__22 = bagulhotensodaquebradaloko264812.<>o__70.<>p__43;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__42 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__42 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control14.Text = target22(<>p__22, bagulhotensodaquebradaloko264812.<>o__70.<>p__42.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__42, Config.GetConfigFile(Settings.CONFIG.RCS_SPEED, currentMode)));
			Control control15 = this.jitter;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__45 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__45 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target23 = bagulhotensodaquebradaloko264812.<>o__70.<>p__45.Target;
			CallSite <>p__23 = bagulhotensodaquebradaloko264812.<>o__70.<>p__45;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__44 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__44 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control15.Text = target23(<>p__23, bagulhotensodaquebradaloko264812.<>o__70.<>p__44.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__44, Config.GetConfigFile(Settings.CONFIG.AIMBOT_JITTER, currentMode)));
			Control control16 = this.ingameSens;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__47 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__47 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target24 = bagulhotensodaquebradaloko264812.<>o__70.<>p__47.Target;
			CallSite <>p__24 = bagulhotensodaquebradaloko264812.<>o__70.<>p__47;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__46 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__46 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control16.Text = target24(<>p__24, bagulhotensodaquebradaloko264812.<>o__70.<>p__46.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__46, Config.GetConfigFile(Settings.CONFIG.AIMBOT_SENS, currentMode)));
			Control control17 = this.flickJitter;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__49 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__49 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target25 = bagulhotensodaquebradaloko264812.<>o__70.<>p__49.Target;
			CallSite <>p__25 = bagulhotensodaquebradaloko264812.<>o__70.<>p__49;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__48 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__48 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control17.Text = target25(<>p__25, bagulhotensodaquebradaloko264812.<>o__70.<>p__48.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__48, Config.GetConfigFile(Settings.CONFIG.FLICK_JITTER, currentMode)));
			Control control18 = this.flickSens;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__51 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__51 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target26 = bagulhotensodaquebradaloko264812.<>o__70.<>p__51.Target;
			CallSite <>p__26 = bagulhotensodaquebradaloko264812.<>o__70.<>p__51;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__50 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__50 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control18.Text = target26(<>p__26, bagulhotensodaquebradaloko264812.<>o__70.<>p__50.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__50, Config.GetConfigFile(Settings.CONFIG.FLICK_SENS, currentMode)));
			Control control19 = this.assistJitter;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__53 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__53 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target27 = bagulhotensodaquebradaloko264812.<>o__70.<>p__53.Target;
			CallSite <>p__27 = bagulhotensodaquebradaloko264812.<>o__70.<>p__53;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__52 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__52 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control19.Text = target27(<>p__27, bagulhotensodaquebradaloko264812.<>o__70.<>p__52.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__52, Config.GetConfigFile(Settings.CONFIG.ASSIST_JITTER, currentMode)));
			Control control20 = this.assistSens;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__55 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__55 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, string> target28 = bagulhotensodaquebradaloko264812.<>o__70.<>p__55.Target;
			CallSite <>p__28 = bagulhotensodaquebradaloko264812.<>o__70.<>p__55;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__54 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__54 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control20.Text = target28(<>p__28, bagulhotensodaquebradaloko264812.<>o__70.<>p__54.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__54, Config.GetConfigFile(Settings.CONFIG.ASSIST_SENS, currentMode)));
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__57 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__57 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(bagulhotensodaquebradaloko264812)));
			}
			Func<CallSite, object, int> target29 = bagulhotensodaquebradaloko264812.<>o__70.<>p__57.Target;
			CallSite <>p__29 = bagulhotensodaquebradaloko264812.<>o__70.<>p__57;
			if (bagulhotensodaquebradaloko264812.<>o__70.<>p__56 == null)
			{
				bagulhotensodaquebradaloko264812.<>o__70.<>p__56 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(bagulhotensodaquebradaloko264812), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num = target29(<>p__29, bagulhotensodaquebradaloko264812.<>o__70.<>p__56.Target(bagulhotensodaquebradaloko264812.<>o__70.<>p__56, typeof(Convert), Config.GetConfigFile(Settings.CONFIG.CHEAT_MONITOR, currentMode)));
			if (Screen.AllScreens.Length >= num)
			{
				this.metroSetComboBox2.SelectedIndex = num;
				PixelSearcher.monitor = num;
			}
			else
			{
				PixelSearcher.monitor = 0;
			}
			this.currentModeCombo.SelectedIndex = currentMode;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002520 File Offset: 0x00000720
		private void label30_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000A418 File Offset: 0x00008618
		public void UpdateAimbotConfig()
		{
			Config.SetConfig(Settings.CONFIG.AIMBOT_FOV_X, Config.currentMode, this.fovXField.Text.ToString());
			Config.SetConfig(Settings.CONFIG.AIMBOT_FOV_Y, Config.currentMode, this.fovYField.Text.ToString());
			Config.SetConfig(Settings.CONFIG.AIMBOT_HEADSHOT_OFFSET, Config.currentMode, this.headshotOffsetField.Text.ToString());
			Config.SetConfig(Settings.CONFIG.AIMBOT_JITTER, Config.currentMode, this.jitter.Text.ToString());
			Config.SetConfig(Settings.CONFIG.AIMBOT_SENS, Config.currentMode, this.ingameSens.Text.ToString());
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000A4B0 File Offset: 0x000086B0
		private void updateButton_Click(object sender, EventArgs e)
		{
			this.UpdateAimbotConfig();
			this.UpdateRecoilConfig();
			Config.SetConfig(Settings.CONFIG.ASSIST_FOV_X, Config.currentMode, this.BlueBerryFOVXField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_FOV_Y, Config.currentMode, this.BlueBerryFOVYField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_HEADSHOT_OFFSET, Config.currentMode, this.headshotOffsetField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_MAX_COUNT, Config.currentMode, this.BlueBerryMaxCountField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_JITTER, Config.currentMode, this.assistJitter.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_SENS, Config.currentMode, this.assistSens.Text);
			Config.SetConfig(Settings.CONFIG.TRIGGER_DELAY, Config.currentMode, this.triggerDelay.Text);
			Config.SetConfig(Settings.CONFIG.TRIGGER_FOVX, Config.currentMode, this.AppleFOVX.Text);
			Config.SetConfig(Settings.CONFIG.TRIGGER_FOVY, Config.currentMode, this.AppleFOVY.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_FOV_X, Config.currentMode, this.flickFovX.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_FOV_Y, Config.currentMode, this.flickFovY.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_HEADSHOT_OFFSET, Config.currentMode, this.flickHO.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_JITTER, Config.currentMode, this.flickJitter.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_SENS, Config.currentMode, this.flickSens.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_FOLLOW_TIME, Config.currentMode, this.followTime.Text);
			this.UpdateResolutionConfig();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000A628 File Offset: 0x00008828
		private void metroSetSwitch2_SwitchedChanged(object sender)
		{
			try
			{
				if (!bagulhotensodaquebradaloko264812._leonardo.leonardoOpened)
				{
					bagulhotensodaquebradaloko264812.WriteDebugMessage("[Aimbot] Der Aimbot kann ohne den ausgewählten leonardo nicht gestartet werden");
				}
				else
				{
					Config.AimbotStatus = !Config.AimbotStatus;
					if (bagulhotensodaquebradaloko264812._debug)
					{
						bagulhotensodaquebradaloko264812.WriteDebugMessage("[Aimbot] Aimbot wurde " + (Config.AimbotStatus ? "aktiviert" : "deaktiviert"));
					}
					if (this.metroSetSwitch2.Switched)
					{
						this.AimOff.Text = "ON";
						this.AimOff.ForeColor = Color.White;
					}
					else if (!this.metroSetSwitch2.Switched)
					{
						this.AimOff.Text = "OFF";
						this.AimOff.ForeColor = Color.Red;
					}
				}
			}
			catch
			{
				MessageBox.Show("Selecione a porta do seu arduino antes de ativar o Aimbot!", "Galaxy Arduino");
				Environment.Exit(0);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000256F File Offset: 0x0000076F
		public static void WriteDebugMessage(string msg)
		{
			bagulhotensodaquebradaloko264812._debugWindow.AddDebugLine(msg);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A710 File Offset: 0x00008910
		private void MainScreen_Move(object sender, EventArgs e)
		{
			if (bagulhotensodaquebradaloko264812._debugWindow != null && bagulhotensodaquebradaloko264812._debugWindow.Enabled)
			{
				bagulhotensodaquebradaloko264812._debugWindow.Location = new Point(base.Location.X + 460, base.Location.Y);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000A764 File Offset: 0x00008964
		private void leonardoPorts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (bagulhotensodaquebradaloko264812._debug)
			{
				string str = "[leonardo] Port wurde zu ";
				object selectedItem = this.leonardoPorts.SelectedItem;
				bagulhotensodaquebradaloko264812.WriteDebugMessage(str + ((selectedItem != null) ? selectedItem.ToString() : null) + " gewechselt");
			}
			bagulhotensodaquebradaloko264812._leonardo = new leonardo(this.leonardoPorts.SelectedItem.ToString());
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A7C0 File Offset: 0x000089C0
		private void metroSetSwitch3_SwitchedChanged(object sender)
		{
			Config.SHITRECStatus = !Config.SHITRECStatus;
			if (this.metroSetSwitch3.Switched)
			{
				this.label30.Text = "ON";
				this.label30.ForeColor = Color.White;
				return;
			}
			if (!this.metroSetSwitch3.Switched)
			{
				this.label30.Text = "OFF";
				this.label30.ForeColor = Color.Red;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000257C File Offset: 0x0000077C
		private void currentModeCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdateCurrentMode(Config.currentMode = this.currentModeCombo.SelectedIndex);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A838 File Offset: 0x00008A38
		public void UpdateCurrentMode(int id)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				this.currentModeCombo.SelectedIndex = id;
			}));
			base.Invoke(new MethodInvoker(delegate()
			{
				this.LoadConfigInFields(id);
			}));
			this.UpdateAimbotConfig();
			this.UpdateResolutionConfig();
			this.UpdateRecoilConfig();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002595 File Offset: 0x00000795
		private void HotKeySystem()
		{
			new Thread(delegate()
			{
				for (;;)
				{
					if (bagulhotensodaquebradaloko264812.GetAsyncKeyState(112) == 0)
					{
						if (bagulhotensodaquebradaloko264812.GetAsyncKeyState(113) != 0)
						{
							if (Config.currentMode == 1)
							{
								continue;
							}
							Config.currentMode = 1;
							Console.Beep(1000, 100);
							this.UpdateCurrentMode(1);
						}
						else if (bagulhotensodaquebradaloko264812.GetAsyncKeyState(114) != 0)
						{
							if (Config.currentMode == 2)
							{
								continue;
							}
							Config.currentMode = 2;
							Console.Beep(1500, 100);
							this.UpdateCurrentMode(2);
						}
						else if (bagulhotensodaquebradaloko264812.GetAsyncKeyState(35) != 0 && Config.AppleStatus)
						{
							if (Config.TriggerAimbot)
							{
								Console.Beep(2500, 100);
								Console.Beep(1000, 100);
								base.Invoke(new MethodInvoker(delegate()
								{
									this.metroSetSwitch6.Switched = false;
								}));
							}
							else
							{
								Console.Beep(1000, 100);
								Console.Beep(2500, 100);
								base.Invoke(new MethodInvoker(delegate()
								{
									this.metroSetSwitch6.Switched = true;
								}));
							}
						}
						else if (bagulhotensodaquebradaloko264812.GetAsyncKeyState(46) != 0)
						{
							if (Config.AppleStatus)
							{
								Console.Beep(2500, 100);
								Console.Beep(1000, 100);
								base.Invoke(new MethodInvoker(delegate()
								{
									this.AppleSwitch.Switched = false;
								}));
							}
							else
							{
								Console.Beep(1000, 100);
								Console.Beep(2500, 100);
								base.Invoke(new MethodInvoker(delegate()
								{
									this.AppleSwitch.Switched = true;
								}));
							}
						}
					}
					else
					{
						if (Config.currentMode == 0)
						{
							continue;
						}
						Config.currentMode = 0;
						Console.Beep(800, 100);
						this.UpdateCurrentMode(0);
					}
					Thread.Sleep(150);
				}
			}).Start();
		}

		// Token: 0x060000B8 RID: 184
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x060000B9 RID: 185 RVA: 0x000025AD File Offset: 0x000007AD
		private void updateRecoil_Click(object sender, EventArgs e)
		{
			this.UpdateRecoilConfig();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A894 File Offset: 0x00008A94
		public void UpdateRecoilConfig()
		{
			Config.SetConfig(Settings.CONFIG.RCS_MULTIPLIER, Config.currentMode, this.recoilMultiplierField.Text);
			Config.SetConfig(Settings.CONFIG.RCS_MAX_RECOIL, Config.currentMode, this.maxRecoilField.Text);
			Config.SetConfig(Settings.CONFIG.RCS_HOLDINGTIME, Config.currentMode, this.holdingTimeBox.Text);
			Config.SetConfig(Settings.CONFIG.RCS_SPEED, Config.currentMode, this.rcsSpeed.Text);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000A8FC File Offset: 0x00008AFC
		private void BlueBerryUpdate_Click(object sender, EventArgs e)
		{
			Config.SetConfig(Settings.CONFIG.ASSIST_FOV_X, Config.currentMode, this.BlueBerryFOVXField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_FOV_Y, Config.currentMode, this.BlueBerryFOVYField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_HEADSHOT_OFFSET, Config.currentMode, this.BlueBerryHSOffsetField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_MAX_COUNT, Config.currentMode, this.BlueBerryMaxCountField.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_JITTER, Config.currentMode, this.assistJitter.Text);
			Config.SetConfig(Settings.CONFIG.ASSIST_SENS, Config.currentMode, this.assistSens.Text);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000A994 File Offset: 0x00008B94
		private void BlueBerrySwitch_SwitchedChanged(object sender)
		{
			Config.BlueBerryStatus = !Config.BlueBerryStatus;
			if (this.BlueBerrySwitch.Switched)
			{
				this.label32.Text = "ON";
				this.label32.ForeColor = Color.White;
				return;
			}
			if (!this.BlueBerrySwitch.Switched)
			{
				this.label32.Text = "OFF";
				this.label32.ForeColor = Color.Red;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000AA0C File Offset: 0x00008C0C
		private void AppleSwitch_SwitchedChanged(object sender)
		{
			Config.AppleStatus = this.AppleSwitch.Switched;
			if (this.AppleSwitch.Switched)
			{
				this.triglabel.Text = "ON";
				this.triglabel.ForeColor = Color.White;
				return;
			}
			if (!this.AppleSwitch.Switched)
			{
				this.triglabel.Text = "OFF";
				this.triglabel.ForeColor = Color.Red;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000AA84 File Offset: 0x00008C84
		private void metroSetButton1_Click(object sender, EventArgs e)
		{
			Config.SetConfig(Settings.CONFIG.TRIGGER_DELAY, Config.currentMode, this.triggerDelay.Text);
			Config.SetConfig(Settings.CONFIG.TRIGGER_FOVX, Config.currentMode, this.AppleFOVX.Text);
			Config.SetConfig(Settings.CONFIG.TRIGGER_FOVY, Config.currentMode, this.AppleFOVY.Text);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private void metroSetButton2_Click(object sender, EventArgs e)
		{
			Config.SetConfig(Settings.CONFIG.FLICK_FOV_X, Config.currentMode, this.flickFovX.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_FOV_Y, Config.currentMode, this.flickFovY.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_HEADSHOT_OFFSET, Config.currentMode, this.flickHO.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_JITTER, Config.currentMode, this.flickJitter.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_SENS, Config.currentMode, this.flickSens.Text);
			Config.SetConfig(Settings.CONFIG.FLICK_FOLLOW_TIME, Config.currentMode, this.followTime.Text);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000025B5 File Offset: 0x000007B5
		public void UpdateResolutionConfig()
		{
			Config.SetConfig(Settings.CONFIG.CHEAT_RESOLUTION_X, Config.currentMode, this.resolutionXField.Text);
			Config.SetConfig(Settings.CONFIG.CHEAT_RESOLUTION_Y, Config.currentMode, this.resolutionYField.Text);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000025E5 File Offset: 0x000007E5
		private void UpdateRes_Click(object sender, EventArgs e)
		{
			this.UpdateResolutionConfig();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000025ED File Offset: 0x000007ED
		private void metroSetComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			PixelSearcher.monitor = this.metroSetComboBox2.SelectedIndex;
			Config.SetConfig(Settings.CONFIG.CHEAT_MONITOR, Config.currentMode, this.metroSetComboBox2.SelectedIndex);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002520 File Offset: 0x00000720
		private void label27_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002520 File Offset: 0x00000720
		private void label25_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000AB70 File Offset: 0x00008D70
		private void metroSetSwitch6_SwitchedChanged(object sender)
		{
			Config.TriggerAimbot = this.metroSetSwitch6.Switched;
			if (this.metroSetSwitch6.Switched)
			{
				this.flicktext.Text = "ON";
				this.flicktext.ForeColor = Color.White;
				return;
			}
			if (!this.metroSetSwitch6.Switched)
			{
				this.flicktext.Text = "OFF";
				this.flicktext.ForeColor = Color.Red;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002520 File Offset: 0x00000720
		private void metroSetControlBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000261B File Offset: 0x0000081B
		private void label19_Click_1(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized != base.WindowState)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000024B5 File Offset: 0x000006B5
		private void label20_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002520 File Offset: 0x00000720
		private void AimOff_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002520 File Offset: 0x00000720
		private void label30_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002520 File Offset: 0x00000720
		private void label33_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		private void metroSetSwitch1_SwitchedChanged(object sender)
		{
			if (this.metroSetSwitch1.Switched)
			{
				Config.purple = true;
				Config.yellow = false;
				this.label34.Text = "Purple";
				this.label34.ForeColor = Color.DarkViolet;
				return;
			}
			Config.yellow = true;
			Config.purple = false;
			this.label34.Text = "Yellow";
			this.label34.ForeColor = Color.Yellow;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002520 File Offset: 0x00000720
		private void label34_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000AC5C File Offset: 0x00008E5C
		private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.CONFIG conf = Settings.CONFIG.TRIGGER_HOTKEY;
			object val = this.metroSetComboBox1.SelectedIndex.ToString();
			Config.SetConfig(conf, Config.currentMode, val);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002520 File Offset: 0x00000720
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002520 File Offset: 0x00000720
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002520 File Offset: 0x00000720
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002520 File Offset: 0x00000720
		private void resolutionXField_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002520 File Offset: 0x00000720
		private void label36_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002520 File Offset: 0x00000720
		private void usuario_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002520 File Offset: 0x00000720
		private void label36_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002520 File Offset: 0x00000720
		private void Galaxy_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002520 File Offset: 0x00000720
		private void HideButton_CheckedChanged(object sender)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000262C File Offset: 0x0000082C
		private void Galaxy_Click(object sender, EventArgs e)
		{
			base.ShowInTaskbar = true;
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002520 File Offset: 0x00000720
		private void headshotOffsetField_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002520 File Offset: 0x00000720
		private void ingameSens_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002520 File Offset: 0x00000720
		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002520 File Offset: 0x00000720
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002520 File Offset: 0x00000720
		private void Name_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002520 File Offset: 0x00000720
		private void metroSetSwitch5_SwitchedChanged(object sender)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002518 File Offset: 0x00000718
		private void bagulhotensodaquebradaloko264812_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002520 File Offset: 0x00000720
		private void label36_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002520 File Offset: 0x00000720
		private void label37_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002520 File Offset: 0x00000720
		private void BlueBerryHSOffsetField_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002520 File Offset: 0x00000720
		private void label32_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000045 RID: 69
		public static bool _debug;

		// Token: 0x04000046 RID: 70
		private static DebugWindow _debugWindow;

		// Token: 0x04000047 RID: 71
		public static leonardo _leonardo;

		// Token: 0x04000048 RID: 72
		private StyleManager styleManager1;

		// Token: 0x04000049 RID: 73
		private MetroSetComboBox leonardoPorts;

		// Token: 0x0400004A RID: 74
		private MetroSetComboBox AimbotKeyCombo;

		// Token: 0x0400004B RID: 75
		private MetroSetSwitch metroSetSwitch2;

		// Token: 0x0400004C RID: 76
		private MetroSetSwitch metroSetSwitch3;

		// Token: 0x0400004D RID: 77
		private MetroSetButton updateButton;

		// Token: 0x0400004E RID: 78
		private MetroSetSwitch BlueBerrySwitch;

		// Token: 0x0400004F RID: 79
		private MetroSetSwitch AppleSwitch;

		// Token: 0x04000050 RID: 80
		private MetroSetComboBox metroSetComboBox1;

		// Token: 0x04000051 RID: 81
		private MetroSetComboBox metroSetComboBox2;

		// Token: 0x04000052 RID: 82
		private MetroSetSwitch metroSetSwitch6;

		// Token: 0x04000053 RID: 83
		private Label label20;

		// Token: 0x04000054 RID: 84
		private Label label19;

		// Token: 0x04000055 RID: 85
		private Label AimOff;

		// Token: 0x04000056 RID: 86
		private Label label30;

		// Token: 0x04000057 RID: 87
		private Label label32;

		// Token: 0x04000058 RID: 88
		private Label triglabel;

		// Token: 0x04000059 RID: 89
		private Label flicktext;

		// Token: 0x0400005A RID: 90
		private MetroSetSwitch metroSetSwitch1;

		// Token: 0x0400005B RID: 91
		private Label label34;

		// Token: 0x0400005C RID: 92
		private MetroSetComboBox currentModeCombo;

		// Token: 0x0400005D RID: 93
		private IContainer components;

		// Token: 0x0400005E RID: 94
		private MetroSetButton UpdateRes;

		// Token: 0x0400005F RID: 95
		private MetroSetButton metroSetButton2;

		// Token: 0x04000060 RID: 96
		private MetroSetButton BlueBerryUpdate;

		// Token: 0x04000061 RID: 97
		private MetroSetButton metroSetButton1;

		// Token: 0x04000062 RID: 98
		private Label label37;

		// Token: 0x04000063 RID: 99
		private Label label36;

		// Token: 0x04000064 RID: 100
		private TextBox flickHO;

		// Token: 0x04000065 RID: 101
		private TextBox flickJitter;

		// Token: 0x04000066 RID: 102
		private TextBox followTime;

		// Token: 0x04000067 RID: 103
		private TextBox flickFovY;

		// Token: 0x04000068 RID: 104
		private TextBox flickSens;

		// Token: 0x04000069 RID: 105
		private TextBox AppleFOVX;

		// Token: 0x0400006A RID: 106
		private TextBox triggerDelay;

		// Token: 0x0400006B RID: 107
		private TextBox flickFovX;

		// Token: 0x0400006C RID: 108
		private TextBox resolutionYField;

		// Token: 0x0400006D RID: 109
		private TextBox resolutionXField;

		// Token: 0x0400006E RID: 110
		private TextBox BlueBerryHSOffsetField;

		// Token: 0x0400006F RID: 111
		private TextBox assistSens;

		// Token: 0x04000070 RID: 112
		private TextBox BlueBerryMaxCountField;

		// Token: 0x04000071 RID: 113
		private TextBox assistJitter;

		// Token: 0x04000072 RID: 114
		private TextBox AppleFOVY;

		// Token: 0x04000073 RID: 115
		private TextBox rcsSpeed;

		// Token: 0x04000074 RID: 116
		private TextBox BlueBerryFOVYField;

		// Token: 0x04000075 RID: 117
		private TextBox BlueBerryFOVXField;

		// Token: 0x04000076 RID: 118
		private TextBox holdingTimeBox;

		// Token: 0x04000077 RID: 119
		private TextBox recoilMultiplierField;

		// Token: 0x04000078 RID: 120
		private TextBox maxRecoilField;

		// Token: 0x04000079 RID: 121
		private TextBox fovXField;

		// Token: 0x0400007A RID: 122
		private TextBox headshotOffsetField;

		// Token: 0x0400007B RID: 123
		private TextBox jitter;

		// Token: 0x0400007C RID: 124
		private TextBox ingameSens;

		// Token: 0x0400007D RID: 125
		private TextBox fovYField;

		// Token: 0x0400007E RID: 126
		private NotifyIcon notifyIcon1;
	}
}
