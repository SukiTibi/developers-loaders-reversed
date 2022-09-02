using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RenameMe.Properties
{
	// Token: 0x02000055 RID: 85
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000035DC File Offset: 0x000017DC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000035E3 File Offset: 0x000017E3
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000035F5 File Offset: 0x000017F5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00003603 File Offset: 0x00001803
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003615 File Offset: 0x00001815
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00003623 File Offset: 0x00001823
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00003635 File Offset: 0x00001835
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Usernamedbg
		{
			get
			{
				return (string)this["Usernamedbg"];
			}
			set
			{
				this["Usernamedbg"] = value;
			}
		}

		// Token: 0x04000478 RID: 1144
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
