# mailslurp.Api.PhoneControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmergencyAddress**](PhoneControllerApi#createemergencyaddress) | **POST** /phone/emergency-addresses | 
[**DeleteEmergencyAddress**](PhoneControllerApi#deleteemergencyaddress) | **DELETE** /phone/emergency-addresses/{addressId} | 
[**DeletePhoneNumber**](PhoneControllerApi#deletephonenumber) | **DELETE** /phone/numbers/{phoneNumberId} | 
[**GetEmergencyAddress**](PhoneControllerApi#getemergencyaddress) | **GET** /phone/emergency-addresses/{addressId} | 
[**GetEmergencyAddresses**](PhoneControllerApi#getemergencyaddresses) | **GET** /phone/emergency-addresses | 
[**GetPhoneNumber**](PhoneControllerApi#getphonenumber) | **GET** /phone/numbers/{phoneNumberId} | 
[**GetPhoneNumbers**](PhoneControllerApi#getphonenumbers) | **GET** /phone/numbers | 
[**GetPhonePlans**](PhoneControllerApi#getphoneplans) | **GET** /phone/plans | 


<a name="createemergencyaddress"></a>
# **CreateEmergencyAddress**
> EmergencyAddress CreateEmergencyAddress (CreateEmergencyAddressOptions createEmergencyAddressOptions)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateEmergencyAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var createEmergencyAddressOptions = new CreateEmergencyAddressOptions(); // CreateEmergencyAddressOptions | 

            try
            {
                EmergencyAddress result = apiInstance.CreateEmergencyAddress(createEmergencyAddressOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.CreateEmergencyAddress: " + e.Message );
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
 **createEmergencyAddressOptions** | [**CreateEmergencyAddressOptions**](CreateEmergencyAddressOptions)|  | 

### Return type

[**EmergencyAddress**](EmergencyAddress)

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

<a name="deleteemergencyaddress"></a>
# **DeleteEmergencyAddress**
> EmptyResponseDto DeleteEmergencyAddress (Guid addressId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteEmergencyAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var addressId = new Guid(); // Guid | 

            try
            {
                EmptyResponseDto result = apiInstance.DeleteEmergencyAddress(addressId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.DeleteEmergencyAddress: " + e.Message );
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
 **addressId** | [**Guid**](Guid)|  | 

### Return type

[**EmptyResponseDto**](EmptyResponseDto)

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

<a name="deletephonenumber"></a>
# **DeletePhoneNumber**
> void DeletePhoneNumber (Guid phoneNumberId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeletePhoneNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var phoneNumberId = new Guid(); // Guid | 

            try
            {
                apiInstance.DeletePhoneNumber(phoneNumberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.DeletePhoneNumber: " + e.Message );
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
 **phoneNumberId** | [**Guid**](Guid)|  | 

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

<a name="getemergencyaddress"></a>
# **GetEmergencyAddress**
> EmergencyAddress GetEmergencyAddress (Guid addressId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmergencyAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var addressId = new Guid(); // Guid | 

            try
            {
                EmergencyAddress result = apiInstance.GetEmergencyAddress(addressId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.GetEmergencyAddress: " + e.Message );
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
 **addressId** | [**Guid**](Guid)|  | 

### Return type

[**EmergencyAddress**](EmergencyAddress)

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

<a name="getemergencyaddresses"></a>
# **GetEmergencyAddresses**
> List&lt;EmergencyAddressDto&gt; GetEmergencyAddresses ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmergencyAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);

            try
            {
                List<EmergencyAddressDto> result = apiInstance.GetEmergencyAddresses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.GetEmergencyAddresses: " + e.Message );
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

[**List&lt;EmergencyAddressDto&gt;**](EmergencyAddressDto)

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

<a name="getphonenumber"></a>
# **GetPhoneNumber**
> PhoneNumberDto GetPhoneNumber (Guid phoneNumberId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetPhoneNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var phoneNumberId = new Guid(); // Guid | 

            try
            {
                PhoneNumberDto result = apiInstance.GetPhoneNumber(phoneNumberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.GetPhoneNumber: " + e.Message );
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
 **phoneNumberId** | [**Guid**](Guid)|  | 

### Return type

[**PhoneNumberDto**](PhoneNumberDto)

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

<a name="getphonenumbers"></a>
# **GetPhoneNumbers**
> PagePhoneNumberProjection GetPhoneNumbers (int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetPhoneNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);
            var page = 56;  // int? | Optional page index for list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size for list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                PagePhoneNumberProjection result = apiInstance.GetPhoneNumbers(page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.GetPhoneNumbers: " + e.Message );
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
 **page** | **int?**| Optional page index for list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size for list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PagePhoneNumberProjection**](PagePhoneNumberProjection)

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

<a name="getphoneplans"></a>
# **GetPhonePlans**
> List&lt;PhonePlanDto&gt; GetPhonePlans ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetPhonePlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PhoneControllerApi(config);

            try
            {
                List<PhonePlanDto> result = apiInstance.GetPhonePlans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneControllerApi.GetPhonePlans: " + e.Message );
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

[**List&lt;PhonePlanDto&gt;**](PhonePlanDto)

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

