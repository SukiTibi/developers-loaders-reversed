using System;
using System.Diagnostics;

// Token: 0x02000002 RID: 2
internal static class Sandboxie
{
	// Token: 0x06000002 RID: 2 RVA: 0x00003674 File Offset: 0x00001874
	private static IntPtr GetModuleHandle(string libName)
	{
		foreach (object obj in Process.GetCurrentProcess().Modules)
		{
			ProcessModule processModule = (ProcessModule)obj;
			if (processModule.ModuleName.ToLower().Contains(libName.ToLower()))
			{
				return processModule.BaseAddress;
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000210F File Offset: 0x0000030F
	internal static bool IsSandboxie()
	{
		return Sandboxie.GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
	}
}
