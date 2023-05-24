namespace PhoneBook
{
    public interface IMessageChannel
    {
        void Send(Message message);
    }
}