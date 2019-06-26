using NBench;

namespace BusinessLogic.PerfTests
{
    public class BusinessClassTest
    {
        [PerfBenchmark]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        public void Benchmark()
        {
            new BusinessClass().DoSometing();
        }
    }
}
