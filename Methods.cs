using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direct_Algorithms_Interface
{
	internal class Methods
	{
		public Form1 formInstance;
		bool calculable = true;

		public Func<double, double> CreateFunction(string expression)
		{
			calculable = true;
			// Заменяем ^ на ** для возведения в степень в NCalc
			expression = expression
				.Replace("sin", "Sin")
				.Replace("cos", "Cos")
				.Replace("tan", "Tan")
				.Replace("exp", "Exp")
				.Replace("log", "Log")
				.Replace("sqrt", "Sqrt");

			return (double x) =>
			{
				try 
				{ 
					var e = new Expression(expression);
					e.Parameters["x"] = x;
					var result = e.Evaluate();
					
					return Convert.ToDouble(result);
				}
				catch (Exception ex)
				{
					formInstance.AppendText(ex.Message);
					formInstance.AppendText("");
					calculable = false;
					return double.NaN;
				}
			};
		}

		public double SequentialIteration(Func<double, double> f, double a, double b, double step)
		{
			if (!calculable) return 0;
			double minValue = double.MaxValue;
			double minPoint = a;
			int i = 0;
			int nf = 0;
			for (double x = a; x <= b; x += step)
			{
				formInstance.AppendText($"iteration {i}: {x}, nf = {nf}");
				formInstance.AppendText("");
				double currentValue = f(x);
				nf++;
				if (currentValue < minValue)
				{
					minValue = currentValue;
					minPoint = x;
				}
				i++;
			}

			return minPoint;
		}

		public double Dichotomy(Func<double, double> f, double a, double b, double epsilon = 1e-6, double delta = 1e-7)
		{
			if (!calculable) return 0;
			int iteration = 0;
			int nf = 0;

			while ((b - a) > epsilon)
			{
				double mid = (a + b) / 2;
				double x1 = mid - delta;
				double x2 = mid + delta;

				double f1 = f(x1);
				double f2 = f(x2);

				formInstance.AppendText($"Iteration {iteration}: nf = {nf}, a = {a:F6}, b = {b:F6}, x1 = {x1:F6}, f(x1) = {f1:F6}, x2 = {x2:F6}, f(x2) = {f2:F6}");
				formInstance.AppendText("");
				if (f1 < f2)
				{
					nf += 2;
					b = x2;
				}
				else
				{
					nf += 2;
					a = x1;
				}

				iteration++;
			}

			double minimumX = (a + b) / 2;
			//Console.WriteLine($"Minimum found at x = {minimumX:F6}, f(x) = {f(minimumX):F6} after {iteration} iterations.");
			return minimumX;
		}

		public double GoldenRatio(Func<double, double> f, double a, double b, double epsilon = 1e-6)
		{
			if (!calculable) return 0;
			double gr = (Math.Sqrt(5) - 1) / 2; // Golden ratio coefficient ≈ 0.618
			double x1 = b - gr * (b - a);
			double x2 = a + gr * (b - a);
			double f1 = f(x1);
			double f2 = f(x2);

			int iteration = 0;
			int nf = 0;

			while ((b - a) > epsilon)
			{
				formInstance.AppendText($"Iteration {iteration}: nf = {nf}, a = {a:F6}, b = {b:F6}, x1 = {x1:F6}, f(x1) = {f1:F6}, x2 = {x2:F6}, f(x2) = {f2:F6}");
				formInstance.AppendText("");
				if (f1 < f2)
				{
					nf+=2;
					b = x2;
					x2 = x1;
					f2 = f1;
					x1 = b - gr * (b - a);
					f1 = f(x1);
				}
				else
				{
					nf+= 2;
					a = x1;
					x1 = x2;
					f1 = f2;
					x2 = a + gr * (b - a);
					f2 = f(x2);
				}

				iteration++;
			}

			double minimumX = (a + b) / 2;
			//Console.WriteLine($"Minimum found at x = {minimumX:F6}, f(x) = {f(minimumX):F6} after {iteration} iterations.");
			return minimumX;
		}

		public double Parabola(Func<double, double> f, double x0, double x1, double x2, double epsilon = 1e-6)
		{
			if (!calculable) return 0;
			int iteration = 0;
			int nf = 0;

			double f0 = f(x0); nf++;
			double f1 = f(x1); nf++;
			double f2 = f(x2); nf++;

			double x3 = x1;
			double f3 = f1; // Инициализация для вывода, будет пересчитана на 1-й итерации

			while (true)
			{
				double numerator = Math.Pow(x1 - x0, 2) * (f1 - f2) - Math.Pow(x1 - x2, 2) * (f1 - f0);
				double denominator = 2 * ((x1 - x0) * (f1 - f2) - (x1 - x2) * (f1 - f0));

				if (denominator == 0) break;

				x3 = x1 - numerator / denominator;
				f3 = f(x3); nf++;

				formInstance.AppendText($"Iteration {iteration}: nf = {nf}, x0 = {x0:F6}, x1 = {x1:F6}, x2 = {x2:F6}, x3 = {x3:F6}, f(x3) = {f3:F6}");
				formInstance.AppendText("");

				// Обновляем только одну точку и соответствующее значение функции
				if (x3 < x1)
				{
					if (f3 < f1)
					{
						x2 = x1;
						f2 = f1;
						x1 = x3;
						f1 = f3;
					}
					else
					{
						x0 = x3;
						f0 = f3;
					}
				}
				else
				{
					if (f3 < f1)
					{
						x0 = x1;
						f0 = f1;
						x1 = x3;
						f1 = f3;
					}
					else
					{
						x2 = x3;
						f2 = f3;
					}
				}

				iteration++;

				if (Math.Abs(x3 - x1) < epsilon)
					break;
			}

			//formInstance.AppendText($"Minimum found at x = {x3:F6}, f(x) = {f3:F6} after {iteration} iterations.");
			//formInstance.AppendText($"Total function evaluations: {nf}");

			return x3;
		}


		public int Bitwise(Func<int, double> f, int left, int right)
		{
			if (!calculable) return 0;
			int nf = 0;
			int iteration = 0;
			while (right - left > 3)
			{
				int mid1 = left + (right - left) / 3;
				int mid2 = right - (right - left) / 3;

				double f1 = f(mid1); nf++;
				double f2 = f(mid2); nf++;	

				formInstance.AppendText($"iteration {iteration}: nf = {nf}left = {left}, right = {right}, mid1 = {mid1}, f1 = {f1:F6}, mid2 = {mid2}, f2 = {f2:F6}");
				formInstance.AppendText("");
				if (f1 < f2)
				{
					right = mid2;
				}
				else
				{
					left = mid1;
				}
				iteration++;
			}

			// Final loop to check small range
			int bestX = left;
			double bestF = f(left); nf++;
			for (int x = left + 1; x <= right; x++)
			{
				double val = f(x); nf++;
				if (val < bestF)
				{
					bestF = val;
					bestX = x;
				}
				iteration++;
			}
			formInstance.AppendText($"iteration {iteration}: nf = {nf}");
			//Console.WriteLine($"Minimum found at x = {bestX}, f(x) = {bestF:F6}");
			return bestX;
		}

		public bool IsUnimodal(Func<double, double> f, double a, double b, int steps = 1000)
		{
			double stepSize = (b - a) / steps;
			bool increasing = false;
			bool decreasing = false;

			double prev = f(a);
			for (int i = 1; i <= steps; i++)
			{
				double x = a + i * stepSize;
				double current = f(x);

				if (current > prev)
				{
					if (decreasing) increasing = true;
				}
				else if (current < prev)
				{
					if (increasing) return false; // Changed from increasing back to decreasing
					decreasing = true;
				}

				prev = current;
			}

			return true; // It was strictly decreasing then increasing — unimodal
		}

	}
}
