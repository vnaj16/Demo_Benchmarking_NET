// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Demo_Benchmarking_NET;

var results = BenchmarkRunner.Run<MethodsToCompare>();
//Console.WriteLine(results);
Console.ReadKey();
