using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace RenameMe
{
	// Token: 0x0200004C RID: 76
	internal class IniFile
	{
		// Token: 0x060001D1 RID: 465
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x060001D2 RID: 466
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x060001D3 RID: 467 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		public IniFile(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + ".ini")).FullName;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000BE40 File Offset: 0x0000A040
		public string Read(string Key, string Section = null)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", stringBuilder, 255, this.Path);
			return stringBuilder.ToString();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002D28 File Offset: 0x00000F28
		public void Write(string Key, string Value, string Section = null)
		{
			IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002D43 File Offset: 0x00000F43
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002D58 File Offset: 0x00000F58
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002D6D File Offset: 0x00000F6D
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x040003DA RID: 986
		private string Path;

		// Token: 0x040003DB RID: 987
		private string EXE = Assembly.GetExecutingAssembly().GetName().Name;
	}
}
