# MailSlurp C\# Client

> Create real email addresses on demand. Send and receive emails and attachments from code and tests using CSharp (C# DotNet Core).

MailSlurp is an email API service that lets you create real email addresses in code. You can then send and receive emails and attachments in C# applications and tests.

## Quick links

- [Method Documentation](./docs)
- [NuGet Package](https://www.nuget.org/packages/mailslurp/)
- [Code Examples](https://github.com/mailslurp/examples)
- [Github Source](https://github.com/mailslurp/mailslurp-client-csharp)

## Get started

::: tip
This section describes how to get up and running with the CSharp client. The client targets `DotNet-Core 2.1`. If you need a different target consider calling the [REST API](https://www.mailslurp.com/docs/api/).

See the method documentation for a [list of all functions](https://github.com/mailslurp/mailslurp-client-csharp)
:::

### Create API Key

First you'll need an API Key. [Create a free account](https://app.mailslurp.com) and copy the key from your dashboard.

### Install NuGet Package

MailSlurp's CSharp library is [hosted on NuGet](https://www.nuget.org/packages/mailslurp/).

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

## Common uses

MailSlurp has many functions. Here are some common uses:

### Create an inbox

Inboxes have an ID and a real email address.

```csharp
var apiInstance = new InboxControllerApi(config);
var inbox = apiInstance.CreateInbox();

Assert.NotNull(inbox);
Assert.Contains("@mailslurp.com", inbox.EmailAddress);
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

### Receive emails

You can receive emails using `waitFor` methods on the `WaitForControllerApi` class.

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

## SDK Documentation

See the GitHub source code for more [Method Documentation](./docs).

## Documentation for Authorization

### API_KEY

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header
