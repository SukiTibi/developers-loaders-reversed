using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace RenameMe
{
	// Token: 0x0200001E RID: 30
	public class ClientDatabase
	{
		// Token: 0x06000050 RID: 80
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x06000051 RID: 81
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x06000052 RID: 82 RVA: 0x000022E5 File Offset: 0x000004E5
		public ClientDatabase(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + ".ini")).FullName;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004C00 File Offset: 0x00002E00
		public string Read(string Key, string Section = null)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			ClientDatabase.GetPrivateProfileString(Section ?? this.EXE, Key, "", stringBuilder, 255, this.Path);
			return stringBuilder.ToString();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000231D File Offset: 0x0000051D
		public void Write(string Key, string Value, string Section = null)
		{
			ClientDatabase.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002338 File Offset: 0x00000538
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000234D File Offset: 0x0000054D
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002362 File Offset: 0x00000562
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x040002A3 RID: 675
		private string Path;

		// Token: 0x040002A4 RID: 676
		private string EXE = "Config";
	}
}
