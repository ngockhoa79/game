using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Mathos.Parser
{
	public class MathParser
	{
		private readonly List<string> roughExpr;

		private readonly List<double> args;

		public List<string> OperatorList { get; set; }

		public Dictionary<string, Func<double, double, double>> OperatorAction { get; set; }

		public Dictionary<string, Func<double[], double>> LocalFunctions { get; set; }

		public Dictionary<string, double> LocalVariables { get; set; }

		public CultureInfo CultureInfo { get; set; }

		public MathParser(bool loadPreDefinedFunctions = true, bool loadPreDefinedOperators = true, bool loadPreDefinedVariables = true, CultureInfo cultureInfo = null)
		{
		}

		public double Parse(string mathExpression)
		{
			return 0.0;
		}

		public double Parse(ReadOnlyCollection<string> mathExpression)
		{
			return 0.0;
		}

		public double ProgrammaticallyParse(string mathExpression, bool correctExpression = true, bool identifyComments = true)
		{
			return 0.0;
		}

		public ReadOnlyCollection<string> GetTokens(string mathExpression)
		{
			return null;
		}

		private string Correction(string input)
		{
			return null;
		}

		private List<string> Lexer(string expr)
		{
			return null;
		}

		private double MathParserLogic(List<string> tokens)
		{
			return 0.0;
		}

		private double BasicArithmeticalExpression(List<string> tokens)
		{
			return 0.0;
		}
	}
}
