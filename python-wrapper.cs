using System;
using System.Diagnostics;
using System.IO;

static class Program
{
	static int Main()
	{
		string line = Environment.CommandLine;
		int index = line.IndexOf(' ');
		index = (index < 0) ? line.Length : index;
		string exe = line.Substring(0, index);
		exe = Path.ChangeExtension(exe, ".py");
		string arg = (index + 1 >= line.Length) ? "" : line.Substring(index + 1);
		var p = Process.Start(new ProcessStartInfo("python.exe", exe + " " + arg) { UseShellExecute = false, CreateNoWindow = false });
		p.WaitForExit();
		return p.ExitCode;
	}
}