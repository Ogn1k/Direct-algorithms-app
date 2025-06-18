using System.Diagnostics;

namespace Direct_Algorithms_Interface
{
	public partial class Form1 : Form
	{
		private bool isExpanded = false;
		private int originalWidth;
		Methods methods = new Methods();

		public Form1()
		{
			InitializeComponent();
			methods.formInstance = this;
			// Настройка основной формы
			originalWidth = this.Width;

			if (isExpanded)
				outputTextBox.Visible = true;
			else
				outputTextBox.Visible = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		bool isError = false;

		private void button1_Click(object sender, EventArgs e)
		{
			isError = false;
			if (textBox1.Text == null || textBox1.Text == "")
			{
				AppendText("Ошибка ввода: Пожалуйста, введите функцию");
				AppendText("");
				isError = true;
			}
			string func = textBox1.Text;
			if (!double.TryParse(textBox2.Text, out double min))
			{
				AppendText("Ошибка ввода: Пожалуйста, введите корректное целое число для минимального значения");
				AppendText("");
				textBox2.Focus();
				isError = true;
			}

			// Проверка textBox3 (max)
			if (!double.TryParse(textBox3.Text, out double max))
			{
				AppendText("Ошибка ввода: Пожалуйста, введите корректное целое число для максимального значения");
				AppendText("");
				textBox3.Focus();
				isError = true;
			}

			// Проверка textBox4 (step) - с значением по умолчанию 0.1
			double stepN = 0.1;
			if (!string.IsNullOrWhiteSpace(textBox4.Text) &&
				!double.TryParse(textBox4.Text, out stepN))
			{
				AppendText("Ошибка ввода: Пожалуйста, введите корректное число для шага");
				AppendText("");
				textBox4.Focus();
				isError = true;
			}

			// Проверка диапазона (min < max)
			if (min >= max)
			{
				AppendText("Ошибка диапазона: Минимальное значение должно быть меньше максимального");
				AppendText("");
				isError = true;
			}

			// Проверка шага (step > 0)
			if (stepN <= 0)
			{
				AppendText("Ошибка шага: Шаг должен быть положительным числом");
				AppendText("");
				textBox4.Focus();
				isError = true;
			}

			if (isError) return;

			double minimumX;
			Func<double, double> funcWork = methods.CreateFunction(func);
			if (!methods.IsUnimodal(funcWork, min, max))
			{
				AppendText("Логическая ошибка: Функция должна быть унимодальной");
				AppendText("");
				isError = true;
			}

			if (isError) return; 

			Stopwatch stopwatch;
			ClearText();
			switch (comboBox1.SelectedIndex)
			{
				case 0:
					stopwatch = Stopwatch.StartNew();
					minimumX = methods.SequentialIteration(funcWork, min, max, stepN);
					stopwatch.Stop();
					AppendText("");
					AppendText($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds}  милисек");

					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);
					break;
				case 1:
					stopwatch = Stopwatch.StartNew();
					minimumX = methods.Dichotomy(funcWork, min, max, stepN);
					stopwatch.Stop();
					AppendText("");
					AppendText($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} милисек");

					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);
					break;
				case 2:
					stopwatch = Stopwatch.StartNew();
					minimumX = methods.GoldenRatio(funcWork, min, max, stepN);
					stopwatch.Stop();
					AppendText("");
					AppendText($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} милисек");

					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);
					break;
				case 3:
					stopwatch = Stopwatch.StartNew();
					minimumX = methods.Parabola(funcWork, min, max, (min+max)/2);
					stopwatch.Stop();
					AppendText("");
					AppendText($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} милисек");

					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);
					break;
				case 4:
					Func<int, double> intFunc = (int x) => funcWork(x);
					stopwatch = Stopwatch.StartNew();
					minimumX = methods.Bitwise(intFunc, (int)min, (int)max);
					stopwatch.Stop();
					AppendText("");
					AppendText($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} милисек");

					label7.Text = "x = " + minimumX;
					label9.Text = "f(x) = " + funcWork(minimumX);
					break;
				case -1:
					break;
			}
		}

		// Метод для добавления текста в поле вывода (можно вызывать из других частей программы)
		public void AppendText(string text)
		{
			outputTextBox.AppendText(text + Environment.NewLine);
			outputTextBox.ScrollToCaret();
		}

		public void ClearText()
		{ outputTextBox.Clear(); }

		private void button2_Click(object sender, EventArgs e)
		{
			if (isExpanded)
			{
				// Сворачиваем форму
				this.Width = originalWidth;
				plusButton.Text = ">> Развернуть >>";

				// Пример вывода текста в поле (можно удалить)
				outputTextBox.Clear();
			}
			else
			{
				// Расширяем форму
				this.Width = originalWidth + 300;
				plusButton.Text = "<< Свернуть <<";

				
			}

			outputTextBox.Visible = !outputTextBox.Visible;
			isExpanded = !isExpanded;
		}

	}
}
