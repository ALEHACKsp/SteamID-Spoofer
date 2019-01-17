using System;
using System.Runtime.InteropServices;

namespace SpooferHDDID
{
	internal class API
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int ReadProcessMemory(IntPtr hProcess, int lpBase, ref float lpBuffer, int nSize, int lpNumberOfBytesRead);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int ReadProcessMemory(IntPtr hProcess, int lpBase, ref int lpBuffer, int nSize, int lpNumberOfBytesRead);

		[DllImport("Kernel32")]
		public static extern IntPtr OpenProcess(API.DesiredAccessProcess dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

		[DllImport("kernel32.dll")]
		public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

		[DllImport("psapi.dll", SetLastError = true)]
		public static extern bool EnumProcessModules(IntPtr hProcess, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] [In] [Out] uint[] lphModule, uint cb, [MarshalAs(UnmanagedType.U4)] out uint lpcbNeeded);

		[DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern int EnumProcessModules(IntPtr hProcess, [Out] IntPtr lphModule, uint cb, out uint lpcbNeeded);

		[DllImport("kernel32.dll")]
		public static extern int CloseHandle(IntPtr hObject);

		[Flags]
		public enum DesiredAccessProcess : uint
		{
			PROCESS_TERMINATE = 1u,
			PROCESS_CREATE_THREAD = 2u,
			PROCESS_VM_OPERATION = 8u,
			PROCESS_VM_READ = 16u,
			PROCESS_VM_WRITE = 32u,
			PROCESS_DUP_HANDLE = 64u,
			PROCESS_CREATE_PROCESS = 128u,
			PROCESS_SET_QUOTA = 256u,
			PROCESS_SET_INFORMATION = 512u,
			PROCESS_QUERY_INFORMATION = 1024u,
			SYNCHRONIZE = 1048576u,
			PROCESS_ALL_ACCESS = 2035711u
		}
	}
}
