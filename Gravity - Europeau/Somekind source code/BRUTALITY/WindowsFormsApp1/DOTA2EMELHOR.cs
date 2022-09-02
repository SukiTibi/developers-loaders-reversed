using System;
using System.Windows.Forms;
using KeyAuth;

namespace WindowsFormsApp1
{
	// Token: 0x02000002 RID: 2
	internal static class DOTA2EMELHOR
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000207B File Offset: 0x0000027B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
