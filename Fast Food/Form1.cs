using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			panel4.Height = button1.Height;
			panel4.Top = button1.Top;

			firstCustomerControl1.BringToFront();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			panel4.Height = button2.Height;
			panel4.Top = button2.Top;
			mySecondCustomControl1.BringToFront();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			panel4.Height = button3.Height;
			panel4.Top = button3.Top;
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			panel4.Height = button5.Height;
			panel4.Top = button5.Top;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			panel4.Height = button4.Height;
			panel4.Top = button4.Top;
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			panel4.Height = button6.Height;
			panel4.Top = button6.Top;
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			panel4.Height = button7.Height;
			panel4.Top = button7.Top;
		}
	}
}
