# mailslurp.Api.InboxControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInbox**](InboxControllerApi#createinbox) | **POST** /inboxes | Create an inbox email address. An inbox has a real email address and can send and receive emails. Inboxes can be either &#x60;SMTP&#x60; or &#x60;HTTP&#x60; inboxes.
[**CreateInboxRuleset**](InboxControllerApi#createinboxruleset) | **POST** /inboxes/{inboxId}/rulesets | Create an inbox ruleset
[**CreateInboxWithDefaults**](InboxControllerApi#createinboxwithdefaults) | **POST** /inboxes/withDefaults | Create an inbox with default options. Uses MailSlurp domain pool address and is private.
[**CreateInboxWithOptions**](InboxControllerApi#createinboxwithoptions) | **POST** /inboxes/withOptions | Create an inbox with options. Extended options for inbox creation.
[**DeleteAllInboxes**](InboxControllerApi#deleteallinboxes) | **DELETE** /inboxes | Delete all inboxes
[**DeleteInbox**](InboxControllerApi#deleteinbox) | **DELETE** /inboxes/{inboxId} | Delete inbox
[**DoesInboxExist**](InboxControllerApi#doesinboxexist) | **GET** /inboxes/exists | Does inbox exist
[**FlushExpired**](InboxControllerApi#flushexpired) | **DELETE** /inboxes/expired | Remove expired inboxes
[**GetAllInboxes**](InboxControllerApi#getallinboxes) | **GET** /inboxes/paginated | List All Inboxes Paginated
[**GetEmails**](InboxControllerApi#getemails) | **GET** /inboxes/{inboxId}/emails | Get emails in an Inbox. This method is not idempotent as it allows retries and waits if you want certain conditions to be met before returning. For simple listing and sorting of known emails use the email controller instead.
[**GetInbox**](InboxControllerApi#getinbox) | **GET** /inboxes/{inboxId} | Get Inbox. Returns properties of an inbox.
[**GetInboxCount**](InboxControllerApi#getinboxcount) | **GET** /inboxes/count | Get total inbox count
[**GetInboxEmailCount**](InboxControllerApi#getinboxemailcount) | **GET** /inboxes/{inboxId}/emails/count | Get email count in inbox
[**GetInboxEmailsPaginated**](InboxControllerApi#getinboxemailspaginated) | **GET** /inboxes/{inboxId}/emails/paginated | Get inbox emails paginated
[**GetInboxIds**](InboxControllerApi#getinboxids) | **GET** /inboxes/ids | Get all inbox IDs
[**GetInboxSentEmails**](InboxControllerApi#getinboxsentemails) | **GET** /inboxes/{inboxId}/sent | Get Inbox Sent Emails
[**GetInboxTags**](InboxControllerApi#getinboxtags) | **GET** /inboxes/tags | Get inbox tags
[**GetInboxes**](InboxControllerApi#getinboxes) | **GET** /inboxes | List Inboxes and email addresses
[**GetOrganizationInboxes**](InboxControllerApi#getorganizationinboxes) | **GET** /inboxes/organization | List Organization Inboxes Paginated
[**ListInboxRulesets**](InboxControllerApi#listinboxrulesets) | **GET** /inboxes/{inboxId}/rulesets | List inbox rulesets
[**ListInboxTrackingPixels**](InboxControllerApi#listinboxtrackingpixels) | **GET** /inboxes/{inboxId}/tracking-pixels | List inbox tracking pixels
[**SendEmail**](InboxControllerApi#sendemail) | **POST** /inboxes/{inboxId} | Send Email
[**SendEmailAndConfirm**](InboxControllerApi#sendemailandconfirm) | **POST** /inboxes/{inboxId}/confirm | Send email and return sent confirmation
[**SendTestEmail**](InboxControllerApi#sendtestemail) | **POST** /inboxes/{inboxId}/send-test-email | Send a test email to inbox
[**SetInboxFavourited**](InboxControllerApi#setinboxfavourited) | **PUT** /inboxes/{inboxId}/favourite | Set inbox favourited state
[**UpdateInbox**](InboxControllerApi#updateinbox) | **PATCH** /inboxes/{inboxId} | Update Inbox. Change name and description. Email address is not editable.


<a name="createinbox"></a>
# **CreateInbox**
> InboxDto CreateInbox (string emailAddress = null, List<string> tags = null, string name = null, string description = null, bool? useDomainPool = null, bool? favourite = null, DateTime? expiresAt = null, long? expiresIn = null, bool? allowTeamAccess = null, string inboxType = null)

Create an inbox email address. An inbox has a real email address and can send and receive emails. Inboxes can be either `SMTP` or `HTTP` inboxes.

Create a new inbox and with a randomized email address to send and receive from. Pass emailAddress parameter if you wish to use a specific email address. Creating an inbox is required before sending or receiving emails. If writing tests it is recommended that you create a new inbox during each test method so that it is unique and empty. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var emailAddress = emailAddress_example;  // string | A custom email address to use with the inbox. Defaults to null. When null MailSlurp will assign a random email address to the inbox such as `123@mailslurp.com`. If you use the `useDomainPool` option when the email address is null it will generate an email address with a more varied domain ending such as `123@mailslurp.info` or `123@mailslurp.biz`. When a custom email address is provided the address is split into a domain and the domain is queried against your user. If you have created the domain in the MailSlurp dashboard and verified it you can use any email address that ends with the domain. Note domain types must match the inbox type - so `SMTP` inboxes will only work with `SMTP` type domains. Avoid `SMTP` inboxes if you need to send emails as they can only receive. Send an email to this address and the inbox will receive and store it for you. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID. (optional) 
            var tags = new List<string>(); // List<string> | Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI. (optional) 
            var name = name_example;  // string | Optional name of the inbox. Displayed in the dashboard for easier search and used as the sender name when sending emails. (optional) 
            var description = description_example;  // string | Optional description of the inbox for labelling purposes. Is shown in the dashboard and can be used with (optional) 
            var useDomainPool = true;  // bool? | Use the MailSlurp domain name pool with this inbox when creating the email address. Defaults to null. If enabled the inbox will be an email address with a domain randomly chosen from a list of the MailSlurp domains. This is useful when the default `@mailslurp.com` email addresses used with inboxes are blocked or considered spam by a provider or receiving service. When domain pool is enabled an email address will be generated ending in `@mailslurp.{world,info,xyz,...}` . This means a TLD is randomly selecting from a list of `.biz`, `.info`, `.xyz` etc to add variance to the generated email addresses. When null or false MailSlurp uses the default behavior of `@mailslurp.com` or custom email address provided by the emailAddress field. Note this feature is only available for `HTTP` inbox types. (optional) 
            var favourite = true;  // bool? | Is the inbox a favorite. Marking an inbox as a favorite is typically done in the dashboard for quick access or filtering (optional) 
            var expiresAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional inbox expiration date. If null then this inbox is permanent and the emails in it won't be deleted. If an expiration date is provided or is required by your plan the inbox will be closed when the expiration time is reached. Expired inboxes still contain their emails but can no longer send or receive emails. An ExpiredInboxRecord is created when an inbox and the email address and inbox ID are recorded. The expiresAt property is a timestamp string in ISO DateTime Format yyyy-MM-dd'T'HH:mm:ss.SSSXXX. (optional) 
            var expiresIn = 789;  // long? | Number of milliseconds that inbox should exist for (optional) 
            var allowTeamAccess = true;  // bool? | DEPRECATED (team access is always true). Grant team access to this inbox and the emails that belong to it for team members of your organization. (optional) 
            var inboxType = inboxType_example;  // string | HTTP (default) or SMTP inbox type. HTTP inboxes are default and best solution for most cases. SMTP inboxes are more reliable for public inbound email consumption (but do not support sending emails). When using custom domains the domain type must match the inbox type. HTTP inboxes are processed by AWS SES while SMTP inboxes use a custom mail server running at `mx.mailslurp.com`. (optional) 

            try
            {
                // Create an inbox email address. An inbox has a real email address and can send and receive emails. Inboxes can be either `SMTP` or `HTTP` inboxes.
                InboxDto result = apiInstance.CreateInbox(emailAddress, tags, name, description, useDomainPool, favourite, expiresAt, expiresIn, allowTeamAccess, inboxType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.CreateInbox: " + e.Message );
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
 **emailAddress** | **string**| A custom email address to use with the inbox. Defaults to null. When null MailSlurp will assign a random email address to the inbox such as &#x60;123@mailslurp.com&#x60;. If you use the &#x60;useDomainPool&#x60; option when the email address is null it will generate an email address with a more varied domain ending such as &#x60;123@mailslurp.info&#x60; or &#x60;123@mailslurp.biz&#x60;. When a custom email address is provided the address is split into a domain and the domain is queried against your user. If you have created the domain in the MailSlurp dashboard and verified it you can use any email address that ends with the domain. Note domain types must match the inbox type - so &#x60;SMTP&#x60; inboxes will only work with &#x60;SMTP&#x60; type domains. Avoid &#x60;SMTP&#x60; inboxes if you need to send emails as they can only receive. Send an email to this address and the inbox will receive and store it for you. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID. | [optional] 
 **tags** | [**List&lt;string&gt;**](string)| Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI. | [optional] 
 **name** | **string**| Optional name of the inbox. Displayed in the dashboard for easier search and used as the sender name when sending emails. | [optional] 
 **description** | **string**| Optional description of the inbox for labelling purposes. Is shown in the dashboard and can be used with | [optional] 
 **useDomainPool** | **bool?**| Use the MailSlurp domain name pool with this inbox when creating the email address. Defaults to null. If enabled the inbox will be an email address with a domain randomly chosen from a list of the MailSlurp domains. This is useful when the default &#x60;@mailslurp.com&#x60; email addresses used with inboxes are blocked or considered spam by a provider or receiving service. When domain pool is enabled an email address will be generated ending in &#x60;@mailslurp.{world,info,xyz,...}&#x60; . This means a TLD is randomly selecting from a list of &#x60;.biz&#x60;, &#x60;.info&#x60;, &#x60;.xyz&#x60; etc to add variance to the generated email addresses. When null or false MailSlurp uses the default behavior of &#x60;@mailslurp.com&#x60; or custom email address provided by the emailAddress field. Note this feature is only available for &#x60;HTTP&#x60; inbox types. | [optional] 
 **favourite** | **bool?**| Is the inbox a favorite. Marking an inbox as a favorite is typically done in the dashboard for quick access or filtering | [optional] 
 **expiresAt** | **DateTime?**| Optional inbox expiration date. If null then this inbox is permanent and the emails in it won&#39;t be deleted. If an expiration date is provided or is required by your plan the inbox will be closed when the expiration time is reached. Expired inboxes still contain their emails but can no longer send or receive emails. An ExpiredInboxRecord is created when an inbox and the email address and inbox ID are recorded. The expiresAt property is a timestamp string in ISO DateTime Format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX. | [optional] 
 **expiresIn** | **long?**| Number of milliseconds that inbox should exist for | [optional] 
 **allowTeamAccess** | **bool?**| DEPRECATED (team access is always true). Grant team access to this inbox and the emails that belong to it for team members of your organization. | [optional] 
 **inboxType** | **string**| HTTP (default) or SMTP inbox type. HTTP inboxes are default and best solution for most cases. SMTP inboxes are more reliable for public inbound email consumption (but do not support sending emails). When using custom domains the domain type must match the inbox type. HTTP inboxes are processed by AWS SES while SMTP inboxes use a custom mail server running at &#x60;mx.mailslurp.com&#x60;. | [optional] 

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

<a name="createinboxruleset"></a>
# **CreateInboxRuleset**
> InboxRulesetDto CreateInboxRuleset (Guid inboxId, CreateInboxRulesetOptions createInboxRulesetOptions)

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
    public class CreateInboxRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | inboxId
            var createInboxRulesetOptions = new CreateInboxRulesetOptions(); // CreateInboxRulesetOptions | 

            try
            {
                // Create an inbox ruleset
                InboxRulesetDto result = apiInstance.CreateInboxRuleset(inboxId, createInboxRulesetOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.CreateInboxRuleset: " + e.Message );
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
 **createInboxRulesetOptions** | [**CreateInboxRulesetOptions**](CreateInboxRulesetOptions)|  | 

### Return type

[**InboxRulesetDto**](InboxRulesetDto)

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

<a name="createinboxwithdefaults"></a>
# **CreateInboxWithDefaults**
> InboxDto CreateInboxWithDefaults ()

Create an inbox with default options. Uses MailSlurp domain pool address and is private.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateInboxWithDefaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);

            try
            {
                // Create an inbox with default options. Uses MailSlurp domain pool address and is private.
                InboxDto result = apiInstance.CreateInboxWithDefaults();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.CreateInboxWithDefaults: " + e.Message );
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

<a name="createinboxwithoptions"></a>
# **CreateInboxWithOptions**
> InboxDto CreateInboxWithOptions (CreateInboxDto createInboxDto)

Create an inbox with options. Extended options for inbox creation.

Additional endpoint that allows inbox creation with request body options. Can be more flexible that other methods for some clients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class CreateInboxWithOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var createInboxDto = new CreateInboxDto(); // CreateInboxDto | 

            try
            {
                // Create an inbox with options. Extended options for inbox creation.
                InboxDto result = apiInstance.CreateInboxWithOptions(createInboxDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.CreateInboxWithOptions: " + e.Message );
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
 **createInboxDto** | [**CreateInboxDto**](CreateInboxDto)|  | 

### Return type

[**InboxDto**](InboxDto)

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

<a name="deleteallinboxes"></a>
# **DeleteAllInboxes**
> void DeleteAllInboxes ()

Delete all inboxes

Permanently delete all inboxes and associated email addresses. This will also delete all emails within the inboxes. Be careful as inboxes cannot be recovered once deleted. Note: deleting inboxes will not impact your usage limits. Monthly inbox creation limits are based on how many inboxes were created in the last 30 days, not how many inboxes you currently have.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteAllInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);

            try
            {
                // Delete all inboxes
                apiInstance.DeleteAllInboxes();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.DeleteAllInboxes: " + e.Message );
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

<a name="deleteinbox"></a>
# **DeleteInbox**
> void DeleteInbox (Guid inboxId)

Delete inbox

Permanently delete an inbox and associated email address as well as all emails within the given inbox. This action cannot be undone. Note: deleting an inbox will not affect your account usage. Monthly inbox usage is based on how many inboxes you create within 30 days, not how many exist at time of request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DeleteInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 

            try
            {
                // Delete inbox
                apiInstance.DeleteInbox(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.DeleteInbox: " + e.Message );
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

<a name="doesinboxexist"></a>
# **DoesInboxExist**
> InboxExistsDto DoesInboxExist (string emailAddress)

Does inbox exist

Check if inboxes exist by email address. Useful if you are sending emails to mailslurp addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class DoesInboxExistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var emailAddress = emailAddress_example;  // string | Email address

            try
            {
                // Does inbox exist
                InboxExistsDto result = apiInstance.DoesInboxExist(emailAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.DoesInboxExist: " + e.Message );
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
 **emailAddress** | **string**| Email address | 

### Return type

[**InboxExistsDto**](InboxExistsDto)

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

<a name="flushexpired"></a>
# **FlushExpired**
> FlushExpiredInboxesResult FlushExpired (DateTime? before = null)

Remove expired inboxes

Remove any expired inboxes for your account (instead of waiting for scheduled removal on server)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class FlushExpiredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional expired at before flag to flush expired inboxes that have expired before the given time (optional) 

            try
            {
                // Remove expired inboxes
                FlushExpiredInboxesResult result = apiInstance.FlushExpired(before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.FlushExpired: " + e.Message );
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
 **before** | **DateTime?**| Optional expired at before flag to flush expired inboxes that have expired before the given time | [optional] 

### Return type

[**FlushExpiredInboxesResult**](FlushExpiredInboxesResult)

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

<a name="getallinboxes"></a>
# **GetAllInboxes**
> PageInboxProjection GetAllInboxes (int? page = null, int? size = null, string sort = null, bool? favourite = null, string search = null, string tag = null, bool? teamAccess = null, DateTime? since = null, DateTime? before = null)

List All Inboxes Paginated

List inboxes in paginated form. The results are available on the `content` property of the returned object. This method allows for page index (zero based), page size (how many results to return), and a sort direction (based on createdAt time). You Can also filter by whether an inbox is favorited or use email address pattern. This method is the recommended way to query inboxes. The alternative `getInboxes` method returns a full list of inboxes but is limited to 100 results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetAllInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var favourite = true;  // bool? | Optionally filter results for favourites only (optional)  (default to false)
            var search = search_example;  // string | Optionally filter by search words partial matching ID, tags, name, and email address (optional) 
            var tag = tag_example;  // string | Optionally filter by tags. Will return inboxes that include given tags (optional) 
            var teamAccess = true;  // bool? | DEPRECATED. Optionally filter by team access. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created before given date time (optional) 

            try
            {
                // List All Inboxes Paginated
                PageInboxProjection result = apiInstance.GetAllInboxes(page, size, sort, favourite, search, tag, teamAccess, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetAllInboxes: " + e.Message );
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
 **favourite** | **bool?**| Optionally filter results for favourites only | [optional] [default to false]
 **search** | **string**| Optionally filter by search words partial matching ID, tags, name, and email address | [optional] 
 **tag** | **string**| Optionally filter by tags. Will return inboxes that include given tags | [optional] 
 **teamAccess** | **bool?**| DEPRECATED. Optionally filter by team access. | [optional] 
 **since** | **DateTime?**| Optional filter by created after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by created before given date time | [optional] 

### Return type

[**PageInboxProjection**](PageInboxProjection)

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

<a name="getemails"></a>
# **GetEmails**
> List&lt;EmailPreview&gt; GetEmails (Guid inboxId, int? size = null, int? limit = null, string sort = null, long? retryTimeout = null, long? delayTimeout = null, long? minCount = null, bool? unreadOnly = null, DateTime? before = null, DateTime? since = null)

Get emails in an Inbox. This method is not idempotent as it allows retries and waits if you want certain conditions to be met before returning. For simple listing and sorting of known emails use the email controller instead.

List emails that an inbox has received. Only emails that are sent to the inbox's email address will appear in the inbox. It may take several seconds for any email you send to an inbox's email address to appear in the inbox. To make this endpoint wait for a minimum number of emails use the `minCount` parameter. The server will retry the inbox database until the `minCount` is satisfied or the `retryTimeout` is reached

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | Id of inbox that emails belongs to
            var size = 56;  // int? | Alias for limit. Assessed first before assessing any passed limit. (optional) 
            var limit = 56;  // int? | Limit the result set, ordered by received date time sort direction. Maximum 100. For more listing options see the email controller (optional) 
            var sort = sort_example;  // string | Sort the results by received date and direction ASC or DESC (optional) 
            var retryTimeout = 789;  // long? | Maximum milliseconds to spend retrying inbox database until minCount emails are returned (optional) 
            var delayTimeout = 789;  // long? |  (optional) 
            var minCount = 789;  // long? | Minimum acceptable email count. Will cause request to hang (and retry) until minCount is satisfied or retryTimeout is reached. (optional) 
            var unreadOnly = true;  // bool? |  (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Exclude emails received after this ISO 8601 date time (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Exclude emails received before this ISO 8601 date time (optional) 

            try
            {
                // Get emails in an Inbox. This method is not idempotent as it allows retries and waits if you want certain conditions to be met before returning. For simple listing and sorting of known emails use the email controller instead.
                List<EmailPreview> result = apiInstance.GetEmails(inboxId, size, limit, sort, retryTimeout, delayTimeout, minCount, unreadOnly, before, since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetEmails: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| Id of inbox that emails belongs to | 
 **size** | **int?**| Alias for limit. Assessed first before assessing any passed limit. | [optional] 
 **limit** | **int?**| Limit the result set, ordered by received date time sort direction. Maximum 100. For more listing options see the email controller | [optional] 
 **sort** | **string**| Sort the results by received date and direction ASC or DESC | [optional] 
 **retryTimeout** | **long?**| Maximum milliseconds to spend retrying inbox database until minCount emails are returned | [optional] 
 **delayTimeout** | **long?**|  | [optional] 
 **minCount** | **long?**| Minimum acceptable email count. Will cause request to hang (and retry) until minCount is satisfied or retryTimeout is reached. | [optional] 
 **unreadOnly** | **bool?**|  | [optional] 
 **before** | **DateTime?**| Exclude emails received after this ISO 8601 date time | [optional] 
 **since** | **DateTime?**| Exclude emails received before this ISO 8601 date time | [optional] 

### Return type

[**List&lt;EmailPreview&gt;**](EmailPreview)

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

<a name="getinbox"></a>
# **GetInbox**
> InboxDto GetInbox (Guid inboxId)

Get Inbox. Returns properties of an inbox.

Returns an inbox's properties, including its email address and ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 

            try
            {
                // Get Inbox. Returns properties of an inbox.
                InboxDto result = apiInstance.GetInbox(inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInbox: " + e.Message );
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

[**InboxDto**](InboxDto)

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

<a name="getinboxcount"></a>
# **GetInboxCount**
> CountDto GetInboxCount ()

Get total inbox count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);

            try
            {
                // Get total inbox count
                CountDto result = apiInstance.GetInboxCount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxCount: " + e.Message );
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

[**CountDto**](CountDto)

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

<a name="getinboxemailcount"></a>
# **GetInboxEmailCount**
> CountDto GetInboxEmailCount (Guid inboxId)

Get email count in inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxEmailCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | Id of inbox that emails belongs to

            try
            {
                // Get email count in inbox
                CountDto result = apiInstance.GetInboxEmailCount(inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxEmailCount: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| Id of inbox that emails belongs to | 

### Return type

[**CountDto**](CountDto)

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

<a name="getinboxemailspaginated"></a>
# **GetInboxEmailsPaginated**
> PageEmailPreview GetInboxEmailsPaginated (Guid inboxId, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get inbox emails paginated

Get a paginated list of emails in an inbox. Does not hold connections open.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxEmailsPaginatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | Id of inbox that emails belongs to
            var page = 56;  // int? | Optional page index in inbox emails list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox emails list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by received after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by received before given date time (optional) 

            try
            {
                // Get inbox emails paginated
                PageEmailPreview result = apiInstance.GetInboxEmailsPaginated(inboxId, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxEmailsPaginated: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| Id of inbox that emails belongs to | 
 **page** | **int?**| Optional page index in inbox emails list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox emails list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Optional filter by received after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by received before given date time | [optional] 

### Return type

[**PageEmailPreview**](PageEmailPreview)

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

<a name="getinboxids"></a>
# **GetInboxIds**
> InboxIdsResult GetInboxIds ()

Get all inbox IDs

Get list of inbox IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);

            try
            {
                // Get all inbox IDs
                InboxIdsResult result = apiInstance.GetInboxIds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxIds: " + e.Message );
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

[**InboxIdsResult**](InboxIdsResult)

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

<a name="getinboxsentemails"></a>
# **GetInboxSentEmails**
> PageSentEmailProjection GetInboxSentEmails (Guid inboxId, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

Get Inbox Sent Emails

Returns an inbox's sent email receipts. Call individual sent email endpoints for more details. Note for privacy reasons the full body of sent emails is never stored. An MD5 hash hex is available for comparison instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxSentEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in inbox sent email list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox sent email list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional sent email search (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by sent before given date time (optional) 

            try
            {
                // Get Inbox Sent Emails
                PageSentEmailProjection result = apiInstance.GetInboxSentEmails(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxSentEmails: " + e.Message );
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
 **page** | **int?**| Optional page index in inbox sent email list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox sent email list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional sent email search | [optional] 
 **since** | **DateTime?**| Optional filter by sent after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by sent before given date time | [optional] 

### Return type

[**PageSentEmailProjection**](PageSentEmailProjection)

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

<a name="getinboxtags"></a>
# **GetInboxTags**
> List&lt;string&gt; GetInboxTags ()

Get inbox tags

Get all inbox tags

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);

            try
            {
                // Get inbox tags
                List<string> result = apiInstance.GetInboxTags();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxTags: " + e.Message );
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

**List<string>**

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

<a name="getinboxes"></a>
# **GetInboxes**
> List&lt;InboxDto&gt; GetInboxes (int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

List Inboxes and email addresses

List the inboxes you have created. Note use of the more advanced `getAllEmails` is recommended and allows paginated access using a limit and sort parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var size = 56;  // int? | Optional result size limit. Note an automatic limit of 100 results is applied. See the paginated `getAllEmails` for larger queries. (optional)  (default to 100)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created before given date time (optional) 

            try
            {
                // List Inboxes and email addresses
                List<InboxDto> result = apiInstance.GetInboxes(size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetInboxes: " + e.Message );
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
 **size** | **int?**| Optional result size limit. Note an automatic limit of 100 results is applied. See the paginated &#x60;getAllEmails&#x60; for larger queries. | [optional] [default to 100]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **since** | **DateTime?**| Optional filter by created after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by created before given date time | [optional] 

### Return type

[**List&lt;InboxDto&gt;**](InboxDto)

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

<a name="getorganizationinboxes"></a>
# **GetOrganizationInboxes**
> PageOrganizationInboxProjection GetOrganizationInboxes (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

List Organization Inboxes Paginated

List organization inboxes in paginated form. These are inboxes created with `allowTeamAccess` flag enabled. Organization inboxes are `readOnly` for non-admin users. The results are available on the `content` property of the returned object. This method allows for page index (zero based), page size (how many results to return), and a sort direction (based on createdAt time). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class GetOrganizationInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var page = 56;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created before given date time (optional) 

            try
            {
                // List Organization Inboxes Paginated
                PageOrganizationInboxProjection result = apiInstance.GetOrganizationInboxes(page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.GetOrganizationInboxes: " + e.Message );
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
 **since** | **DateTime?**| Optional filter by created after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by created before given date time | [optional] 

### Return type

[**PageOrganizationInboxProjection**](PageOrganizationInboxProjection)

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

<a name="listinboxrulesets"></a>
# **ListInboxRulesets**
> PageInboxRulesetDto ListInboxRulesets (Guid inboxId, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

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
    public class ListInboxRulesetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in inbox ruleset list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox ruleset list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created before given date time (optional) 

            try
            {
                // List inbox rulesets
                PageInboxRulesetDto result = apiInstance.ListInboxRulesets(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.ListInboxRulesets: " + e.Message );
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
 **page** | **int?**| Optional page index in inbox ruleset list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox ruleset list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Optional filter by created after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by created before given date time | [optional] 

### Return type

[**PageInboxRulesetDto**](PageInboxRulesetDto)

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

<a name="listinboxtrackingpixels"></a>
# **ListInboxTrackingPixels**
> PageTrackingPixelProjection ListInboxTrackingPixels (Guid inboxId, int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null)

List inbox tracking pixels

List all tracking pixels sent from an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class ListInboxTrackingPixelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var page = 56;  // int? | Optional page index in inbox tracking pixel list pagination (optional)  (default to 0)
            var size = 56;  // int? | Optional page size in inbox tracking pixel list pagination (optional)  (default to 20)
            var sort = sort_example;  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var searchFilter = searchFilter_example;  // string | Optional search filter (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created after given date time (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional filter by created before given date time (optional) 

            try
            {
                // List inbox tracking pixels
                PageTrackingPixelProjection result = apiInstance.ListInboxTrackingPixels(inboxId, page, size, sort, searchFilter, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.ListInboxTrackingPixels: " + e.Message );
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
 **page** | **int?**| Optional page index in inbox tracking pixel list pagination | [optional] [default to 0]
 **size** | **int?**| Optional page size in inbox tracking pixel list pagination | [optional] [default to 20]
 **sort** | **string**| Optional createdAt sort direction ASC or DESC | [optional] [default to ASC]
 **searchFilter** | **string**| Optional search filter | [optional] 
 **since** | **DateTime?**| Optional filter by created after given date time | [optional] 
 **before** | **DateTime?**| Optional filter by created before given date time | [optional] 

### Return type

[**PageTrackingPixelProjection**](PageTrackingPixelProjection)

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

<a name="sendemail"></a>
# **SendEmail**
> void SendEmail (Guid inboxId, SendEmailOptions sendEmailOptions)

Send Email

Send an email from an inbox's email address.  The request body should contain the `SendEmailOptions` that include recipients, attachments, body etc. See `SendEmailOptions` for all available properties. Note the `inboxId` refers to the inbox's id not the inbox's email address. See https://www.mailslurp.com/guides/ for more information on how to send emails. This method does not return a sent email entity due to legacy reasons. To send and get a sent email as returned response use the sister method `sendEmailAndConfirm`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | ID of the inbox you want to send the email from
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | 

            try
            {
                // Send Email
                apiInstance.SendEmail(inboxId, sendEmailOptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.SendEmail: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| ID of the inbox you want to send the email from | 
 **sendEmailOptions** | [**SendEmailOptions**](SendEmailOptions)|  | 

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

<a name="sendemailandconfirm"></a>
# **SendEmailAndConfirm**
> SentEmailDto SendEmailAndConfirm (Guid inboxId, SendEmailOptions sendEmailOptions)

Send email and return sent confirmation

Sister method for standard `sendEmail` method with the benefit of returning a `SentEmail` entity confirming the successful sending of the email with a link to the sent object created for it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendEmailAndConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | ID of the inbox you want to send the email from
            var sendEmailOptions = new SendEmailOptions(); // SendEmailOptions | 

            try
            {
                // Send email and return sent confirmation
                SentEmailDto result = apiInstance.SendEmailAndConfirm(inboxId, sendEmailOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.SendEmailAndConfirm: " + e.Message );
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
 **inboxId** | [**Guid**](Guid)| ID of the inbox you want to send the email from | 
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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="sendtestemail"></a>
# **SendTestEmail**
> void SendTestEmail (Guid inboxId)

Send a test email to inbox

Send an inbox a test email to test email receiving is working

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SendTestEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 

            try
            {
                // Send a test email to inbox
                apiInstance.SendTestEmail(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.SendTestEmail: " + e.Message );
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

<a name="setinboxfavourited"></a>
# **SetInboxFavourited**
> InboxDto SetInboxFavourited (Guid inboxId, SetInboxFavouritedOptions setInboxFavouritedOptions)

Set inbox favourited state

Set and return new favourite state for an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SetInboxFavouritedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var setInboxFavouritedOptions = new SetInboxFavouritedOptions(); // SetInboxFavouritedOptions | 

            try
            {
                // Set inbox favourited state
                InboxDto result = apiInstance.SetInboxFavourited(inboxId, setInboxFavouritedOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.SetInboxFavourited: " + e.Message );
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
 **setInboxFavouritedOptions** | [**SetInboxFavouritedOptions**](SetInboxFavouritedOptions)|  | 

### Return type

[**InboxDto**](InboxDto)

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

<a name="updateinbox"></a>
# **UpdateInbox**
> InboxDto UpdateInbox (Guid inboxId, UpdateInboxOptions updateInboxOptions)

Update Inbox. Change name and description. Email address is not editable.

Update editable fields on an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class UpdateInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxControllerApi(config);
            var inboxId = new Guid(); // Guid | 
            var updateInboxOptions = new UpdateInboxOptions(); // UpdateInboxOptions | 

            try
            {
                // Update Inbox. Change name and description. Email address is not editable.
                InboxDto result = apiInstance.UpdateInbox(inboxId, updateInboxOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxControllerApi.UpdateInbox: " + e.Message );
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
 **updateInboxOptions** | [**UpdateInboxOptions**](UpdateInboxOptions)|  | 

### Return type

[**InboxDto**](InboxDto)

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

