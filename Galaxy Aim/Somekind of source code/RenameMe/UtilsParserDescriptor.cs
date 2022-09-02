using System;
using System.Runtime.CompilerServices;

namespace RenameMe
{
	// Token: 0x0200001C RID: 28
	public class UtilsParserDescriptor
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000022B2 File Offset: 0x000004B2
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022BA File Offset: 0x000004BA
		public ParamExceptionID.CancelStub config { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000022C3 File Offset: 0x000004C3
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022CB File Offset: 0x000004CB
		[Dynamic]
		public dynamic value { [return: Dynamic] get; [param: Dynamic] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000022D4 File Offset: 0x000004D4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022DC File Offset: 0x000004DC
		public int mode { get; set; }
	}
}
