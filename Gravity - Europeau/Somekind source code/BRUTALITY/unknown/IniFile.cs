using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace unknown
{
	// Token: 0x0200001E RID: 30
	public class IniFile
	{
		// Token: 0x0600011D RID: 285
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x0600011E RID: 286
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x0600011F RID: 287 RVA: 0x000027AC File Offset: 0x000009AC
		public IniFile(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + ".ini")).FullName;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		public string Read(string Key, string Section = null)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", stringBuilder, 255, this.Path);
			return stringBuilder.ToString();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000027E4 File Offset: 0x000009E4
		public void Write(string Key, string Value, string Section = null)
		{
			IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000027FF File Offset: 0x000009FF
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002814 File Offset: 0x00000A14
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002829 File Offset: 0x00000A29
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x040000EB RID: 235
		private string Path;

		// Token: 0x040000EC RID: 236
		private string EXE = "Config";
	}
}
