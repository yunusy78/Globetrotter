using Entity.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class EmailController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    
    public IActionResult SendEmail()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult SendEmail(Email email)
    {
        MimeMessage message = new MimeMessage();
        MailboxAddress from = new MailboxAddress("Globetrotter.org.no", "globetrotter.org.no@gmail.com");
        message.From.Add(from);
        MailboxAddress to = new MailboxAddress("Receiver", email.ReceiverEmailAddress);
        message.To.Add(to);
        message.Body = new TextPart("plain")
        {
            Text = email.Message
        };
        message.Subject = email.Subject;
        SmtpClient client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587, false);
        client.Authenticate("globetrotter.org.no@gmail.com", "zdwvxgqvtqheqmfi");
        client.Send(message);
        //globetrotter.org.no@gmail.com
        client.Disconnect(true);
        return RedirectToAction("Index" ,"Dashboard", new{Areas="Admin"});
    }
}