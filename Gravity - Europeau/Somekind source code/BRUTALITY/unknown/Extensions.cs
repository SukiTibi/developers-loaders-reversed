using System;

namespace unknown
{
	// Token: 0x0200001C RID: 28
	public static class Extensions
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		public static bool IsNumeric(this string s)
		{
			float num;
			return float.TryParse(s, out num);
		}
	}
}
