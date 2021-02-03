using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace Static_HWID
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : MetroForm
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002213 File Offset: 0x00000413
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002237 File Offset: 0x00000437
		private void Form1_Load(object sender, EventArgs e)
		{
			this.listBox1.BackColor = Color.FromArgb(29, 29, 29);
			this.listBox1.ForeColor = Color.FromArgb(255, 255, 255);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002270 File Offset: 0x00000470
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox1.Checked)
			{
				this.metroCheckBox2.Checked = true;
				this.metroCheckBox3.Checked = true;
				this.metroCheckBox4.Checked = true;
				this.metroCheckBox5.Checked = true;
				this.metroCheckBox6.Checked = true;
				this.metroCheckBox7.Checked = true;
				this.metroCheckBox8.Checked = true;
				this.metroCheckBox9.Checked = true;
				return;
			}
			this.metroCheckBox2.Checked = false;
			this.metroCheckBox3.Checked = false;
			this.metroCheckBox4.Checked = false;
			this.metroCheckBox5.Checked = false;
			this.metroCheckBox6.Checked = false;
			this.metroCheckBox7.Checked = false;
			this.metroCheckBox8.Checked = false;
			this.metroCheckBox9.Checked = false;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000234B File Offset: 0x0000054B
		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you would like to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.Spoof();
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002368 File Offset: 0x00000568
		public void Log(string log)
		{
			this.listBox1.Items.Add(log);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000237C File Offset: 0x0000057C
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox2.Checked)
			{
				Global.PCName = true;
				return;
			}
			Global.PCName = false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002398 File Offset: 0x00000598
		private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox3.Checked)
			{
				Global.GUID = true;
				return;
			}
			Global.GUID = false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023B4 File Offset: 0x000005B4
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox4.Checked)
			{
				Global.HWIDserial = true;
				return;
			}
			Global.HWIDserial = false;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023D0 File Offset: 0x000005D0
		private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox5.Checked)
			{
				Global.ProductID = true;
				return;
			}
			Global.ProductID = false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023EC File Offset: 0x000005EC
		private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox6.Checked)
			{
				Global.MacAddress = true;
				return;
			}
			Global.MacAddress = false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002408 File Offset: 0x00000608
		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox7.Checked)
			{
				Global.InstallTime = true;
				return;
			}
			Global.InstallTime = false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002424 File Offset: 0x00000624
		private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox8.Checked)
			{
				Global.InstallDate = true;
				return;
			}
			Global.InstallDate = false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002440 File Offset: 0x00000640
		private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox9.Checked)
			{
				Global.HwProfileGUID = true;
				return;
			}
			Global.HwProfileGUID = false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000245C File Offset: 0x0000065C
		public void Spoof()
		{
			this.listBox1.Items.Clear();
			if (Global.PCName)
			{
				this.SpoofPCName();
			}
			if (Global.GUID)
			{
				this.SpoofGUID();
			}
			if (Global.MacAddress)
			{
				this.SpoofMacAddress();
			}
			if (Global.ProductID)
			{
				this.SpoofProductID();
			}
			if (Global.InstallTime)
			{
				this.SpoofInstallTime();
			}
			if (Global.InstallDate)
			{
				this.SpoofInstallDate();
			}
			if (Global.HwProfileGUID)
			{
				this.SpoofHwProfileGUID();
			}
			MessageBox.Show("Please restart your computer.", "Restart");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024F4 File Offset: 0x000006F4
		public string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "ABCDEF0123456789"[this.rand.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000253C File Offset: 0x0000073C
		private void SpoofMacAddress()
		{
			this.Log("Current MAC Address: " + this.CurrentMAC());
			string value = "00" + this.GenerateString(10);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012", true);
			registryKey.SetValue("NetworkAddress", value);
			registryKey.Close();
			this.Log("MAC address changed to: " + this.CurrentMAC());
			this.Log("");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025B4 File Offset: 0x000007B4
		private string CurrentMAC()
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012", true);
			string result = (string)registryKey.GetValue("NetworkAddress");
			registryKey.Close();
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025E8 File Offset: 0x000007E8
		private void SpoofGUID()
		{
			this.Log("Current GUID: " + Form1.CurrentGUID());
			string value = Guid.NewGuid().ToString();
			RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true).SetValue("MachineGuid", value);
			this.Log("GUID changed to: " + Form1.CurrentGUID());
			this.Log("");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002664 File Offset: 0x00000864
		public static string CurrentGUID()
		{
			string text = "SOFTWARE\\Microsoft\\Cryptography";
			string text2 = "MachineGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002700 File Offset: 0x00000900
		private void SpoofProductID()
		{
			this.Log("Current ProductID: " + Form1.CurrentProductID());
			string value = string.Concat(new string[]
			{
				this.GenerateString(5),
				"-",
				this.GenerateString(5),
				"-",
				this.GenerateString(5),
				"-",
				this.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			this.Log("ProductID changed to: " + Form1.CurrentProductID());
			this.Log("");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000027BC File Offset: 0x000009BC
		public static string CurrentProductID()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002858 File Offset: 0x00000A58
		public string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[this.random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000028A0 File Offset: 0x00000AA0
		private void SpoofInstallTime()
		{
			this.Log("Current install time: " + Form1.CurrentInstallTime());
			string value = this.GenerateDate(15);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallTime", value);
			registryKey.Close();
			this.Log("Install time changed to: " + Form1.CurrentInstallTime());
			this.Log("");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002918 File Offset: 0x00000B18
		public static string CurrentInstallTime()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "InstallTime";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000029B4 File Offset: 0x00000BB4
		private void SpoofInstallDate()
		{
			this.Log("Current install date: " + Form1.CurrentInstallDate());
			string value = this.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			this.Log("New Install Date: " + Form1.CurrentInstallDate());
			this.Log("");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002A2C File Offset: 0x00000C2C
		public static string CurrentInstallDate()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "InstallDate";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private void SpoofHwProfileGUID()
		{
			this.Log("Current HwProfileGUID: " + Form1.CurrentHwProfileGUID());
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
			registryKey.SetValue("HwProfileGUID", value);
			registryKey.Close();
			this.Log("New HwProfileGUID: " + Form1.CurrentHwProfileGUID());
			this.Log("");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002B58 File Offset: 0x00000D58
		public static string CurrentHwProfileGUID()
		{
			string text = "SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text2 = "HwProfileGUID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002BF4 File Offset: 0x00000DF4


		// Token: 0x06000025 RID: 37 RVA: 0x00002CE8 File Offset: 0x00000EE8
		private bool Strncmp(string str, byte[] data, int offset)
		{
			for (int i = 0; i < str.Length; i++)
			{
				if (data[i + offset] != (byte)str[i])
				{
					return false;
				}
			}
			return true;
		}


		// Token: 0x06000027 RID: 39 RVA: 0x00002D7C File Offset: 0x00000F7C
		private void SpoofPCName()
		{
			this.Log("Current PC name: " + Form1.CurrentPCName());
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + this.GenerateString(15));
			registryKey.Close();
			this.Log("PC name spoofed to: " + Form1.CurrentPCName());
			this.Log("");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002DFC File Offset: 0x00000FFC
		public static string CurrentPCName()
		{
			string text = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
			string text2 = "ComputerName";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x04000004 RID: 4
		private Random rand = new Random();

		// Token: 0x04000005 RID: 5
		public const string Alphabet = "ABCDEF0123456789";

		// Token: 0x04000006 RID: 6
		private Random random = new Random();

		// Token: 0x04000007 RID: 7
		public const string Alphabet1 = "abcdef0123456789";

		// Token: 0x02000009 RID: 9
		private class Disk : IDisposable
		{
			// Token: 0x0600003F RID: 63 RVA: 0x00003DC4 File Offset: 0x00001FC4
			public Disk(char volume)
			{
				IntPtr preexistingHandle = Form1.Disk.CreateFile(string.Format("\\\\.\\{0}:", volume), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);
				this.handle = new SafeFileHandle(preexistingHandle, true);
				if (this.handle.IsInvalid)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00003E20 File Offset: 0x00002020
			public void ReadSector(uint sector, byte[] buffer)
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (Form1.Disk.SetFilePointer(this.handle, sector, IntPtr.Zero, Form1.Disk.EMoveMethod.Begin) == 4294967295u)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				uint num;
				if (!Form1.Disk.ReadFile(this.handle, buffer, buffer.Length, out num, IntPtr.Zero))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				if ((ulong)num != (ulong)((long)buffer.Length))
				{
					throw new IOException();
				}
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00003E8C File Offset: 0x0000208C
			public void WriteSector(uint sector, byte[] buffer)
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (Form1.Disk.SetFilePointer(this.handle, sector, IntPtr.Zero, Form1.Disk.EMoveMethod.Begin) == 4294967295u)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				uint num;
				if (!Form1.Disk.WriteFile(this.handle, buffer, buffer.Length, out num, IntPtr.Zero))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				if ((ulong)num != (ulong)((long)buffer.Length))
				{
					throw new IOException();
				}
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00003EF6 File Offset: 0x000020F6
			public void Dispose()
			{
				this.Dispose(true);
				GC.SuppressFinalize(this);
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00003F05 File Offset: 0x00002105
			protected virtual void Dispose(bool disposing)
			{
				if (disposing && this.handle != null)
				{
					this.handle.Dispose();
				}
			}

			// Token: 0x06000044 RID: 68
			[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			public static extern IntPtr CreateFile(string fileName, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess, [MarshalAs(UnmanagedType.U4)] FileShare fileShare, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, int flags, IntPtr template);

			// Token: 0x06000045 RID: 69
			[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			private static extern uint SetFilePointer([In] SafeFileHandle hFile, [In] uint lDistanceToMove, [In] IntPtr lpDistanceToMoveHigh, [In] Form1.Disk.EMoveMethod dwMoveMethod);

			// Token: 0x06000046 RID: 70
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern bool ReadFile(SafeFileHandle hFile, [Out] byte[] lpBuffer, int nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

			// Token: 0x06000047 RID: 71
			[DllImport("kernel32.dll")]
			private static extern bool WriteFile(SafeFileHandle hFile, [In] byte[] lpBuffer, int nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] IntPtr lpOverlapped);

			// Token: 0x04000027 RID: 39
			private SafeFileHandle handle;

			// Token: 0x04000028 RID: 40
			private const uint INVALID_SET_FILE_POINTER = 4294967295u;

			// Token: 0x0200000B RID: 11
			private enum EMoveMethod : uint
			{
				// Token: 0x0400002C RID: 44
				Begin,
				// Token: 0x0400002D RID: 45
				Current,
				// Token: 0x0400002E RID: 46
				End
			}
		}
	}
}
