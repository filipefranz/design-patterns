namespace FactoryMethod.Product
{
    public abstract class Screen
    {
        protected string BackgroundColor { get; }
        private readonly string MessageText;

        public Screen(string backgroundColor, string messageText)
        {
            BackgroundColor = backgroundColor;
            MessageText = messageText;
        }

        public string GetMessageText()
        {
            return MessageText;
        }
    }
}
