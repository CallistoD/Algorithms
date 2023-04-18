using BenchmarkDotNet.Properties;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quicksort
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int[] randomArray = Tools.FillRandomNum(20, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            FirstPivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("First pivot", randomArray);
            Console.WriteLine();

            randomArray = Tools.FillRandomNum(20, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            MiddlePivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("Middle pivot", randomArray);
            Console.WriteLine();

            randomArray = Tools.FillRandomNum(20, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            LastPivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("Last pivot", randomArray);
            Console.WriteLine();

            BenchmarkSwitcher.FromAssembly(typeof(Programm).Assembly).Run(args, new BenchmarkDotNet.Configs.DebugInProcessConfig());
            BenchmarkRunner.Run<AlgorithmSortTest>();
        }
    }
}
