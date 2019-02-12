using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Algorithms.Sorting;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
            Console.WriteLine(summary);
            ////for(var i = 0; i < 100; i++)
            ////{
            ////    var array = GenerateArray(100000);
            ////    array.Quicksort();
            ////}
        }


        [Benchmark(Description = "Linq Sort")]
        [ArgumentsSource(nameof(RandomArrays))]
        public void SortBenchmark(int[] array)
        {
            array.OrderBy(x => x).ToList();
        }

        [Benchmark(Description = "Quicksort_rec on List<T>")]
        [ArgumentsSource(nameof(RandomArrays))]
        public void QuicksortBenchmark(int[] array)
        {
            array.Quicksort();
        }

        [Benchmark(Description = "Mergesort_rec on List<T>")]
        [ArgumentsSource(nameof(RandomArrays))]
        public void MergesortBenchmark(int[] array)
        {
            array.Mergesort();
        }

        //[Benchmark(Description = "Quicksort_rec on Span<T>")]
        //[ArgumentsSource(nameof(RandomArrays))]
        //public void QuicksortRecBenchmark(int[] array)
        //{
        //    array.Quicksort();
        //}

        public static IEnumerable<int[]> RandomArrays()
        {
            yield return GenerateArray(1000);
        }

        private static int[] GenerateArray(int count)
        {
            var randomizer = new Random();
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = randomizer.Next(-100, 100);
            }

            return array;
        }
    }
}
