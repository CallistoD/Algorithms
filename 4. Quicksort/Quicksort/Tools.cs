using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    internal class Tools
    {
        public static void PrintArray(string mess, int[] arr){
            Console.Write($"{mess} --> ");
            
            foreach (int i in arr){
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        public static int[] FillRandomNum(int size, int min, int max){
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size;){
                bool contains = false;
                int num = random.Next(min, max);
                for (int j = 0; j < i; j++){
                    if (array[j] == num){
                        contains = true;
                        break;
                    }
                }
                if (!contains){
                    array[i] = num;
                    i++;
                }
            }
            return array; ;
        }



    }
}
