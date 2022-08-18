# mailslurp.Api.SmsControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSmsMessage**](SmsControllerApi#deletesmsmessage) | **DELETE** /sms/{smsId} | Delete SMS message.
[**DeleteSmsMessages**](SmsControllerApi#deletesmsmessages) | **DELETE** /sms | Delete all SMS messages
[**GetSmsMessage**](SmsControllerApi#getsmsmessage) | **GET** /sms/{smsId} | Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.
[**GetSmsMessagesPaginated**](SmsControllerApi#getsmsmessagespaginated) | **GET** /sms | Get all SMS messages in all phone numbers in paginated form. .


<a name="deletesmsmessage"></a>
# **DeleteSmsMessage**
> void DeleteSmsMessage (Guid smsId)

Delete SMS message.

Delete an SMS message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = new Guid(); // Guid | 

            try
            {
                // Delete SMS message.
                apiInstance.DeleteSmsMessage(smsId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessage: " + e.Message );
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
 **smsId** | [**Guid**](Guid)|  | 

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

<a name="deletesmsmessages"></a>
# **DeleteSmsMessages**
> void DeleteSmsMessages (Guid? phoneNumberId = null)

Delete all SMS messages

Delete all SMS messages or all messages for a given phone number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteSmsMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var phoneNumberId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // Delete all SMS messages
                apiInstance.DeleteSmsMessages(phoneNumberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessages: " + e.Message );
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
 **phoneNumberId** | [**Guid?**](Guid?)|  | [optional] 

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

<a name="getsmsmessage"></a>
# **GetSmsMessage**
> SmsDto GetSmsMessage (Guid smsId)

Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.

Returns a SMS summary object with content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = new Guid(); // Guid | 

            try
            {
                // Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.
                SmsDto result = apiInstance.GetSmsMessage(smsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetSmsMessage: " + e.Message );
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
 **smsId** | [**Guid**](Guid)|  | 

### Return type

[**SmsDto**](SmsDto)

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

<a name="getsmsmessagespaginated"></a>
# **GetSmsMessagesPaginated**
> PageSmsProjection GetSmsMessagesPaginated (Guid? phoneNumber = null, int? page = null, int? size = null, string sort = null, bool? unreadOnly = null, DateTime? since = null, DateTime? before = null)

Get all SMS messages in all phone numbers in paginated form. .

By default returns all SMS messages across all phone numbers sorted by ascending created at date. Responses are paginated. You can restrict results to a list of phone number IDs. You can also filter out read messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetSmsMessagesPaginatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var phoneNumber = new Guid?(); // Guid? | Optional receiving phone number to filter SMS messages for (optional) 
            var page = 56;  // int? | Optional page index in SMS list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in SMS list pagination. Maximum size is 100. Use page index and sort to page through larger results (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var unreadOnly = true;  // bool? | Optional filter for unread SMS only. All SMS are considered unread until they are viewed in the dashboard or requested directly (optional)  (default to false)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter SMSs received after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter SMSs received before given date time (optional) 

            try
            {
                // Get all SMS messages in all phone numbers in paginated form. .
                PageSmsProjection result = apiInstance.GetSmsMessagesPaginated(phoneNumber, page, size, sort, unreadOnly, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetSmsMessagesPaginated: " + e.Message );
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
 **phoneNumber** | [**Guid?**](Guid?)| Optional receiving phone number to filter SMS messages for | [optional] 
 **page** | **int?**| Optional page index in SMS list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in SMS list pagination. Maximum size is 100. Use page index and sort to page through larger results | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **unreadOnly** | **bool?**| Optional filter for unread SMS only. All SMS are considered unread until they are viewed in the dashboard or requested directly | [optional] [default to false]
 **since** | **DateTime?**| Optional filter SMSs received after given date time | [optional] 
 **before** | **DateTime?**| Optional filter SMSs received before given date time | [optional] 

### Return type

[**PageSmsProjection**](PageSmsProjection)

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

