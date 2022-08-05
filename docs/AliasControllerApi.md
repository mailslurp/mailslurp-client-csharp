# mailslurp.Api.AliasControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAlias**](AliasControllerApi#createalias) | **POST** /aliases | Create an email alias. Must be verified by clicking link inside verification email that will be sent to the address. Once verified the alias will be active.
[**DeleteAlias**](AliasControllerApi#deletealias) | **DELETE** /aliases/{aliasId} | Delete an email alias
[**GetAlias**](AliasControllerApi#getalias) | **GET** /aliases/{aliasId} | Get an email alias
[**GetAliasEmails**](AliasControllerApi#getaliasemails) | **GET** /aliases/{aliasId}/emails | Get emails for an alias
[**GetAliasThreads**](AliasControllerApi#getaliasthreads) | **GET** /aliases/{aliasId}/threads | Get threads created for an alias
[**GetAliases**](AliasControllerApi#getaliases) | **GET** /aliases | Get all email aliases you have created
[**ReplyToAliasEmail**](AliasControllerApi#replytoaliasemail) | **PUT** /aliases/{aliasId}/emails/{emailId} | Reply to an email
[**SendAliasEmail**](AliasControllerApi#sendaliasemail) | **POST** /aliases/{aliasId}/emails | Send an email from an alias inbox
[**UpdateAlias**](AliasControllerApi#updatealias) | **PUT** /aliases/{aliasId} | Update an email alias


<a name="createalias"></a>
# **CreateAlias**
> AliasDto CreateAlias (CreateAliasOptions createAliasOptions)

Create an email alias. Must be verified by clicking link inside verification email that will be sent to the address. Once verified the alias will be active.

Email aliases use a MailSlurp randomly generated email address (or a custom domain inbox that you provide) to mask or proxy a real email address. Emails sent to the alias address will be forwarded to the hidden email address it was created for. If you want to send a reply use the threadId attached

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
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var createAliasOptions = new CreateAliasOptions(); // CreateAliasOptions | 

            try
            {
                // Create an email alias. Must be verified by clicking link inside verification email that will be sent to the address. Once verified the alias will be active.
                AliasDto result = apiInstance.CreateAlias(createAliasOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **createAliasOptions** | [**CreateAliasOptions**](CreateAliasOptions)|  | 

### Return type

[**AliasDto**](AliasDto)

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

<a name="deletealias"></a>
# **DeleteAlias**
> void DeleteAlias (Guid aliasId)

Delete an email alias

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
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 

            try
            {
                // Delete an email alias
                apiInstance.DeleteAlias(aliasId);
            }
            catch (ApiException  e)
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
 **aliasId** | [**Guid**](Guid)|  | 

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

<a name="getalias"></a>
# **GetAlias**
> AliasDto GetAlias (Guid aliasId)

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
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 

            try
            {
                // Get an email alias
                AliasDto result = apiInstance.GetAlias(aliasId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **aliasId** | [**Guid**](Guid)|  | 

### Return type

[**AliasDto**](AliasDto)

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

<a name="getaliasemails"></a>
# **GetAliasEmails**
> PageEmailProjection GetAliasEmails (Guid aliasId, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get emails for an alias

Get paginated emails for an alias by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAliasEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index alias email list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size alias email list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent before given date time (optional) 

            try
            {
                // Get emails for an alias
                PageEmailProjection result = apiInstance.GetAliasEmails(aliasId, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasControllerApi.GetAliasEmails: " + e.Message );
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
 **aliasId** | [**Guid**](Guid)|  | 
 **page** | **int?**| Optional page index alias email list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size alias email list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Optional filter by sent after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by sent before given date time | [optional] 

### Return type

[**PageEmailProjection**](PageEmailProjection)

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

<a name="getaliasthreads"></a>
# **GetAliasThreads**
> PageThreadProjection GetAliasThreads (Guid aliasId, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get threads created for an alias

Returns threads created for an email alias in paginated form

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAliasThreadsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in thread list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in thread list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent before given date time (optional) 

            try
            {
                // Get threads created for an alias
                PageThreadProjection result = apiInstance.GetAliasThreads(aliasId, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasControllerApi.GetAliasThreads: " + e.Message );
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
 **aliasId** | [**Guid**](Guid)|  | 
 **page** | **int?**| Optional page index in thread list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in thread list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Optional filter by sent after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by sent before given date time | [optional] 

### Return type

[**PageThreadProjection**](PageThreadProjection)

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

<a name="getaliases"></a>
# **GetAliases**
> PageAlias GetAliases (int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get all email aliases you have created

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
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var page = 56;  // int? | Optional page index in alias list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in alias list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get all email aliases you have created
                PageAlias result = apiInstance.GetAliases(page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **page** | **int?**| Optional page index in alias list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in alias list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Filter by created at after the given timestamp | [optional] 
 **before** | **DateTime?**| Filter by created at before the given timestamp | [optional] 

### Return type

[**PageAlias**](PageAlias)

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

<a name="replytoaliasemail"></a>
# **ReplyToAliasEmail**
> SentEmailDto ReplyToAliasEmail (Guid aliasId, Guid emailId, ReplyToAliasEmailOptions replyToAliasEmailOptions)

Reply to an email

Send the reply to the email sender or reply-to and include same subject cc bcc etc. Reply to an email and the contents will be sent with the existing subject to the emails `to`, `cc`, and `bcc`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class ReplyToAliasEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | ID of the alias that email belongs to
            var emailId = new Guid(); // Guid | ID of the email that should be replied to
            var replyToAliasEmailOptions = new ReplyToAliasEmailOptions(); // ReplyToAliasEmailOptions | 

            try
            {
                // Reply to an email
                SentEmailDto result = apiInstance.ReplyToAliasEmail(aliasId, emailId, replyToAliasEmailOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasControllerApi.ReplyToAliasEmail: " + e.Message );
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
 **aliasId** | [**Guid**](Guid)| ID of the alias that email belongs to | 
 **emailId** | [**Guid**](Guid)| ID of the email that should be replied to | 
 **replyToAliasEmailOptions** | [**ReplyToAliasEmailOptions**](ReplyToAliasEmailOptions)|  | 

### Return type

[**SentEmailDto**](SentEmailDto)

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

<a name="sendaliasemail"></a>
# **SendAliasEmail**
> SentEmailDto SendAliasEmail (Guid aliasId, SendEmailOptions sendEmailOptions)

Send an email from an alias inbox

Send an email from an alias. Replies to the email will be forwarded to the alias masked email address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendAliasEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | 

            try
            {
                // Send an email from an alias inbox
                SentEmailDto result = apiInstance.SendAliasEmail(aliasId, sendEmailOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasControllerApi.SendAliasEmail: " + e.Message );
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
 **aliasId** | [**Guid**](Guid)|  | 
 **sendEmailOptions** | [**SendEmailOptions**](SendEmailOptions)|  | 

### Return type

[**SentEmailDto**](SentEmailDto)

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

<a name="updatealias"></a>
# **UpdateAlias**
> AliasDto UpdateAlias (Guid aliasId, UpdateAliasOptions updateAliasOptions)

Update an email alias

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
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AliasControllerApi(config);
            var aliasId = new Guid(); // Guid | 
            var updateAliasOptions = new UpdateAliasOptions(); // UpdateAliasOptions | 

            try
            {
                // Update an email alias
                AliasDto result = apiInstance.UpdateAlias(aliasId, updateAliasOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **aliasId** | [**Guid**](Guid)|  | 
 **updateAliasOptions** | [**UpdateAliasOptions**](UpdateAliasOptions)|  | 

### Return type

[**AliasDto**](AliasDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

