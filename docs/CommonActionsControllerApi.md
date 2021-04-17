# mailslurp.Api.CommonActionsControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewEmailAddress**](CommonActionsControllerApi#createnewemailaddress) | **POST** /createInbox | Create new random inbox
[**CreateNewEmailAddress1**](CommonActionsControllerApi#createnewemailaddress1) | **POST** /newEmailAddress | Create new random inbox
[**EmptyInbox**](CommonActionsControllerApi#emptyinbox) | **DELETE** /emptyInbox | Delete all emails in an inbox
[**SendEmailSimple**](CommonActionsControllerApi#sendemailsimple) | **POST** /sendEmail | Send an email


<a name="createnewemailaddress"></a>
# **CreateNewEmailAddress**
> Inbox CreateNewEmailAddress (bool? allowTeamAccess = null, DateTime? expiresAt = null, long? expiresIn = null, bool? useDomainPool = null)

Create new random inbox

Returns an Inbox with an `id` and an `emailAddress`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewEmailAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var allowTeamAccess = true;  // bool? | allowTeamAccess (optional) 
            var expiresAt = 2013-10-20T19:20:30+01:00;  // DateTime? | expiresAt (optional) 
            var expiresIn = 789;  // long? | expiresIn (optional) 
            var useDomainPool = true;  // bool? | useDomainPool (optional) 

            try
            {
                // Create new random inbox
                Inbox result = apiInstance.CreateNewEmailAddress(allowTeamAccess, expiresAt, expiresIn, useDomainPool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateNewEmailAddress: " + e.Message );
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
 **allowTeamAccess** | **bool?**| allowTeamAccess | [optional] 
 **expiresAt** | **DateTime?**| expiresAt | [optional] 
 **expiresIn** | **long?**| expiresIn | [optional] 
 **useDomainPool** | **bool?**| useDomainPool | [optional] 

### Return type

[**Inbox**](Inbox)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="createnewemailaddress1"></a>
# **CreateNewEmailAddress1**
> Inbox CreateNewEmailAddress1 (bool? allowTeamAccess = null, DateTime? expiresAt = null, long? expiresIn = null, bool? useDomainPool = null)

Create new random inbox

Returns an Inbox with an `id` and an `emailAddress`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewEmailAddress1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var allowTeamAccess = true;  // bool? | allowTeamAccess (optional) 
            var expiresAt = 2013-10-20T19:20:30+01:00;  // DateTime? | expiresAt (optional) 
            var expiresIn = 789;  // long? | expiresIn (optional) 
            var useDomainPool = true;  // bool? | useDomainPool (optional) 

            try
            {
                // Create new random inbox
                Inbox result = apiInstance.CreateNewEmailAddress1(allowTeamAccess, expiresAt, expiresIn, useDomainPool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateNewEmailAddress1: " + e.Message );
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
 **allowTeamAccess** | **bool?**| allowTeamAccess | [optional] 
 **expiresAt** | **DateTime?**| expiresAt | [optional] 
 **expiresIn** | **long?**| expiresIn | [optional] 
 **useDomainPool** | **bool?**| useDomainPool | [optional] 

### Return type

[**Inbox**](Inbox)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="emptyinbox"></a>
# **EmptyInbox**
> void EmptyInbox (Guid inboxId)

Delete all emails in an inbox

Deletes all emails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class EmptyInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var inboxId = new Guid(); // Guid | inboxId

            try
            {
                // Delete all emails in an inbox
                apiInstance.EmptyInbox(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.EmptyInbox: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| inboxId | 

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

<a name="sendemailsimple"></a>
# **SendEmailSimple**
> void SendEmailSimple (SimpleSendEmailOptions emailOptions)

Send an email

If no senderId or inboxId provided a random email address will be used to send from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailSimpleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var emailOptions = new SimpleSendEmailOptions(); // SimpleSendEmailOptions | emailOptions

            try
            {
                // Send an email
                apiInstance.SendEmailSimple(emailOptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailSimple: " + e.Message );
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
 **emailOptions** | [**SimpleSendEmailOptions**](SimpleSendEmailOptions)| emailOptions | 

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

