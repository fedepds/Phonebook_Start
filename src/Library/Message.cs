namespace PhoneBook
{
<<<<<<< Updated upstream
    public class Message 
=======
    public class Message  : IMessageChannel
>>>>>>> Stashed changes
    {
        protected Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }

        public void Send( Message message)
        {

        }


        public string Text { get; set; }

        public string From { get; }

        public string To { get; }
    }
}