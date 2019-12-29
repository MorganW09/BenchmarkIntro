using BenchmarkDotNet.Running;

namespace BenchmarkIntro {
    class Program {
        static void Main(string[] args) {
            var stringBenchmark = BenchmarkRunner.Run<StringBenchmark>();
        }
    }
}
