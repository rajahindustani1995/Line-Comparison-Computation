﻿namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            LineComparisonComputation lineModel = new LineComparisonComputation();
            lineModel.LineMeasuring();
            EqualityOfLength line = new EqualityOfLength();
            line.TwoLineEquality();
            CompareTwoLineLength compare = new CompareTwoLineLengths();
            compare.TwoLineCompare();
        }
    }
}
