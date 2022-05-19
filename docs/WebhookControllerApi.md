# mailslurp.Api.WebhookControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountWebhook**](WebhookControllerApi#createaccountwebhook) | **POST** /webhooks | Attach a WebHook URL to an inbox
[**CreateWebhook**](WebhookControllerApi#createwebhook) | **POST** /inboxes/{inboxId}/webhooks | Attach a WebHook URL to an inbox
[**DeleteAllWebhooks**](WebhookControllerApi#deleteallwebhooks) | **DELETE** /webhooks | Delete all webhooks
[**DeleteWebhook**](WebhookControllerApi#deletewebhook) | **DELETE** /inboxes/{inboxId}/webhooks/{webhookId} | Delete and disable a Webhook for an Inbox
[**DeleteWebhookById**](WebhookControllerApi#deletewebhookbyid) | **DELETE** /webhooks/{webhookId} | Delete a webhook
[**GetAllWebhookResults**](WebhookControllerApi#getallwebhookresults) | **GET** /webhooks/results | Get results for all webhooks
[**GetAllWebhooks**](WebhookControllerApi#getallwebhooks) | **GET** /webhooks/paginated | List Webhooks Paginated
[**GetInboxWebhooksPaginated**](WebhookControllerApi#getinboxwebhookspaginated) | **GET** /inboxes/{inboxId}/webhooks/paginated | Get paginated webhooks for an Inbox
[**GetJsonSchemaForWebhookEvent**](WebhookControllerApi#getjsonschemaforwebhookevent) | **POST** /webhooks/schema | 
[**GetJsonSchemaForWebhookPayload**](WebhookControllerApi#getjsonschemaforwebhookpayload) | **POST** /webhooks/{webhookId}/schema | 
[**GetTestWebhookPayload**](WebhookControllerApi#gettestwebhookpayload) | **GET** /webhooks/test | 
[**GetTestWebhookPayloadBounce**](WebhookControllerApi#gettestwebhookpayloadbounce) | **GET** /webhooks/test/email-bounce-payload | 
[**GetTestWebhookPayloadBounceRecipient**](WebhookControllerApi#gettestwebhookpayloadbouncerecipient) | **GET** /webhooks/test/email-bounce-recipient-payload | 
[**GetTestWebhookPayloadEmailOpened**](WebhookControllerApi#gettestwebhookpayloademailopened) | **GET** /webhooks/test/email-opened-payload | 
[**GetTestWebhookPayloadEmailRead**](WebhookControllerApi#gettestwebhookpayloademailread) | **GET** /webhooks/test/email-read-payload | 
[**GetTestWebhookPayloadForWebhook**](WebhookControllerApi#gettestwebhookpayloadforwebhook) | **POST** /webhooks/{webhookId}/example | 
[**GetTestWebhookPayloadNewAttachment**](WebhookControllerApi#gettestwebhookpayloadnewattachment) | **GET** /webhooks/test/new-attachment-payload | Get webhook test payload for new attachment event
[**GetTestWebhookPayloadNewContact**](WebhookControllerApi#gettestwebhookpayloadnewcontact) | **GET** /webhooks/test/new-contact-payload | Get webhook test payload for new contact event
[**GetTestWebhookPayloadNewEmail**](WebhookControllerApi#gettestwebhookpayloadnewemail) | **GET** /webhooks/test/new-email-payload | Get webhook test payload for new email event
[**GetWebhook**](WebhookControllerApi#getwebhook) | **GET** /webhooks/{webhookId} | Get a webhook
[**GetWebhookResult**](WebhookControllerApi#getwebhookresult) | **GET** /webhooks/results/{webhookResultId} | Get a webhook result for a webhook
[**GetWebhookResults**](WebhookControllerApi#getwebhookresults) | **GET** /webhooks/{webhookId}/results | Get a webhook results for a webhook
[**GetWebhookResultsUnseenErrorCount**](WebhookControllerApi#getwebhookresultsunseenerrorcount) | **GET** /webhooks/results/unseen-count | Get count of unseen webhook results with error status
[**GetWebhooks**](WebhookControllerApi#getwebhooks) | **GET** /inboxes/{inboxId}/webhooks | Get all webhooks for an Inbox
[**RedriveWebhookResult**](WebhookControllerApi#redrivewebhookresult) | **POST** /webhooks/results/{webhookResultId}/redrive | Get a webhook result and try to resend the original webhook payload
[**SendTestData**](WebhookControllerApi#sendtestdata) | **POST** /webhooks/{webhookId}/test | Send webhook test data
[**VerifyWebhookSignature**](WebhookControllerApi#verifywebhooksignature) | **POST** /webhooks/verify | Verify a webhook payload signature


<a name="createaccountwebhook"></a>
# **CreateAccountWebhook**
> WebhookDto CreateAccountWebhook (CreateWebhookOptions createWebhookOptions)

Attach a WebHook URL to an inbox

Get notified of account level events such as bounce and bounce recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateAccountWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var createWebhookOptions = new CreateWebhookOptions(); // CreateWebhookOptions | 

            try
            {
                // Attach a WebHook URL to an inbox
                WebhookDto result = apiInstance.CreateAccountWebhook(createWebhookOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.CreateAccountWebhook: " + e.Message );
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
 **createWebhookOptions** | [**CreateWebhookOptions**](CreateWebhookOptions)|  | 

### Return type

[**WebhookDto**](WebhookDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="createwebhook"></a>
# **CreateWebhook**
> WebhookDto CreateWebhook (Guid inboxId, CreateWebhookOptions createWebhookOptions)

Attach a WebHook URL to an inbox

Get notified whenever an inbox receives an email via a WebHook URL. An emailID will be posted to this URL every time an email is received for this inbox. The URL must be publicly reachable by the MailSlurp server. You can provide basicAuth values if you wish to secure this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var createWebhookOptions = new CreateWebhookOptions(); // CreateWebhookOptions | 

            try
            {
                // Attach a WebHook URL to an inbox
                WebhookDto result = apiInstance.CreateWebhook(inboxId, createWebhookOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.CreateWebhook: " + e.Message );
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
 **createWebhookOptions** | [**CreateWebhookOptions**](CreateWebhookOptions)|  | 

### Return type

[**WebhookDto**](WebhookDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deleteallwebhooks"></a>
# **DeleteAllWebhooks**
> void DeleteAllWebhooks ()

Delete all webhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteAllWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                // Delete all webhooks
                apiInstance.DeleteAllWebhooks();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.DeleteAllWebhooks: " + e.Message );
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

<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (Guid inboxId, Guid webhookId)

Delete and disable a Webhook for an Inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var webhookId = new Guid(); // Guid | 

            try
            {
                // Delete and disable a Webhook for an Inbox
                apiInstance.DeleteWebhook(inboxId, webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.DeleteWebhook: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

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

<a name="deletewebhookbyid"></a>
# **DeleteWebhookById**
> void DeleteWebhookById (Guid webhookId)

Delete a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteWebhookByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | 

            try
            {
                // Delete a webhook
                apiInstance.DeleteWebhookById(webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.DeleteWebhookById: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getallwebhookresults"></a>
# **GetAllWebhookResults**
> PageWebhookResult GetAllWebhookResults (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null, bool? unseenOnly = null)

Get results for all webhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllWebhookResultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 
            var unseenOnly = true;  // bool? | Filter for unseen exceptions only (optional) 

            try
            {
                // Get results for all webhooks
                PageWebhookResult result = apiInstance.GetAllWebhookResults(page, size, sort, searchFilter, since, before, unseenOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetAllWebhookResults: " + e.Message );
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
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 
 **unseenOnly** | **bool?**| Filter for unseen exceptions only | [optional] 

### Return type

[**PageWebhookResult**](PageWebhookResult)

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

<a name="getallwebhooks"></a>
# **GetAllWebhooks**
> PageWebhookProjection GetAllWebhooks (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

List Webhooks Paginated

List webhooks in paginated form. Allows for page index, page size, and sort direction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size for paginated result list. (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to DESC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // List Webhooks Paginated
                PageWebhookProjection result = apiInstance.GetAllWebhooks(page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetAllWebhooks: " + e.Message );
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
 **size** | **int?**| Optional page size for paginated result list. | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to DESC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageWebhookProjection**](PageWebhookProjection)

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

<a name="getinboxwebhookspaginated"></a>
# **GetInboxWebhooksPaginated**
> PageWebhookProjection GetInboxWebhooksPaginated (Guid inboxId, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

Get paginated webhooks for an Inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxWebhooksPaginatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get paginated webhooks for an Inbox
                PageWebhookProjection result = apiInstance.GetInboxWebhooksPaginated(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetInboxWebhooksPaginated: " + e.Message );
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
 **page** | **int?**| Optional page index in list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageWebhookProjection**](PageWebhookProjection)

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

<a name="getjsonschemaforwebhookevent"></a>
# **GetJsonSchemaForWebhookEvent**
> JSONSchemaDto GetJsonSchemaForWebhookEvent (string _event)



Get JSON Schema definition for webhook payload by event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetJsonSchemaForWebhookEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var _event = _event_example;  // string | 

            try
            {
                JSONSchemaDto result = apiInstance.GetJsonSchemaForWebhookEvent(_event);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetJsonSchemaForWebhookEvent: " + e.Message );
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
 **_event** | **string**|  | 

### Return type

[**JSONSchemaDto**](JSONSchemaDto)

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

<a name="getjsonschemaforwebhookpayload"></a>
# **GetJsonSchemaForWebhookPayload**
> JSONSchemaDto GetJsonSchemaForWebhookPayload (Guid webhookId)



Get JSON Schema definition for webhook payload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetJsonSchemaForWebhookPayloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | 

            try
            {
                JSONSchemaDto result = apiInstance.GetJsonSchemaForWebhookPayload(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetJsonSchemaForWebhookPayload: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

### Return type

[**JSONSchemaDto**](JSONSchemaDto)

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

<a name="gettestwebhookpayload"></a>
# **GetTestWebhookPayload**
> AbstractWebhookPayload GetTestWebhookPayload (string eventName = null)



Get test webhook payload example. Response content depends on eventName passed. Uses `EMAIL_RECEIVED` as default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var eventName = eventName_example;  // string |  (optional) 

            try
            {
                AbstractWebhookPayload result = apiInstance.GetTestWebhookPayload(eventName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayload: " + e.Message );
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
 **eventName** | **string**|  | [optional] 

### Return type

[**AbstractWebhookPayload**](AbstractWebhookPayload)

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

<a name="gettestwebhookpayloadbounce"></a>
# **GetTestWebhookPayloadBounce**
> WebhookBouncePayload GetTestWebhookPayloadBounce ()



Get webhook test payload for bounce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadBounceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                WebhookBouncePayload result = apiInstance.GetTestWebhookPayloadBounce();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadBounce: " + e.Message );
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

[**WebhookBouncePayload**](WebhookBouncePayload)

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

<a name="gettestwebhookpayloadbouncerecipient"></a>
# **GetTestWebhookPayloadBounceRecipient**
> WebhookBounceRecipientPayload GetTestWebhookPayloadBounceRecipient ()



Get webhook test payload for bounce recipient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadBounceRecipientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                WebhookBounceRecipientPayload result = apiInstance.GetTestWebhookPayloadBounceRecipient();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadBounceRecipient: " + e.Message );
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

[**WebhookBounceRecipientPayload**](WebhookBounceRecipientPayload)

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

<a name="gettestwebhookpayloademailopened"></a>
# **GetTestWebhookPayloadEmailOpened**
> WebhookEmailOpenedPayload GetTestWebhookPayloadEmailOpened ()



Get webhook test payload for email opened event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadEmailOpenedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                WebhookEmailOpenedPayload result = apiInstance.GetTestWebhookPayloadEmailOpened();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadEmailOpened: " + e.Message );
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

[**WebhookEmailOpenedPayload**](WebhookEmailOpenedPayload)

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

<a name="gettestwebhookpayloademailread"></a>
# **GetTestWebhookPayloadEmailRead**
> WebhookEmailReadPayload GetTestWebhookPayloadEmailRead ()



Get webhook test payload for email opened event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadEmailReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                WebhookEmailReadPayload result = apiInstance.GetTestWebhookPayloadEmailRead();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadEmailRead: " + e.Message );
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

[**WebhookEmailReadPayload**](WebhookEmailReadPayload)

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

<a name="gettestwebhookpayloadforwebhook"></a>
# **GetTestWebhookPayloadForWebhook**
> AbstractWebhookPayload GetTestWebhookPayloadForWebhook (Guid webhookId)



Get example payload for webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadForWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | 

            try
            {
                AbstractWebhookPayload result = apiInstance.GetTestWebhookPayloadForWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadForWebhook: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

### Return type

[**AbstractWebhookPayload**](AbstractWebhookPayload)

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

<a name="gettestwebhookpayloadnewattachment"></a>
# **GetTestWebhookPayloadNewAttachment**
> WebhookNewAttachmentPayload GetTestWebhookPayloadNewAttachment ()

Get webhook test payload for new attachment event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadNewAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                // Get webhook test payload for new attachment event
                WebhookNewAttachmentPayload result = apiInstance.GetTestWebhookPayloadNewAttachment();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadNewAttachment: " + e.Message );
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

[**WebhookNewAttachmentPayload**](WebhookNewAttachmentPayload)

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

<a name="gettestwebhookpayloadnewcontact"></a>
# **GetTestWebhookPayloadNewContact**
> WebhookNewContactPayload GetTestWebhookPayloadNewContact ()

Get webhook test payload for new contact event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadNewContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                // Get webhook test payload for new contact event
                WebhookNewContactPayload result = apiInstance.GetTestWebhookPayloadNewContact();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadNewContact: " + e.Message );
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

[**WebhookNewContactPayload**](WebhookNewContactPayload)

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

<a name="gettestwebhookpayloadnewemail"></a>
# **GetTestWebhookPayloadNewEmail**
> WebhookNewEmailPayload GetTestWebhookPayloadNewEmail ()

Get webhook test payload for new email event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetTestWebhookPayloadNewEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                // Get webhook test payload for new email event
                WebhookNewEmailPayload result = apiInstance.GetTestWebhookPayloadNewEmail();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetTestWebhookPayloadNewEmail: " + e.Message );
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

[**WebhookNewEmailPayload**](WebhookNewEmailPayload)

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

<a name="getwebhook"></a>
# **GetWebhook**
> WebhookDto GetWebhook (Guid webhookId)

Get a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | 

            try
            {
                // Get a webhook
                WebhookDto result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetWebhook: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

### Return type

[**WebhookDto**](WebhookDto)

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

<a name="getwebhookresult"></a>
# **GetWebhookResult**
> WebhookResultDto GetWebhookResult (Guid webhookResultId)

Get a webhook result for a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhookResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookResultId = new Guid(); // Guid | Webhook Result ID

            try
            {
                // Get a webhook result for a webhook
                WebhookResultDto result = apiInstance.GetWebhookResult(webhookResultId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetWebhookResult: " + e.Message );
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
 **webhookResultId** | [**Guid**](Guid)| Webhook Result ID | 

### Return type

[**WebhookResultDto**](WebhookResultDto)

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

<a name="getwebhookresults"></a>
# **GetWebhookResults**
> PageWebhookResult GetWebhookResults (Guid webhookId, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null, bool? unseenOnly = null)

Get a webhook results for a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhookResultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | ID of webhook to get results for
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 
            var unseenOnly = true;  // bool? | Filter for unseen exceptions only (optional) 

            try
            {
                // Get a webhook results for a webhook
                PageWebhookResult result = apiInstance.GetWebhookResults(webhookId, page, size, sort, searchFilter, since, before, unseenOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetWebhookResults: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)| ID of webhook to get results for | 
 **page** | **int?**| Optional page index in list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 
 **unseenOnly** | **bool?**| Filter for unseen exceptions only | [optional] 

### Return type

[**PageWebhookResult**](PageWebhookResult)

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

<a name="getwebhookresultsunseenerrorcount"></a>
# **GetWebhookResultsUnseenErrorCount**
> UnseenErrorCountDto GetWebhookResultsUnseenErrorCount ()

Get count of unseen webhook results with error status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhookResultsUnseenErrorCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);

            try
            {
                // Get count of unseen webhook results with error status
                UnseenErrorCountDto result = apiInstance.GetWebhookResultsUnseenErrorCount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetWebhookResultsUnseenErrorCount: " + e.Message );
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

[**UnseenErrorCountDto**](UnseenErrorCountDto)

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

<a name="getwebhooks"></a>
# **GetWebhooks**
> List&lt;WebhookDto&gt; GetWebhooks (Guid inboxId)

Get all webhooks for an Inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var inboxId = new Guid(); // Guid | 

            try
            {
                // Get all webhooks for an Inbox
                List<WebhookDto> result = apiInstance.GetWebhooks(inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.GetWebhooks: " + e.Message );
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

[**List&lt;WebhookDto&gt;**](WebhookDto)

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

<a name="redrivewebhookresult"></a>
# **RedriveWebhookResult**
> WebhookRedriveResult RedriveWebhookResult (Guid webhookResultId)

Get a webhook result and try to resend the original webhook payload

Allows you to resend a webhook payload that was already sent. Webhooks that fail are retried automatically for 24 hours and then put in a dead letter queue. You can retry results manually using this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class RedriveWebhookResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookResultId = new Guid(); // Guid | Webhook Result ID

            try
            {
                // Get a webhook result and try to resend the original webhook payload
                WebhookRedriveResult result = apiInstance.RedriveWebhookResult(webhookResultId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.RedriveWebhookResult: " + e.Message );
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
 **webhookResultId** | [**Guid**](Guid)| Webhook Result ID | 

### Return type

[**WebhookRedriveResult**](WebhookRedriveResult)

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

<a name="sendtestdata"></a>
# **SendTestData**
> WebhookTestResult SendTestData (Guid webhookId)

Send webhook test data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendTestDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var webhookId = new Guid(); // Guid | 

            try
            {
                // Send webhook test data
                WebhookTestResult result = apiInstance.SendTestData(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.SendTestData: " + e.Message );
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
 **webhookId** | [**Guid**](Guid)|  | 

### Return type

[**WebhookTestResult**](WebhookTestResult)

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

<a name="verifywebhooksignature"></a>
# **VerifyWebhookSignature**
> VerifyWebhookSignatureResults VerifyWebhookSignature (VerifyWebhookSignatureOptions verifyWebhookSignatureOptions)

Verify a webhook payload signature

Verify a webhook payload using the messageId and signature. This allows you to be sure that MailSlurp sent the payload and not another server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class VerifyWebhookSignatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(config);
            var verifyWebhookSignatureOptions = new VerifyWebhookSignatureOptions(); // VerifyWebhookSignatureOptions | 

            try
            {
                // Verify a webhook payload signature
                VerifyWebhookSignatureResults result = apiInstance.VerifyWebhookSignature(verifyWebhookSignatureOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookControllerApi.VerifyWebhookSignature: " + e.Message );
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
 **verifyWebhookSignatureOptions** | [**VerifyWebhookSignatureOptions**](VerifyWebhookSignatureOptions)|  | 

### Return type

[**VerifyWebhookSignatureResults**](VerifyWebhookSignatureResults)

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

