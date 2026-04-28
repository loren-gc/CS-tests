using System;
using System.IO;
using System.Net.Mime;
using System.Text;

class Program
{
    static void Main()
    {
        
        using (FileStream file = File.Open("test_file.txt", FileMode.Open))
        {
            byte[] file_buffer = new byte[file.Length];
            int read_bytes = file.Read(file_buffer, 0, file_buffer.Length);
            string content = Encoding.UTF8.GetString(file_buffer);
            Console.WriteLine($"This file has {read_bytes} bytes\n");
            Console.Write(content);
        }

    }
}
