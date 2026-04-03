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
		int size = this.memoryQtd*sizeof(int);
		unsafe
		{
			IntPtr p = Marshal.AllocHGlobal(size);
			int* pointer = (int*)p.ToPointer();
			
			Console.Write("Vector creation method = ");
			for (int i=0; i<this.memoryQtd; i++) pointer[i] = i;
			for (int i=0; i<this.memoryQtd; i++) Console.Write($"{pointer[i] }");
			Console.Write("\n");
			Marshal.FreeHGlobal(p);
		}
	}
	
}
