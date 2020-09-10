using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class program
{
	static void writeFile(String Filename)
	{
		FileStream fs = new FileStream(Filename, FileMode.Create, FileAccess.Write);
		if (fs.CanWrite)
		{
			byte[] buffer = Encoding.ASCII.GetBytes("Hello World");
			fs.Write(buffer, 0, buffer.Length);
		}
		fs.Flush();
		fs.Close();
	}
	static void readFile(String Filename)
	{
		FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);
		if(fs.CanRead)
        {
			byte[] buffer = new byte[fs.Length];
			int byteread = fs.Read(buffer, 0, buffer.Length);
			Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, byteread));
		}
		fs.Close();

	}
	static void Main(String[] args)
	{
		string Filename = @"F:\abc\abcd.txt";
		writeFile(Filename);
		readFile(Filename);
		Console.Read();

	}

}