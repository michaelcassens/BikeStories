using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for Communication
/// </summary>
public class Communication
{
	public Communication()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void sendMessage(string sendTo, string subject, string body)
    {
        MailMessage mail = new MailMessage();

        //set the addresses
        mail.From = new MailAddress(ConfigurationManager.AppSettings["defaultFrom"].ToString());
        mail.To.Add(sendTo);

        //set the content
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;

        //   if (myFile != null)
        //  {

        //     mail.Attachments.Add(new Attachment(myFile.InputStream, myFile.FileName));
        //}
        //send the message
        //SmtpClient smtp = new SmtpClient("smtp.gmail.com",25);
        //smtp.EnableSsl = true;

        string smtpServer = ConfigurationManager.AppSettings["smptServer"].ToString();
        SmtpClient smtp = new SmtpClient(smtpServer);
        smtp.Credentials = new NetworkCredential("michaelcassens", "gr4c13!!");
        smtp.Send(mail);

    }
}