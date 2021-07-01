# mailslurp.Api.TrackingControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTrackingPixel**](TrackingControllerApi#createtrackingpixel) | **POST** /tracking/pixels | Create tracking pixel
[**GetAllTrackingPixels**](TrackingControllerApi#getalltrackingpixels) | **GET** /tracking/pixels | Get tracking pixels
[**GetTrackingPixel**](TrackingControllerApi#gettrackingpixel) | **GET** /tracking/pixels/{id} | Get pixel


<a name="createtrackingpixel"></a>
# **CreateTrackingPixel**
> TrackingPixelDto CreateTrackingPixel (CreateTrackingPixelOptions createTrackingPixelOptions)

Create tracking pixel

Create a tracking pixel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateTrackingPixelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TrackingControllerApi(config);
            var createTrackingPixelOptions = new CreateTrackingPixelOptions(); // CreateTrackingPixelOptions | createTrackingPixelOptions

            try
            {
                // Create tracking pixel
                TrackingPixelDto result = apiInstance.CreateTrackingPixel(createTrackingPixelOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingControllerApi.CreateTrackingPixel: " + e.Message );
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
 **createTrackingPixelOptions** | [**CreateTrackingPixelOptions**](CreateTrackingPixelOptions)| createTrackingPixelOptions | 

### Return type

[**TrackingPixelDto**](TrackingPixelDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getalltrackingpixels"></a>
# **GetAllTrackingPixels**
> PageTrackingPixelProjection GetAllTrackingPixels (int? page = null, int? size = null, string sort = null)

Get tracking pixels

List tracking pixels in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllTrackingPixelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TrackingControllerApi(config);
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get tracking pixels
                PageTrackingPixelProjection result = apiInstance.GetAllTrackingPixels(page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingControllerApi.GetAllTrackingPixels: " + e.Message );
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
 **page** | **int?**| Optional page index in list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageTrackingPixelProjection**](PageTrackingPixelProjection)

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

<a name="gettrackingpixel"></a>
# **GetTrackingPixel**
> TrackingPixelDto GetTrackingPixel (Guid id)

Get pixel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTrackingPixelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TrackingControllerApi(config);
            var id = new Guid(); // Guid | id

            try
            {
                // Get pixel
                TrackingPixelDto result = apiInstance.GetTrackingPixel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingControllerApi.GetTrackingPixel: " + e.Message );
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
 **id** | [**Guid**](Guid)| id | 

### Return type

[**TrackingPixelDto**](TrackingPixelDto)

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

