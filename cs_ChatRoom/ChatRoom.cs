namespace cs_ChatRoom
{
    public class ChatRoom : IChat
    {
        public string Name { get; private set; }
        public List<Message> Messages = new List<Message>();
        public ChatRoom(string name, List<Message> m)
        {
            Name = name;
            Messages = m;
        }

        void IChat.DisplayMessage()
        {
            foreach (var message in Messages)
                Console.WriteLine($"{message.TimeStamp}: {message.UserSentMessage.Username} - {message.Text}");
        }

        void IChat.SendMessage()
        {
            throw new NotImplementedException();
        }

    }
}
