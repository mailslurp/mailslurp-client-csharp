# mailslurp.Api.CommonActionsControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewEmailAddress**](CommonActionsControllerApi#createnewemailaddress) | **POST** /newEmailAddress | Create new random inbox
[**CreateRandomInbox**](CommonActionsControllerApi#createrandominbox) | **POST** /createInbox | Create new random inbox
[**DeleteEmailAddress**](CommonActionsControllerApi#deleteemailaddress) | **DELETE** /deleteEmailAddress | Delete inbox email address by inbox id
[**EmptyInbox**](CommonActionsControllerApi#emptyinbox) | **DELETE** /emptyInbox | Delete all emails in an inbox
[**SendEmailSimple**](CommonActionsControllerApi#sendemailsimple) | **POST** /sendEmail | Send an email


<a name="createnewemailaddress"></a>
# **CreateNewEmailAddress**
> InboxDto CreateNewEmailAddress (bool? allowTeamAccess = null, bool? useDomainPool = null, DateTime? expiresAt = null, long? expiresIn = null, string emailAddress = null, string inboxType = null, string description = null, string name = null, List<string> tags = null, bool? favourite = null, bool? virtualInbox = null)

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
            var allowTeamAccess = true;  // bool? |  (optional) 
            var useDomainPool = true;  // bool? |  (optional) 
            var expiresAt = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var expiresIn = 789;  // long? |  (optional) 
            var emailAddress = emailAddress_example;  // string |  (optional) 
            var inboxType = inboxType_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var favourite = true;  // bool? |  (optional) 
            var virtualInbox = true;  // bool? |  (optional) 

            try
            {
                // Create new random inbox
                InboxDto result = apiInstance.CreateNewEmailAddress(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox);
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
 **allowTeamAccess** | **bool?**|  | [optional] 
 **useDomainPool** | **bool?**|  | [optional] 
 **expiresAt** | **DateTime?**|  | [optional] 
 **expiresIn** | **long?**|  | [optional] 
 **emailAddress** | **string**|  | [optional] 
 **inboxType** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **tags** | [**List&lt;string&gt;**](string)|  | [optional] 
 **favourite** | **bool?**|  | [optional] 
 **virtualInbox** | **bool?**|  | [optional] 

### Return type

[**InboxDto**](InboxDto)

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

<a name="createrandominbox"></a>
# **CreateRandomInbox**
> InboxDto CreateRandomInbox (bool? allowTeamAccess = null, bool? useDomainPool = null, DateTime? expiresAt = null, long? expiresIn = null, string emailAddress = null, string inboxType = null, string description = null, string name = null, List<string> tags = null, bool? favourite = null, bool? virtualInbox = null)

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
    public class CreateRandomInboxExample
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
            var allowTeamAccess = true;  // bool? |  (optional) 
            var useDomainPool = true;  // bool? |  (optional) 
            var expiresAt = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var expiresIn = 789;  // long? |  (optional) 
            var emailAddress = emailAddress_example;  // string |  (optional) 
            var inboxType = inboxType_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var favourite = true;  // bool? |  (optional) 
            var virtualInbox = true;  // bool? |  (optional) 

            try
            {
                // Create new random inbox
                InboxDto result = apiInstance.CreateRandomInbox(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateRandomInbox: " + e.Message );
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
 **allowTeamAccess** | **bool?**|  | [optional] 
 **useDomainPool** | **bool?**|  | [optional] 
 **expiresAt** | **DateTime?**|  | [optional] 
 **expiresIn** | **long?**|  | [optional] 
 **emailAddress** | **string**|  | [optional] 
 **inboxType** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **tags** | [**List&lt;string&gt;**](string)|  | [optional] 
 **favourite** | **bool?**|  | [optional] 
 **virtualInbox** | **bool?**|  | [optional] 

### Return type

[**InboxDto**](InboxDto)

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

<a name="deleteemailaddress"></a>
# **DeleteEmailAddress**
> void DeleteEmailAddress (Guid inboxId)

Delete inbox email address by inbox id

Deletes inbox email address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteEmailAddressExample
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
            var inboxId = new Guid(); // Guid | 

            try
            {
                // Delete inbox email address by inbox id
                apiInstance.DeleteEmailAddress(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.DeleteEmailAddress: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)|  | 

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
            var inboxId = new Guid(); // Guid | 

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
 **inboxId** | [**Guid**](Guid)|  | 

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

<a name="sendemailsimple"></a>
# **SendEmailSimple**
> void SendEmailSimple (SimpleSendEmailOptions simpleSendEmailOptions)

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
            var simpleSendEmailOptions = new SimpleSendEmailOptions(); // SimpleSendEmailOptions | 

            try
            {
                // Send an email
                apiInstance.SendEmailSimple(simpleSendEmailOptions);
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
 **simpleSendEmailOptions** | [**SimpleSendEmailOptions**](SimpleSendEmailOptions)|  | 

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

