# mailslurp.Api.WaitForControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WaitFor**](WaitForControllerApi.md#waitfor) | **POST** /waitFor | Wait for conditions to be met
[**WaitForEmailCount**](WaitForControllerApi.md#waitforemailcount) | **GET** /waitForEmailCount | Wait for and return count number of emails 
[**WaitForLatestEmail**](WaitForControllerApi.md#waitforlatestemail) | **GET** /waitForLatestEmail | Fetch inbox&#39;s latest email or if empty wait for an email to arrive
[**WaitForMatchingEmail**](WaitForControllerApi.md#waitformatchingemail) | **POST** /waitForMatchingEmails | Wait or return list of emails that match simple matching patterns
[**WaitForNthEmail**](WaitForControllerApi.md#waitfornthemail) | **GET** /waitForNthEmail | Wait for or fetch the email with a given index in the inbox specified



## WaitFor

> List&lt;EmailPreview&gt; WaitFor (WaitForConditions waitForConditions = null)

Wait for conditions to be met

Generic waitFor method that will wait until an inbox meets given conditions or return immediately if already met

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(Configuration.Default);
            var waitForConditions = new WaitForConditions(); // WaitForConditions | Conditions to wait for (optional) 

            try
            {
                // Wait for conditions to be met
                List<EmailPreview> result = apiInstance.WaitFor(waitForConditions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WaitForControllerApi.WaitFor: " + e.Message );
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
 **waitForConditions** | [**WaitForConditions**](WaitForConditions.md)| Conditions to wait for | [optional] 

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


## WaitForEmailCount

> List&lt;EmailPreview&gt; WaitForEmailCount (int count = null, Guid inboxId = null, long timeout = null, bool unreadOnly = null)

Wait for and return count number of emails 

If inbox contains count or more emails at time of request then return count worth of emails. If not wait until the count is reached and return those or return an error if timeout is exceeded.

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

            var apiInstance = new WaitForControllerApi(Configuration.Default);
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
                Debug.Print("Exception when calling WaitForControllerApi.WaitForEmailCount: " + e.Message );
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

Fetch inbox's latest email or if empty wait for an email to arrive

Will return either the last received email or wait for an email to arrive and return that. If you need to wait for an email for a non-empty inbox set `unreadOnly=true` or see the other receive methods such as `waitForNthEmail` or `waitForEmailCount`.

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

            var apiInstance = new WaitForControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | Id of the inbox we are fetching emails from (optional) 
            var timeout = 789;  // long | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only. (optional)  (default to false)

            try
            {
                // Fetch inbox's latest email or if empty wait for an email to arrive
                Email result = apiInstance.WaitForLatestEmail(inboxId, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WaitForControllerApi.WaitForLatestEmail: " + e.Message );
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
 **unreadOnly** | **bool**| Optional filter for unread only. | [optional] [default to false]

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

Perform a search of emails in an inbox with the given patterns. If results match expected count then return or else retry the search until results are found or timeout is reached. Match options allow simple CONTAINS or EQUALS filtering on SUBJECT, TO, BCC, CC, and FROM. See the `MatchOptions` object for options.

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

            var apiInstance = new WaitForControllerApi(Configuration.Default);
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
                Debug.Print("Exception when calling WaitForControllerApi.WaitForMatchingEmail: " + e.Message );
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

If nth email is already present in inbox then return it. If not hold the connection open until timeout expires or the nth email is received and returned.

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

            var apiInstance = new WaitForControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | Id of the inbox you are fetching emails from (optional) 
            var index = 56;  // int | Zero based index of the email to wait for. If an inbox has 1 email already and you want to wait for the 2nd email pass index=1 (optional) 
            var timeout = 789;  // long | Max milliseconds to wait for the nth email if not already present (optional) 
            var unreadOnly = true;  // bool | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for or fetch the email with a given index in the inbox specified
                Email result = apiInstance.WaitForNthEmail(inboxId, index, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WaitForControllerApi.WaitForNthEmail: " + e.Message );
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
 **inboxId** | [**Guid**](Guid.md)| Id of the inbox you are fetching emails from | [optional] 
 **index** | **int**| Zero based index of the email to wait for. If an inbox has 1 email already and you want to wait for the 2nd email pass index&#x3D;1 | [optional] 
 **timeout** | **long**| Max milliseconds to wait for the nth email if not already present | [optional] 
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

