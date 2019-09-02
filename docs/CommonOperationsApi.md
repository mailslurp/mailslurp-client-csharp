# mailslurp.Api.CommonOperationsApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewEmailAddress**](CommonOperationsApi.md#createnewemailaddress) | **POST** /newEmailAddress | Create new email address
[**DeleteEmailAddress**](CommonOperationsApi.md#deleteemailaddress) | **DELETE** /deleteEmailAddress | Delete email address and its emails
[**SendEmailSimple**](CommonOperationsApi.md#sendemailsimple) | **POST** /sendEmail | Send an email from a random email address
[**WaitForLatestEmail**](CommonOperationsApi.md#waitforlatestemail) | **GET** /fetchLatestEmail | Fetch inbox&#39;s latest email or if empty wait for email to arrive
[**WaitForNthEmail**](CommonOperationsApi.md#waitfornthemail) | **GET** /waitForNthEmail | Wait for or fetch the email with a given index in the inbox specified


<a name="createnewemailaddress"></a>
# **CreateNewEmailAddress**
> Inbox CreateNewEmailAddress ()

Create new email address

Returns an Inbox with an `id` and an `emailAddress`

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewEmailAddressExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonOperationsApi();

            try
            {
                // Create new email address
                Inbox result = apiInstance.CreateNewEmailAddress();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommonOperationsApi.CreateNewEmailAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Inbox**](Inbox.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailaddress"></a>
# **DeleteEmailAddress**
> void DeleteEmailAddress (Guid? inboxId)

Delete email address and its emails

Deletes an inbox

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteEmailAddressExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonOperationsApi();
            var inboxId = new Guid?(); // Guid? | inboxId

            try
            {
                // Delete email address and its emails
                apiInstance.DeleteEmailAddress(inboxId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommonOperationsApi.DeleteEmailAddress: " + e.Message );
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

<a name="sendemailsimple"></a>
# **SendEmailSimple**
> void SendEmailSimple (SendEmailOptions sendEmailOptions)

Send an email from a random email address

To specify an email address first create an inbox and use that with the other send email methods

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonOperationsApi();
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | sendEmailOptions

            try
            {
                // Send an email from a random email address
                apiInstance.SendEmailSimple(sendEmailOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommonOperationsApi.SendEmailSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendEmailOptions** | [**SendEmailOptions**](SendEmailOptions.md)| sendEmailOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitforlatestemail"></a>
# **WaitForLatestEmail**
> Email WaitForLatestEmail (string inboxEmailAddress = null, Guid? inboxId = null)

Fetch inbox's latest email or if empty wait for email to arrive

Will return either the last received email or wait for an email to arrive and return that. If you need to wait for an email for a non-empty inbox see the other receive methods.

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForLatestEmailExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonOperationsApi();
            var inboxEmailAddress = inboxEmailAddress_example;  // string | Email address of the inbox we are fetching emails from (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are fetching emails from (optional) 

            try
            {
                // Fetch inbox's latest email or if empty wait for email to arrive
                Email result = apiInstance.WaitForLatestEmail(inboxEmailAddress, inboxId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommonOperationsApi.WaitForLatestEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxEmailAddress** | **string**| Email address of the inbox we are fetching emails from | [optional] 
 **inboxId** | [**Guid?**](Guid?.md)| Id of the inbox we are fetching emails from | [optional] 

### Return type

[**Email**](Email.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitfornthemail"></a>
# **WaitForNthEmail**
> Email WaitForNthEmail (Guid? inboxId = null, int? index = null)

Wait for or fetch the email with a given index in the inbox specified

### Example
```csharp
using System;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForNthEmailExample
    {
        public void main()
        {
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonOperationsApi();
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are fetching emails from (optional) 
            var index = 56;  // int? | Zero based index of the email to wait for (optional) 

            try
            {
                // Wait for or fetch the email with a given index in the inbox specified
                Email result = apiInstance.WaitForNthEmail(inboxId, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommonOperationsApi.WaitForNthEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid?**](Guid?.md)| Id of the inbox we are fetching emails from | [optional] 
 **index** | **int?**| Zero based index of the email to wait for | [optional] 

### Return type

[**Email**](Email.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

