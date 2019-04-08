using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bombV2._0
{
	public partial class BOMB : Form
	{
		bool partial = false;
		bool partial2 = false;
		bool outputWire = true;

		public BOMB()
		{
			InitializeComponent();
			startTimer();
		}

		private async void startTimer()
		{
			for (int x = 59; x >= 0; x--)
			{
				await Task.Delay(1000);
				if (x>10)
				{
					Timer.Text = "00:" + x.ToString();

				}
				if (x == 0)
				{
					Timer.Text = "00:00";
					explode();
				}
				if (x < 10)
				{
					Timer.Text = "00:0" + x.ToString();
					if (partial && partial2 && x == 0)
						Timer.BackColor = Color.Green;
					else
						Timer.BackColor = Color.Red;
				}

			}
		}

		private void explode()
		{
			if (partial && partial2)
			{
				output.Text = "Somehow You did it";
				Timer.BackColor = Color.Green;
				Timer2.BackColor = Color.Green;

			}
			else
			{
				//System.Diagnostics.Process.Start("https://vignette.wikia.nocookie.net/steven-universe/images/1/13/Explosion.jpg/revision/latest?cb=20150816111347");
				//System.Diagnostics.Process.Start("https://socioecohistory.files.wordpress.com/2012/07/nuclear-bomb-explosion.jpg");
				//System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dOojm4TE6Ow");
				System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=sDj72zqZakE");

				output.Text = "NNNNOOOOOOOOOO";
				Timer2.Text = Timer.Text;
				Timer2.BackColor = Color.Red;
				Timer.Dispose();
			}
		}

		private void diffuse()
		{
			partial = true;
			partial2 = true;
			Timer2.Text = Timer.Text;
			Timer2.BackColor = Color.Green;
			Timer.Dispose();
			//System.Threading.Thread.Sleep(10000);
		}

		private void outputText(int wire)
		{
			Console.WriteLine(wire);

			if (outputWire)
			{


				switch (wire)
				{
					case 1:
						output.Text = "Threat eliminated";
						break;
					case 2:
						output.Text = "That's not good";
						break;
					case 3:
						output.Text = "NNNNOOOOOOOOOO";
						break;
					case 4:
						output.Text = "Partial Diffusion";
						break;
					case 5:
						output.Text = "nothing happened";
						break;
					case 6:
						output.Text = "Threat eliminated";
						break;
					case 7:
						output.Text = "Partial Diffusion";
						break;
					case 8:
						output.Text = "The bomb is still Active!!!";
						break;
					case 9:
						output.Text = "You Saved Us!!";
						break;
					case 10:
						output.Text = "I hope that was good!";
						break;
					case 11:
						output.Text = "That's not good";
						break;
					case 12:
						output.Text = "That's not good";

						break;
					default:
						break;
				}
			}
		}
		private void wire1_Click(object sender, EventArgs e)
		{
			wire8.Dispose();
			outputText(1);
			wire1.Dispose();
		}

		private void wire2_Click(object sender, EventArgs e)
		{
			if (partial)
			{
				partial = false;
			}
			else
			{
				Timer2.Text = Timer.Text;
				Timer.Dispose();
				explode();
			}
			outputText(2);
			wire2.Dispose();
		}

		private void wire3_Click(object sender, EventArgs e)
		{
			explode();
			outputText(3);
			wire3.Dispose();
		}

		private void wire4_Click(object sender, EventArgs e)
		{
			partial = true;
			outputText(4);
			wire4.Dispose();
		}

		private void wire5_Click(object sender, EventArgs e)
		{
			outputText(5);
			wire5.Dispose();
		}

		private void wire6_Click(object sender, EventArgs e)
		{
			wire3.Dispose();
			outputText(6);
			wire6.Dispose();
		}

		private void wire7_Click(object sender, EventArgs e)
		{
			partial2 = true;
			outputText(7);
			wire7.Dispose();
		}

		private void wire8_Click(object sender, EventArgs e)
		{
			outputText(8);
			wire8.Dispose();
		}

		private void wire9_Click(object sender, EventArgs e)
		{
			outputText(9);
			diffuse();
			wire9.Dispose();
		}

		private void wire10_Click(object sender, EventArgs e)
		{
			wire4.Dispose();
			outputText(10);
			wire10.Dispose();
		}

		private void wire11_Click(object sender, EventArgs e)
		{
			//output cuts out
			outputWire = false;
			output.Dispose();
			outputText(11);
			wire11.Dispose();
		}

		private void wire12_Click(object sender, EventArgs e)
		{
			if (partial2)
			{
				partial2 = false;
			}
			else
			{
				Timer2.Text = Timer.Text;
				Timer.Dispose();
				explode();
			}
			outputText(12);
			wire12.Dispose();
		}
	}
}
