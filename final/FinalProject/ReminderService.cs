public class ReminderService
{
    private string _senderEmail;
    private string _senderPassword;
    private string _smtpServer;
    private int _smtpPort;

    public ReminderService(string senderEmail, string senderPassword, string smtpServer, int smtpPort)
    {
        _senderEmail = senderEmail;
        _senderPassword = senderPassword;
        _smtpServer = smtpServer;
        _smtpPort = smtpPort;
    }

    public void SendEmailNotification(string recipientEmail, string subject, string body)
    {

    }
}