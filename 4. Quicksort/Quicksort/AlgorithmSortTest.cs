using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    [MemoryDiagnoser]
    public class AlgorithmSortTest
    {
        [Benchmark]
        public void FirstPivotTest(){
            int[] randomArray = Tools.FillRandomNum(10, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            FirstPivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("First pivot", randomArray);
            
        }

        [Benchmark]
        public void MiddlePivotTest(){
            int[] randomArray = Tools.FillRandomNum(10, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            MiddlePivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("Middle pivot", randomArray);
            
        }

        [Benchmark]
        public void LastPivotTest(){
            int[] randomArray = Tools.FillRandomNum(10, 0, 1000);
            Tools.PrintArray("Unsorted array", randomArray);
            LastPivot.SortArray(randomArray, 0, randomArray.Length - 1);
            Tools.PrintArray("Last pivot", randomArray);
            
        }

    }
}
