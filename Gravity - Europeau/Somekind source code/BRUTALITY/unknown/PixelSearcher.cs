using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace unknown
{
	// Token: 0x02000021 RID: 33
	public class PixelSearcher
	{
		// Token: 0x0600012A RID: 298
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x0600012B RID: 299 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public PixelSearcher()
		{
			new Thread(delegate()
			{
				for (;;)
				{
					if (Config.AppleStatus)
					{
						if (PixelSearcher.<>o__11.<>p__1 == null)
						{
							PixelSearcher.<>o__11.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
						}
						Func<CallSite, object, int> target = PixelSearcher.<>o__11.<>p__1.Target;
						CallSite <>p__ = PixelSearcher.<>o__11.<>p__1;
						if (PixelSearcher.<>o__11.<>p__0 == null)
						{
							PixelSearcher.<>o__11.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						int num = target(<>p__, PixelSearcher.<>o__11.<>p__0.Target(PixelSearcher.<>o__11.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.TRIGGER_HOTKEY, Config.currentMode)));
						if (PixelSearcher.GetAsyncKeyState(PixelSearcher.RedDotKey[num]) != 0)
						{
							if (!PixelSearcher.holdingTriggerKey)
							{
								PixelSearcher.holdingTriggerKey = true;
							}
						}
						else if (PixelSearcher.holdingTriggerKey)
						{
							PixelSearcher.holdingTriggerKey = false;
							this.followTimer = 0;
						}
						if (Config.AppleStatus)
						{
							if (Config.TriggerAimbot && PixelSearcher.GetAsyncKeyState(PixelSearcher.RedDotKey[num]) != 0)
							{
								this.FlickBot();
							}
							if (PixelSearcher.GetAsyncKeyState(PixelSearcher.RedDotKey[num]) != 0)
							{
								this.TriggerBot();
							}
						}
					}
					Thread.Sleep(1);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					if (Config.SHITRECStatus)
					{
						this.NewRecoilSystem();
					}
					Thread.Sleep(1);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					if (PixelSearcher.<>o__11.<>p__3 == null)
					{
						PixelSearcher.<>o__11.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target = PixelSearcher.<>o__11.<>p__3.Target;
					CallSite <>p__ = PixelSearcher.<>o__11.<>p__3;
					if (PixelSearcher.<>o__11.<>p__2 == null)
					{
						PixelSearcher.<>o__11.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int screenWidth = target(<>p__, PixelSearcher.<>o__11.<>p__2.Target(PixelSearcher.<>o__11.<>p__2, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_X, Config.currentMode)));
					if (PixelSearcher.<>o__11.<>p__5 == null)
					{
						PixelSearcher.<>o__11.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target2 = PixelSearcher.<>o__11.<>p__5.Target;
					CallSite <>p__2 = PixelSearcher.<>o__11.<>p__5;
					if (PixelSearcher.<>o__11.<>p__4 == null)
					{
						PixelSearcher.<>o__11.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int screenHeight = target2(<>p__2, PixelSearcher.<>o__11.<>p__4.Target(PixelSearcher.<>o__11.<>p__4, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_Y, Config.currentMode)));
					if (PixelSearcher.<>o__11.<>p__7 == null)
					{
						PixelSearcher.<>o__11.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target3 = PixelSearcher.<>o__11.<>p__7.Target;
					CallSite <>p__3 = PixelSearcher.<>o__11.<>p__7;
					if (PixelSearcher.<>o__11.<>p__6 == null)
					{
						PixelSearcher.<>o__11.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num = target3(<>p__3, PixelSearcher.<>o__11.<>p__6.Target(PixelSearcher.<>o__11.<>p__6, typeof(Convert), Config.GetConfig(Settings.CONFIG.TRIGGER_HOTKEY, Config.currentMode)));
					if (Config.BlueBerryStatus && PixelSearcher.GetAsyncKeyState(PixelSearcher.RedDotKey[num]) == 0)
					{
						this.AimAssist(screenWidth, screenHeight);
					}
					Thread.Sleep(1);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					if (PixelSearcher.<>o__11.<>p__9 == null)
					{
						PixelSearcher.<>o__11.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target = PixelSearcher.<>o__11.<>p__9.Target;
					CallSite <>p__ = PixelSearcher.<>o__11.<>p__9;
					if (PixelSearcher.<>o__11.<>p__8 == null)
					{
						PixelSearcher.<>o__11.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int screenWidth = target(<>p__, PixelSearcher.<>o__11.<>p__8.Target(PixelSearcher.<>o__11.<>p__8, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_X, Config.currentMode)));
					if (PixelSearcher.<>o__11.<>p__11 == null)
					{
						PixelSearcher.<>o__11.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target2 = PixelSearcher.<>o__11.<>p__11.Target;
					CallSite <>p__2 = PixelSearcher.<>o__11.<>p__11;
					if (PixelSearcher.<>o__11.<>p__10 == null)
					{
						PixelSearcher.<>o__11.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int screenHeight = target2(<>p__2, PixelSearcher.<>o__11.<>p__10.Target(PixelSearcher.<>o__11.<>p__10, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_Y, Config.currentMode)));
					if (PixelSearcher.<>o__11.<>p__13 == null)
					{
						PixelSearcher.<>o__11.<>p__13 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target3 = PixelSearcher.<>o__11.<>p__13.Target;
					CallSite <>p__3 = PixelSearcher.<>o__11.<>p__13;
					if (PixelSearcher.<>o__11.<>p__12 == null)
					{
						PixelSearcher.<>o__11.<>p__12 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num = target3(<>p__3, PixelSearcher.<>o__11.<>p__12.Target(PixelSearcher.<>o__11.<>p__12, typeof(Convert), Config.GetConfig(Settings.CONFIG.AIMBOT_HOTKEY, Config.currentMode)));
					if (PixelSearcher.GetAsyncKeyState(PixelSearcher.RedDotKey[num]) != 0)
					{
						this.Aimbot(screenWidth, screenHeight);
					}
					else if (PixelSearcher.currentBHAOffset != -999f)
					{
						PixelSearcher.currentBHAOffset = -999f;
					}
					Thread.Sleep(1);
				}
			}).Start();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000C444 File Offset: 0x0000A644
		private void TriggerBot()
		{
			if (Config.AppleStatus)
			{
				if (PixelSearcher.<>o__12.<>p__1 == null)
				{
					PixelSearcher.<>o__12.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target = PixelSearcher.<>o__12.<>p__1.Target;
				CallSite <>p__ = PixelSearcher.<>o__12.<>p__1;
				if (PixelSearcher.<>o__12.<>p__0 == null)
				{
					PixelSearcher.<>o__12.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num = target(<>p__, PixelSearcher.<>o__12.<>p__0.Target(PixelSearcher.<>o__12.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_X, Config.currentMode)));
				if (PixelSearcher.<>o__12.<>p__3 == null)
				{
					PixelSearcher.<>o__12.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target2 = PixelSearcher.<>o__12.<>p__3.Target;
				CallSite <>p__2 = PixelSearcher.<>o__12.<>p__3;
				if (PixelSearcher.<>o__12.<>p__2 == null)
				{
					PixelSearcher.<>o__12.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num2 = target2(<>p__2, PixelSearcher.<>o__12.<>p__2.Target(PixelSearcher.<>o__12.<>p__2, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_Y, Config.currentMode)));
				if (PixelSearcher.<>o__12.<>p__5 == null)
				{
					PixelSearcher.<>o__12.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target3 = PixelSearcher.<>o__12.<>p__5.Target;
				CallSite <>p__3 = PixelSearcher.<>o__12.<>p__5;
				if (PixelSearcher.<>o__12.<>p__4 == null)
				{
					PixelSearcher.<>o__12.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num3 = target3(<>p__3, PixelSearcher.<>o__12.<>p__4.Target(PixelSearcher.<>o__12.<>p__4, typeof(Convert), Config.GetConfig(Settings.CONFIG.TRIGGER_FOVX, Config.currentMode)));
				if (PixelSearcher.<>o__12.<>p__7 == null)
				{
					PixelSearcher.<>o__12.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target4 = PixelSearcher.<>o__12.<>p__7.Target;
				CallSite <>p__4 = PixelSearcher.<>o__12.<>p__7;
				if (PixelSearcher.<>o__12.<>p__6 == null)
				{
					PixelSearcher.<>o__12.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num4 = target4(<>p__4, PixelSearcher.<>o__12.<>p__6.Target(PixelSearcher.<>o__12.<>p__6, typeof(Convert), Config.GetConfig(Settings.CONFIG.TRIGGER_FOVY, Config.currentMode)));
				Point[] result = this.PixelSearch(new Rectangle((num - num4) / 2, (num2 - num3) / 2, num4, num3)).GetAwaiter().GetResult();
				if (result != null && result.Length != 0)
				{
					this.ArduinoAdsMove(0, 0, true);
				}
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000C744 File Offset: 0x0000A944
		private void NewRecoilSystem()
		{
			if (!Config.AimbotStatus)
			{
				return;
			}
			if (!Config.SHITRECStatus)
			{
				if (PixelSearcher._rcsCurrent != 0f)
				{
					this.UpdateRecoilCurrent(0f);
				}
				if (this._holdingAimKey)
				{
					this._holdingAimKey = false;
					this._rcsHoldingTime = 0;
					return;
				}
			}
			else if (PixelSearcher.GetAsyncKeyState(1) != 0)
			{
				this._holdingAimKey = true;
				this._rcsHoldingTime++;
				if (PixelSearcher.<>o__13.<>p__7 == null)
				{
					PixelSearcher.<>o__13.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = PixelSearcher.<>o__13.<>p__7.Target;
				CallSite <>p__ = PixelSearcher.<>o__13.<>p__7;
				if (PixelSearcher.<>o__13.<>p__1 == null)
				{
					PixelSearcher.<>o__13.<>p__1 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThanOrEqual, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, int, object, object> target2 = PixelSearcher.<>o__13.<>p__1.Target;
				CallSite <>p__2 = PixelSearcher.<>o__13.<>p__1;
				int rcsHoldingTime = this._rcsHoldingTime;
				if (PixelSearcher.<>o__13.<>p__0 == null)
				{
					PixelSearcher.<>o__13.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object obj = target2(<>p__2, rcsHoldingTime, PixelSearcher.<>o__13.<>p__0.Target(PixelSearcher.<>o__13.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.RCS_HOLDINGTIME, Config.currentMode)));
				if (PixelSearcher.<>o__13.<>p__6 == null)
				{
					PixelSearcher.<>o__13.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg2;
				if (!PixelSearcher.<>o__13.<>p__6.Target(PixelSearcher.<>o__13.<>p__6, obj))
				{
					if (PixelSearcher.<>o__13.<>p__5 == null)
					{
						PixelSearcher.<>o__13.<>p__5 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, bool, object> target3 = PixelSearcher.<>o__13.<>p__5.Target;
					CallSite <>p__3 = PixelSearcher.<>o__13.<>p__5;
					object arg = obj;
					if (PixelSearcher.<>o__13.<>p__4 == null)
					{
						PixelSearcher.<>o__13.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target4 = PixelSearcher.<>o__13.<>p__4.Target;
					CallSite <>p__4 = PixelSearcher.<>o__13.<>p__4;
					if (PixelSearcher.<>o__13.<>p__3 == null)
					{
						PixelSearcher.<>o__13.<>p__3 = CallSite<Func<CallSite, float, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThanOrEqual, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, float, object, object> target5 = PixelSearcher.<>o__13.<>p__3.Target;
					CallSite <>p__5 = PixelSearcher.<>o__13.<>p__3;
					float rcsCurrent = PixelSearcher._rcsCurrent;
					if (PixelSearcher.<>o__13.<>p__2 == null)
					{
						PixelSearcher.<>o__13.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg2 = target3(<>p__3, arg, target4(<>p__4, target5(<>p__5, rcsCurrent, PixelSearcher.<>o__13.<>p__2.Target(PixelSearcher.<>o__13.<>p__2, typeof(Convert), Config.GetConfig(Settings.CONFIG.RCS_MAX_RECOIL, Config.currentMode)))));
				}
				else
				{
					arg2 = obj;
				}
				if (target(<>p__, arg2))
				{
					if (PixelSearcher.<>o__13.<>p__9 == null)
					{
						PixelSearcher.<>o__13.<>p__9 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
					}
					Func<CallSite, object, float> target6 = PixelSearcher.<>o__13.<>p__9.Target;
					CallSite <>p__6 = PixelSearcher.<>o__13.<>p__9;
					if (PixelSearcher.<>o__13.<>p__8 == null)
					{
						PixelSearcher.<>o__13.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					float num = target6(<>p__6, PixelSearcher.<>o__13.<>p__8.Target(PixelSearcher.<>o__13.<>p__8, typeof(float), Config.GetConfig(Settings.CONFIG.RCS_SPEED, Config.currentMode)));
					if (PixelSearcher.<>o__13.<>p__11 == null)
					{
						PixelSearcher.<>o__13.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
					}
					Func<CallSite, object, int> target7 = PixelSearcher.<>o__13.<>p__11.Target;
					CallSite <>p__7 = PixelSearcher.<>o__13.<>p__11;
					if (PixelSearcher.<>o__13.<>p__10 == null)
					{
						PixelSearcher.<>o__13.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num2 = target7(<>p__7, PixelSearcher.<>o__13.<>p__10.Target(PixelSearcher.<>o__13.<>p__10, typeof(Convert), Config.GetConfig(Settings.CONFIG.RCS_MULTIPLIER, Config.currentMode)));
					float num3 = num;
					this.UpdateRecoilCurrent(PixelSearcher._rcsCurrent + (float)num2 * num3);
					return;
				}
			}
			else if (this._holdingAimKey)
			{
				this._holdingAimKey = false;
				this._rcsHoldingTime = 0;
				this.UpdateRecoilCurrent(0f);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002874 File Offset: 0x00000A74
		private void UpdateRecoilCurrent(float update)
		{
			PixelSearcher._rcsCurrent = update;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		private void AimAssist(int screenWidth, int screenHeight)
		{
			if (PixelSearcher.<>o__15.<>p__1 == null)
			{
				PixelSearcher.<>o__15.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target = PixelSearcher.<>o__15.<>p__1.Target;
			CallSite <>p__ = PixelSearcher.<>o__15.<>p__1;
			if (PixelSearcher.<>o__15.<>p__0 == null)
			{
				PixelSearcher.<>o__15.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num = target(<>p__, PixelSearcher.<>o__15.<>p__0.Target(PixelSearcher.<>o__15.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.ASSIST_FOV_X, Config.currentMode)));
			if (PixelSearcher.<>o__15.<>p__3 == null)
			{
				PixelSearcher.<>o__15.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target2 = PixelSearcher.<>o__15.<>p__3.Target;
			CallSite <>p__2 = PixelSearcher.<>o__15.<>p__3;
			if (PixelSearcher.<>o__15.<>p__2 == null)
			{
				PixelSearcher.<>o__15.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num2 = target2(<>p__2, PixelSearcher.<>o__15.<>p__2.Target(PixelSearcher.<>o__15.<>p__2, typeof(Convert), Config.GetConfig(Settings.CONFIG.ASSIST_FOV_Y, Config.currentMode)));
			if (PixelSearcher.<>o__15.<>p__5 == null)
			{
				PixelSearcher.<>o__15.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target3 = PixelSearcher.<>o__15.<>p__5.Target;
			CallSite <>p__3 = PixelSearcher.<>o__15.<>p__5;
			if (PixelSearcher.<>o__15.<>p__4 == null)
			{
				PixelSearcher.<>o__15.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num3 = target3(<>p__3, PixelSearcher.<>o__15.<>p__4.Target(PixelSearcher.<>o__15.<>p__4, typeof(Convert), Config.GetConfig(Settings.CONFIG.ASSIST_MAX_COUNT, Config.currentMode)));
			if (PixelSearcher.<>o__15.<>p__7 == null)
			{
				PixelSearcher.<>o__15.<>p__7 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target4 = PixelSearcher.<>o__15.<>p__7.Target;
			CallSite <>p__4 = PixelSearcher.<>o__15.<>p__7;
			if (PixelSearcher.<>o__15.<>p__6 == null)
			{
				PixelSearcher.<>o__15.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			float num4 = target4(<>p__4, PixelSearcher.<>o__15.<>p__6.Target(PixelSearcher.<>o__15.<>p__6, typeof(float), Config.GetConfig(Settings.CONFIG.ASSIST_HEADSHOT_OFFSET, Config.currentMode)));
			if (PixelSearcher.<>o__15.<>p__9 == null)
			{
				PixelSearcher.<>o__15.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target5 = PixelSearcher.<>o__15.<>p__9.Target;
			CallSite <>p__5 = PixelSearcher.<>o__15.<>p__9;
			if (PixelSearcher.<>o__15.<>p__8 == null)
			{
				PixelSearcher.<>o__15.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int maxValue = target5(<>p__5, PixelSearcher.<>o__15.<>p__8.Target(PixelSearcher.<>o__15.<>p__8, typeof(Convert), Config.GetConfig(Settings.CONFIG.ASSIST_JITTER, Config.currentMode)));
			if (PixelSearcher.<>o__15.<>p__11 == null)
			{
				PixelSearcher.<>o__15.<>p__11 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target6 = PixelSearcher.<>o__15.<>p__11.Target;
			CallSite <>p__6 = PixelSearcher.<>o__15.<>p__11;
			if (PixelSearcher.<>o__15.<>p__10 == null)
			{
				PixelSearcher.<>o__15.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			float num5 = target6(<>p__6, PixelSearcher.<>o__15.<>p__10.Target(PixelSearcher.<>o__15.<>p__10, typeof(float), Config.GetConfig(Settings.CONFIG.ASSIST_SENS, Config.currentMode)));
			Point[] result = this.PixelSearch(new Rectangle((screenWidth - num2) / 2, (screenHeight - num) / 2, num2, num)).GetAwaiter().GetResult();
			if (result != null && result.Length != 0)
			{
				Point[] array = (from t in result
				orderby t.Y
				select t).ToArray<Point>();
				List<Vector2> list = new List<Vector2>();
				float num6 = 0f;
				for (int i = 0; i < array.Length; i++)
				{
					Vector2 current = new Vector2((float)array[i].X, (float)array[i].Y);
					if (num6 <= current.Y)
					{
						num6 = current.Y;
						if ((from t in list
						where (t - current).Length() < 60f || Math.Abs(t.X - current.X) < 60f
						select t).Count<Vector2>() < 1)
						{
							list.Add(current);
							if (list.Count > num3)
							{
								break;
							}
						}
					}
				}
				Vector2 vector = (from t in list
				select t - new Vector2((float)(screenWidth / 2), (float)(screenHeight / 2))).OrderBy(delegate(Vector2 t)
				{
					Vector2 vector2 = t;
					return vector2.Length();
				}).FirstOrDefault<Vector2>() + new Vector2(1f, num4 + (float)Convert.ToInt32(PixelSearcher._rcsCurrent));
				Random random = new Random();
				float num7 = 1f - (float)random.Next(maxValue) / 100f;
				int xDelta = Convert.ToInt32(vector.X / num5 * num7);
				int yDelta = Convert.ToInt32(vector.Y / num5 * num7);
				this.ArduinoAdsMove(xDelta, yDelta, false);
				return;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		private void Aimbot(int screenWidth, int screenHeight)
		{
			if (!Config.AimbotStatus)
			{
				return;
			}
			int num = 5;
			if (PixelSearcher.<>o__16.<>p__1 == null)
			{
				PixelSearcher.<>o__16.<>p__1 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target = PixelSearcher.<>o__16.<>p__1.Target;
			CallSite <>p__ = PixelSearcher.<>o__16.<>p__1;
			if (PixelSearcher.<>o__16.<>p__0 == null)
			{
				PixelSearcher.<>o__16.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			float num2 = target(<>p__, PixelSearcher.<>o__16.<>p__0.Target(PixelSearcher.<>o__16.<>p__0, typeof(float), Config.GetConfig(Settings.CONFIG.AIMBOT_HEADSHOT_OFFSET, Config.currentMode)));
			if (PixelSearcher.<>o__16.<>p__4 == null)
			{
				PixelSearcher.<>o__16.<>p__4 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target2 = PixelSearcher.<>o__16.<>p__4.Target;
			CallSite <>p__2 = PixelSearcher.<>o__16.<>p__4;
			if (PixelSearcher.<>o__16.<>p__3 == null)
			{
				PixelSearcher.<>o__16.<>p__3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target3 = PixelSearcher.<>o__16.<>p__3.Target;
			CallSite <>p__3 = PixelSearcher.<>o__16.<>p__3;
			if (PixelSearcher.<>o__16.<>p__2 == null)
			{
				PixelSearcher.<>o__16.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target2(<>p__2, target3(<>p__3, PixelSearcher.<>o__16.<>p__2.Target(PixelSearcher.<>o__16.<>p__2, typeof(float), Config.GetConfig(Settings.CONFIG.AIMBOT_SPEED_X, Config.currentMode)), 100));
			if (PixelSearcher.<>o__16.<>p__7 == null)
			{
				PixelSearcher.<>o__16.<>p__7 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target4 = PixelSearcher.<>o__16.<>p__7.Target;
			CallSite <>p__4 = PixelSearcher.<>o__16.<>p__7;
			if (PixelSearcher.<>o__16.<>p__6 == null)
			{
				PixelSearcher.<>o__16.<>p__6 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target5 = PixelSearcher.<>o__16.<>p__6.Target;
			CallSite <>p__5 = PixelSearcher.<>o__16.<>p__6;
			if (PixelSearcher.<>o__16.<>p__5 == null)
			{
				PixelSearcher.<>o__16.<>p__5 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target4(<>p__4, target5(<>p__5, PixelSearcher.<>o__16.<>p__5.Target(PixelSearcher.<>o__16.<>p__5, typeof(float), Config.GetConfig(Settings.CONFIG.AIMBOT_SPEED_Y, Config.currentMode)), 100));
			if (PixelSearcher.<>o__16.<>p__9 == null)
			{
				PixelSearcher.<>o__16.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target6 = PixelSearcher.<>o__16.<>p__9.Target;
			CallSite <>p__6 = PixelSearcher.<>o__16.<>p__9;
			if (PixelSearcher.<>o__16.<>p__8 == null)
			{
				PixelSearcher.<>o__16.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num3 = target6(<>p__6, PixelSearcher.<>o__16.<>p__8.Target(PixelSearcher.<>o__16.<>p__8, typeof(Convert), Config.GetConfig(Settings.CONFIG.AIMBOT_JITTER, Config.currentMode)));
			if (PixelSearcher.<>o__16.<>p__11 == null)
			{
				PixelSearcher.<>o__16.<>p__11 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
			}
			Func<CallSite, object, float> target7 = PixelSearcher.<>o__16.<>p__11.Target;
			CallSite <>p__7 = PixelSearcher.<>o__16.<>p__11;
			if (PixelSearcher.<>o__16.<>p__10 == null)
			{
				PixelSearcher.<>o__16.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			float num4 = target7(<>p__7, PixelSearcher.<>o__16.<>p__10.Target(PixelSearcher.<>o__16.<>p__10, typeof(float), Config.GetConfig(Settings.CONFIG.AIMBOT_SENS, Config.currentMode)));
			if (PixelSearcher.<>o__16.<>p__13 == null)
			{
				PixelSearcher.<>o__16.<>p__13 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target8 = PixelSearcher.<>o__16.<>p__13.Target;
			CallSite <>p__8 = PixelSearcher.<>o__16.<>p__13;
			if (PixelSearcher.<>o__16.<>p__12 == null)
			{
				PixelSearcher.<>o__16.<>p__12 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num5 = target8(<>p__8, PixelSearcher.<>o__16.<>p__12.Target(PixelSearcher.<>o__16.<>p__12, typeof(Convert), Config.GetConfig(Settings.CONFIG.AIMBOT_FOV_X, Config.currentMode)));
			if (PixelSearcher.<>o__16.<>p__15 == null)
			{
				PixelSearcher.<>o__16.<>p__15 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target9 = PixelSearcher.<>o__16.<>p__15.Target;
			CallSite <>p__9 = PixelSearcher.<>o__16.<>p__15;
			if (PixelSearcher.<>o__16.<>p__14 == null)
			{
				PixelSearcher.<>o__16.<>p__14 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num6 = target9(<>p__9, PixelSearcher.<>o__16.<>p__14.Target(PixelSearcher.<>o__16.<>p__14, typeof(Convert), Config.GetConfig(Settings.CONFIG.AIMBOT_FOV_Y, Config.currentMode)));
			if (PixelSearcher.<>o__16.<>p__18 == null)
			{
				PixelSearcher.<>o__16.<>p__18 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(PixelSearcher)));
			}
			Func<CallSite, object, bool> target10 = PixelSearcher.<>o__16.<>p__18.Target;
			CallSite <>p__10 = PixelSearcher.<>o__16.<>p__18;
			if (PixelSearcher.<>o__16.<>p__17 == null)
			{
				PixelSearcher.<>o__16.<>p__17 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToBoolean", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target11 = PixelSearcher.<>o__16.<>p__17.Target;
			CallSite <>p__11 = PixelSearcher.<>o__16.<>p__17;
			Type typeFromHandle = typeof(Convert);
			if (PixelSearcher.<>o__16.<>p__16 == null)
			{
				PixelSearcher.<>o__16.<>p__16 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			bool flag = target10(<>p__10, target11(<>p__11, typeFromHandle, PixelSearcher.<>o__16.<>p__16.Target(PixelSearcher.<>o__16.<>p__16, typeof(Convert), Config.GetConfig(Settings.CONFIG.BHA_ENABLED, Config.currentMode))));
			if (PixelSearcher.<>o__16.<>p__21 == null)
			{
				PixelSearcher.<>o__16.<>p__21 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(PixelSearcher)));
			}
			Func<CallSite, object, bool> target12 = PixelSearcher.<>o__16.<>p__21.Target;
			CallSite <>p__12 = PixelSearcher.<>o__16.<>p__21;
			if (PixelSearcher.<>o__16.<>p__20 == null)
			{
				PixelSearcher.<>o__16.<>p__20 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToBoolean", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object> target13 = PixelSearcher.<>o__16.<>p__20.Target;
			CallSite <>p__13 = PixelSearcher.<>o__16.<>p__20;
			Type typeFromHandle2 = typeof(Convert);
			if (PixelSearcher.<>o__16.<>p__19 == null)
			{
				PixelSearcher.<>o__16.<>p__19 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			bool flag2 = target12(<>p__12, target13(<>p__13, typeFromHandle2, PixelSearcher.<>o__16.<>p__19.Target(PixelSearcher.<>o__16.<>p__19, typeof(Convert), Config.GetConfig(Settings.CONFIG.AIMBOT_RANDOM_SMOOTH, Config.currentMode))));
			bool shot = false;
			Point[] result = this.PixelSearch(new Rectangle((screenWidth - num6) / 2, (screenHeight - num5) / 2, num6, num5)).GetAwaiter().GetResult();
			if (result == null || result.Length == 0)
			{
				return;
			}
			Point[] array = (from t in result
			orderby t.Y
			select t).ToArray<Point>();
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < array.Length; i++)
			{
				Vector2 current = new Vector2((float)array[i].X, (float)array[i].Y);
				if ((from t in list
				where (t - current).Length() < 60f || Math.Abs(t.X - current.X) < 60f
				select t).Count<Vector2>() < 1)
				{
					list.Add(current);
					if (list.Count > num)
					{
						break;
					}
				}
			}
			if (flag)
			{
				if (PixelSearcher.<>o__16.<>p__23 == null)
				{
					PixelSearcher.<>o__16.<>p__23 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target14 = PixelSearcher.<>o__16.<>p__23.Target;
				CallSite <>p__14 = PixelSearcher.<>o__16.<>p__23;
				if (PixelSearcher.<>o__16.<>p__22 == null)
				{
					PixelSearcher.<>o__16.<>p__22 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num7 = target14(<>p__14, PixelSearcher.<>o__16.<>p__22.Target(PixelSearcher.<>o__16.<>p__22, typeof(Convert), Config.GetConfig(Settings.CONFIG.BHA_FROM, Config.currentMode)));
				if (PixelSearcher.<>o__16.<>p__25 == null)
				{
					PixelSearcher.<>o__16.<>p__25 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target15 = PixelSearcher.<>o__16.<>p__25.Target;
				CallSite <>p__15 = PixelSearcher.<>o__16.<>p__25;
				if (PixelSearcher.<>o__16.<>p__24 == null)
				{
					PixelSearcher.<>o__16.<>p__24 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num8 = target15(<>p__15, PixelSearcher.<>o__16.<>p__24.Target(PixelSearcher.<>o__16.<>p__24, typeof(Convert), Config.GetConfig(Settings.CONFIG.BHA_TO, Config.currentMode)));
				if (PixelSearcher.<>o__16.<>p__27 == null)
				{
					PixelSearcher.<>o__16.<>p__27 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target16 = PixelSearcher.<>o__16.<>p__27.Target;
				CallSite <>p__16 = PixelSearcher.<>o__16.<>p__27;
				if (PixelSearcher.<>o__16.<>p__26 == null)
				{
					PixelSearcher.<>o__16.<>p__26 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num9 = target16(<>p__16, PixelSearcher.<>o__16.<>p__26.Target(PixelSearcher.<>o__16.<>p__26, typeof(Convert), Config.GetConfig(Settings.CONFIG.BHA_MULTIPLIER, Config.currentMode)));
				if (PixelSearcher.<>o__16.<>p__29 == null)
				{
					PixelSearcher.<>o__16.<>p__29 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
				}
				Func<CallSite, object, float> target17 = PixelSearcher.<>o__16.<>p__29.Target;
				CallSite <>p__17 = PixelSearcher.<>o__16.<>p__29;
				if (PixelSearcher.<>o__16.<>p__28 == null)
				{
					PixelSearcher.<>o__16.<>p__28 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				float num10 = target17(<>p__17, PixelSearcher.<>o__16.<>p__28.Target(PixelSearcher.<>o__16.<>p__28, typeof(float), Config.GetConfig(Settings.CONFIG.BHA_SPEED, Config.currentMode)));
				if (PixelSearcher.currentBHAOffset == -999f)
				{
					PixelSearcher.currentBHAOffset = (float)num7;
				}
				if (PixelSearcher.currentBHAOffset > (float)num8)
				{
					PixelSearcher.currentBHAOffset -= (float)num9 * num10;
				}
				Random random = new Random();
				Vector2 vector = (from t in list
				select t - new Vector2((float)(screenWidth / 2), (float)(screenHeight / 2))).OrderBy(delegate(Vector2 t)
				{
					Vector2 vector3 = t;
					return vector3.Length();
				}).FirstOrDefault<Vector2>() + new Vector2(1f, (float)(Convert.ToInt32(PixelSearcher.currentBHAOffset) + Convert.ToInt32(PixelSearcher._rcsCurrent)));
				int num11 = num3;
				if (flag2)
				{
					num11 = random.Next(num3);
				}
				float num12 = 1f - (float)num11 / 100f;
				int xDelta = Convert.ToInt32(vector.X / num4 * num12);
				int yDelta = Convert.ToInt32(vector.Y / num4 * num12);
				this.ArduinoAdsMove(xDelta, yDelta, shot);
				return;
			}
			Random random2 = new Random();
			Vector2 vector2 = (from t in list
			select t - new Vector2((float)(screenWidth / 2), (float)(screenHeight / 2))).OrderBy(delegate(Vector2 t)
			{
				Vector2 vector3 = t;
				return vector3.Length();
			}).FirstOrDefault<Vector2>() + new Vector2(1f, num2 + (float)Convert.ToInt32(PixelSearcher._rcsCurrent));
			int num13 = num3;
			if (flag2)
			{
				num13 = random2.Next(num3);
			}
			float num14 = 1f - (float)num13 / 100f;
			int xDelta2 = Convert.ToInt32(vector2.X / num4 * num14);
			int yDelta2 = Convert.ToInt32(vector2.Y / num4 * num14);
			this.ArduinoAdsMove(xDelta2, yDelta2, shot);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		private void FlickBot()
		{
			PixelSearcher.<>c__DisplayClass17_0 CS$<>8__locals1 = new PixelSearcher.<>c__DisplayClass17_0();
			PixelSearcher.<>c__DisplayClass17_0 CS$<>8__locals2 = CS$<>8__locals1;
			if (PixelSearcher.<>o__17.<>p__1 == null)
			{
				PixelSearcher.<>o__17.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target = PixelSearcher.<>o__17.<>p__1.Target;
			CallSite <>p__ = PixelSearcher.<>o__17.<>p__1;
			if (PixelSearcher.<>o__17.<>p__0 == null)
			{
				PixelSearcher.<>o__17.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CS$<>8__locals2.screenWidth = target(<>p__, PixelSearcher.<>o__17.<>p__0.Target(PixelSearcher.<>o__17.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_X, Config.currentMode)));
			PixelSearcher.<>c__DisplayClass17_0 CS$<>8__locals3 = CS$<>8__locals1;
			if (PixelSearcher.<>o__17.<>p__3 == null)
			{
				PixelSearcher.<>o__17.<>p__3 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target2 = PixelSearcher.<>o__17.<>p__3.Target;
			CallSite <>p__2 = PixelSearcher.<>o__17.<>p__3;
			if (PixelSearcher.<>o__17.<>p__2 == null)
			{
				PixelSearcher.<>o__17.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CS$<>8__locals3.screenHeight = target2(<>p__2, PixelSearcher.<>o__17.<>p__2.Target(PixelSearcher.<>o__17.<>p__2, typeof(Convert), Config.GetConfig(Settings.CONFIG.CHEAT_RESOLUTION_Y, Config.currentMode)));
			if (PixelSearcher.<>o__17.<>p__5 == null)
			{
				PixelSearcher.<>o__17.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target3 = PixelSearcher.<>o__17.<>p__5.Target;
			CallSite <>p__3 = PixelSearcher.<>o__17.<>p__5;
			if (PixelSearcher.<>o__17.<>p__4 == null)
			{
				PixelSearcher.<>o__17.<>p__4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num = target3(<>p__3, PixelSearcher.<>o__17.<>p__4.Target(PixelSearcher.<>o__17.<>p__4, typeof(Convert), Config.GetConfig(Settings.CONFIG.FLICK_FOV_X, Config.currentMode)));
			if (PixelSearcher.<>o__17.<>p__7 == null)
			{
				PixelSearcher.<>o__17.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
			}
			Func<CallSite, object, int> target4 = PixelSearcher.<>o__17.<>p__7.Target;
			CallSite <>p__4 = PixelSearcher.<>o__17.<>p__7;
			if (PixelSearcher.<>o__17.<>p__6 == null)
			{
				PixelSearcher.<>o__17.<>p__6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			int num2 = target4(<>p__4, PixelSearcher.<>o__17.<>p__6.Target(PixelSearcher.<>o__17.<>p__6, typeof(Convert), Config.GetConfig(Settings.CONFIG.FLICK_FOV_Y, Config.currentMode)));
			Point[] result = this.PixelSearch(new Rectangle((CS$<>8__locals1.screenWidth - num2) / 2, (CS$<>8__locals1.screenHeight - num) / 2, num2, num)).GetAwaiter().GetResult();
			if (result != null && result.Length != 0)
			{
				int num3 = 5;
				if (PixelSearcher.<>o__17.<>p__9 == null)
				{
					PixelSearcher.<>o__17.<>p__9 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
				}
				Func<CallSite, object, float> target5 = PixelSearcher.<>o__17.<>p__9.Target;
				CallSite <>p__5 = PixelSearcher.<>o__17.<>p__9;
				if (PixelSearcher.<>o__17.<>p__8 == null)
				{
					PixelSearcher.<>o__17.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target5(<>p__5, PixelSearcher.<>o__17.<>p__8.Target(PixelSearcher.<>o__17.<>p__8, typeof(float), Config.GetConfig(Settings.CONFIG.FLICK_HEADSHOT_OFFSET, Config.currentMode)));
				if (PixelSearcher.<>o__17.<>p__11 == null)
				{
					PixelSearcher.<>o__17.<>p__11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target6 = PixelSearcher.<>o__17.<>p__11.Target;
				CallSite <>p__6 = PixelSearcher.<>o__17.<>p__11;
				if (PixelSearcher.<>o__17.<>p__10 == null)
				{
					PixelSearcher.<>o__17.<>p__10 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num4 = target6(<>p__6, PixelSearcher.<>o__17.<>p__10.Target(PixelSearcher.<>o__17.<>p__10, typeof(Convert), Config.GetConfig(Settings.CONFIG.FLICK_FOLLOW_TIME, Config.currentMode)));
				if (PixelSearcher.<>o__17.<>p__13 == null)
				{
					PixelSearcher.<>o__17.<>p__13 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(PixelSearcher)));
				}
				Func<CallSite, object, int> target7 = PixelSearcher.<>o__17.<>p__13.Target;
				CallSite <>p__7 = PixelSearcher.<>o__17.<>p__13;
				if (PixelSearcher.<>o__17.<>p__12 == null)
				{
					PixelSearcher.<>o__17.<>p__12 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int maxValue = target7(<>p__7, PixelSearcher.<>o__17.<>p__12.Target(PixelSearcher.<>o__17.<>p__12, typeof(Convert), Config.GetConfig(Settings.CONFIG.FLICK_JITTER, Config.currentMode)));
				if (PixelSearcher.<>o__17.<>p__15 == null)
				{
					PixelSearcher.<>o__17.<>p__15 = CallSite<Func<CallSite, object, float>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(float), typeof(PixelSearcher)));
				}
				Func<CallSite, object, float> target8 = PixelSearcher.<>o__17.<>p__15.Target;
				CallSite <>p__8 = PixelSearcher.<>o__17.<>p__15;
				if (PixelSearcher.<>o__17.<>p__14 == null)
				{
					PixelSearcher.<>o__17.<>p__14 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				float num5 = target8(<>p__8, PixelSearcher.<>o__17.<>p__14.Target(PixelSearcher.<>o__17.<>p__14, typeof(float), Config.GetConfig(Settings.CONFIG.FLICK_SENS, Config.currentMode)));
				Point[] array = (from t in result
				orderby t.Y
				select t).ToArray<Point>();
				List<Vector2> list = new List<Vector2>();
				float num6 = 0f;
				for (int i = 0; i < array.Length; i++)
				{
					Vector2 current = new Vector2((float)array[i].X, (float)array[i].Y);
					if (num6 <= current.Y)
					{
						num6 = current.Y;
						if ((from t in list
						where (t - current).Length() < 60f || Math.Abs(t.X - current.X) < 60f
						select t).Count<Vector2>() < 1)
						{
							list.Add(current);
							if (list.Count > num3)
							{
								break;
							}
						}
					}
				}
				Vector2 vector = (from t in list
				select t - new Vector2((float)(CS$<>8__locals1.screenWidth / 2), (float)(CS$<>8__locals1.screenHeight / 2))).OrderBy(delegate(Vector2 t)
				{
					Vector2 vector2 = t;
					return vector2.Length();
				}).FirstOrDefault<Vector2>() + new Vector2(1f, (float)num4);
				if (num5 != 0f && (float)this.followTimer <= num5)
				{
					this.followTimer++;
				}
				if ((float)this.followTimer <= num5)
				{
					Random random = new Random();
					float num7 = 1f - (float)random.Next(maxValue) / 100f;
					int xDelta = Convert.ToInt32(vector.X / num5 * num7);
					int yDelta = Convert.ToInt32(vector.Y / num5 * num7);
					this.ArduinoAdsMove(xDelta, yDelta, false);
				}
				return;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000E63C File Offset: 0x0000C83C
		public void ArduinoAdsMove(int xDelta, int yDelta, bool shot = false)
		{
			try
			{
				if (shot)
				{
					if (PixelSearcher.<>o__18.<>p__2 == null)
					{
						PixelSearcher.<>o__18.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = PixelSearcher.<>o__18.<>p__2.Target;
					CallSite <>p__ = PixelSearcher.<>o__18.<>p__2;
					if (PixelSearcher.<>o__18.<>p__1 == null)
					{
						PixelSearcher.<>o__18.<>p__1 = CallSite<Func<CallSite, double, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThan, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, double, object, object> target2 = PixelSearcher.<>o__18.<>p__1.Target;
					CallSite <>p__2 = PixelSearcher.<>o__18.<>p__1;
					double totalMilliseconds = DateTime.Now.Subtract(PixelSearcher.lastShot).TotalMilliseconds;
					if (PixelSearcher.<>o__18.<>p__0 == null)
					{
						PixelSearcher.<>o__18.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(PixelSearcher), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target(<>p__, target2(<>p__2, totalMilliseconds, PixelSearcher.<>o__18.<>p__0.Target(PixelSearcher.<>o__18.<>p__0, typeof(Convert), Config.GetConfig(Settings.CONFIG.TRIGGER_DELAY, Config.currentMode)))))
					{
						shot = false;
					}
					else
					{
						PixelSearcher.lastShot = DateTime.Now;
					}
				}
				bagulhotensodaquebradaloko264812._leonardo.MoverMouse(xDelta, yDelta, shot);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		public Task<Point[]> PixelSearch(Rectangle rect)
		{
			PixelSearcher.<PixelSearch>d__19 <PixelSearch>d__;
			<PixelSearch>d__.<>t__builder = AsyncTaskMethodBuilder<Point[]>.Create();
			<PixelSearch>d__.<>4__this = this;
			<PixelSearch>d__.rect = rect;
			<PixelSearch>d__.<>1__state = -1;
			<PixelSearch>d__.<>t__builder.Start<PixelSearcher.<PixelSearch>d__19>(ref <PixelSearch>d__);
			return <PixelSearch>d__.<>t__builder.Task;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public bool Colors(int red, int green, int blue)
		{
			if (Config.purple)
			{
				if (green >= 190)
				{
					return false;
				}
				if (green >= 120)
				{
					return Math.Abs(red - blue) <= 8 && red - green >= 50 && blue - green >= 50 && red >= 105 && blue >= 105;
				}
				return Math.Abs(red - blue) <= 13 && red - green >= 60 && blue - green >= 60 && red >= 110 && blue >= 100;
			}
			else
			{
				if (blue >= 80)
				{
					return false;
				}
				if (blue >= 40)
				{
					return Math.Abs(red - green) <= 8 && red - blue >= 100 && green - blue >= 100 && red >= 200 && green >= 200;
				}
				return Math.Abs(red - green) <= 13 && red - blue >= 130 && green - blue >= 130 && red >= 230 && blue >= 230;
			}
		}

		// Token: 0x040000F0 RID: 240
		private const int size = 60;

		// Token: 0x040000F1 RID: 241
		private static float _rcsCurrent = 0f;

		// Token: 0x040000F2 RID: 242
		private bool _holdingAimKey;

		// Token: 0x040000F3 RID: 243
		private int _rcsHoldingTime;

		// Token: 0x040000F4 RID: 244
		public static int monitor = 0;

		// Token: 0x040000F5 RID: 245
		private static bool holdingTriggerKey = false;

		// Token: 0x040000F6 RID: 246
		private static float currentBHAOffset = 0f;

		// Token: 0x040000F7 RID: 247
		private int followTimer;

		// Token: 0x040000F8 RID: 248
		private static DateTime lastShot = DateTime.Now;

		// Token: 0x040000F9 RID: 249
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
			20
		};
	}
}
