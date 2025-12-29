using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using Transpargo.Models;

[ApiController]
[Route("api/contact")]
public class ContactController : ControllerBase
{
    [HttpPost]
    public IActionResult SendMail([FromBody] ContactRequest request)
    {
        try
        {
            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(
                    "shippingagencyspartan@gmail.com",
                    "jbbj zqhu exzr yqjx"
                ),
                EnableSsl = true
            };

            var mail = new MailMessage
            {
                From = new MailAddress("shippingagencyspartan@gmail.com"),
                Subject = "New Contact Us Message",
                Body = $@"
Name: {request.Name}
Email: {request.Email}

Message:
{request.Message}
"
            };

            // Send TO shipping agency
            mail.To.Add("shippingagencyspartan@gmail.com");

            // IMPORTANT: allow reply directly to user
            mail.ReplyToList.Add(new MailAddress(request.Email));

            smtp.Send(mail);

            return Ok(new { success = true });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                success = false,
                error = ex.Message
            });
        }
    }
}
