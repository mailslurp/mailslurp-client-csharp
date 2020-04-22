# mailslurp.Api.AliasControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAlias**](AliasControllerApi.md#createalias) | **POST** /aliases | Create an email alias
[**CreateAnonymousAlias**](AliasControllerApi.md#createanonymousalias) | **POST** /aliases/anonymous | Create an anonymous email alias
[**DeleteAlias**](AliasControllerApi.md#deletealias) | **DELETE** /aliases/{aliasId} | Delete an owned alias
[**GetAlias**](AliasControllerApi.md#getalias) | **GET** /aliases/{aliasId} | Get an email alias
[**GetAliases**](AliasControllerApi.md#getaliases) | **GET** /aliases | Get all email aliases
[**UpdateAlias**](AliasControllerApi.md#updatealias) | **PUT** /aliases/{aliasId} | Update an owned alias



## CreateAlias

> void CreateAlias (CreateOwnedAliasOptions createOwnedAliasOptions)

Create an email alias

Create an email alias belonging to a user ID. To create anonymous aliases use the `createAnonymousAlias` method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateAliasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var createOwnedAliasOptions = new CreateOwnedAliasOptions(); // CreateOwnedAliasOptions | createOwnedAliasOptions

            try
            {
                // Create an email alias
                apiInstance.CreateAlias(createOwnedAliasOptions);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.CreateAlias: " + e.Message );
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
 **createOwnedAliasOptions** | [**CreateOwnedAliasOptions**](CreateOwnedAliasOptions.md)| createOwnedAliasOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateAnonymousAlias

> Alias CreateAnonymousAlias (CreateAnonymousAliasOptions createAnonymousAliasOptions)

Create an anonymous email alias

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateAnonymousAliasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var createAnonymousAliasOptions = new CreateAnonymousAliasOptions(); // CreateAnonymousAliasOptions | createAnonymousAliasOptions

            try
            {
                // Create an anonymous email alias
                Alias result = apiInstance.CreateAnonymousAlias(createAnonymousAliasOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.CreateAnonymousAlias: " + e.Message );
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
 **createAnonymousAliasOptions** | [**CreateAnonymousAliasOptions**](CreateAnonymousAliasOptions.md)| createAnonymousAliasOptions | 

### Return type

[**Alias**](Alias.md)

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


## DeleteAlias

> void DeleteAlias (Guid aliasId)

Delete an owned alias

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteAliasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var aliasId = new Guid(); // Guid | aliasId

            try
            {
                // Delete an owned alias
                apiInstance.DeleteAlias(aliasId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.DeleteAlias: " + e.Message );
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
 **aliasId** | [**Guid**](Guid.md)| aliasId | 

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


## GetAlias

> Alias GetAlias (Guid aliasId)

Get an email alias

Get an email alias by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAliasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var aliasId = new Guid(); // Guid | aliasId

            try
            {
                // Get an email alias
                Alias result = apiInstance.GetAlias(aliasId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.GetAlias: " + e.Message );
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
 **aliasId** | [**Guid**](Guid.md)| aliasId | 

### Return type

[**Alias**](Alias.md)

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


## GetAliases

> PageAlias GetAliases (int page = null, int size = null, string sort = null)

Get all email aliases

Get all email aliases in paginated form

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAliasesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var page = 56;  // int | Optional page index in alias list pagination (optional)  (default to 0)
            var size = 56;  // int | Optional page size in alias list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get all email aliases
                PageAlias result = apiInstance.GetAliases(page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.GetAliases: " + e.Message );
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
 **page** | **int**| Optional page index in alias list pagination | [optional] [default to 0]
 **size** | **int**| Optional page size in alias list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]

### Return type

[**PageAlias**](PageAlias.md)

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


## UpdateAlias

> void UpdateAlias (Guid aliasId, CreateOwnedAliasOptions createOwnedAliasOptions)

Update an owned alias

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class UpdateAliasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(Configuration.Default);
            var aliasId = new Guid(); // Guid | aliasId
            var createOwnedAliasOptions = new CreateOwnedAliasOptions(); // CreateOwnedAliasOptions | createOwnedAliasOptions

            try
            {
                // Update an owned alias
                apiInstance.UpdateAlias(aliasId, createOwnedAliasOptions);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AliasControllerApi.UpdateAlias: " + e.Message );
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
 **aliasId** | [**Guid**](Guid.md)| aliasId | 
 **createOwnedAliasOptions** | [**CreateOwnedAliasOptions**](CreateOwnedAliasOptions.md)| createOwnedAliasOptions | 

### Return type

void (empty response body)

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

