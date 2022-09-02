using System;
using System.IO.Ports;

namespace unknown
{
	// Token: 0x02000020 RID: 32
	public class leonardo
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0000C300 File Offset: 0x0000A500
		public leonardo(string COMPORT)
		{
			this.port = new SerialPort(COMPORT, 115100);
			try
			{
				this.port.Open();
				this.leonardoOpened = true;
			}
			catch (Exception ex)
			{
				bagulhotensodaquebradaloko264812.WriteDebugMessage("[leonardo (Error)] " + ex.ToString());
				this.leonardoOpened = false;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000C368 File Offset: 0x0000A568
		public void MoverMouse(int x, int y, bool shot)
		{
			if (this.port != null)
			{
				this.port.Write(string.Concat(new string[]
				{
					this.limitecaodoarduino(x).ToString(),
					",",
					this.limitecaodoarduino(y).ToString(),
					",",
					Convert.ToInt32(shot).ToString()
				}));
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002861 File Offset: 0x00000A61
		private int limitecaodoarduino(int a)
		{
			if (a < -127)
			{
				return -127;
			}
			if (a > 127)
			{
				return 127;
			}
			return a;
		}

		// Token: 0x040000EE RID: 238
		private SerialPort port;

		// Token: 0x040000EF RID: 239
		public bool leonardoOpened;
	}
}
