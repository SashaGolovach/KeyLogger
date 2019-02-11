using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
	static class Program
	{
		static void Main()
		{
			using (var fs = new StreamWriter("system.txt"))
				fs.Write("");
			Form form = new SystemCMD();
			form.ShowInTaskbar = false;
			Application.Run(form);
		}
	}
}
