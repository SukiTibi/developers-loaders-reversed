using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RenameMe
{
	// Token: 0x0200004B RID: 75
	internal static class FileToString
	{
		// Token: 0x060001CE RID: 462
		[DllImport("kernel32.dll")]
		public static extern IntPtr LoadLibrary(string dllToLoad);

		// Token: 0x060001CF RID: 463
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

		// Token: 0x060001D0 RID: 464 RVA: 0x0000BD38 File Offset: 0x00009F38
		[STAThread]
		private static void Main()
		{
			MemoryImporter.FoundAllocateMemoryBase();
			IntPtr hModule = FileToString.LoadLibrary("kernel32.dll");
			IntPtr procAddress = FileToString.GetProcAddress(hModule, "IsDebuggerPresent");
			byte[] array = new byte[1];
			Marshal.Copy(procAddress, array, 0, 1);
			if (array[0] == 233)
			{
				Environment.Exit(0);
				Process.GetCurrentProcess().Kill();
				File.Create("a??|\\\\????@@1!:").Close();
			}
			IntPtr procAddress2 = FileToString.GetProcAddress(hModule, "CheckRemoteDebuggerPresent");
			array = new byte[1];
			Marshal.Copy(procAddress2, array, 0, 1);
			if (array[0] == 233)
			{
				Environment.Exit(0);
				Process.GetCurrentProcess().Kill();
				File.Create("a??|\\\\????@@1!:").Close();
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TheBest());
		}
	}
}
