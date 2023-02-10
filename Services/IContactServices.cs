namespace HuskMock.Services
{
    public interface IContactServices
    {
        void SendMessage(string to, string subject, string body);
    }
}