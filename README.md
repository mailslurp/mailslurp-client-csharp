# MailSlurp C\# Client

> Create real email addresses on demand. Send and receive emails and attachments from code and tests using CSharp (C# DotNet Core).

MailSlurp is an email API service that lets you create real email addresses in code. You can then send and receive emails and attachments in C# applications and tests.

```csharp
// create client
var config = new Configuration();
config.ApiKey.Add("x-api-key", ApiKey);

// create inboxes
var inboxControllerApi = new InboxControllerApi(config);
var inbox1 = inboxControllerApi.CreateInbox();
var inbox2 = inboxControllerApi.CreateInbox();

// send email
inboxControllerApi.SendEmail(inbox1.Id, new SendEmailOptions(
    to: new List<string> {inbox2.EmailAddress},
    subject: "Test CSharp",
    body: "<span>Hello</span>",
    isHTML: true
));

// receive email with wait controller
var email = new WaitForControllerApi(config).WaitForLatestEmail(inbox2.Id, 60000, true);
StringAssert.Contains(email.Body, "Hello");

// list emails in inbox
var emails = inboxControllerApi.GetInboxEmailsPaginated(inbox2.Id);
Assert.AreEqual(emails.TotalElements, 1);
```

## Quick links

- [Method Documentation](https://mailslurp.github.io/mailslurp-client-csharp/)
- [NuGet Package](https://www.nuget.org/packages/mailslurp/)
- [Code Examples](https://github.com/mailslurp/examples)
- [Github Source](https://github.com/mailslurp/mailslurp-client-csharp)
- [CSharp SMTP access](https://www.mailslurp.com/smtp/csharp-send-email-smtp/)

### Tutorials

- [SpecFlow email integration test](https://www.mailslurp.com/examples/specflow-test-email-accounts/)
- [Selenium DotNet email tutorial](https://www.mailslurp.com/examples/test-emails-selenium-dotnet-csharp/)

## Get started

This section describes how to get up and running with the CSharp client. The client targets `DotNet-Core 2.1` and greater. If you need a different target see the .NET Standard targets below or consider calling the [REST API](https://docs.mailslurp.com/api/).

- [.NET Core 2.1](https://github.com/mailslurp/mailslurp-client-csharp)
- [.NET Standard 2.1](https://github.com/mailslurp/mailslurp-client-csharp-netstandard-2x)

See the method documentation for a [list of all functions](https://github.com/mailslurp/mailslurp-client-csharp)

### Create API Key

First you'll need an API Key. [Create a free account](https://app.mailslurp.com) and copy the key from your dashboard.

### Install NuGet Package

MailSlurp's CSharp library is [hosted on NuGet](https://www.nuget.org/packages/mailslurp/).

![dotnet add mailslurp](https://www.mailslurp.com/assets/dotnet-add-mailslurp.png)

#### With .NET CLI

```bash
dotnet add package mailslurp
dotnet restore
```

### Package Manager

```bash
Install-Package mailslurp
```

## Configure client

Once your MailSlurp package is installed you can configure a client with your API Key.

```csharp
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

var config = new Configuration();
config.ApiKey.Add("x-api-key", "your_api_key_here");
```

### Create controllers

You can call API controllers using the corresponding ControllerApi classes.

```csharp
// create an inbox controller to control inboxes
var apiInstance = new InboxControllerApi(config);
```

### Common controllers

- [EmailController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.EmailControllerApi.html) read and send emails
- [InboxController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.InboxControllerApi.html) create email addresses
- [WaitForController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.WaitForControllerApi.html) wait for emails to arrive
- [WebhookController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.WebhookControllerApi.html) manage http server webhooks

## Common uses

MailSlurp has many functions. Here are some common uses:

### Create an inbox

Inboxes have an ID and a real email address. You can create them using the [InboxController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.InboxControllerApi.html). For more information see the [creating inboxes guide](https://www.mailslurp.com/guides/creating-inboxes/).

```csharp
var apiInstance = new InboxControllerApi(config);
var inbox = apiInstance.CreateInbox();

Assert.NotNull(inbox);
Assert.Contains("@mailslurp.com", inbox.EmailAddress);
```

#### Inbox types

Inboxes can be either `SMTP` or `HTTP` type. Set the inbox type using the `inboxType` property. SMTP inboxes are handled by a custom mailserver and support a wide range of clients while HTTP inboxes use Amazon SES and don't support some older clients like Outlook. SMTP inboxes are recommended for public facing email addresses while HTTP inboxes are best for application testing. Please see the guide on [types of inboxes](https://www.mailslurp.com/guides/smtp-vs-http-email-inboxes/) for more information.

### Send and receive using SMTP Client 
MailSlurp provides SMTP and IMAP servers for all SMTP inboxes. Each account has unique username and password for IMAP and SMTP.

| Protocol | Host             | Port | TLS   | Description |
|----------|------------------|------|-------|-------------|
| SMTP     | mailslurp.mx     | 2587 | true  | SMTP server |
| SMTP     | mx.mailslurp.com | 2525 | false | SMTP server |
| IMAP     | mailslurp.click  | 1143 | false | IMAP server |

If you wish to send or receive using SMTP in CSharp simply create an SMTP type inbox and use the `GetImapSmtpAccess` method on the inbox controller to obtain SMTP host, port, username and password for your client. Set SSL to false:

```csharp
using System;
using System.Net;
using System.Net.Mail;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;
using Xunit;

namespace SmtpService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSendEmailWithMailSlurpSmtp()
        {
            var apiKey = Environment.GetEnvironmentVariable("API_KEY")
                         ?? throw new ArgumentNullException("Missing API_KEY environment variable containing MailSlurp key");

            // configure client
            var config = new Configuration();
            config.ApiKey.Add("x-api-key", apiKey);
            var inboxController = new InboxControllerApi(config);

            // create an smtp inbox
            var inbox = inboxController.CreateInboxWithOptions(new CreateInboxDto(
                inboxType: CreateInboxDto.InboxTypeEnum.SMTPINBOX
            ));
            Assert.Contains("@mailslurp.mx", inbox.EmailAddress);

            // get smtp host, port, password, username etc
            var imapSmtpAccessDetails = inboxController.GetImapSmtpAccess();
            var smtpClient = new SmtpClient(imapSmtpAccessDetails.SmtpServerHost)
            {
                Port = imapSmtpAccessDetails.SmtpServerPort,
                Credentials = new NetworkCredential(userName: imapSmtpAccessDetails.SmtpUsername, password: imapSmtpAccessDetails.SmtpPassword),
                // disable ssl recommended
                EnableSsl = false
            };
            
            // send email to inbox
            smtpClient.Send(from: "test@external.com", recipients: inbox.EmailAddress, subject: "This inbound", body: "Hello");
            
            // wait for email to arrive
            var waitController = new WaitForControllerApi(config);
            waitController.WaitForLatestEmail(inboxId: inbox.Id, timeout: 30_000);
        }
    }
}
```

### Can list inboxes

Inboxes are listed in paginated format:

```csharp
[TestMethod]
public void Can_List_Inboxes()
{
    
    // create an inbox controller
    var inboxControllerApi = new InboxControllerApi(_config);
    var pageInboxes = inboxControllerApi.GetAllInboxes(page:0, size:20);
    
    // result pagination options
    Assert.IsTrue(pageInboxes.Number == 0);
    
    // contents contains the results
    foreach (var inboxProjection in pageInboxes.Content)
    {
        Assert.IsNotNull(inboxProjection.Id);
    }
}
```

See the [InboxController docs](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.InboxControllerApi.html) for help.

### Verify email address
Validate email recipients to maintain a good sender reputation and reduce bounces.

```csharp
Log("Can validate email address");
var emails = new List<string>
{
    "contact@mailslurp.dev",
    "bad@mailslurp.dev"
};
var emailVerificationControllerApi = new EmailVerificationControllerApi(config);
var validateEmailAddressListResult = emailVerificationControllerApi.ValidateEmailAddressList(new ValidateEmailAddressListOptions(emails));
Assert(validateEmailAddressListResult.InvalidEmailAddresses.Contains("bad@mailslurp.dev"), "Has invalid");
Assert(validateEmailAddressListResult.ValidEmailAddresses.Contains("contact@mailslurp.dev"), "Has valid");
```

### Send emails

You can send an email by first creating an inbox. Then use the inbox ID to send an email from it.

```csharp
var sendEmailOptions = new SendEmailOptions()
{
    To = new List‹string›() {"test@example.com"},
    Subject = "Hello",
    Body = "<h1>MailSlurp supports HTML</h1>",
};
apiInstance.SendEmail(inbox.Id, sendEmailOptions);
```

See the [SendEmailOptions](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Model.SendEmailOptions.html) for sending options.

### Receive emails

You can fetch and read emails that already exist using the [EmailControllerApi](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.EmailControllerApi.html). To wait for expected emails to arrive use the [WaitForControllerApi](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.WaitForControllerApi.html) to wait for conditions to be met.

You can receive emails using `waitFor` methods on the [WaitForControllerApi](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.WaitForControllerApi.html) class.

```csharp
var Timeout = 30000L; // max milliseconds to wait
var UnreadOnly = true; // only count unread emails

var waitForInstance = new WaitForControllerApi(config);
var email = waitForInstance.WaitForLatestEmail(inbox.Id, Timeout, UnreadOnly);

Assert.NotNull(email);
Assert.Equal("Hello", email.Subject);
Assert.Contains("Your code is: ", email.Body);
```

You can extract content from email bodies using RegExps:

```csharp
// imagine that email body is `Your code is: 123` and you want to get the number
var rx = new Regex(@"Your code is: ([0-9]{3})", RegexOptions.Compiled);
var match = rx.Match(email.Body);
var code = match.Groups[1].Value;

Assert.Equal("123", code);
```

If you are having trouble receiving emails please see the [email receiving guide](https://www.mailslurp.com/guides/receiving-emails/) or the [inbox not receiving support page](https://www.mailslurp.com/support/inbox-not-receiving-emails/).

### Attachments

To send attachments first upload them using the [AttachmentControllerApi](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.AttachmentControllerApi.html).

```csharp
private List<string> _uploadAttachment()
{
    var attachmentControllerApi = new AttachmentControllerApi(_config);
    // read a file in byte array
    byte[] bytesOfAttachment = {0};
    // encode the bytes as base64 encoded string
    string base64EncodedFile = Convert.ToBase64String(bytesOfAttachment, 0, bytesOfAttachment.Length);
    // specify file name and content-type
    var uploadOptions = new UploadAttachmentOptions(filename:"test.txt", contentType:"text/plain", base64Contents: base64EncodedFile);
    // use the returned list of ids for subsequent sending (can return multiple ids depending on size of files).
    return attachmentControllerApi.UploadAttachment(uploadOptions);
}
```

Then use the returned attachment IDs in the [SendEmailOptions](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Model.SendEmailOptions.html) of your email send call.

```csharp
[TestMethod]
public void Can_Receive_Email_Contents_And_Attachments()
{
    
    // create two inboxes and send an email between them
    var inboxControllerApi = new InboxControllerApi(_config);
    var inbox1 = inboxControllerApi.CreateInbox();
    var inbox2 = inboxControllerApi.CreateInbox();
    
    // send email with attachment from inbox 1 to inbox 2
    var sendEmailOptions = new SendEmailOptions(
        // send to inbox 2
        to: new List<string> {inbox2.EmailAddress},
        subject: "Hello inbox 2",
        body: "Here is your attachment",
        isHTML: true,
        attachments: _uploadAttachment()
    );
    inboxControllerApi.SendEmail(inbox1.Id, sendEmailOptions);
    
    // now wait for email to arrive in inbox 2
    var waitForControllerApi = new WaitForControllerApi(_config);
    var email = waitForControllerApi.WaitForLatestEmail(inboxId: inbox2.Id, timeout: 30000, unreadOnly: true);
    
    // validate received email
    StringAssert.Contains(email.Body, "Here is your attachment");
    StringAssert.Contains(email.Subject, "Hello inbox 2");
    Assert.IsTrue(email.Attachments.Count > 0);
    
    // fetch attachment
    var emailControllerApi = new EmailControllerApi(_config);
    var downloadAttachmentDto = emailControllerApi.DownloadAttachmentBase64(attachmentId: email.Attachments.First(), emailId: email.Id);

    StringAssert.Contains(downloadAttachmentDto.ContentType, "text/plain");
    Assert.IsNotNull(downloadAttachmentDto.SizeBytes);
    Assert.IsNotNull(downloadAttachmentDto.Base64FileContents); // convert to bytes if you wish to parse or save file
}
```

### Get sent emails

```csharp
[TestMethod]
public void Can_Get_Sent_Emails()
{
    
    var sentEmailsControllerApi = new SentEmailsControllerApi(_config);
    var inboxControllerApi = new InboxControllerApi(_config);
    
    var inbox = inboxControllerApi.CreateInbox();
    var sentEmails = sentEmailsControllerApi.GetSentEmails(inboxId:inbox.Id, page:0, size: 20);
    
    Assert.IsNotNull(sentEmails.Content);
    Assert.IsNotNull(sentEmails.TotalPages);
    Assert.AreEqual(sentEmails.Pageable.PageNumber, 0);
    Assert.AreEqual(sentEmails.Pageable.PageSize, 20);
}
```

### Extract email content

You can extract content using pattern matching with the [WaitForController](https://mailslurp.github.io/mailslurp-client-csharp/api/mailslurp.Api.WaitForControllerApi.html)

```csharp
[TestMethod]
public void Can_Extract_Codes()
{
    
    // create an inbox
    var inboxControllerApi = new InboxControllerApi(_config);
    var inbox = inboxControllerApi.CreateInbox();
    
    // send a code to the inbox
    var sendEmailOptions = new SendEmailOptions(
        to: new List<string>() {inbox.EmailAddress},
        subject: "Welcome email",
        body: "Hello. Your code is X-456"
    );
    inboxControllerApi.SendEmail(inbox.Id, sendEmailOptions);
    
    // wait for the email to arrive
    var waitForController = new WaitForControllerApi(_config);
    var emailController = new EmailControllerApi(_config);
    var email = waitForController.WaitForLatestEmail(inboxId:inbox.Id, timeout: 30000, unreadOnly: true);
    StringAssert.Contains(email.Body, "Hello");
    
    // extract the code
    var matchOptions = new ContentMatchOptions(pattern:"Your code is ([A-Z]-[0-9]{3})");
    var matchResults = emailController.GetEmailContentMatch(email.Id, matchOptions);
    Assert.AreEqual(matchResults.Matches[1], "X-456");
}
```

## SDK Documentation

See the GitHub source code for more [Method Documentation](https://mailslurp.github.io/mailslurp-client-csharp/).
