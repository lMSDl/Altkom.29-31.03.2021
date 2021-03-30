namespace WPC.DesignPatterns.StructuralPatterns.Bridge.II
{
    public class MessageAbstraction
    {

        public IMessageSenderImplementation MessageSender { get; set; }

        public virtual void Send(string message)
        {
            MessageSender.SendMessage(message);
        }
    }
}