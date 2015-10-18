# Email Sender

AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/b20aaib5fed0o7yr/branch/dev?svg=true)](https://ci.appveyor.com/project/Kagamine/emailsender/branch/dev)

Travis: [![Build status](https://travis-ci.org/CodeComb/EmailSender.svg)](https://travis-ci.org/CodeComb/EmailSender)

An email sender library for DNXCORE50 / DNX451

For DI:

```
services.AddSmtpEmailSender(server, port, senderName, email, username, password, ssl);
...
var mail = services.GetRequiredService<IEMailSender>();
mail.SendEmailAsync("blablabla@blabla.com","Title", "<html><head><meta http-equiv=\"Content-type\" content=\"text/html;charset=utf-8\"/></head><body>Html</body></html>").Wait();
```

For Common:

```
using CodeComb.Net.EmailSender;
...
var mail = new SmtpEmailSender("smtp.qq.com", 25, "Code Comb", "YourQQNumber@qq.com", "YourQQNumber", "YourPassword");
mail.SendEmailAsync("1@1234.sh","关于MailSender项目说明", "<html><head><meta http-equiv=\"Content-type\" content=\"text/html;charset=utf-8\"/></head><body>能收到邮件吗</body></html>").Wait();
```