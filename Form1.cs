using System.Diagnostics;

namespace Direct_Algorithms_Interface
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string func = textBox1.Text;
			int min = int.Parse(textBox2.Text);
			int max = int.Parse(textBox3.Text);
			double stepN = 0.1;
			bool step =  double.TryParse(textBox4.Text, out stepN);

			if (!step)
				Debug.WriteLine("bad step");


			double minimumX;
			switch(comboBox1.SelectedIndex)
			{
				case 0:
					var funcWork = Methods.CreateFunction(func);
					minimumX = Methods.SequentialIteration(funcWork, min, max, stepN);
					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);          
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				case -1:
					break;
			}
		}
	}
}
