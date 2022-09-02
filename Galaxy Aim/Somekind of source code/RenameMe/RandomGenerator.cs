using System;
using System.Text;

namespace RenameMe
{
	// Token: 0x02000030 RID: 48
	public class RandomGenerator
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000246C File Offset: 0x0000066C
		public int RandomNumber(int min, int max)
		{
			return this._random.Next(min, max);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005944 File Offset: 0x00003B44
		public string RandomString(int size, bool lowerCase = false)
		{
			StringBuilder stringBuilder = new StringBuilder(size);
			char c = lowerCase ? 'a' : 'A';
			for (int i = 0; i < size; i++)
			{
				char value = (char)this._random.Next((int)c, (int)(c + '\u001a'));
				stringBuilder.Append(value);
			}
			if (!lowerCase)
			{
				return stringBuilder.ToString();
			}
			return stringBuilder.ToString().ToLower();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000059A0 File Offset: 0x00003BA0
		public string RandomPassword()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.RandomString(4, true));
			stringBuilder.Append(this.RandomNumber(1000, 9999));
			stringBuilder.Append(this.RandomString(2, false));
			return stringBuilder.ToString();
		}

		// Token: 0x0400032D RID: 813
		private readonly Random _random = new Random();
	}
}
