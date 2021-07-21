# mailslurp.Api.MissedEmailControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllMissedEmails**](MissedEmailControllerApi#getallmissedemails) | **GET** /missed-emails | Get all MissedEmails in paginated format
[**GetMissedEmail**](MissedEmailControllerApi#getmissedemail) | **GET** /missed-emails/{missedEmailId} | Get MissedEmail
[**WaitForNthMissedEmail**](MissedEmailControllerApi#waitfornthmissedemail) | **GET** /missed-emails/waitForNthMissedEmail | Wait for Nth missed email


<a name="getallmissedemails"></a>
# **GetAllMissedEmails**
> PageMissedEmailProjection GetAllMissedEmails (Guid? inboxId = null, int? page = null, string searchFilter = null, int? size = null, string sort = null)

Get all MissedEmails in paginated format

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllMissedEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox ID filter (optional) 
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get all MissedEmails in paginated format
                PageMissedEmailProjection result = apiInstance.GetAllMissedEmails(inboxId, page, searchFilter, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.GetAllMissedEmails: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox ID filter | [optional] 
 **page** | **int?**| Optional page index in list pagination | [optional] [default to 0]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageMissedEmailProjection**](PageMissedEmailProjection)

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

<a name="getmissedemail"></a>
# **GetMissedEmail**
> MissedEmail GetMissedEmail (Guid missedEmailId)

Get MissedEmail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetMissedEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var missedEmailId = new Guid(); // Guid | missedEmailId

            try
            {
                // Get MissedEmail
                MissedEmail result = apiInstance.GetMissedEmail(missedEmailId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.GetMissedEmail: " + e.Message );
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
 **missedEmailId** | [**Guid**](Guid)| missedEmailId | 

### Return type

[**MissedEmail**](MissedEmail)

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

<a name="waitfornthmissedemail"></a>
# **WaitForNthMissedEmail**
> MissedEmail WaitForNthMissedEmail (Guid? inboxId = null, int? index = null, long? timeout = null)

Wait for Nth missed email

Wait for 0 based index missed email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class WaitForNthMissedEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox ID filter (optional) 
            var index = 56;  // int? | Zero based index of the email to wait for. If 1 missed email already and you want to wait for the 2nd email pass index=1 (optional) 
            var timeout = 789;  // long? | Optional timeout milliseconds (optional) 

            try
            {
                // Wait for Nth missed email
                MissedEmail result = apiInstance.WaitForNthMissedEmail(inboxId, index, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.WaitForNthMissedEmail: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox ID filter | [optional] 
 **index** | **int?**| Zero based index of the email to wait for. If 1 missed email already and you want to wait for the 2nd email pass index&#x3D;1 | [optional] 
 **timeout** | **long?**| Optional timeout milliseconds | [optional] 

### Return type

[**MissedEmail**](MissedEmail)

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

