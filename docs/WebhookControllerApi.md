# mailslurp.Api.WebhookControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](WebhookControllerApi#createwebhook) | **POST** /inboxes/{inboxId}/webhooks | Attach a WebHook URL to an inbox
[**DeleteWebhook**](WebhookControllerApi#deletewebhook) | **DELETE** /inboxes/{inboxId}/webhooks/{webhookId} | Delete and disable a Webhook for an Inbox
[**GetAllWebhookResults**](WebhookControllerApi#getallwebhookresults) | **GET** /webhooks/results | Get results for all webhooks
[**GetAllWebhooks**](WebhookControllerApi#getallwebhooks) | **GET** /webhooks/paginated | List Webhooks Paginated
[**GetInboxWebhooksPaginated**](WebhookControllerApi#getinboxwebhookspaginated) | **GET** /inboxes/{inboxId}/webhooks/paginated | Get paginated webhooks for an Inbox
[**GetTestWebhookPayload**](WebhookControllerApi#gettestwebhookpayload) | **GET** /webhooks/test | Get test webhook payload example. Response content depends on eventName passed. Uses &#x60;EMAIL_RECEIVED&#x60; as default.
[**GetTestWebhookPayloadEmailOpened**](WebhookControllerApi#gettestwebhookpayloademailopened) | **GET** /webhooks/test/email-opened-payload | Get webhook test payload for email opened event
[**GetTestWebhookPayloadNewAttachment**](WebhookControllerApi#gettestwebhookpayloadnewattachment) | **GET** /webhooks/test/new-attachment-payload | Get webhook test payload for new attachment event
[**GetTestWebhookPayloadNewContact**](WebhookControllerApi#gettestwebhookpayloadnewcontact) | **GET** /webhooks/test/new-contact-payload | Get webhook test payload for new contact event
[**GetTestWebhookPayloadNewEmail**](WebhookControllerApi#gettestwebhookpayloadnewemail) | **GET** /webhooks/test/new-email-payload | Get webhook test payload for new email event
[**GetWebhook**](WebhookControllerApi#getwebhook) | **GET** /webhooks/{webhookId} | Get a webhook for an Inbox
[**GetWebhookResult**](WebhookControllerApi#getwebhookresult) | **GET** /webhooks/results/{webhookResultId} | Get a webhook result for a webhook
[**GetWebhookResults**](WebhookControllerApi#getwebhookresults) | **GET** /webhooks/{webhookId}/results | Get a webhook results for a webhook
[**GetWebhooks**](WebhookControllerApi#getwebhooks) | **GET** /inboxes/{inboxId}/webhooks | Get all webhooks for an Inbox
[**SendTestData**](WebhookControllerApi#sendtestdata) | **POST** /webhooks/{webhookId}/test | Send webhook test data


<a name="createwebhook"></a>
# **CreateWebhook**
> WebhookDto CreateWebhook (Guid inboxId, CreateWebhookOptions webhookOptions)

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
            var inboxId = new Guid(); // Guid | inboxId
            var webhookOptions = new CreateWebhookOptions(); // CreateWebhookOptions | webhookOptions

            try
            {
                // Attach a WebHook URL to an inbox
                WebhookDto result = apiInstance.CreateWebhook(inboxId, webhookOptions);
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
 **inboxId** | [**Guid**](Guid)| inboxId | 
 **webhookOptions** | [**CreateWebhookOptions**](CreateWebhookOptions)| webhookOptions | 

### Return type

[**WebhookDto**](WebhookDto)

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
            var inboxId = new Guid(); // Guid | inboxId
            var webhookId = new Guid(); // Guid | webhookId

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
 **inboxId** | [**Guid**](Guid)| inboxId | 
 **webhookId** | [**Guid**](Guid)| webhookId | 

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

<a name="getallwebhookresults"></a>
# **GetAllWebhookResults**
> PageWebhookResult GetAllWebhookResults (int? page = null, string searchFilter = null, int? size = null, string sort = null)

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
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get results for all webhooks
                PageWebhookResult result = apiInstance.GetAllWebhookResults(page, searchFilter, size, sort);
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
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageWebhookResult**](PageWebhookResult)

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

<a name="getallwebhooks"></a>
# **GetAllWebhooks**
> PageWebhookProjection GetAllWebhooks (int? page = null, string searchFilter = null, int? size = null, string sort = null)

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
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // List Webhooks Paginated
                PageWebhookProjection result = apiInstance.GetAllWebhooks(page, searchFilter, size, sort);
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
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageWebhookProjection**](PageWebhookProjection)

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

<a name="getinboxwebhookspaginated"></a>
# **GetInboxWebhooksPaginated**
> PageWebhookProjection GetInboxWebhooksPaginated (Guid inboxId, int? page = null, string searchFilter = null, int? size = null, string sort = null)

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
            var inboxId = new Guid(); // Guid | inboxId
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get paginated webhooks for an Inbox
                PageWebhookProjection result = apiInstance.GetInboxWebhooksPaginated(inboxId, page, searchFilter, size, sort);
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
 **inboxId** | [**Guid**](Guid)| inboxId | 
 **page** | **int?**| Optional page index in list pagination | [optional] [default to 0]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageWebhookProjection**](PageWebhookProjection)

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
            var eventName = eventName_example;  // string | eventName (optional) 

            try
            {
                // Get test webhook payload example. Response content depends on eventName passed. Uses `EMAIL_RECEIVED` as default.
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
 **eventName** | **string**| eventName | [optional] 

### Return type

[**AbstractWebhookPayload**](AbstractWebhookPayload)

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
                // Get webhook test payload for email opened event
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getwebhook"></a>
# **GetWebhook**
> WebhookDto GetWebhook (Guid webhookId)

Get a webhook for an Inbox

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
            var webhookId = new Guid(); // Guid | webhookId

            try
            {
                // Get a webhook for an Inbox
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
 **webhookId** | [**Guid**](Guid)| webhookId | 

### Return type

[**WebhookDto**](WebhookDto)

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

<a name="getwebhookresult"></a>
# **GetWebhookResult**
> WebhookResultEntity GetWebhookResult (Guid webhookResultId)

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
                WebhookResultEntity result = apiInstance.GetWebhookResult(webhookResultId);
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

[**WebhookResultEntity**](WebhookResultEntity)

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

<a name="getwebhookresults"></a>
# **GetWebhookResults**
> PageWebhookResult GetWebhookResults (Guid webhookId, int? page = null, string searchFilter = null, int? size = null, string sort = null)

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
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get a webhook results for a webhook
                PageWebhookResult result = apiInstance.GetWebhookResults(webhookId, page, searchFilter, size, sort);
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
 **searchFilter** | **string**| Optional search filter | [optional] 
 **size** | **int?**| Optional page size in list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageWebhookResult**](PageWebhookResult)

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
            var inboxId = new Guid(); // Guid | inboxId

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
 **inboxId** | [**Guid**](Guid)| inboxId | 

### Return type

[**List&lt;WebhookDto&gt;**](WebhookDto)

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
            var webhookId = new Guid(); // Guid | webhookId

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
 **webhookId** | [**Guid**](Guid)| webhookId | 

### Return type

[**WebhookTestResult**](WebhookTestResult)

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

