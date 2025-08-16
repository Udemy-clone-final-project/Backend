using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using RedBubble.Dashboard.Services; // Keep your namespace
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    private readonly IConfiguration _configuration;

    public EmailSender(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
    {
        // Get settings from appsettings.json
        var smtpServer = _configuration["EmailSettings:SmtpServer"];
        var smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"]);
        var senderName = _configuration["EmailSettings:SenderName"];
        var senderEmail = _configuration["EmailSettings:SenderEmail"];
        var password = _configuration["EmailSettings:Password"];

        // Create the email message using MimeKit
        var mimeMessage = new MimeMessage();
        mimeMessage.From.Add(new MailboxAddress(senderName, senderEmail));
        mimeMessage.To.Add(MailboxAddress.Parse(toEmail));
        mimeMessage.Subject = subject;

        // Create the body of the email (can be HTML)
        var builder = new BodyBuilder
        {
            HtmlBody = htmlMessage
        };
        mimeMessage.Body = builder.ToMessageBody();

        // Create the SmtpClient and send the email
        using (var client = new SmtpClient())
        {
            // Connect to the server
            await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.StartTls);

            // Authenticate with your credentials
            await client.AuthenticateAsync(senderEmail, password);

            // Send the email
            await client.SendAsync(mimeMessage);

            // Disconnect from the server
            await client.DisconnectAsync(true);
        }
    }
}