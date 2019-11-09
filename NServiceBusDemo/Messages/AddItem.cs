using NServiceBus;

namespace Messages
{
    public class AddItem : ICommand
    {
        public string ItemId { get; set; }
    }
}