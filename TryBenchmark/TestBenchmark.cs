using BenchmarkDotNet.Attributes;
using System.Text;


namespace TryBenchmark
{  /*Run in Release Mode to see Benchmark in Action*/
    public class TestBenchmark
    {
        [Params(100, 1000, 10000)]
        public int N;
      
        [Benchmark]
        public void Concatnate()
        {
            string resString=string.Empty;
            for (int i = 0; i < N; i++)
            {
                resString += i;
            }
        }

        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder resString=new ("");
            for (int i = 0; i < N; i++)
            {
                resString.Append(i);
            }
            
        }
    }
}
