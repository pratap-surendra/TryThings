// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Running;
using TryBenchmark;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<TestBenchmark>();

