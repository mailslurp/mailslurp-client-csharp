# mailslurp.Api.ExtraOperationsApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCreateInboxes**](ExtraOperationsApi.md#bulkcreateinboxes) | **POST** /bulk/inboxes | Bulk create Inboxes (email addresses)
[**BulkDeleteInboxes**](ExtraOperationsApi.md#bulkdeleteinboxes) | **DELETE** /bulk/inboxes | Bulk Delete Inboxes
[**BulkSendEmails**](ExtraOperationsApi.md#bulksendemails) | **POST** /bulk/send | Bulk Send Emails
[**CreateDomain**](ExtraOperationsApi.md#createdomain) | **POST** /domains | Create Domain
[**CreateInbox**](ExtraOperationsApi.md#createinbox) | **POST** /inboxes | Create an Inbox (email address)
[**CreateWebhook**](ExtraOperationsApi.md#createwebhook) | **POST** /inboxes/{inboxId}/webhooks | Attach a WebHook URL to an inbox
[**DeleteDomain**](ExtraOperationsApi.md#deletedomain) | **DELETE** /domains/{id} | Delete a domain
[**DeleteEmail1**](ExtraOperationsApi.md#deleteemail1) | **DELETE** /emails/{emailId} | Delete Email
[**DeleteInbox**](ExtraOperationsApi.md#deleteinbox) | **DELETE** /inboxes/{inboxId} | Delete Inbox / Email Address
[**DeleteWebhook**](ExtraOperationsApi.md#deletewebhook) | **DELETE** /inboxes/{inboxId}/webhooks/{webhookId} | Delete and disable a WebHook for an Inbox
[**DownloadAttachment**](ExtraOperationsApi.md#downloadattachment) | **GET** /emails/{emailId}/attachments/{attachmentId} | Get email attachment
[**ForwardEmail**](ExtraOperationsApi.md#forwardemail) | **POST** /emails/{emailId}/forward | Forward Email
[**GetDomain**](ExtraOperationsApi.md#getdomain) | **GET** /domains/{id} | Get a domain
[**GetDomains**](ExtraOperationsApi.md#getdomains) | **GET** /domains | Get domains
[**GetEmail**](ExtraOperationsApi.md#getemail) | **GET** /emails/{emailId} | Get Email Content
[**GetEmails**](ExtraOperationsApi.md#getemails) | **GET** /inboxes/{inboxId}/emails | List Emails in an Inbox / EmailAddress
[**GetEmailsPaginated**](ExtraOperationsApi.md#getemailspaginated) | **GET** /emails | Get all emails
[**GetInbox**](ExtraOperationsApi.md#getinbox) | **GET** /inboxes/{inboxId} | Get Inbox / EmailAddress
[**GetInboxes**](ExtraOperationsApi.md#getinboxes) | **GET** /inboxes | List Inboxes / Email Addresses
[**GetRawEmailContents**](ExtraOperationsApi.md#getrawemailcontents) | **GET** /emails/{emailId}/raw | Get Raw Email Content
[**GetWebhooks**](ExtraOperationsApi.md#getwebhooks) | **GET** /inboxes/{inboxId}/webhooks | Get all WebHooks for an Inbox
[**SendEmail**](ExtraOperationsApi.md#sendemail) | **POST** /inboxes/{inboxId} | Send Email
[**UploadAttachment**](ExtraOperationsApi.md#uploadattachment) | **POST** /attachments | Upload an attachment for sending
[**UploadMultipartForm**](ExtraOperationsApi.md#uploadmultipartform) | **POST** /attachments/multipart | Upload an attachment for sending using Multipart Form


<a name="bulkcreateinboxes"></a>
# **BulkCreateInboxes**
> List<Inbox> BulkCreateInboxes (int? count)

Bulk create Inboxes (email addresses)

Enterprise Plan Required

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkCreateInboxesExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var count = 56;  // int? | Number of inboxes to be created in bulk

            try
            {
                // Bulk create Inboxes (email addresses)
                List&lt;Inbox&gt; result = apiInstance.BulkCreateInboxes(count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.BulkCreateInboxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**| Number of inboxes to be created in bulk | 

### Return type

[**List<Inbox>**](Inbox.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeleteinboxes"></a>
# **BulkDeleteInboxes**
> void BulkDeleteInboxes (List<Guid?> requestBody)

Bulk Delete Inboxes

Enterprise Plan Required

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkDeleteInboxesExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var requestBody = new List<Guid?>(); // List<Guid?> | ids

            try
            {
                // Bulk Delete Inboxes
                apiInstance.BulkDeleteInboxes(requestBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.BulkDeleteInboxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**List&lt;Guid?&gt;**](List.md)| ids | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulksendemails"></a>
# **BulkSendEmails**
> void BulkSendEmails (BulkSendEmailOptions bulkSendEmailOptions)

Bulk Send Emails

Enterprise Plan Required

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkSendEmailsExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var bulkSendEmailOptions = new BulkSendEmailOptions(); // BulkSendEmailOptions | bulkSendEmailOptions

            try
            {
                // Bulk Send Emails
                apiInstance.BulkSendEmails(bulkSendEmailOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.BulkSendEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bulkSendEmailOptions** | [**BulkSendEmailOptions**](BulkSendEmailOptions.md)| bulkSendEmailOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdomain"></a>
# **CreateDomain**
> DomainPlusVerificationRecordsAndStatus CreateDomain (CreateDomainOptions createDomainOptions)

Create Domain

Link a domain that you own with MailSlurp so you can create inboxes with it. Returns DNS records used for validation. You must add these verification records to your host provider's DNS setup to verify the domain.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateDomainExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var createDomainOptions = new CreateDomainOptions(); // CreateDomainOptions | domainOptions

            try
            {
                // Create Domain
                DomainPlusVerificationRecordsAndStatus result = apiInstance.CreateDomain(createDomainOptions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.CreateDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDomainOptions** | [**CreateDomainOptions**](CreateDomainOptions.md)| domainOptions | 

### Return type

[**DomainPlusVerificationRecordsAndStatus**](DomainPlusVerificationRecordsAndStatus.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinbox"></a>
# **CreateInbox**
> Inbox CreateInbox (string emailAddress = null)

Create an Inbox (email address)

Create a new inbox and with a ranmdomized email address to send and receive from. Pass emailAddress parameter if you wish to use a specific email address. Creating an inbox is required before sending or receiving emails. If writing tests it is recommended that you create a new inbox during each test method so that it is unique and empty. 

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateInboxExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var emailAddress = emailAddress_example;  // string | Optional email address including domain you wish inbox to use (eg: test123@mydomain.com). Only supports domains that you have registered and verified with MailSlurp using dashboard or `createDomain` method. (optional) 

            try
            {
                // Create an Inbox (email address)
                Inbox result = apiInstance.CreateInbox(emailAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.CreateInbox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Optional email address including domain you wish inbox to use (eg: test123@mydomain.com). Only supports domains that you have registered and verified with MailSlurp using dashboard or &#x60;createDomain&#x60; method. | [optional] 

### Return type

[**Inbox**](Inbox.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (Guid? inboxId, CreateWebhookOptions createWebhookOptions)

Attach a WebHook URL to an inbox

Get notified whenever an inbox receives an email via a WebHook URL. An emailID will be posted to this URL every time an email is received for this inbox. The URL must be publicly reachable by the MailSlurp server. You can provide basicAuth values if you wish to secure this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId
            var createWebhookOptions = new CreateWebhookOptions(); // CreateWebhookOptions | webhookOptions

            try
            {
                // Attach a WebHook URL to an inbox
                Webhook result = apiInstance.CreateWebhook(inboxId, createWebhookOptions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.CreateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 
 **createWebhookOptions** | [**CreateWebhookOptions**](CreateWebhookOptions.md)| webhookOptions | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedomain"></a>
# **DeleteDomain**
> void DeleteDomain (Guid? id)

Delete a domain

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteDomainExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Delete a domain
                apiInstance.DeleteDomain(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.DeleteDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemail1"></a>
# **DeleteEmail1**
> void DeleteEmail1 (Guid? emailId)

Delete Email

Deletes an email and removes it from the inbox

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteEmail1Example
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var emailId = new Guid?(); // Guid? | emailId

            try
            {
                // Delete Email
                apiInstance.DeleteEmail1(emailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.DeleteEmail1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | [**Guid?**](Guid?.md)| emailId | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinbox"></a>
# **DeleteInbox**
> void DeleteInbox (Guid? inboxId)

Delete Inbox / Email Address

Permanently delete an inbox and associated email address

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId

            try
            {
                // Delete Inbox / Email Address
                apiInstance.DeleteInbox(inboxId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.DeleteInbox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (Guid? inboxId, Guid? webhookId)

Delete and disable a WebHook for an Inbox

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId
            var webhookId = new Guid?(); // Guid? | webhookId

            try
            {
                // Delete and disable a WebHook for an Inbox
                apiInstance.DeleteWebhook(inboxId, webhookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.DeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 
 **webhookId** | [**Guid?**](Guid?.md)| webhookId | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadattachment"></a>
# **DownloadAttachment**
> void DownloadAttachment (string attachmentId, Guid? emailId, string apiKey = null)

Get email attachment

Returns the specified attachment for a given email as a byte stream (file download). Get the attachmentId from the email response. Requires enterprise account.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DownloadAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var attachmentId = attachmentId_example;  // string | attachmentId
            var emailId = new Guid?(); // Guid? | emailId
            var apiKey = apiKey_example;  // string | Can pass apiKey in url for this request if you wish to download the file in a browser (optional) 

            try
            {
                // Get email attachment
                apiInstance.DownloadAttachment(attachmentId, emailId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.DownloadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| attachmentId | 
 **emailId** | [**Guid?**](Guid?.md)| emailId | 
 **apiKey** | **string**| Can pass apiKey in url for this request if you wish to download the file in a browser | [optional] 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forwardemail"></a>
# **ForwardEmail**
> void ForwardEmail (Guid? emailId, ForwardEmailOptions forwardEmailOptions)

Forward Email

Forward email content to given recipients

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class ForwardEmailExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var emailId = new Guid?(); // Guid? | emailId
            var forwardEmailOptions = new ForwardEmailOptions(); // ForwardEmailOptions | forwardEmailOptions

            try
            {
                // Forward Email
                apiInstance.ForwardEmail(emailId, forwardEmailOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.ForwardEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | [**Guid?**](Guid?.md)| emailId | 
 **forwardEmailOptions** | [**ForwardEmailOptions**](ForwardEmailOptions.md)| forwardEmailOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdomain"></a>
# **GetDomain**
> DomainPlusVerificationRecordsAndStatus GetDomain (Guid? id)

Get a domain

Returns domain verification status and tokens

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetDomainExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Get a domain
                DomainPlusVerificationRecordsAndStatus result = apiInstance.GetDomain(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

[**DomainPlusVerificationRecordsAndStatus**](DomainPlusVerificationRecordsAndStatus.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdomains"></a>
# **GetDomains**
> List<DomainPreview> GetDomains ()

Get domains

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetDomainsExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();

            try
            {
                // Get domains
                List&lt;DomainPreview&gt; result = apiInstance.GetDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DomainPreview>**](DomainPreview.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemail"></a>
# **GetEmail**
> Email GetEmail (Guid? emailId)

Get Email Content

Returns a email summary object with headers and content. To retrieve the raw unparsed email use the getRawMessage endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmailExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var emailId = new Guid?(); // Guid? | emailId

            try
            {
                // Get Email Content
                Email result = apiInstance.GetEmail(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | [**Guid?**](Guid?.md)| emailId | 

### Return type

[**Email**](Email.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemails"></a>
# **GetEmails**
> List<EmailPreview> GetEmails (Guid? inboxId, int? limit = null, long? minCount = null, long? retryTimeout = null, DateTime? since = null)

List Emails in an Inbox / EmailAddress

List emails that an inbox has received. Only emails that are sent to the inbox's email address will appear in the inbox. It may take several seconds for any email you send to an inbox's email address to appear in the inbox. To make this endpoint wait for a minimum number of emails use the `minCount` parameter. The server will retry the inbox database until the `minCount` is satisfied or the `retryTimeout` is reached

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmailsExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | Id of inbox that emails belongs to
            var limit = 56;  // int? | Limit the result set, ordered by descending received date time (optional) 
            var minCount = 789;  // long? | Minimum acceptable email count. Will cause request to hang (and retry) until minCount is satisfied or retryTimeout is reached. (optional) 
            var retryTimeout = 789;  // long? | Maximum milliseconds to spend retrying inbox database until minCount emails are returned (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Exclude emails received before this ISO 8601 date time (optional) 

            try
            {
                // List Emails in an Inbox / EmailAddress
                List&lt;EmailPreview&gt; result = apiInstance.GetEmails(inboxId, limit, minCount, retryTimeout, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| Id of inbox that emails belongs to | 
 **limit** | **int?**| Limit the result set, ordered by descending received date time | [optional] 
 **minCount** | **long?**| Minimum acceptable email count. Will cause request to hang (and retry) until minCount is satisfied or retryTimeout is reached. | [optional] 
 **retryTimeout** | **long?**| Maximum milliseconds to spend retrying inbox database until minCount emails are returned | [optional] 
 **since** | **DateTime?**| Exclude emails received before this ISO 8601 date time | [optional] 

### Return type

[**List<EmailPreview>**](EmailPreview.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailspaginated"></a>
# **GetEmailsPaginated**
> PageEmailProjection GetEmailsPaginated (int? page = null, int? size = null)

Get all emails

Responses are paginated

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmailsPaginatedExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var page = 56;  // int? | Optional page index in email list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in email list pagination (optional)  (default to 20)

            try
            {
                // Get all emails
                PageEmailProjection result = apiInstance.GetEmailsPaginated(page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetEmailsPaginated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Optional page index in email list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in email list pagination | [optional] [default to 20]

### Return type

[**PageEmailProjection**](PageEmailProjection.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinbox"></a>
# **GetInbox**
> Inbox GetInbox (Guid? inboxId)

Get Inbox / EmailAddress

Returns an inbox's properties, including its email address and ID.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId

            try
            {
                // Get Inbox / EmailAddress
                Inbox result = apiInstance.GetInbox(inboxId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetInbox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 

### Return type

[**Inbox**](Inbox.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboxes"></a>
# **GetInboxes**
> List<Inbox> GetInboxes ()

List Inboxes / Email Addresses

List the inboxes you have created

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxesExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();

            try
            {
                // List Inboxes / Email Addresses
                List&lt;Inbox&gt; result = apiInstance.GetInboxes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetInboxes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Inbox>**](Inbox.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrawemailcontents"></a>
# **GetRawEmailContents**
> string GetRawEmailContents (Guid? emailId)

Get Raw Email Content

Returns a raw, unparsed and unprocessed email

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetRawEmailContentsExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var emailId = new Guid?(); // Guid? | emailId

            try
            {
                // Get Raw Email Content
                string result = apiInstance.GetRawEmailContents(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetRawEmailContents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | [**Guid?**](Guid?.md)| emailId | 

### Return type

**string**

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<Webhook> GetWebhooks (Guid? inboxId)

Get all WebHooks for an Inbox

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId

            try
            {
                // Get all WebHooks for an Inbox
                List&lt;Webhook&gt; result = apiInstance.GetWebhooks(inboxId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemail"></a>
# **SendEmail**
> void SendEmail (Guid? inboxId, SendEmailOptions sendEmailOptions)

Send Email

Send an email from the inbox's email address. Specify the email recipients and contents in the request body. See the `SendEmailOptions` for more information. Note the `inboxId` refers to the inbox's id NOT its email address

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | sendEmailOptions

            try
            {
                // Send Email
                apiInstance.SendEmail(inboxId, sendEmailOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.SendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| inboxId | 
 **sendEmailOptions** | [**SendEmailOptions**](SendEmailOptions.md)| sendEmailOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadattachment"></a>
# **UploadAttachment**
> List<string> UploadAttachment (UploadAttachmentOptions uploadAttachmentOptions)

Upload an attachment for sending

When sending emails with attachments first upload each attachment with this endpoint. Record the returned attachment IDs. Then use these attachment IDs in the SendEmailOptions when sending an email. This means that attachments can easily be reused.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class UploadAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var uploadAttachmentOptions = new UploadAttachmentOptions(); // UploadAttachmentOptions | uploadOptions

            try
            {
                // Upload an attachment for sending
                List&lt;string&gt; result = apiInstance.UploadAttachment(uploadAttachmentOptions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.UploadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadAttachmentOptions** | [**UploadAttachmentOptions**](UploadAttachmentOptions.md)| uploadOptions | 

### Return type

**List<string>**

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmultipartform"></a>
# **UploadMultipartForm**
> List<string> UploadMultipartForm (System.IO.Stream file, string contentType = null, string filename = null)

Upload an attachment for sending using Multipart Form

When sending emails with attachments first upload each attachment with this endpoint. Record the returned attachment IDs. Then use these attachment IDs in the SendEmailOptions when sending an email. This means that attachments can easily be reused.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class UploadMultipartFormExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExtraOperationsApi();
            var file = BINARY_DATA_HERE;  // System.IO.Stream | file
            var contentType = contentType_example;  // string | contentType (optional) 
            var filename = filename_example;  // string | filename (optional) 

            try
            {
                // Upload an attachment for sending using Multipart Form
                List&lt;string&gt; result = apiInstance.UploadMultipartForm(file, contentType, filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtraOperationsApi.UploadMultipartForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream****System.IO.Stream**| file | 
 **contentType** | **string**| contentType | [optional] 
 **filename** | **string**| filename | [optional] 

### Return type

**List<string>**

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

