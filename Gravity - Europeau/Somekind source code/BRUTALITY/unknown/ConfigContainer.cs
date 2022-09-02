using System;
using System.Runtime.CompilerServices;

namespace unknown
{
	// Token: 0x02000019 RID: 25
	public class ConfigContainer
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000026DF File Offset: 0x000008DF
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000026E7 File Offset: 0x000008E7
		public Settings.CONFIG config { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000026F0 File Offset: 0x000008F0
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000026F8 File Offset: 0x000008F8
		[Dynamic]
		public dynamic value { [return: Dynamic] get; [param: Dynamic] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002701 File Offset: 0x00000901
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002709 File Offset: 0x00000909
		public int mode { get; set; }
	}
}
