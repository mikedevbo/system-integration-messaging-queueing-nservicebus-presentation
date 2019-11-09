using Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Threading.Tasks;

namespace Server
{
    public class AddItemHandler : IHandleMessages<AddItem>
    {
        private static ILog log = LogManager.GetLogger<AddItemHandler>();
        private static Random random = new Random();

        public Task Handle(AddItem message, IMessageHandlerContext context)
        {
            ////// Uncomment if you want to simulate timeout or deadlock exception
            ////if (random.Next(0, 5) == 0)
            ////{
            ////    throw new Exception("Timeout_Deadlock");
            ////}

            ////// Uncomment if you want to simulate bug exception
            ////throw new Exception("Bug");

            log.Info($"Item processed: {message.ItemId}");
            return Task.CompletedTask;
        }
    }
}
