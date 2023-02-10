namespace HuskMock.Services
{
    public class NullContactServices : IContactServices
    {
        private readonly ILogger<NullContactServices> logger;

        public NullContactServices(ILogger<NullContactServices> logger)
        {
            this.logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            logger.LogInformation($"To:{to} Subject: {subject} Body: {body}");
        }
    }
}
