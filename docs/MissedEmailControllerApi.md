# mailslurp.Api.MissedEmailControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllMissedEmails**](MissedEmailControllerApi#getallmissedemails) | **GET** /missed-emails | Get all MissedEmails in paginated format |
| [**GetAllUnknownMissedEmails**](MissedEmailControllerApi#getallunknownmissedemails) | **GET** /missed-emails/unknown | Get all unknown missed emails in paginated format |
| [**GetMissedEmail**](MissedEmailControllerApi#getmissedemail) | **GET** /missed-emails/{missedEmailId} | Get MissedEmail |
| [**RestoreMissedEmails**](MissedEmailControllerApi#restoremissedemails) | **POST** /missed-emails/restore | Restore missed emails |
| [**WaitForNthMissedEmail**](MissedEmailControllerApi#waitfornthmissedemail) | **GET** /missed-emails/waitForNthMissedEmail | Wait for Nth missed email |

<a name="getallmissedemails"></a>
# **GetAllMissedEmails**
> PageMissedEmailProjection GetAllMissedEmails (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null, Guid? inboxId = null)

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
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var page = 0;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = "searchFilter_example";  // string | Optional search filter (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 
            var inboxId = "inboxId_example";  // Guid? | Optional inbox ID filter (optional) 

            try
            {
                // Get all MissedEmails in paginated format
                PageMissedEmailProjection result = apiInstance.GetAllMissedEmails(page, size, sort, searchFilter, since, before, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.GetAllMissedEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllMissedEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all MissedEmails in paginated format
    ApiResponse<PageMissedEmailProjection> response = apiInstance.GetAllMissedEmailsWithHttpInfo(page, size, sort, searchFilter, since, before, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissedEmailControllerApi.GetAllMissedEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **searchFilter** | **string** | Optional search filter | [optional]  |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |
| **inboxId** | **Guid?** | Optional inbox ID filter | [optional]  |

### Return type

[**PageMissedEmailProjection**](PageMissedEmailProjection)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getallunknownmissedemails"></a>
# **GetAllUnknownMissedEmails**
> PageUnknownMissedEmailProjection GetAllUnknownMissedEmails (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null, Guid? inboxId = null)

Get all unknown missed emails in paginated format

Unknown missed emails are emails that were sent to MailSlurp but could not be assigned to an existing inbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllUnknownMissedEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var page = 0;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = "searchFilter_example";  // string | Optional search filter (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 
            var inboxId = "inboxId_example";  // Guid? | Optional inbox ID filter (optional) 

            try
            {
                // Get all unknown missed emails in paginated format
                PageUnknownMissedEmailProjection result = apiInstance.GetAllUnknownMissedEmails(page, size, sort, searchFilter, since, before, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.GetAllUnknownMissedEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllUnknownMissedEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all unknown missed emails in paginated format
    ApiResponse<PageUnknownMissedEmailProjection> response = apiInstance.GetAllUnknownMissedEmailsWithHttpInfo(page, size, sort, searchFilter, since, before, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissedEmailControllerApi.GetAllUnknownMissedEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **searchFilter** | **string** | Optional search filter | [optional]  |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |
| **inboxId** | **Guid?** | Optional inbox ID filter | [optional]  |

### Return type

[**PageUnknownMissedEmailProjection**](PageUnknownMissedEmailProjection)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getmissedemail"></a>
# **GetMissedEmail**
> MissedEmailDto GetMissedEmail (Guid missedEmailId)

Get MissedEmail

List emails that were missed due to plan limits.

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
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var missedEmailId = "missedEmailId_example";  // Guid | 

            try
            {
                // Get MissedEmail
                MissedEmailDto result = apiInstance.GetMissedEmail(missedEmailId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.GetMissedEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMissedEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MissedEmail
    ApiResponse<MissedEmailDto> response = apiInstance.GetMissedEmailWithHttpInfo(missedEmailId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissedEmailControllerApi.GetMissedEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **missedEmailId** | **Guid** |  |  |

### Return type

[**MissedEmailDto**](MissedEmailDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="restoremissedemails"></a>
# **RestoreMissedEmails**
> void RestoreMissedEmails ()

Restore missed emails

If emails were missed due to a plan limit they are saved as missed emails. If support team enables the canRestore flag these emails can be reload into your account using this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class RestoreMissedEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);

            try
            {
                // Restore missed emails
                apiInstance.RestoreMissedEmails();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.RestoreMissedEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreMissedEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore missed emails
    apiInstance.RestoreMissedEmailsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissedEmailControllerApi.RestoreMissedEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="waitfornthmissedemail"></a>
# **WaitForNthMissedEmail**
> MissedEmailDto WaitForNthMissedEmail (int index, Guid? inboxId = null, long? timeout = null, DateTime? since = null, DateTime? before = null)

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
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new MissedEmailControllerApi(config);
            var index = 56;  // int | Zero based index of the email to wait for. If 1 missed email already and you want to wait for the 2nd email pass index=1
            var inboxId = "inboxId_example";  // Guid? | Optional inbox ID filter (optional) 
            var timeout = 789L;  // long? | Optional timeout milliseconds (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Wait for Nth missed email
                MissedEmailDto result = apiInstance.WaitForNthMissedEmail(index, inboxId, timeout, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissedEmailControllerApi.WaitForNthMissedEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaitForNthMissedEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wait for Nth missed email
    ApiResponse<MissedEmailDto> response = apiInstance.WaitForNthMissedEmailWithHttpInfo(index, inboxId, timeout, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissedEmailControllerApi.WaitForNthMissedEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **index** | **int** | Zero based index of the email to wait for. If 1 missed email already and you want to wait for the 2nd email pass index&#x3D;1 |  |
| **inboxId** | **Guid?** | Optional inbox ID filter | [optional]  |
| **timeout** | **long?** | Optional timeout milliseconds | [optional]  |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**MissedEmailDto**](MissedEmailDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

