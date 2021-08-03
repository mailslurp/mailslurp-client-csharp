# mailslurp.Api.InboxForwarderControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewInboxForwarder**](InboxForwarderControllerApi#createnewinboxforwarder) | **POST** /forwarders | Create an inbox forwarder
[**DeleteInboxForwarder**](InboxForwarderControllerApi#deleteinboxforwarder) | **DELETE** /forwarders/{id} | Delete an inbox forwarder
[**DeleteInboxForwarders**](InboxForwarderControllerApi#deleteinboxforwarders) | **DELETE** /forwarders | Delete inbox forwarders
[**GetInboxForwarder**](InboxForwarderControllerApi#getinboxforwarder) | **GET** /forwarders/{id} | Get an inbox forwarder
[**GetInboxForwarders**](InboxForwarderControllerApi#getinboxforwarders) | **GET** /forwarders | List inbox forwarders
[**TestInboxForwarder**](InboxForwarderControllerApi#testinboxforwarder) | **POST** /forwarders/{id}/test | Test an inbox forwarder
[**TestInboxForwardersForInbox**](InboxForwarderControllerApi#testinboxforwardersforinbox) | **PUT** /forwarders | Test inbox forwarders for inbox
[**TestNewInboxForwarder**](InboxForwarderControllerApi#testnewinboxforwarder) | **PATCH** /forwarders | Test new inbox forwarder


<a name="createnewinboxforwarder"></a>
# **CreateNewInboxForwarder**
> InboxForwarderDto CreateNewInboxForwarder (CreateInboxForwarderOptions createInboxForwarderOptions, Guid? inboxId = null)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var createInboxForwarderOptions = new CreateInboxForwarderOptions(); // CreateInboxForwarderOptions | createInboxForwarderOptions
            var inboxId = new Guid?(); // Guid? | Inbox id to attach forwarder to (optional) 

            try
            {
                // Create an inbox forwarder
                InboxForwarderDto result = apiInstance.CreateNewInboxForwarder(createInboxForwarderOptions, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.CreateNewInboxForwarder: " + e.Message );
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
 **createInboxForwarderOptions** | [**CreateInboxForwarderOptions**](CreateInboxForwarderOptions)| createInboxForwarderOptions | 
 **inboxId** | [**Guid?**](Guid?)| Inbox id to attach forwarder to | [optional] 

### Return type

[**InboxForwarderDto**](InboxForwarderDto)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = new Guid(); // Guid | ID of inbox forwarder

            try
            {
                // Delete an inbox forwarder
                apiInstance.DeleteInboxForwarder(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwarder: " + e.Message );
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
 **id** | [**Guid**](Guid)| ID of inbox forwarder | 

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox id to attach forwarder to (optional) 

            try
            {
                // Delete inbox forwarders
                apiInstance.DeleteInboxForwarders(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.DeleteInboxForwarders: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox id to attach forwarder to | [optional] 

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = new Guid(); // Guid | ID of inbox forwarder

            try
            {
                // Get an inbox forwarder
                InboxForwarderDto result = apiInstance.GetInboxForwarder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarder: " + e.Message );
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
 **id** | [**Guid**](Guid)| ID of inbox forwarder | 

### Return type

[**InboxForwarderDto**](InboxForwarderDto)

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

<a name="getinboxforwarders"></a>
# **GetInboxForwarders**
> PageInboxForwarderDto GetInboxForwarders (Guid? inboxId = null, int? page = null, string searchFilter = null, int? size = null, string sort = null)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox id to get forwarders from (optional) 
            var page = 56;  // int? | Optional page index in inbox forwarder list pagination (optional)  (default to 0)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in inbox forwarder list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // List inbox forwarders
                PageInboxForwarderDto result = apiInstance.GetInboxForwarders(inboxId, page, searchFilter, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.GetInboxForwarders: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox id to get forwarders from | [optional] 
 **page** | **int?**| Optional page index in inbox forwarder list pagination | [optional] [default to 0]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in inbox forwarder list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageInboxForwarderDto**](PageInboxForwarderDto)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var id = new Guid(); // Guid | ID of inbox forwarder
            var inboxForwarderTestOptions = new InboxForwarderTestOptions(); // InboxForwarderTestOptions | inboxForwarderTestOptions

            try
            {
                // Test an inbox forwarder
                InboxForwarderTestResult result = apiInstance.TestInboxForwarder(id, inboxForwarderTestOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwarder: " + e.Message );
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
 **id** | [**Guid**](Guid)| ID of inbox forwarder | 
 **inboxForwarderTestOptions** | [**InboxForwarderTestOptions**](InboxForwarderTestOptions)| inboxForwarderTestOptions | 

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var inboxId = new Guid(); // Guid | ID of inbox
            var inboxForwarderTestOptions = new InboxForwarderTestOptions(); // InboxForwarderTestOptions | inboxForwarderTestOptions

            try
            {
                // Test inbox forwarders for inbox
                InboxForwarderTestResult result = apiInstance.TestInboxForwardersForInbox(inboxId, inboxForwarderTestOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestInboxForwardersForInbox: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| ID of inbox | 
 **inboxForwarderTestOptions** | [**InboxForwarderTestOptions**](InboxForwarderTestOptions)| inboxForwarderTestOptions | 

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

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
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxForwarderControllerApi(config);
            var testNewInboxForwarderOptions = new TestNewInboxForwarderOptions(); // TestNewInboxForwarderOptions | testNewInboxForwarderOptions

            try
            {
                // Test new inbox forwarder
                InboxForwarderTestResult result = apiInstance.TestNewInboxForwarder(testNewInboxForwarderOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxForwarderControllerApi.TestNewInboxForwarder: " + e.Message );
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
 **testNewInboxForwarderOptions** | [**TestNewInboxForwarderOptions**](TestNewInboxForwarderOptions)| testNewInboxForwarderOptions | 

### Return type

[**InboxForwarderTestResult**](InboxForwarderTestResult)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

