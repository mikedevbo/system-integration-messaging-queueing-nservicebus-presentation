using NServiceBus;
using System;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            const string endpointName = "Server";

            Console.Title = endpointName;

            var endpointConfiguration = new EndpointConfiguration(endpointName);

            ////// uncomment if you want to disable delayed retries
            ////endpointConfiguration.Recoverability().Delayed(custom => custom.NumberOfRetries(0));

            endpointConfiguration.UseTransport<LearningTransport>();
            endpointConfiguration.UsePersistence<LearningPersistence>();

            var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

            Console.WriteLine("Ready");
            Console.ReadKey();

            await endpointInstance.Stop().ConfigureAwait(false);
        }
    }
}
