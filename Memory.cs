using System;
using System.Runtime.InteropServices;

public class Memory
{
	public int memoryQtd;
	
	public Memory(int qtd)
	{
		this.memoryQtd = qtd;
	}
	
	public void vectorCreation()
	{
		unsafe
		{
			int size = this.memoryQtd*sizeof(int);
			IntPtr p = Marshal.AllocHGlobal(size);
			int* pointer = (int*)p.ToPointer();
			for (int i=0; i<this.memoryQtd; i++) pointer[i] = i;
			for (int i=0; i<this.memoryQtd; i++) Console.WriteLine($"{pointer[i] }");
			Console.WriteLine("\n\n");
		}
	}
	
}
