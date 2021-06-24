# mailslurp.Api.ExportControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportEntities**](ExportControllerApi#exportentities) | **GET** /export | Export inboxes link callable via browser
[**GetExportLink**](ExportControllerApi#getexportlink) | **POST** /export | Get export link


<a name="exportentities"></a>
# **ExportEntities**
> byte[] ExportEntities (string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = null, DateTime? createdOldestTime = null, bool? excludePreviouslyExported = null, string filter = null, string listSeparatorToken = null)

Export inboxes link callable via browser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class ExportEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExportControllerApi(config);
            var apiKey = apiKey_example;  // string | apiKey
            var exportType = exportType_example;  // string | exportType
            var outputFormat = outputFormat_example;  // string | outputFormat
            var createdEarliestTime = 2013-10-20T19:20:30+01:00;  // DateTime? | createdEarliestTime (optional) 
            var createdOldestTime = 2013-10-20T19:20:30+01:00;  // DateTime? | createdOldestTime (optional) 
            var excludePreviouslyExported = true;  // bool? | excludePreviouslyExported (optional) 
            var filter = filter_example;  // string | filter (optional) 
            var listSeparatorToken = listSeparatorToken_example;  // string | listSeparatorToken (optional) 

            try
            {
                // Export inboxes link callable via browser
                byte[] result = apiInstance.ExportEntities(apiKey, exportType, outputFormat, createdEarliestTime, createdOldestTime, excludePreviouslyExported, filter, listSeparatorToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportControllerApi.ExportEntities: " + e.Message );
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
 **apiKey** | **string**| apiKey | 
 **exportType** | **string**| exportType | 
 **outputFormat** | **string**| outputFormat | 
 **createdEarliestTime** | **DateTime?**| createdEarliestTime | [optional] 
 **createdOldestTime** | **DateTime?**| createdOldestTime | [optional] 
 **excludePreviouslyExported** | **bool?**| excludePreviouslyExported | [optional] 
 **filter** | **string**| filter | [optional] 
 **listSeparatorToken** | **string**| listSeparatorToken | [optional] 

### Return type

**byte[]**

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

<a name="getexportlink"></a>
# **GetExportLink**
> ExportLink GetExportLink (string exportType, ExportOptions exportOptions, string apiKey = null)

Get export link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetExportLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExportControllerApi(config);
            var exportType = exportType_example;  // string | exportType
            var exportOptions = new ExportOptions(); // ExportOptions | exportOptions
            var apiKey = apiKey_example;  // string | apiKey (optional) 

            try
            {
                // Get export link
                ExportLink result = apiInstance.GetExportLink(exportType, exportOptions, apiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportControllerApi.GetExportLink: " + e.Message );
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
 **exportType** | **string**| exportType | 
 **exportOptions** | [**ExportOptions**](ExportOptions)| exportOptions | 
 **apiKey** | **string**| apiKey | [optional] 

### Return type

[**ExportLink**](ExportLink)

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

