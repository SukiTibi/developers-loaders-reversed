using System;
using System.Runtime.InteropServices;

namespace RenameMe
{
	// Token: 0x02000025 RID: 37
	internal class CDD
	{
		// Token: 0x06000067 RID: 103
		[DllImport("Kernel32")]
		private static extern IntPtr LoadLibrary(string dllfile);

		// Token: 0x06000068 RID: 104
		[DllImport("Kernel32")]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000069 RID: 105
		[DllImport("kernel32.dll")]
		public static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x0600006A RID: 106 RVA: 0x00005070 File Offset: 0x00003270
		~CDD()
		{
			if (!this.m_hinst.Equals(IntPtr.Zero))
			{
				CDD.FreeLibrary(this.m_hinst);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000239B File Offset: 0x0000059B
		public int Load(string dllfile)
		{
			this.m_hinst = CDD.LoadLibrary(dllfile);
			if (this.m_hinst.Equals(IntPtr.Zero))
			{
				return -2;
			}
			return this.GetDDfunAddress(this.m_hinst);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000050BC File Offset: 0x000032BC
		private int GetDDfunAddress(IntPtr hinst)
		{
			IntPtr procAddress = CDD.GetProcAddress(hinst, "DD_btn");
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			this.btn = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_btn)) as CDD.pDD_btn);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_whl");
			this.whl = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_whl)) as CDD.pDD_whl);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_mov");
			this.mov = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_mov)) as CDD.pDD_mov);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_key");
			this.key = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_key)) as CDD.pDD_key);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_movR");
			this.movR = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_movR)) as CDD.pDD_movR);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_str");
			this.str = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_str)) as CDD.pDD_str);
			if (procAddress.Equals(IntPtr.Zero))
			{
				return -1;
			}
			procAddress = CDD.GetProcAddress(hinst, "DD_todc");
			return 1;
		}

		// Token: 0x040002C5 RID: 709
		public CDD.pDD_btn btn;

		// Token: 0x040002C6 RID: 710
		public CDD.pDD_whl whl;

		// Token: 0x040002C7 RID: 711
		public CDD.pDD_mov mov;

		// Token: 0x040002C8 RID: 712
		public CDD.pDD_movR movR;

		// Token: 0x040002C9 RID: 713
		public CDD.pDD_key key;

		// Token: 0x040002CA RID: 714
		public CDD.pDD_str str;

		// Token: 0x040002CB RID: 715
		private IntPtr m_hinst;

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600006F RID: 111
		public delegate int pDD_btn(int btn);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000073 RID: 115
		public delegate int pDD_whl(int whl);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000077 RID: 119
		public delegate int pDD_key(int ddcode, int flag);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600007B RID: 123
		public delegate int pDD_mov(int x, int y);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600007F RID: 127
		public delegate int pDD_movR(int dx, int dy);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000083 RID: 131
		public delegate int pDD_str(string str);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000087 RID: 135
		public delegate int pDD_todc(int vkcode);
	}
}
