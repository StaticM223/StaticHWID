using System;
using System.Diagnostics;

namespace Static_HWID
{
	// Token: 0x02000005 RID: 5
	internal class Global
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003CD2 File Offset: 0x00001ED2
		public static void Restart()
		{
			Global.StartShutDown("-f -r -t 5");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003CDE File Offset: 0x00001EDE
		private static void StartShutDown(string param)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = "/C shutdown " + param
			});
		}

		// Token: 0x0400001C RID: 28
		public static bool PCName;

		// Token: 0x0400001D RID: 29
		public static bool GUID;

		// Token: 0x0400001E RID: 30
		public static bool HWIDserial;

		// Token: 0x0400001F RID: 31
		public static bool ProductID;

		// Token: 0x04000020 RID: 32
		public static bool MacAddress;

		// Token: 0x04000021 RID: 33
		public static bool InstallTime;

		// Token: 0x04000022 RID: 34
		public static bool InstallDate;

		// Token: 0x04000023 RID: 35
		public static bool HwProfileGUID;
	}
}
