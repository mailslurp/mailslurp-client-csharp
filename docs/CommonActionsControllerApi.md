# mailslurp.Api.CommonActionsControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewEmailAddress**](CommonActionsControllerApi.md#createnewemailaddress) | **POST** /newEmailAddress | Create new random inbox
[**EmptyInbox**](CommonActionsControllerApi.md#emptyinbox) | **DELETE** /emptyInbox | Delete all emails in an inbox
[**SendEmailSimple**](CommonActionsControllerApi.md#sendemailsimple) | **POST** /sendEmail | Send an email from a random email address
[**WaitForEmailCount**](CommonActionsControllerApi.md#waitforemailcount) | **GET** /waitForEmailCount | Wait for and return count number of emails 
[**WaitForLatestEmail**](CommonActionsControllerApi.md#waitforlatestemail) | **GET** /waitForLatestEmail | Fetch inbox&#39;s latest email or if empty wait for email to arrive
[**WaitForMatchingEmail**](CommonActionsControllerApi.md#waitformatchingemail) | **POST** /waitForMatchingEmails | Wait or return list of emails that match simple matching patterns
[**WaitForNthEmail**](CommonActionsControllerApi.md#waitfornthemail) | **GET** /waitForNthEmail | Wait for or fetch the email with a given index in the inbox specified



## CreateNewEmailAddress

> Inbox CreateNewEmailAddress ()

Create new random inbox

Returns an Inbox with an `id` and an `emailAddress`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewEmailAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);

            try
            {
                // Create new random inbox
                Inbox result = apiInstance.CreateNewEmailAddress();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateNewEmailAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmptyInbox

> void EmptyInbox (Guid inboxId)

Delete all emails in an inbox

Deletes all emails

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class EmptyInboxExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | inboxId

            try
            {
                // Delete all emails in an inbox
                apiInstance.EmptyInbox(inboxId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.EmptyInbox: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid**](Guid.md)| inboxId | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendEmailSimple

> void SendEmailSimple (SendEmailOptions sendEmailOptions)

Send an email from a random email address

To specify an email address first create an inbox and use that with the other send email methods

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailSimpleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | sendEmailOptions

            try
            {
                // Send an email from a random email address
                apiInstance.SendEmailSimple(sendEmailOptions);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailSimple: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WaitForEmailCount

> List&lt;EmailPreview&gt; WaitForEmailCount (int count = null, Guid inboxId = null, long timeout = null, bool unreadOnly = null)

Wait for and return count number of emails 

Will only wait if count is greater that the found emails in given inbox.If you need to wait for an email for a non-empty inbox see the other receive methods.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForEmailCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var count = 56;  // int | Number of emails to wait for. Must be greater that 1 (optional) 
            var inboxId = new Guid(); // Guid | Id of the inbox we are fetching emails from (optional) 
            var timeout = 789;  // long | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for and return count number of emails 
                List<EmailPreview> result = apiInstance.WaitForEmailCount(count, inboxId, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.WaitForEmailCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int**| Number of emails to wait for. Must be greater that 1 | [optional] 
 **inboxId** | [**Guid**](Guid.md)| Id of the inbox we are fetching emails from | [optional] 
 **timeout** | **long**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool**| Optional filter for unread only | [optional] [default to false]

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WaitForLatestEmail

> Email WaitForLatestEmail (Guid inboxId = null, long timeout = null, bool unreadOnly = null)

Fetch inbox's latest email or if empty wait for email to arrive

Will return either the last received email or wait for an email to arrive and return that. If you need to wait for an email for a non-empty inbox see the other receive methods.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForLatestEmailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | Id of the inbox we are fetching emails from (optional) 
            var timeout = 789;  // long | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Fetch inbox's latest email or if empty wait for email to arrive
                Email result = apiInstance.WaitForLatestEmail(inboxId, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.WaitForLatestEmail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid**](Guid.md)| Id of the inbox we are fetching emails from | [optional] 
 **timeout** | **long**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool**| Optional filter for unread only | [optional] [default to false]

### Return type

[**Email**](Email.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WaitForMatchingEmail

> List&lt;EmailPreview&gt; WaitForMatchingEmail (MatchOptions matchOptions, int count = null, Guid inboxId = null, long timeout = null, bool unreadOnly = null)

Wait or return list of emails that match simple matching patterns

Results must also meet provided count. Match options allow simple CONTAINS or EQUALS filtering on SUBJECT, TO, BCC, CC, and FROM.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForMatchingEmailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var matchOptions = new MatchOptions(); // MatchOptions | matchOptions
            var count = 56;  // int | Number of emails to wait for. Must be greater that 1 (optional) 
            var inboxId = new Guid(); // Guid | Id of the inbox we are fetching emails from (optional) 
            var timeout = 789;  // long | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait or return list of emails that match simple matching patterns
                List<EmailPreview> result = apiInstance.WaitForMatchingEmail(matchOptions, count, inboxId, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.WaitForMatchingEmail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchOptions** | [**MatchOptions**](MatchOptions.md)| matchOptions | 
 **count** | **int**| Number of emails to wait for. Must be greater that 1 | [optional] 
 **inboxId** | [**Guid**](Guid.md)| Id of the inbox we are fetching emails from | [optional] 
 **timeout** | **long**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool**| Optional filter for unread only | [optional] [default to false]

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WaitForNthEmail

> Email WaitForNthEmail (Guid inboxId = null, int index = null, long timeout = null, bool unreadOnly = null)

Wait for or fetch the email with a given index in the inbox specified

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForNthEmailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | Id of the inbox we are fetching emails from (optional) 
            var index = 56;  // int | Zero based index of the email to wait for (optional) 
            var timeout = 789;  // long | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for or fetch the email with a given index in the inbox specified
                Email result = apiInstance.WaitForNthEmail(inboxId, index, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.WaitForNthEmail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboxId** | [**Guid**](Guid.md)| Id of the inbox we are fetching emails from | [optional] 
 **index** | **int**| Zero based index of the email to wait for | [optional] 
 **timeout** | **long**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool**| Optional filter for unread only | [optional] [default to false]

### Return type

[**Email**](Email.md)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

