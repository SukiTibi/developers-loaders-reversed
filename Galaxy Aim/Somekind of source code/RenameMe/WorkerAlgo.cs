using System;
using System.Text;

namespace RenameMe
{
	// Token: 0x02000033 RID: 51
	public class WorkerAlgo
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00002498 File Offset: 0x00000698
		public int RandomNumber(int min, int max)
		{
			return this._random.Next(min, max);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000059EC File Offset: 0x00003BEC
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

		// Token: 0x060000A9 RID: 169 RVA: 0x00005A48 File Offset: 0x00003C48
		public string RandomPassword()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.RandomString(4, true));
			stringBuilder.Append(this.RandomNumber(1000, 9999));
			stringBuilder.Append(this.RandomString(2, false));
			return stringBuilder.ToString();
		}

		// Token: 0x0400032F RID: 815
		private readonly Random _random = new Random();
	}
}
