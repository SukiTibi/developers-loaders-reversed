using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.CSharp.RuntimeBinder;
using RenameMe.Properties;
using RenameMe.UserControls;

namespace RenameMe
{
	// Token: 0x02000043 RID: 67
	public partial class GalaStore : Form
	{
		// Token: 0x06000153 RID: 339
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000154 RID: 340
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000155 RID: 341
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

		// Token: 0x06000156 RID: 342
		[DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

		// Token: 0x06000157 RID: 343
		[DllImport("USER32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		// Token: 0x06000158 RID: 344
		[DllImport("gdi32.dll")]
		private static extern bool BitBlt(IntPtr hdcDest, int nxDest, int nyDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

		// Token: 0x06000159 RID: 345
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int width, int nHeight);

		// Token: 0x0600015A RID: 346
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// Token: 0x0600015B RID: 347
		[DllImport("gdi32.dll")]
		private static extern IntPtr DeleteDC(IntPtr hdc);

		// Token: 0x0600015C RID: 348
		[DllImport("gdi32.dll")]
		private static extern IntPtr DeleteObject(IntPtr hObject);

		// Token: 0x0600015D RID: 349
		[DllImport("user32.dll")]
		private static extern IntPtr GetDesktopWindow();

		// Token: 0x0600015E RID: 350
		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowDC(IntPtr hWnd);

		// Token: 0x0600015F RID: 351
		[DllImport("user32.dll")]
		private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

		// Token: 0x06000160 RID: 352
		[DllImport("gdi32.dll")]
		private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

		// Token: 0x06000161 RID: 353
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x06000162 RID: 354 RVA: 0x00007EBC File Offset: 0x000060BC
		public static void arduinoauto()
		{
			string[] portNames = SerialPort.GetPortNames();
			for (int i = 0; i < portNames.Length; i++)
			{
				try
				{
					if (!(portNames[i] == "COM1"))
					{
						GalaStore.port = new SerialPort(portNames[i], 14400, Parity.None, 8, StopBits.One);
						GalaStore.port.Open();
						if (GalaStore.port.IsOpen)
						{
							GalaStore.IsConnected = true;
							break;
						}
					}
				}
				catch
				{
					MessageBox.Show("Arduino not found", "ERROR");
				}
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002943 File Offset: 0x00000B43
		public GalaStore()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002951 File Offset: 0x00000B51
		public static void ArduMove(int x, int y)
		{
			GalaStore.port.Write(x.ToString() + ";" + y.ToString() + ";0");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000297A File Offset: 0x00000B7A
		internal static void smethod_15(string string_0)
		{
			File.AppendAllText(string_0, string.Format("[{0}] {1}\n", DateTime.Now, string_0));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007F48 File Offset: 0x00006148
		internal static bool smethod_77()
		{
			if (Dns.GetHostAddresses("Galxy")[0].ToString() == "666")
			{
				return true;
			}
			GalaStore.smethod_15("Erro no Handshake! Entre em contato com o suporte da Galaxy.");
			GalaStore.smethod_15("Por favor delete seu arquivos de hosts. Você encontra ele aqui: C:\\Windows\\System32\\drivers\\etc\\hosts");
			string arguments = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Galaxy\\Log";
			Process.Start("notepad.exe", arguments);
			return false;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007FA8 File Offset: 0x000061A8
		private static bool is_colora(Color ada)
		{
			if (config.color == "Purple")
			{
				if (ada.G >= 190)
				{
					return false;
				}
				if (ada.G >= 140)
				{
					return ada.R - ada.B <= 8 && ada.R - ada.G >= 50 && ada.B - ada.G >= 50 && ada.R >= 105 && ada.B >= 105;
				}
				return ada.R - ada.B <= 13 && ada.R - ada.G >= 60 && ada.B - ada.G >= 60 && ada.R >= 110 && ada.B >= 100;
			}
			else
			{
				if (config.color == "Red")
				{
					Color color = Color.FromArgb(255, 0, 0);
					Color color2 = Color.FromArgb(255, 126, 129);
					return color.R <= ada.R && ada.R <= color2.R && color.G <= ada.G && ada.G <= color2.G && color.B <= ada.B && ada.B <= color2.B;
				}
				if (config.color == "Yellow")
				{
					return ada.R >= 200 && (ada.G > 200 && ada.G < byte.MaxValue && ada.B > 0) && ada.B < 100;
				}
				if (ada.R < 235)
				{
					return false;
				}
				if (ada.R > 245)
				{
					return Math.Abs((int)(ada.R - ada.B)) <= 8 && ada.R - ada.G >= 50 && ada.B - ada.G >= 50 && ada.R >= 105 && ada.B >= 105;
				}
				return Math.Abs((int)(ada.R - ada.B)) <= 80 && ada.R - ada.G >= 125 && ada.B - ada.G >= 60 && ada.R >= 145 && ada.B >= 87;
			}
		}

		// Token: 0x06000168 RID: 360
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000169 RID: 361
		[DllImport("user32.dll")]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		// Token: 0x0600016A RID: 362 RVA: 0x00008254 File Offset: 0x00006454
		private static string GetActiveWindowTitle()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (GalaStore.GetWindowText(GalaStore.GetForegroundWindow(), stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002997 File Offset: 0x00000B97
		private static void pixelsearchaim()
		{
			/*
An exception occurred when decompiling this method (0600016B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void RenameMe.GalaStore::pixelsearchaim()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008288 File Offset: 0x00006488
		private static void asdasdsadasda()
		{
			if (GalaStore.<>o__62.<>p__1 == null)
			{
				GalaStore.<>o__62.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
			}
			Func<CallSite, object, int> target = GalaStore.<>o__62.<>p__1.Target;
			CallSite <>p__ = GalaStore.<>o__62.<>p__1;
			if (GalaStore.<>o__62.<>p__0 == null)
			{
				GalaStore.<>o__62.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, GalaStore.<>o__62.<>p__0.Target(GalaStore.<>o__62.<>p__0, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.SilentKey, BroadCastWrite.currentMode)));
			for (;;)
			{
				Thread.Sleep(10);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000834C File Offset: 0x0000654C
		private static void vsavsavavsa()
		{
			if (GalaStore.<>o__63.<>p__1 == null)
			{
				GalaStore.<>o__63.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
			}
			Func<CallSite, object, int> target = GalaStore.<>o__63.<>p__1.Target;
			CallSite <>p__ = GalaStore.<>o__63.<>p__1;
			if (GalaStore.<>o__63.<>p__0 == null)
			{
				GalaStore.<>o__63.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, GalaStore.<>o__63.<>p__0.Target(GalaStore.<>o__63.<>p__0, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.FlickKey, BroadCastWrite.currentMode)));
			for (;;)
			{
				Thread.Sleep(10);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000029C3 File Offset: 0x00000BC3
		public static int AntiDebuggerProtect()
		{
			GalaStore.dd.Load(GalaStore.local);
			GalaStore.dd.btn(9884625);
			return 1;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000029EF File Offset: 0x00000BEF
		private static void asdasdsad()
		{
			for (;;)
			{
				Thread.Sleep(1);
				if (false)
				{
					config.checkautofire = false;
					GalaStore.mouse_event(6U, 0U, 0U, 0U, 0U);
					Thread.Sleep(config.shot_speed * 3);
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008410 File Offset: 0x00006610
		private static void adsadaD()
		{
			try
			{
				int fov_x = config.fov_x;
				int fov_y = config.fov_y;
				Bitmap bitmap = GalaStore.screen_shot(new Rectangle(config.screenWidth / 2 - fov_x / 2 + config.uwux, config.screenHeight / 2 - fov_y / 2 - config.extras + config.uwuy, fov_x, fov_y));
				if (GalaStore.<>o__70.<>p__1 == null)
				{
					GalaStore.<>o__70.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
				}
				Func<CallSite, object, int> target = GalaStore.<>o__70.<>p__1.Target;
				CallSite <>p__ = GalaStore.<>o__70.<>p__1;
				if (GalaStore.<>o__70.<>p__0 == null)
				{
					GalaStore.<>o__70.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num = target(<>p__, GalaStore.<>o__70.<>p__0.Target(GalaStore.<>o__70.<>p__0, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.Aimkey, BroadCastWrite.currentMode)));
				if (GalaStore.<>o__70.<>p__3 == null)
				{
					GalaStore.<>o__70.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
				}
				Func<CallSite, object, int> target2 = GalaStore.<>o__70.<>p__3.Target;
				CallSite <>p__2 = GalaStore.<>o__70.<>p__3;
				if (GalaStore.<>o__70.<>p__2 == null)
				{
					GalaStore.<>o__70.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target2(<>p__2, GalaStore.<>o__70.<>p__2.Target(GalaStore.<>o__70.<>p__2, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.FlickKey, BroadCastWrite.currentMode)));
				if (GalaStore.<>o__70.<>p__5 == null)
				{
					GalaStore.<>o__70.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
				}
				Func<CallSite, object, int> target3 = GalaStore.<>o__70.<>p__5.Target;
				CallSite <>p__3 = GalaStore.<>o__70.<>p__5;
				if (GalaStore.<>o__70.<>p__4 == null)
				{
					GalaStore.<>o__70.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target3(<>p__3, GalaStore.<>o__70.<>p__4.Target(GalaStore.<>o__70.<>p__4, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.SilentKey, BroadCastWrite.currentMode)));
				if (GalaStore.<>o__70.<>p__7 == null)
				{
					GalaStore.<>o__70.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
				}
				Func<CallSite, object, int> target4 = GalaStore.<>o__70.<>p__7.Target;
				CallSite <>p__4 = GalaStore.<>o__70.<>p__7;
				if (GalaStore.<>o__70.<>p__6 == null)
				{
					GalaStore.<>o__70.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target4(<>p__4, GalaStore.<>o__70.<>p__6.Target(GalaStore.<>o__70.<>p__6, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.TriggerKey, BroadCastWrite.currentMode)));
				for (int i = 1; i < fov_y; i++)
				{
					for (int j = 1; j < fov_x; j++)
					{
						if (GalaStore.is_colora(bitmap.GetPixel(j, i)))
						{
							j = GalaStore.adsada(j, i, bitmap);
							double num2;
							if (config.smooth_state)
							{
								num2 = config.smooth;
							}
							else
							{
								num2 = 0.4;
							}
							if (GalaStore.GetAsyncKeyState(GalaStore.RedDotKey[num]) != 0)
							{
								if (config.auto_fire_state && Math.Sqrt(Math.Pow((double)(config.screenWidth / 2 - (config.screenWidth / 2 - fov_x / 2 + j)), 2.0) + Math.Pow((double)(config.screenHeight / 2 - (config.screenHeight / 2 - fov_y / 2 + i)), 2.0)) < 5.0)
								{
									config.checkautofire = true;
								}
								if (config.aim_only_on_x_state)
								{
									GalaStore.dd.movR((int)Convert.ToInt16((double)(j - fov_x / 2) * config.sensitivity_x * num2), 0);
								}
								else
								{
									GalaStore.dd.movR((int)Convert.ToInt16((double)(j - fov_x / 2) * config.sensitivity_x * num2), (int)Convert.ToInt16((double)(i - fov_y / 2) * config.sensitivity_y * num2));
								}
							}
							return;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000887C File Offset: 0x00006A7C
		private static bool check_variant(Color ada, Color uwu, int variant)
		{
			return (int)ada.R + variant > (int)uwu.R && (int)ada.R - variant < (int)uwu.R && (int)ada.G + variant > (int)uwu.G && (int)ada.G - variant < (int)uwu.G && (int)ada.B + variant > (int)uwu.B && (int)ada.B - variant < (int)uwu.B;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000088F8 File Offset: 0x00006AF8
		private static int adsada(int x, int y, Bitmap objec)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 25;
			int num4 = x - 10;
			int num5 = y - 3;
			for (int i = 0; i < 5; i++)
			{
				num4 = x - 10;
				for (int j = 0; j < 15; j++)
				{
					try
					{
						if (GalaStore.is_colora(objec.GetPixel(num4 + j, num5 + i)))
						{
							num += num4 + j;
							num2++;
							if (num2 >= num3)
							{
								return num / num2;
							}
						}
					}
					catch (Exception)
					{
						break;
					}
				}
			}
			if (num2 != 0)
			{
				return num / num2;
			}
			return x;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000898C File Offset: 0x00006B8C
		private static void trig()
		{
			int[] array = new int[]
			{
				1,
				2,
				4,
				5,
				6,
				16,
				18,
				17,
				20,
				86
			};
			if (GalaStore.<>o__73.<>p__1 == null)
			{
				GalaStore.<>o__73.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(GalaStore)));
			}
			Func<CallSite, object, int> target = GalaStore.<>o__73.<>p__1.Target;
			CallSite <>p__ = GalaStore.<>o__73.<>p__1;
			if (GalaStore.<>o__73.<>p__0 == null)
			{
				GalaStore.<>o__73.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(GalaStore), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num = target(<>p__, GalaStore.<>o__73.<>p__0.Target(GalaStore.<>o__73.<>p__0, typeof(Convert), BroadCastWrite.GetConfig(ParamExceptionID.CancelStub.TriggerKey, BroadCastWrite.currentMode)));
			for (;;)
			{
				if (config.triggerbot_state && GalaStore.GetAsyncKeyState(array[num]) > 1)
				{
					if (config.trigger_force_hs_state)
					{
						GalaStore.aaaaa();
					}
					else
					{
						GalaStore.aaaa();
					}
				}
				Thread.Sleep(3);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008A84 File Offset: 0x00006C84
		private static void aaaaa()
		{
			int num = 50;
			int num2 = 50;
			try
			{
				Bitmap bitmap = GalaStore.screen_shot(new Rectangle(config.screenWidth / 2 - num / 2 + config.uwux, config.screenHeight / 2 - num2 / 2 - config.extras + config.uwuy, num, num2));
				for (int i = 1; i < num2; i++)
				{
					for (int j = 1; j < num; j++)
					{
						if (GalaStore.is_colora(bitmap.GetPixel(j, i)))
						{
							j = GalaStore.adsada(j, i, bitmap);
							if (Math.Sqrt(Math.Pow((double)(config.screenWidth / 2 - (config.screenWidth / 2 - num / 2 + j)), 2.0) + Math.Pow((double)(config.screenHeight / 2 - (config.screenHeight / 2 - num2 / 2 + i)), 2.0)) < 5.0)
							{
								GalaStore.dd.btn(1);
								GalaStore.dd.btn(2);
								Thread.Sleep(config.trigger_speed * 3);
								return;
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008BC0 File Offset: 0x00006DC0
		private static void aaaa()
		{
			int num = 8;
			int num2 = 8;
			try
			{
				Bitmap bitmap = GalaStore.screen_shot(new Rectangle(config.screenWidth / 2 - num2 / 2, config.screenHeight / 2 - num / 2, num2, num));
				for (int i = 1; i < num; i++)
				{
					for (int j = 1; j < num2; j++)
					{
						if (GalaStore.is_colora(bitmap.GetPixel(j, i)))
						{
							GalaStore.dd.btn(1);
							GalaStore.dd.btn(2);
							Thread.Sleep(config.trigger_speed * 3);
							return;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008C68 File Offset: 0x00006E68
		private static void ada()
		{
			bool flag = false;
			bool flag2 = false;
			DateTime now = DateTime.Now;
			config.max_recoil = 45;
			config.recoilspeed = 1.5;
			for (;;)
			{
				Thread.Sleep(1);
				if (config.bodypartcheckboxselectiontruefalse && config.recoil_system_state && GalaStore.GetAsyncKeyState(1) > 0 && !flag && !flag2)
				{
					flag = true;
					now = DateTime.Now;
				}
				else if (config.bodypartcheckboxselectiontruefalse && config.recoil_system_state && GalaStore.GetAsyncKeyState(1) > 0 && ((flag && !flag2) || (!flag && flag2)))
				{
					double totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
					config.extras = (int)Convert.ToInt16((double)config.max_recoil * ((double)config.screenHeight / 1080.0) * (totalMilliseconds / 1080.0) * config.recoilspeed);
					if (config.extras > config.max_recoil)
					{
						config.extras = config.max_recoil;
					}
					flag = false;
					flag2 = true;
				}
				else
				{
					flag = false;
					flag2 = false;
					config.extras = 0;
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008D5C File Offset: 0x00006F5C
		private void getscreensiz()
		{
			for (;;)
			{
				config.screenWidth = Screen.PrimaryScreen.Bounds.Width;
				config.screenHeight = Screen.PrimaryScreen.Bounds.Height;
				config.sensitivity_x = 1.0 / config.sens / ((double)config.screenWidth / 1920.0) * 1.05;
				config.sensitivity_y = 1.0 / config.sens / ((double)config.screenHeight / 1080.0) * 1.05;
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002A17 File Offset: 0x00000C17
		private static void checkactivewindow()
		{
			for (;;)
			{
				if (config.aimbot_state_checkbox)
				{
					if (GalaStore.GetActiveWindowTitle() == "VALORANT  ")
					{
						config.aimbot_state = true;
					}
					else
					{
						config.aimbot_state = false;
					}
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008E04 File Offset: 0x00007004
		public static Bitmap screen_shot(Rectangle region)
		{
			IntPtr desktopWindow = GalaStore.GetDesktopWindow();
			IntPtr windowDC = GalaStore.GetWindowDC(desktopWindow);
			IntPtr intPtr = GalaStore.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = GalaStore.CreateCompatibleBitmap(windowDC, region.Width, region.Height);
			IntPtr hObject = GalaStore.SelectObject(intPtr, intPtr2);
			bool flag = GalaStore.BitBlt(intPtr, 0, 0, region.Width, region.Height, windowDC, region.Left, region.Top, 1087111200);
			Bitmap result;
			try
			{
				if (!flag)
				{
					throw new Win32Exception();
				}
				result = Image.FromHbitmap(intPtr2);
			}
			finally
			{
				GalaStore.SelectObject(intPtr, hObject);
				GalaStore.DeleteObject(intPtr2);
				GalaStore.DeleteDC(intPtr);
				GalaStore.ReleaseDC(desktopWindow, windowDC);
			}
			return result;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002A47 File Offset: 0x00000C47
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[GalaStore.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008EB8 File Offset: 0x000070B8
		private void Main_Form_Load(object sender, EventArgs e)
		{
			new WebClient();
			if (TheBest.KeyAuthApp.checkblack())
			{
				MemoryImporter.FindPattern();
				MemoryImporter.HexValueCalculator();
				MemoryImporter.BinaryConstPagePool();
				Environment.Exit(0);
			}
			byte[] bytes = TheBest.KeyAuthApp.download("729630");
			File.WriteAllBytes(GalaStore.local, bytes);
			string text = this.tempo.Text;
			WebClient webClient = new WebClient();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text2 = webClient.DownloadString("http://51.79.86.198/illusion/api/info.php?hwid=" + value);
			this.tempo.Text = text2;
			int num = Convert.ToInt32(text2);
			if (num >= 1000)
			{
				this.tempo.Text = "Lifetime";
			}
			else if (num <= 999)
			{
				this.tempo.Text = text2;
			}
			else if (num < 1)
			{
				this.tempo.Text = text2;
			}
			if (GalaStore.userloginn == string.Empty)
			{
				new TheBest
				{
					Enabled = true
				}.ShowDialog();
				base.Close();
				base.Dispose();
			}
			this.usuario.Text = GalaStore.userloginn;
			TheBest.KeyAuthApp.log("LOGIN: " + GalaStore.userloginn + " HWID: " + value);
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				currentProcess.PriorityClass = ProcessPriorityClass.RealTime;
			}
			string text3 = new WebClient().DownloadString("http://51.79.86.198/illusion/api/info.php?hwid=" + value);
			this.tempo.Text = text3;
			this.Text = GalaStore.RandomString(15);
			config.screenWidth = Screen.PrimaryScreen.Bounds.Width;
			config.screenHeight = Screen.PrimaryScreen.Bounds.Height;
			config.silent_active = true;
			config.flick_active = true;
			config.aimbot_state_checkbox = true;
			config.smooth_state = true;
			config.bone1_state = true;
			config.bodypartcheckboxselectiontruefalse = true;
			Thread thread = new Thread(new ThreadStart(GalaStore.pixelsearchaim));
			Thread thread2 = new Thread(new ThreadStart(GalaStore.asdasdsad));
			Thread thread3 = new Thread(new ThreadStart(GalaStore.ada));
			Thread thread4 = new Thread(new ThreadStart(this.getscreensiz));
			Thread thread5 = new Thread(new ThreadStart(GalaStore.checkactivewindow));
			Thread thread6 = new Thread(new ThreadStart(GalaStore.trig));
			new Thread(new ThreadStart(GalaStore.sadasda)).Start();
			thread4.Start();
			thread6.Start();
			thread5.Start();
			thread3.Start();
			thread2.Start();
			thread.Start();
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Show();
			this.userControl11.BringToFront();
			GalaStore.dd = new CDD();
			GalaStore.AntiDebuggerProtect();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000248E File Offset: 0x0000068E
		public static void sadasda()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002A82 File Offset: 0x00000C82
		private void Button_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Show();
			this.userControl11.BringToFront();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002AB0 File Offset: 0x00000CB0
		private void Button2_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl11.Hide();
			this.userControl31.Hide();
			this.userControl21.Show();
			this.userControl21.BringToFront();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002ADE File Offset: 0x00000CDE
		private void Button3_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl11.Hide();
			this.userControl31.Show();
			this.userControl31.BringToFront();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002B0C File Offset: 0x00000D0C
		private void Button4_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Hide();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002B2F File Offset: 0x00000D2F
		private void Button5_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000917C File Offset: 0x0000737C
		private void Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.Grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002B47 File Offset: 0x00000D47
		private void Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000917C File Offset: 0x0000737C
		private void Icon2_Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.Grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002B47 File Offset: 0x00000D47
		private void Icon2_Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000091C8 File Offset: 0x000073C8
		private void Icon2_Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000917C File Offset: 0x0000737C
		private void Icon_Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.Grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002B47 File Offset: 0x00000D47
		private void Icon_Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000091C8 File Offset: 0x000073C8
		private void Icon_Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000917C File Offset: 0x0000737C
		private void Label_Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.Grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002B47 File Offset: 0x00000D47
		private void Label_Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000091C8 File Offset: 0x000073C8
		private void Label_Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002B5E File Offset: 0x00000D5E
		private void Button_Top_Panel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
			Application.Exit();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000028C7 File Offset: 0x00000AC7
		private void Button2_Top_Panel_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000248E File Offset: 0x0000068E
		private void Top_Panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000287D File Offset: 0x00000A7D
		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000248E File Offset: 0x0000068E
		private void userControl51_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000248E File Offset: 0x0000068E
		private void Button_Panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000248E File Offset: 0x0000068E
		private void userControl11_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000248E File Offset: 0x0000068E
		private void Icon_Top_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000248E File Offset: 0x0000068E
		private void userControl31_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000248E File Offset: 0x0000068E
		private void Picture_Button_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000248E File Offset: 0x0000068E
		private void Label_Top_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000248E File Offset: 0x0000068E
		private void userControl41_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000248E File Offset: 0x0000068E
		private void Icon2_Top_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000248E File Offset: 0x0000068E
		private void User_Panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000248E File Offset: 0x0000068E
		private void Icon_User_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000248E File Offset: 0x0000068E
		private void Label2_Top_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000248E File Offset: 0x0000068E
		private void userControl21_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000248E File Offset: 0x0000068E
		private void Picture_Top_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000248E File Offset: 0x0000068E
		private void Label_User_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002B0C File Offset: 0x00000D0C
		private void Button4_Button_Panel_Click_1(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Hide();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002B6B File Offset: 0x00000D6B
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				GalaStore.ReleaseCapture();
				GalaStore.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002B0C File Offset: 0x00000D0C
		private void button1_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Hide();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000248E File Offset: 0x0000068E
		private void tempo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002AB0 File Offset: 0x00000CB0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.userControl11.Hide();
			this.userControl31.Hide();
			this.userControl21.Show();
			this.userControl21.BringToFront();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002ADE File Offset: 0x00000CDE
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl11.Hide();
			this.userControl31.Show();
			this.userControl31.BringToFront();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002A82 File Offset: 0x00000C82
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Show();
			this.userControl11.BringToFront();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000248E File Offset: 0x0000068E
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000248E File Offset: 0x0000068E
		private void usuario_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000248E File Offset: 0x0000068E
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000248E File Offset: 0x0000068E
		private void pictureBox5_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002B93 File Offset: 0x00000D93
		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			this.tempo.Visible = false;
			this.label1.Visible = false;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002BAD File Offset: 0x00000DAD
		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			this.infosopen = true;
			this.tempo.Visible = true;
			this.label1.Visible = true;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002BCE File Offset: 0x00000DCE
		private void metroToggle1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroToggle1.Checked)
			{
				GalaStore.SetWindowDisplayAffinity(base.Handle, 17U);
				return;
			}
			if (!this.metroToggle1.Checked)
			{
				GalaStore.SetWindowDisplayAffinity(base.Handle, 0U);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000091C8 File Offset: 0x000073C8
		private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x0400037F RID: 895
		private MetroTrackBar metroTrackBar1;

		// Token: 0x04000380 RID: 896
		private MetroTrackBar metroTrackBar2;

		// Token: 0x04000381 RID: 897
		private MetroTrackBar metroTrackBar3;

		// Token: 0x04000382 RID: 898
		private MetroTrackBar metroTrackBar4;

		// Token: 0x04000383 RID: 899
		private MetroTrackBar metroTrackBar5;

		// Token: 0x04000384 RID: 900
		private MetroTrackBar metroTrackBar6;

		// Token: 0x04000385 RID: 901
		private MetroTrackBar metroTrackBar7;

		// Token: 0x04000386 RID: 902
		private MetroTrackBar metroTrackBar8;

		// Token: 0x04000387 RID: 903
		private MetroTrackBar metroTrackBar9;

		// Token: 0x04000388 RID: 904
		private MetroTrackBar metroTrackBar10;

		// Token: 0x04000389 RID: 905
		private MetroTrackBar metroTrackBar11;

		// Token: 0x0400038A RID: 906
		private MetroTrackBar metroTrackBar12;

		// Token: 0x0400038B RID: 907
		private MetroTrackBar metroTrackBar13;

		// Token: 0x0400038C RID: 908
		private UserControl UserControl1;

		// Token: 0x0400038D RID: 909
		private UserControl UserControl2;

		// Token: 0x0400038E RID: 910
		private UserControl UserControl3;

		// Token: 0x0400038F RID: 911
		private UserControl UserControl4;

		// Token: 0x04000390 RID: 912
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000391 RID: 913
		public const int HT_CAPTION = 2;

		// Token: 0x04000392 RID: 914
		private const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x04000393 RID: 915
		private const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x04000394 RID: 916
		private const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x04000395 RID: 917
		private const int MOUSEEVENTF_RIGHTUP = 16;

		// Token: 0x04000396 RID: 918
		public static string local = "C:\\ProgramData\\Riot Games\\Metadata\\Riot Client\\Riot Client.dll";

		// Token: 0x04000397 RID: 919
		public static string key = "60803690be6682d97ec3d12a8753ecb137986a3f4b5aefa8f540a8592b73355561a50cf4883ce9e51a7646127864847660a8c60d7f7c1f5cad76f66e5ed78db69426495118cadf15de8e4769413f";

		// Token: 0x04000398 RID: 920
		private const int SRCCOPY = 13369376;

		// Token: 0x04000399 RID: 921
		private static int[] RedDotKey = new int[]
		{
			1,
			2,
			4,
			5,
			6,
			16,
			18,
			17,
			20,
			86
		};

		// Token: 0x0400039A RID: 922
		private const int CAPTUREBLT = 1073741824;

		// Token: 0x0400039B RID: 923
		public static string string_3;

		// Token: 0x0400039C RID: 924
		public static string string_6;

		// Token: 0x0400039D RID: 925
		private static SerialPort port;

		// Token: 0x0400039E RID: 926
		public static bool IsConnected;

		// Token: 0x0400039F RID: 927
		public static List<Color> myList = new List<Color>();

		// Token: 0x040003A0 RID: 928
		private static List<Color> myListdefault = new List<Color>();

		// Token: 0x040003A1 RID: 929
		private static double sens = 0.4;

		// Token: 0x040003A2 RID: 930
		private static double sensitivity_x = 1.0 / GalaStore.sens / ((double)config.screenWidth / 1920.0) * 1.08;

		// Token: 0x040003A3 RID: 931
		private static double sensitivity_y = 1.0 / GalaStore.sens / ((double)config.screenHeight / 1080.0) * 1.08;

		// Token: 0x040003A4 RID: 932
		private static CDD dd;

		// Token: 0x040003A5 RID: 933
		private static DateTime asda = DateTime.Now;

		// Token: 0x040003A6 RID: 934
		private const double size = 60.0;

		// Token: 0x040003A7 RID: 935
		private const int maxCount = 5;

		// Token: 0x040003A8 RID: 936
		private static Random random = new Random();

		// Token: 0x040003A9 RID: 937
		public static string userloginn = string.Empty;

		// Token: 0x040003AA RID: 938
		private bool Grip;

		// Token: 0x040003AB RID: 939
		private int MouseX;

		// Token: 0x040003AC RID: 940
		private int MouseY;

		// Token: 0x040003AD RID: 941
		private bool infosopen;
	}
}
