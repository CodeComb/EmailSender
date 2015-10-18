using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeComb.Net.EmailSender.Sample
{
    public class Program
    {
        public void Main(string[] args)
        {
            var mail = new SmtpEmailSender("smtp.qq.com", 25, "Code Comb", "YourQQNumber@qq.com", "YourQQNumber", "YourPassword");
            mail.SendEmailAsync("1@1234.sh","关于MailSender项目说明", "<html><head><meta http-equiv=\"Content-type\" content=\"text/html;charset=utf-8\"/></head><body>能收到邮件吗</body></html>").Wait();
        }
    }
}
