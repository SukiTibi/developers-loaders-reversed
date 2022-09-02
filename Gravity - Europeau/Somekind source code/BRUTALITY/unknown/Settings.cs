using System;

namespace unknown
{
	// Token: 0x02000032 RID: 50
	public class Settings
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002914 File Offset: 0x00000B14
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000291B File Offset: 0x00000B1B
		public static object Default { get; internal set; }

		// Token: 0x02000033 RID: 51
		public enum CONFIG
		{
			// Token: 0x04000173 RID: 371
			AIMBOT_HOTKEY,
			// Token: 0x04000174 RID: 372
			AIMBOT_FOV_X,
			// Token: 0x04000175 RID: 373
			AIMBOT_FOV_Y,
			// Token: 0x04000176 RID: 374
			AIMBOT_HEADSHOT_OFFSET,
			// Token: 0x04000177 RID: 375
			AIMBOT_SPEED_X = 5,
			// Token: 0x04000178 RID: 376
			AIMBOT_SPEED_Y,
			// Token: 0x04000179 RID: 377
			AIMBOT_ANTI_SHAKE,
			// Token: 0x0400017A RID: 378
			RCS_MULTIPLIER,
			// Token: 0x0400017B RID: 379
			RCS_MAX_RECOIL,
			// Token: 0x0400017C RID: 380
			CHEAT_RESOLUTION_X,
			// Token: 0x0400017D RID: 381
			CHEAT_RESOLUTION_Y,
			// Token: 0x0400017E RID: 382
			CHEAT_CURRENT_MODE,
			// Token: 0x0400017F RID: 383
			ASSIST_FOV_X,
			// Token: 0x04000180 RID: 384
			ASSIST_FOV_Y,
			// Token: 0x04000181 RID: 385
			ASSIST_HEADSHOT_OFFSET,
			// Token: 0x04000182 RID: 386
			ASSIST_MAX_COUNT,
			// Token: 0x04000183 RID: 387
			ASSIST_JITTER,
			// Token: 0x04000184 RID: 388
			ASSIST_SENS,
			// Token: 0x04000185 RID: 389
			CHEAT_DARKMODE,
			// Token: 0x04000186 RID: 390
			TRIGGER_HOTKEY,
			// Token: 0x04000187 RID: 391
			TRIGGER_DELAY,
			// Token: 0x04000188 RID: 392
			TRIGGER_FOVX,
			// Token: 0x04000189 RID: 393
			TRIGGER_FOVY,
			// Token: 0x0400018A RID: 394
			CHEAT_AIMSETTING,
			// Token: 0x0400018B RID: 395
			FLICK_FOV_X,
			// Token: 0x0400018C RID: 396
			FLICK_FOV_Y,
			// Token: 0x0400018D RID: 397
			FLICK_HEADSHOT_OFFSET,
			// Token: 0x0400018E RID: 398
			FLICK_JITTER,
			// Token: 0x0400018F RID: 399
			FLICK_SENS,
			// Token: 0x04000190 RID: 400
			FLICK_FOLLOW_TIME = 31,
			// Token: 0x04000191 RID: 401
			RCS_HOLDINGTIME,
			// Token: 0x04000192 RID: 402
			BHA_ENABLED = 34,
			// Token: 0x04000193 RID: 403
			BHA_FROM,
			// Token: 0x04000194 RID: 404
			BHA_TO,
			// Token: 0x04000195 RID: 405
			BHA_SPEED,
			// Token: 0x04000196 RID: 406
			RCS_SPEED,
			// Token: 0x04000197 RID: 407
			BHA_MULTIPLIER,
			// Token: 0x04000198 RID: 408
			AIMBOT_SENS,
			// Token: 0x04000199 RID: 409
			AIMBOT_JITTER,
			// Token: 0x0400019A RID: 410
			CHEAT_MONITOR,
			// Token: 0x0400019B RID: 411
			AIMBOT_RANDOM_SMOOTH
		}
	}
}
