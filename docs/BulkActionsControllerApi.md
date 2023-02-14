# mailslurp.Api.BulkActionsControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkCreateInboxes**](BulkActionsControllerApi#bulkcreateinboxes) | **POST** /bulk/inboxes | Bulk create Inboxes (email addresses) |
| [**BulkDeleteInboxes**](BulkActionsControllerApi#bulkdeleteinboxes) | **DELETE** /bulk/inboxes | Bulk Delete Inboxes |
| [**BulkSendEmails**](BulkActionsControllerApi#bulksendemails) | **POST** /bulk/send | Bulk Send Emails |

<a name="bulkcreateinboxes"></a>
# **BulkCreateInboxes**
> List&lt;InboxDto&gt; BulkCreateInboxes (int count)

Bulk create Inboxes (email addresses)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkCreateInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new BulkActionsControllerApi(config);
            var count = 56;  // int | Number of inboxes to be created in bulk

            try
            {
                // Bulk create Inboxes (email addresses)
                List<InboxDto> result = apiInstance.BulkCreateInboxes(count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActionsControllerApi.BulkCreateInboxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkCreateInboxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk create Inboxes (email addresses)
    ApiResponse<List<InboxDto>> response = apiInstance.BulkCreateInboxesWithHttpInfo(count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActionsControllerApi.BulkCreateInboxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int** | Number of inboxes to be created in bulk |  |

### Return type

[**List&lt;InboxDto&gt;**](InboxDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="bulkdeleteinboxes"></a>
# **BulkDeleteInboxes**
> void BulkDeleteInboxes (List<Guid> requestBody)

Bulk Delete Inboxes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkDeleteInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new BulkActionsControllerApi(config);
            var requestBody = new List<Guid>(); // List<Guid> | 

            try
            {
                // Bulk Delete Inboxes
                apiInstance.BulkDeleteInboxes(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActionsControllerApi.BulkDeleteInboxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkDeleteInboxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Delete Inboxes
    apiInstance.BulkDeleteInboxesWithHttpInfo(requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActionsControllerApi.BulkDeleteInboxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;Guid&gt;**](Guid) |  |  |

### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="bulksendemails"></a>
# **BulkSendEmails**
> void BulkSendEmails (BulkSendEmailOptions bulkSendEmailOptions)

Bulk Send Emails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class BulkSendEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new BulkActionsControllerApi(config);
            var bulkSendEmailOptions = new BulkSendEmailOptions(); // BulkSendEmailOptions | 

            try
            {
                // Bulk Send Emails
                apiInstance.BulkSendEmails(bulkSendEmailOptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActionsControllerApi.BulkSendEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkSendEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Send Emails
    apiInstance.BulkSendEmailsWithHttpInfo(bulkSendEmailOptions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActionsControllerApi.BulkSendEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bulkSendEmailOptions** | [**BulkSendEmailOptions**](BulkSendEmailOptions) |  |  |

### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

