namespace LR1.Services
{
    public interface IEmailSender
    {
        Task SendMessege(string name, string email, string subject, string message);
    }
}
