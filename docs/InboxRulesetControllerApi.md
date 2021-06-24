# mailslurp.Api.InboxRulesetControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewInboxRuleset**](InboxRulesetControllerApi#createnewinboxruleset) | **POST** /rulesets | Create an inbox ruleset
[**DeleteInboxRuleset**](InboxRulesetControllerApi#deleteinboxruleset) | **DELETE** /rulesets/{id} | Delete an inbox ruleset
[**DeleteInboxRulesets**](InboxRulesetControllerApi#deleteinboxrulesets) | **DELETE** /rulesets | Delete inbox rulesets
[**GetInboxRuleset**](InboxRulesetControllerApi#getinboxruleset) | **GET** /rulesets/{id} | Get an inbox ruleset
[**GetInboxRulesets**](InboxRulesetControllerApi#getinboxrulesets) | **GET** /rulesets | List inbox rulesets


<a name="createnewinboxruleset"></a>
# **CreateNewInboxRuleset**
> InboxRulesetDto CreateNewInboxRuleset (CreateInboxRulesetOptions createInboxRulesetOptions, Guid? inboxId = null)

Create an inbox ruleset

Create a new inbox rule for forwarding, blocking, and allowing emails when sending and receiving

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateNewInboxRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxRulesetControllerApi(config);
            var createInboxRulesetOptions = new CreateInboxRulesetOptions(); // CreateInboxRulesetOptions | createInboxRulesetOptions
            var inboxId = new Guid?(); // Guid? | Inbox id to attach ruleset to (optional) 

            try
            {
                // Create an inbox ruleset
                InboxRulesetDto result = apiInstance.CreateNewInboxRuleset(createInboxRulesetOptions, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxRulesetControllerApi.CreateNewInboxRuleset: " + e.Message );
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
 **createInboxRulesetOptions** | [**CreateInboxRulesetOptions**](CreateInboxRulesetOptions)| createInboxRulesetOptions | 
 **inboxId** | [**Guid?**](Guid?)| Inbox id to attach ruleset to | [optional] 

### Return type

[**InboxRulesetDto**](InboxRulesetDto)

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

<a name="deleteinboxruleset"></a>
# **DeleteInboxRuleset**
> void DeleteInboxRuleset (Guid id)

Delete an inbox ruleset

Delete inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxRulesetControllerApi(config);
            var id = new Guid(); // Guid | ID of inbox ruleset

            try
            {
                // Delete an inbox ruleset
                apiInstance.DeleteInboxRuleset(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxRulesetControllerApi.DeleteInboxRuleset: " + e.Message );
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
 **id** | [**Guid**](Guid)| ID of inbox ruleset | 

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

<a name="deleteinboxrulesets"></a>
# **DeleteInboxRulesets**
> void DeleteInboxRulesets (Guid? inboxId = null)

Delete inbox rulesets

Delete inbox rulesets. Accepts optional inboxId filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxRulesetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxRulesetControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox id to attach ruleset to (optional) 

            try
            {
                // Delete inbox rulesets
                apiInstance.DeleteInboxRulesets(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxRulesetControllerApi.DeleteInboxRulesets: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox id to attach ruleset to | [optional] 

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

<a name="getinboxruleset"></a>
# **GetInboxRuleset**
> InboxRulesetDto GetInboxRuleset (Guid id)

Get an inbox ruleset

Get inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxRulesetControllerApi(config);
            var id = new Guid(); // Guid | ID of inbox ruleset

            try
            {
                // Get an inbox ruleset
                InboxRulesetDto result = apiInstance.GetInboxRuleset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxRulesetControllerApi.GetInboxRuleset: " + e.Message );
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
 **id** | [**Guid**](Guid)| ID of inbox ruleset | 

### Return type

[**InboxRulesetDto**](InboxRulesetDto)

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

<a name="getinboxrulesets"></a>
# **GetInboxRulesets**
> PageInboxRulesetProjection GetInboxRulesets (Guid? inboxId = null, int? page = null, int? size = null, string sort = null)

List inbox rulesets

List all rulesets attached to an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxRulesetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxRulesetControllerApi(config);
            var inboxId = new Guid?(); // Guid? | Optional inbox id to get rulesets from (optional) 
            var page = 56;  // int? | Optional page index in inbox ruleset list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox ruleset list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // List inbox rulesets
                PageInboxRulesetProjection result = apiInstance.GetInboxRulesets(inboxId, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxRulesetControllerApi.GetInboxRulesets: " + e.Message );
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
 **inboxId** | [**Guid?**](Guid?)| Optional inbox id to get rulesets from | [optional] 
 **page** | **int?**| Optional page index in inbox ruleset list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox ruleset list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageInboxRulesetProjection**](PageInboxRulesetProjection)

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

