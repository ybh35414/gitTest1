using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gitTest1.Common;

namespace gitTest1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//gkggkgk
			//MessageBox.Show("유병희 수정함 V1");
			MessageBox.Show("유병희 수정함 V2 장창욱 22");
			MessageBox.Show("유병희 수정함 V3");

			var comm1 = new comm();
			comm1.Test1();

		}
	}
}
