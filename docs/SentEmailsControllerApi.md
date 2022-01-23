# mailslurp.Api.SentEmailsControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAllSentEmails**](SentEmailsControllerApi#deleteallsentemails) | **DELETE** /sent | Delete all sent email receipts
[**DeleteSentEmail**](SentEmailsControllerApi#deletesentemail) | **DELETE** /sent/{id} | Delete sent email receipt
[**GetAllSentTrackingPixels**](SentEmailsControllerApi#getallsenttrackingpixels) | **GET** /sent/tracking-pixels | 
[**GetSentEmail**](SentEmailsControllerApi#getsentemail) | **GET** /sent/{id} | Get sent email receipt
[**GetSentEmailHTMLContent**](SentEmailsControllerApi#getsentemailhtmlcontent) | **GET** /sent/{id}/html | Get sent email HTML content
[**GetSentEmailTrackingPixels**](SentEmailsControllerApi#getsentemailtrackingpixels) | **GET** /sent/{id}/tracking-pixels | 
[**GetSentEmails**](SentEmailsControllerApi#getsentemails) | **GET** /sent | Get all sent emails in paginated form
[**GetSentOrganizationEmails**](SentEmailsControllerApi#getsentorganizationemails) | **GET** /sent/organization | 


<a name="deleteallsentemails"></a>
# **DeleteAllSentEmails**
> void DeleteAllSentEmails ()

Delete all sent email receipts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteAllSentEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);

            try
            {
                // Delete all sent email receipts
                apiInstance.DeleteAllSentEmails();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.DeleteAllSentEmails: " + e.Message );
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

<a name="deletesentemail"></a>
# **DeleteSentEmail**
> void DeleteSentEmail (Guid id)

Delete sent email receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteSentEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Delete sent email receipt
                apiInstance.DeleteSentEmail(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.DeleteSentEmail: " + e.Message );
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
 **id** | [**Guid**](Guid)|  | 

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

<a name="getallsenttrackingpixels"></a>
# **GetAllSentTrackingPixels**
> PageTrackingPixelProjection GetAllSentTrackingPixels (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)



Get all sent email tracking pixels in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllSentTrackingPixelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var page = 56;  // int? | Optional page index in sent email tracking pixel list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in sent email tracking pixel list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                PageTrackingPixelProjection result = apiInstance.GetAllSentTrackingPixels(page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetAllSentTrackingPixels: " + e.Message );
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
 **page** | **int?**| Optional page index in sent email tracking pixel list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in sent email tracking pixel list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageTrackingPixelProjection**](PageTrackingPixelProjection)

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

<a name="getsentemail"></a>
# **GetSentEmail**
> SentEmailDto GetSentEmail (Guid id)

Get sent email receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSentEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Get sent email receipt
                SentEmailDto result = apiInstance.GetSentEmail(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetSentEmail: " + e.Message );
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
 **id** | [**Guid**](Guid)|  | 

### Return type

[**SentEmailDto**](SentEmailDto)

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

<a name="getsentemailhtmlcontent"></a>
# **GetSentEmailHTMLContent**
> string GetSentEmailHTMLContent (Guid id)

Get sent email HTML content

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSentEmailHTMLContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Get sent email HTML content
                string result = apiInstance.GetSentEmailHTMLContent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetSentEmailHTMLContent: " + e.Message );
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
 **id** | [**Guid**](Guid)|  | 

### Return type

**string**

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getsentemailtrackingpixels"></a>
# **GetSentEmailTrackingPixels**
> PageTrackingPixelProjection GetSentEmailTrackingPixels (Guid id, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)



Get all tracking pixels for a sent email in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSentEmailTrackingPixelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var id = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in sent email tracking pixel list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in sent email tracking pixel list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                PageTrackingPixelProjection result = apiInstance.GetSentEmailTrackingPixels(id, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetSentEmailTrackingPixels: " + e.Message );
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
 **id** | [**Guid**](Guid)|  | 
 **page** | **int?**| Optional page index in sent email tracking pixel list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in sent email tracking pixel list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageTrackingPixelProjection**](PageTrackingPixelProjection)

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

<a name="getsentemails"></a>
# **GetSentEmails**
> PageSentEmailProjection GetSentEmails (Guid? inboxId = null, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

Get all sent emails in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSentEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inboxId to filter sender of sent emails by (optional) 
            var page = 56;  // int? | Optional page index in inbox sent email list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox sent email list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get all sent emails in paginated form
                PageSentEmailProjection result = apiInstance.GetSentEmails(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetSentEmails: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inboxId to filter sender of sent emails by | [optional] 
 **page** | **int?**| Optional page index in inbox sent email list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox sent email list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageSentEmailProjection**](PageSentEmailProjection)

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

<a name="getsentorganizationemails"></a>
# **GetSentOrganizationEmails**
> PageSentEmailProjection GetSentOrganizationEmails (Guid? inboxId = null, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)



Get all sent organization emails in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSentOrganizationEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SentEmailsControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inboxId to filter sender of sent emails by (optional) 
            var page = 56;  // int? | Optional page index in sent email list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in sent email list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                PageSentEmailProjection result = apiInstance.GetSentOrganizationEmails(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SentEmailsControllerApi.GetSentOrganizationEmails: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inboxId to filter sender of sent emails by | [optional] 
 **page** | **int?**| Optional page index in sent email list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in sent email list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageSentEmailProjection**](PageSentEmailProjection)

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

