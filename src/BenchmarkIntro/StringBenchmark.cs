using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkIntro {
    [MemoryDiagnoser]
    public class StringBenchmark {

        [Params(100, 1000)]
        public int N;

        [Benchmark]
        public void RegularString() {
            string word = "";
            for (int i = 0; i < N; i++) {
                word += i;
            }
        }

        [Benchmark]
        public void StringBuilder() {
            StringBuilder word = new StringBuilder("");
            for(int i = 0; i < N; i++) {
                word.Append(i);
            }
        }
    }
}
