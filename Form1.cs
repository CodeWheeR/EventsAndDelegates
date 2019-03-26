using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventsDelegates
{
	public partial class Form1 : Form
	{
#pragma warning disable RCS1169 // Mark field as read-only.
		private Dictionary<string, Func<int, int, double>> _operations = new Dictionary<string, Func<int, int, double>>();
		Jenya _jenya = new Jenya(9999);

#pragma warning restore RCS1169 // Mark field as read-only.

		Action act;

		private event EventHandler _operationAdd;

		public Form1()
		{
			InitializeComponent();
			_operations.Add("+", (x, y) => x + y);
			_operations.Add("-", (x, y) => x - y);
			_operationAdd += DefOperator2;
			var j = new Jenya(100);
			act = () => Trace.Write(j.HP);
			j.HP = 50;
			_jenya.HpChangedAddEvent((x, y) => lblHp.Text = _jenya.HP.ToString());
		}

		private void DefOperator2(object sender, EventArgs e)
			=> MessageBox.Show(this, $"{_operations.Count} Операция добавлена");

		private void DefOperator(object sender, EventArgs e)
			=> MessageBox.Show(this, $"{_operations.Count} Операция добавлена");

		~Form1()
		{
			_operationAdd -= DefOperator;
		}

		private void StartWork(object sender, EventArgs e)
		{
			Calc("+", 5, 3);
			_jenya.HP = 1;
			//act();
		}

		public double Calc(string op, int x, int y)
		{
			if (!_operations.ContainsKey(op))
				throw new ArgumentException();
			return _operations[op](x, y);
		}

		public void DefineOperation(string op, Func<int, int, double> act)
			=> _operations.Add(op, act);

		private double Calc<T>(T x, T y, Func<T, T, double> act)
		{
			return 0.0;
		}

		private void _btnAddOperation_Click(object sender, EventArgs e)
		{
			DefineOperation("*", (x, y) => x * y);
		}
	}
}