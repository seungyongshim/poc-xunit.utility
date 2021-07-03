using Xunit;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var xunit = new XunitFrontController(AppDomainSupport.IfAvailable, "Sample.Tests.dll");
            var discoverySink = new TestDiscoverySink();

            xunit.Find(true, discoverySink, TestFrameworkOptions.ForDiscovery());

            discoverySink.Finished.WaitOne();

            var cases = discoverySink.TestCases;

            var messageSink = new TestMessageSink();


        }
    }
}
