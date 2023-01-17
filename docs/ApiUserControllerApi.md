# mailslurp.Api.ApiUserControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetJsonPropertyAsString**](ApiUserControllerApi#getjsonpropertyasstring) | **POST** /user/json/pluck |  |
| [**GetUserInfo**](ApiUserControllerApi#getuserinfo) | **GET** /user/info |  |

<a name="getjsonpropertyasstring"></a>
# **GetJsonPropertyAsString**
> string GetJsonPropertyAsString (string property, Object body)



Utility function to extract properties from JSON objects in language where this is cumbersome.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetJsonPropertyAsStringExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiUserControllerApi(config);
            var property = "property_example";  // string | JSON property name or dot separated path selector such as `a.b.c`
            var body = null;  // Object | 

            try
            {
                string result = apiInstance.GetJsonPropertyAsString(property, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiUserControllerApi.GetJsonPropertyAsString: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJsonPropertyAsStringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetJsonPropertyAsStringWithHttpInfo(property, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiUserControllerApi.GetJsonPropertyAsStringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **property** | **string** | JSON property name or dot separated path selector such as &#x60;a.b.c&#x60; |  |
| **body** | **Object** |  |  |

### Return type

**string**

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

<a name="getuserinfo"></a>
# **GetUserInfo**
> UserInfoDto GetUserInfo ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiUserControllerApi(config);

            try
            {
                UserInfoDto result = apiInstance.GetUserInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiUserControllerApi.GetUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserInfoDto> response = apiInstance.GetUserInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiUserControllerApi.GetUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserInfoDto**](UserInfoDto)

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

