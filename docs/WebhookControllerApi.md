# mailslurp.Api.WebhookControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](WebhookControllerApi.md#createwebhook) | **POST** /inboxes/{inboxId}/webhooks | Attach a WebHook URL to an inbox
[**DeleteWebhook**](WebhookControllerApi.md#deletewebhook) | **DELETE** /inboxes/{inboxId}/webhooks/{webhookId} | Delete and disable a Webhook for an Inbox
[**GetAllWebhooks**](WebhookControllerApi.md#getallwebhooks) | **GET** /webhooks/paginated | List Webhooks Paginated
[**GetWebhook**](WebhookControllerApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Get a webhook for an Inbox
[**GetWebhooks**](WebhookControllerApi.md#getwebhooks) | **GET** /inboxes/{inboxId}/webhooks | Get all Webhooks for an Inbox
[**SendTestData**](WebhookControllerApi.md#sendtestdata) | **POST** /webhooks/{webhookId}/test | Send webhook test data



## CreateWebhook

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | inboxId
            var webhookOptions = new CreateWebhookOptions(); // CreateWebhookOptions | webhookOptions

            try
            {
                // Attach a WebHook URL to an inbox
                WebhookDto result = apiInstance.CreateWebhook(inboxId, webhookOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **inboxId** | [**Guid**](Guid.md)| inboxId | 
 **webhookOptions** | [**CreateWebhookOptions**](CreateWebhookOptions.md)| webhookOptions | 

### Return type

[**WebhookDto**](WebhookDto.md)

### Authorization

[API_KEY](../README.md#API_KEY)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteWebhook

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | inboxId
            var webhookId = new Guid(); // Guid | webhookId

            try
            {
                // Delete and disable a Webhook for an Inbox
                apiInstance.DeleteWebhook(inboxId, webhookId);
            }
            catch (ApiException e)
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
 **inboxId** | [**Guid**](Guid.md)| inboxId | 
 **webhookId** | [**Guid**](Guid.md)| webhookId | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllWebhooks

> PageWebhookProjection GetAllWebhooks (int page = null, int size = null, string sort = null)

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var page = 56;  // int | Optional page index in inbox list pagination (optional)  (default to 0)
            var size = 56;  // int | Optional page size in inbox list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // List Webhooks Paginated
                PageWebhookProjection result = apiInstance.GetAllWebhooks(page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **page** | **int**| Optional page index in inbox list pagination | [optional] [default to 0]
 **size** | **int**| Optional page size in inbox list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageWebhookProjection**](PageWebhookProjection.md)

### Authorization

[API_KEY](../README.md#API_KEY)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebhook

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var webhookId = new Guid(); // Guid | webhookId

            try
            {
                // Get a webhook for an Inbox
                WebhookDto result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **webhookId** | [**Guid**](Guid.md)| webhookId | 

### Return type

[**WebhookDto**](WebhookDto.md)

### Authorization

[API_KEY](../README.md#API_KEY)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebhooks

> List&lt;WebhookDto&gt; GetWebhooks (Guid inboxId)

Get all Webhooks for an Inbox

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var inboxId = new Guid(); // Guid | inboxId

            try
            {
                // Get all Webhooks for an Inbox
                List<WebhookDto> result = apiInstance.GetWebhooks(inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **inboxId** | [**Guid**](Guid.md)| inboxId | 

### Return type

[**List&lt;WebhookDto&gt;**](WebhookDto.md)

### Authorization

[API_KEY](../README.md#API_KEY)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendTestData

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
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhookControllerApi(Configuration.Default);
            var webhookId = new Guid(); // Guid | webhookId

            try
            {
                // Send webhook test data
                WebhookTestResult result = apiInstance.SendTestData(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **webhookId** | [**Guid**](Guid.md)| webhookId | 

### Return type

[**WebhookTestResult**](WebhookTestResult.md)

### Authorization

[API_KEY](../README.md#API_KEY)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

