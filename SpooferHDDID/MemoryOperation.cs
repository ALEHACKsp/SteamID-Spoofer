using System;

namespace SpooferHDDID
{
	public class MemoryOperation : IDisposable
	{
		public MemoryOperation(int pId)
		{
			this.handle = API.OpenProcess(API.DesiredAccessProcess.PROCESS_ALL_ACCESS, false, (uint)pId);
		}

		public void WriteProcessMemory(IntPtr adress, byte[] bWhatWrite)
		{
			uint flNewProtect;
			API.VirtualProtectEx(this.handle, adress, (IntPtr)8, 4u, out flNewProtect);
			IntPtr intPtr;
			API.WriteProcessMemory(this.handle, adress, bWhatWrite, (uint)bWhatWrite.Length, out intPtr);
			API.VirtualProtectEx(this.handle, adress, (IntPtr)8, flNewProtect, out flNewProtect);
		}

		public int ReadInt(int address)
		{
			int result = 0;
			API.ReadProcessMemory(this.handle, address, ref result, 4, 0);
			return result;
		}

		public byte[] ReadBytes(IntPtr adress, int length)
		{
			byte[] array = new byte[length];
			int num;
			API.ReadProcessMemory(this.handle, adress, array, array.Length, out num);
			return array;
		}

		public void Dispose()
		{
			API.CloseHandle(this.handle);
			this.handle = IntPtr.Zero;
		}

		private IntPtr handle;
	}
}
