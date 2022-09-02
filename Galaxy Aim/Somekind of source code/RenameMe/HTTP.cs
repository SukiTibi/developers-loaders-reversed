using System;
using System.Collections.Specialized;
using System.Net;

namespace RenameMe
{
	// Token: 0x02000034 RID: 52
	internal class HTTP
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00005A94 File Offset: 0x00003C94
		public static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.UploadValues(uri, pairs);
			}
			return result;
		}
	}
}
