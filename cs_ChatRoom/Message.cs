namespace cs_ChatRoom
{
    public class Message
    {
        public User UserSentMessage { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp;

        public Message(User userSentMessage, string text)
        {
            UserSentMessage = userSentMessage;
            Text = text;
            TimeStamp = DateTime.Now;
        }
    }
}
