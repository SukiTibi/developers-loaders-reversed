using System;

namespace unknown
{
	// Token: 0x0200001F RID: 31
	public static class IntUtil
	{
		// Token: 0x06000125 RID: 293 RVA: 0x0000283B File Offset: 0x00000A3B
		private static void Init()
		{
			if (IntUtil.random == null)
			{
				IntUtil.random = new Random();
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000284E File Offset: 0x00000A4E
		public static int Random(int min, int max)
		{
			IntUtil.Init();
			return IntUtil.random.Next(min, max);
		}

		// Token: 0x040000ED RID: 237
		private static Random random;
	}
}
