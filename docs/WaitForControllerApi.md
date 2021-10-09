# mailslurp.Api.WaitForControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WaitFor**](WaitForControllerApi#waitfor) | **POST** /waitFor | Wait for an email to match the provided filter conditions such as subject contains keyword.
[**WaitForEmailCount**](WaitForControllerApi#waitforemailcount) | **GET** /waitForEmailCount | Wait for and return count number of emails. Hold connection until inbox count matches expected or timeout occurs
[**WaitForLatestEmail**](WaitForControllerApi#waitforlatestemail) | **GET** /waitForLatestEmail | Fetch inbox&#39;s latest email or if empty wait for an email to arrive
[**WaitForMatchingEmails**](WaitForControllerApi#waitformatchingemails) | **POST** /waitForMatchingEmails | Wait or return list of emails that match simple matching patterns
[**WaitForMatchingFirstEmail**](WaitForControllerApi#waitformatchingfirstemail) | **POST** /waitForMatchingFirstEmail | Wait for or return the first email that matches provided MatchOptions array
[**WaitForNthEmail**](WaitForControllerApi#waitfornthemail) | **GET** /waitForNthEmail | Wait for or fetch the email with a given index in the inbox specified. If index doesn&#39;t exist waits for it to exist or timeout to occur.


<a name="waitfor"></a>
# **WaitFor**
> List&lt;EmailPreview&gt; WaitFor (WaitForConditions waitForConditions = null)

Wait for an email to match the provided filter conditions such as subject contains keyword.

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
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var waitForConditions = new WaitForConditions(); // WaitForConditions | Conditions to apply to emails that you are waiting for (optional) 

            try
            {
                // Wait for an email to match the provided filter conditions such as subject contains keyword.
                List<EmailPreview> result = apiInstance.WaitFor(waitForConditions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **waitForConditions** | [**WaitForConditions**](WaitForConditions)| Conditions to apply to emails that you are waiting for | [optional] 

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitforemailcount"></a>
# **WaitForEmailCount**
> List&lt;EmailPreview&gt; WaitForEmailCount (DateTime? before = null, int? count = null, long? delay = null, Guid? inboxId = null, DateTime? since = null, string sort = null, long? timeout = null, bool? unreadOnly = null)

Wait for and return count number of emails. Hold connection until inbox count matches expected or timeout occurs

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
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received before the given timestamp (optional) 
            var count = 56;  // int? | Number of emails to wait for. Must be greater that 1 (optional) 
            var delay = 789;  // long? | Max milliseconds delay between calls (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are fetching emails from (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received after the given timestamp (optional) 
            var sort = sort_example;  // string | Sort direction (optional) 
            var timeout = 789;  // long? | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool? | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for and return count number of emails. Hold connection until inbox count matches expected or timeout occurs
                List<EmailPreview> result = apiInstance.WaitForEmailCount(before, count, delay, inboxId, since, sort, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **before** | **DateTime?**| Filter for emails that were received before the given timestamp | [optional] 
 **count** | **int?**| Number of emails to wait for. Must be greater that 1 | [optional] 
 **delay** | **long?**| Max milliseconds delay between calls | [optional] 
 **inboxId** | [**Guid?**](Guid?)| Id of the inbox we are fetching emails from | [optional] 
 **since** | **DateTime?**| Filter for emails that were received after the given timestamp | [optional] 
 **sort** | **string**| Sort direction | [optional] 
 **timeout** | **long?**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool?**| Optional filter for unread only | [optional] [default to false]

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitforlatestemail"></a>
# **WaitForLatestEmail**
> Email WaitForLatestEmail (DateTime? before = null, long? delay = null, Guid? inboxId = null, DateTime? since = null, string sort = null, long? timeout = null, bool? unreadOnly = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were before after the given timestamp (optional) 
            var delay = 789;  // long? | Max milliseconds delay between calls (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are fetching emails from (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received after the given timestamp (optional) 
            var sort = sort_example;  // string | Sort direction (optional) 
            var timeout = 789;  // long? | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool? | Optional filter for unread only. (optional)  (default to false)

            try
            {
                // Fetch inbox's latest email or if empty wait for an email to arrive
                Email result = apiInstance.WaitForLatestEmail(before, delay, inboxId, since, sort, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **before** | **DateTime?**| Filter for emails that were before after the given timestamp | [optional] 
 **delay** | **long?**| Max milliseconds delay between calls | [optional] 
 **inboxId** | [**Guid?**](Guid?)| Id of the inbox we are fetching emails from | [optional] 
 **since** | **DateTime?**| Filter for emails that were received after the given timestamp | [optional] 
 **sort** | **string**| Sort direction | [optional] 
 **timeout** | **long?**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool?**| Optional filter for unread only. | [optional] [default to false]

### Return type

[**Email**](Email)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitformatchingemails"></a>
# **WaitForMatchingEmails**
> List&lt;EmailPreview&gt; WaitForMatchingEmails (MatchOptions matchOptions, DateTime? before = null, int? count = null, long? delay = null, Guid? inboxId = null, DateTime? since = null, string sort = null, long? timeout = null, bool? unreadOnly = null)

Wait or return list of emails that match simple matching patterns

Perform a search of emails in an inbox with the given patterns. If results match expected count then return or else retry the search until results are found or timeout is reached. Match options allow simple CONTAINS or EQUALS filtering on SUBJECT, TO, BCC, CC, and FROM. See the `MatchOptions` object for options. An example payload is `{ matches: [{field: 'SUBJECT',should:'CONTAIN',value:'needle'}] }`. You can use an array of matches and they will be applied sequentially to filter out emails. If you want to perform matches and extractions of content using Regex patterns see the EmailController `getEmailContentMatch` method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForMatchingEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var matchOptions = new MatchOptions(); // MatchOptions | matchOptions
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received before the given timestamp (optional) 
            var count = 56;  // int? | Number of emails to wait for. Must be greater or equal to 1 (optional) 
            var delay = 789;  // long? | Max milliseconds delay between calls (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are fetching emails from (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received after the given timestamp (optional) 
            var sort = sort_example;  // string | Sort direction (optional) 
            var timeout = 789;  // long? | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool? | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait or return list of emails that match simple matching patterns
                List<EmailPreview> result = apiInstance.WaitForMatchingEmails(matchOptions, before, count, delay, inboxId, since, sort, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaitForControllerApi.WaitForMatchingEmails: " + e.Message );
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
 **matchOptions** | [**MatchOptions**](MatchOptions)| matchOptions | 
 **before** | **DateTime?**| Filter for emails that were received before the given timestamp | [optional] 
 **count** | **int?**| Number of emails to wait for. Must be greater or equal to 1 | [optional] 
 **delay** | **long?**| Max milliseconds delay between calls | [optional] 
 **inboxId** | [**Guid?**](Guid?)| Id of the inbox we are fetching emails from | [optional] 
 **since** | **DateTime?**| Filter for emails that were received after the given timestamp | [optional] 
 **sort** | **string**| Sort direction | [optional] 
 **timeout** | **long?**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool?**| Optional filter for unread only | [optional] [default to false]

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitformatchingfirstemail"></a>
# **WaitForMatchingFirstEmail**
> Email WaitForMatchingFirstEmail (MatchOptions matchOptions, DateTime? before = null, long? delay = null, Guid? inboxId = null, DateTime? since = null, string sort = null, long? timeout = null, bool? unreadOnly = null)

Wait for or return the first email that matches provided MatchOptions array

Perform a search of emails in an inbox with the given patterns. If a result if found then return or else retry the search until a result is found or timeout is reached. Match options allow simple CONTAINS or EQUALS filtering on SUBJECT, TO, BCC, CC, and FROM. See the `MatchOptions` object for options. An example payload is `{ matches: [{field: 'SUBJECT',should:'CONTAIN',value:'needle'}] }`. You can use an array of matches and they will be applied sequentially to filter out emails. If you want to perform matches and extractions of content using Regex patterns see the EmailController `getEmailContentMatch` method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForMatchingFirstEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var matchOptions = new MatchOptions(); // MatchOptions | matchOptions
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received before the given timestamp (optional) 
            var delay = 789;  // long? | Max milliseconds delay between calls (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox we are matching an email for (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received after the given timestamp (optional) 
            var sort = sort_example;  // string | Sort direction (optional) 
            var timeout = 789;  // long? | Max milliseconds to wait (optional) 
            var unreadOnly = true;  // bool? | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for or return the first email that matches provided MatchOptions array
                Email result = apiInstance.WaitForMatchingFirstEmail(matchOptions, before, delay, inboxId, since, sort, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaitForControllerApi.WaitForMatchingFirstEmail: " + e.Message );
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
 **matchOptions** | [**MatchOptions**](MatchOptions)| matchOptions | 
 **before** | **DateTime?**| Filter for emails that were received before the given timestamp | [optional] 
 **delay** | **long?**| Max milliseconds delay between calls | [optional] 
 **inboxId** | [**Guid?**](Guid?)| Id of the inbox we are matching an email for | [optional] 
 **since** | **DateTime?**| Filter for emails that were received after the given timestamp | [optional] 
 **sort** | **string**| Sort direction | [optional] 
 **timeout** | **long?**| Max milliseconds to wait | [optional] 
 **unreadOnly** | **bool?**| Optional filter for unread only | [optional] [default to false]

### Return type

[**Email**](Email)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitfornthemail"></a>
# **WaitForNthEmail**
> Email WaitForNthEmail (DateTime? before = null, long? delay = null, Guid? inboxId = null, int? index = null, DateTime? since = null, string sort = null, long? timeout = null, bool? unreadOnly = null)

Wait for or fetch the email with a given index in the inbox specified. If index doesn't exist waits for it to exist or timeout to occur.

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
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WaitForControllerApi(config);
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received before the given timestamp (optional) 
            var delay = 789;  // long? | Max milliseconds delay between calls (optional) 
            var inboxId = new Guid?(); // Guid? | Id of the inbox you are fetching emails from (optional) 
            var index = 56;  // int? | Zero based index of the email to wait for. If an inbox has 1 email already and you want to wait for the 2nd email pass index=1 (optional)  (default to 0)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter for emails that were received after the given timestamp (optional) 
            var sort = sort_example;  // string | Sort direction (optional) 
            var timeout = 789;  // long? | Max milliseconds to wait for the nth email if not already present (optional) 
            var unreadOnly = true;  // bool? | Optional filter for unread only (optional)  (default to false)

            try
            {
                // Wait for or fetch the email with a given index in the inbox specified. If index doesn't exist waits for it to exist or timeout to occur.
                Email result = apiInstance.WaitForNthEmail(before, delay, inboxId, index, since, sort, timeout, unreadOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **before** | **DateTime?**| Filter for emails that were received before the given timestamp | [optional] 
 **delay** | **long?**| Max milliseconds delay between calls | [optional] 
 **inboxId** | [**Guid?**](Guid?)| Id of the inbox you are fetching emails from | [optional] 
 **index** | **int?**| Zero based index of the email to wait for. If an inbox has 1 email already and you want to wait for the 2nd email pass index&#x3D;1 | [optional] [default to 0]
 **since** | **DateTime?**| Filter for emails that were received after the given timestamp | [optional] 
 **sort** | **string**| Sort direction | [optional] 
 **timeout** | **long?**| Max milliseconds to wait for the nth email if not already present | [optional] 
 **unreadOnly** | **bool?**| Optional filter for unread only | [optional] [default to false]

### Return type

[**Email**](Email)

### Authorization

[API_KEY](../README#API_KEY)

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

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

