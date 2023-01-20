# mailslurp.Api.InboxForwarderControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewInboxForwarder**](InboxForwarderControllerApi#createnewinboxforwarder) | **POST** /forwarders | Create an inbox forwarder |
| [**DeleteInboxForwarder**](InboxForwarderControllerApi#deleteinboxforwarder) | **DELETE** /forwarders/{id} | Delete an inbox forwarder |
| [**DeleteInboxForwarders**](InboxForwarderControllerApi#deleteinboxforwarders) | **DELETE** /forwarders | Delete inbox forwarders |
| [**GetInboxForwarder**](InboxForwarderControllerApi#getinboxforwarder) | **GET** /forwarders/{id} | Get an inbox forwarder |
| [**GetInboxForwarderEvents**](InboxForwarderControllerApi#getinboxforwarderevents) | **GET** /forwarders/{id}/events | Get an inbox forwarder event list |
| [**GetInboxForwarders**](InboxForwarderControllerApi#getinboxforwarders) | **GET** /forwarders | List inbox forwarders |
| [**TestInboxForwarder**](InboxForwarderControllerApi#testinboxforwarder) | **POST** /forwarders/{id}/test | Test an inbox forwarder |
| [**TestInboxForwardersForInbox**](InboxForwarderControllerApi#testinboxforwardersforinbox) | **PUT** /forwarders | Test inbox forwarders for inbox |
| [**TestNewInboxForwarder**](InboxForwarderControllerApi#testnewinboxforwarder) | **PATCH** /forwarders | Test new inbox forwarder |
| [**UpdateInboxForwarder**](InboxForwarderControllerApi#updateinboxforwarder) | **PUT** /forwarders/{id} | Update an inbox forwarder |

<a name="createnewinboxforwarder"></a>
# **CreateNewInboxForwarder**
> InboxForwarderDto CreateNewInboxForwarder (Guid inboxId, CreateInboxForwarderOptions createInboxForwarderOptions)

Create an inbox forwarder

Create a new inbox rule for forwarding, blocking, and allowing emails when sending and receiving

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = "inboxId_example";  // Guid | Inbox id to attach forwarder to
            var createInboxForwarderOptions = new CreateInboxForwarderOptions(); // CreateInboxForwarderOptions | 

            try
            {
                // Create an inbox forwarder
                InboxForwarderDto result = apiInstance.CreateNewInboxForwarder(inboxId, createInboxForwarderOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.CreateNewInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inbox forwarder
    ApiResponse<InboxForwarderDto> response = apiInstance.CreateNewInboxForwarderWithHttpInfo(inboxId, createInboxForwarderOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.CreateNewInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid** | Inbox id to attach forwarder to |  |
| **createInboxForwarderOptions** | [**CreateInboxForwarderOptions**](CreateInboxForwarderOptions) |  |  |

### Return type

[**InboxForwarderDto**](InboxForwarderDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deleteinboxforwarder"></a>
# **DeleteInboxForwarder**
> void DeleteInboxForwarder (Guid id)

Delete an inbox forwarder

Delete inbox forwarder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox forwarder

            try
            {
                // Delete an inbox forwarder
                apiInstance.DeleteInboxForwarder(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inbox forwarder
    apiInstance.DeleteInboxForwarderWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox forwarder |  |

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
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deleteinboxforwarders"></a>
# **DeleteInboxForwarders**
> void DeleteInboxForwarders (Guid? inboxId = null)

Delete inbox forwarders

Delete inbox forwarders. Accepts optional inboxId filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxForwardersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = "inboxId_example";  // Guid? | Optional inbox id to attach forwarder to (optional) 

            try
            {
                // Delete inbox forwarders
                apiInstance.DeleteInboxForwarders(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwarders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboxForwardersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete inbox forwarders
    apiInstance.DeleteInboxForwardersWithHttpInfo(inboxId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwardersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid?** | Optional inbox id to attach forwarder to | [optional]  |

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
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getinboxforwarder"></a>
# **GetInboxForwarder**
> InboxForwarderDto GetInboxForwarder (Guid id)

Get an inbox forwarder

Get inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox forwarder

            try
            {
                // Get an inbox forwarder
                InboxForwarderDto result = apiInstance.GetInboxForwarder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox forwarder
    ApiResponse<InboxForwarderDto> response = apiInstance.GetInboxForwarderWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox forwarder |  |

### Return type

[**InboxForwarderDto**](InboxForwarderDto)

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

<a name="getinboxforwarderevents"></a>
# **GetInboxForwarderEvents**
> PageInboxForwarderEvents GetInboxForwarderEvents (Guid id, int? page = null, int? size = null, string sort = null)

Get an inbox forwarder event list

Get inbox ruleset events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxForwarderEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox forwarder
            var page = 0;  // int? | Optional page index in inbox forwarder event list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in inbox forwarder event list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get an inbox forwarder event list
                PageInboxForwarderEvents result = apiInstance.GetInboxForwarderEvents(id, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarderEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxForwarderEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox forwarder event list
    ApiResponse<PageInboxForwarderEvents> response = apiInstance.GetInboxForwarderEventsWithHttpInfo(id, page, size, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarderEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox forwarder |  |
| **page** | **int?** | Optional page index in inbox forwarder event list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in inbox forwarder event list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |

### Return type

[**PageInboxForwarderEvents**](PageInboxForwarderEvents)

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

<a name="getinboxforwarders"></a>
# **GetInboxForwarders**
> PageInboxForwarderDto GetInboxForwarders (Guid? inboxId = null, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

List inbox forwarders

List all forwarders attached to an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxForwardersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = "inboxId_example";  // Guid? | Optional inbox id to get forwarders from (optional) 
            var page = 0;  // int? | Optional page index in inbox forwarder list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in inbox forwarder list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = "searchFilter_example";  // string | Optional search filter (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // List inbox forwarders
                PageInboxForwarderDto result = apiInstance.GetInboxForwarders(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxForwardersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List inbox forwarders
    ApiResponse<PageInboxForwarderDto> response = apiInstance.GetInboxForwardersWithHttpInfo(inboxId, page, size, sort, searchFilter, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwardersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid?** | Optional inbox id to get forwarders from | [optional]  |
| **page** | **int?** | Optional page index in inbox forwarder list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in inbox forwarder list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **searchFilter** | **string** | Optional search filter | [optional]  |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageInboxForwarderDto**](PageInboxForwarderDto)

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

<a name="testinboxforwarder"></a>
# **TestInboxForwarder**
> InboxForwarderTestResult TestInboxForwarder (Guid id, InboxForwarderTestOptions inboxForwarderTestOptions)

Test an inbox forwarder

Test an inbox forwarder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class TestInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox forwarder
            var inboxForwarderTestOptions = new InboxForwarderTestOptions(); // InboxForwarderTestOptions | 

            try
            {
                // Test an inbox forwarder
                InboxForwarderTestResult result = apiInstance.TestInboxForwarder(id, inboxForwarderTestOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test an inbox forwarder
    ApiResponse<InboxForwarderTestResult> response = apiInstance.TestInboxForwarderWithHttpInfo(id, inboxForwarderTestOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox forwarder |  |
| **inboxForwarderTestOptions** | [**InboxForwarderTestOptions**](InboxForwarderTestOptions) |  |  |

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="testinboxforwardersforinbox"></a>
# **TestInboxForwardersForInbox**
> InboxForwarderTestResult TestInboxForwardersForInbox (Guid inboxId, InboxForwarderTestOptions inboxForwarderTestOptions)

Test inbox forwarders for inbox

Test inbox forwarders for inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class TestInboxForwardersForInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = "inboxId_example";  // Guid | ID of inbox
            var inboxForwarderTestOptions = new InboxForwarderTestOptions(); // InboxForwarderTestOptions | 

            try
            {
                // Test inbox forwarders for inbox
                InboxForwarderTestResult result = apiInstance.TestInboxForwardersForInbox(inboxId, inboxForwarderTestOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwardersForInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestInboxForwardersForInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test inbox forwarders for inbox
    ApiResponse<InboxForwarderTestResult> response = apiInstance.TestInboxForwardersForInboxWithHttpInfo(inboxId, inboxForwarderTestOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwardersForInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid** | ID of inbox |  |
| **inboxForwarderTestOptions** | [**InboxForwarderTestOptions**](InboxForwarderTestOptions) |  |  |

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="testnewinboxforwarder"></a>
# **TestNewInboxForwarder**
> InboxForwarderTestResult TestNewInboxForwarder (TestNewInboxForwarderOptions testNewInboxForwarderOptions)

Test new inbox forwarder

Test new inbox forwarder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class TestNewInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var testNewInboxForwarderOptions = new TestNewInboxForwarderOptions(); // TestNewInboxForwarderOptions | 

            try
            {
                // Test new inbox forwarder
                InboxForwarderTestResult result = apiInstance.TestNewInboxForwarder(testNewInboxForwarderOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestNewInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestNewInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test new inbox forwarder
    ApiResponse<InboxForwarderTestResult> response = apiInstance.TestNewInboxForwarderWithHttpInfo(testNewInboxForwarderOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.TestNewInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testNewInboxForwarderOptions** | [**TestNewInboxForwarderOptions**](TestNewInboxForwarderOptions) |  |  |

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="updateinboxforwarder"></a>
# **UpdateInboxForwarder**
> InboxForwarderDto UpdateInboxForwarder (Guid id, CreateInboxForwarderOptions createInboxForwarderOptions)

Update an inbox forwarder

Update inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class UpdateInboxForwarderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox forwarder
            var createInboxForwarderOptions = new CreateInboxForwarderOptions(); // CreateInboxForwarderOptions | 

            try
            {
                // Update an inbox forwarder
                InboxForwarderDto result = apiInstance.UpdateInboxForwarder(id, createInboxForwarderOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.UpdateInboxForwarder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInboxForwarderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an inbox forwarder
    ApiResponse<InboxForwarderDto> response = apiInstance.UpdateInboxForwarderWithHttpInfo(id, createInboxForwarderOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxForwarderControllerApi.UpdateInboxForwarderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox forwarder |  |
| **createInboxForwarderOptions** | [**CreateInboxForwarderOptions**](CreateInboxForwarderOptions) |  |  |

### Return type

[**InboxForwarderDto**](InboxForwarderDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

