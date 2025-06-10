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

		public static Func<double, double> CreateFunction(string expression)
		{
			// Заменяем ^ на ** для возведения в степень в NCalc
			expression = expression.Replace("^", "**");

			return (double x) =>
			{
				var e = new Expression(expression);
				e.Parameters["x"] = x;
				var result = e.Evaluate();
				return Convert.ToDouble(result);
			};
		}

		public static double SequentialIteration(Func<double, double> f, double a, double b, double step)
		{
			double minValue = double.MaxValue;
			double minPoint = a;

			for (double x = a; x <= b; x += step)
			{
				double currentValue = f(x);
				if (currentValue < minValue)
				{
					minValue = currentValue;
					minPoint = x;
				}
			}

			return minPoint;
		}

	}
}
