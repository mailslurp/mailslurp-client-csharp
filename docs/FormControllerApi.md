# mailslurp.Api.FormControllerApi

All URIs are relative to *https://api.mailslurp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitForm**](FormControllerApi.md#submitform) | **POST** /forms | Submit a form to be parsed and sent as an email to an address determined by the form fields



## SubmitForm

> string SubmitForm (string emailAddress = null, string redirectTo = null, string spamCheck = null, string subject = null, string successMessage = null, string to = null, string toAlias = null, string otherParameters = null)

Submit a form to be parsed and sent as an email to an address determined by the form fields

This endpoint allows you to submit HTML forms and receive the field values and files via email.   #### Parameters The endpoint looks for special meta parameters in the form fields OR in the URL request parameters. The meta parameters can be used to specify the behaviour of the email.   You must provide at-least a `_to` email address or a `_toAlias` email alias ID to tell the endpoint where the form should be emailed. These can be submitted as hidden HTML input fields with the corresponding `name` attributes or as URL query parameters such as `?_to=test@example.com`  The endpoint takes all other form fields that are named and includes them in the message body of the email. Files are sent as attachments.  #### Submitting This endpoint accepts form submission via POST method. It accepts `application/x-www-form-urlencoded`, and `multipart/form-data` content-types.  #### HTML Example ```html <form    action=\"https://api.mailslurp.com/forms\"   method=\"post\" >   <input name=\"_to\" type=\"hidden\" value=\"test@example.com\"/>   <textarea name=\"feedback\"></textarea>   <button type=\"submit\">Submit</button> </form> ```  #### URL Example ```html <form    action=\"https://api.mailslurp.com/forms?_toAlias=test@example.com\"   method=\"post\" >   <textarea name=\"feedback\"></textarea>   <button type=\"submit\">Submit</button> </form> ```    The email address is specified by a `_to` field OR is extracted from an email alias specified by a `_toAlias` field (see the alias controller for more information).  Endpoint accepts .  You can specify a content type in HTML forms using the `enctype` attribute, for instance: `<form enctype=\"multipart/form-data\">`.  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;

namespace Example
{
    public class SubmitFormExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mailslurp.com";
            // Configure API key authorization: API_KEY
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new FormControllerApi(Configuration.Default);
            var emailAddress = emailAddress_example;  // string | Email address of the submitting user. Include this if you wish to record the submitters email address and reply to it later. (optional) 
            var redirectTo = redirectTo_example;  // string | Optional URL to redirect form submitter to after submission. If not present user will see a success message. (optional) 
            var spamCheck = spamCheck_example;  // string | Optional but recommended field that catches spammers out. Include as a hidden form field but LEAVE EMPTY. Spam-bots will usually fill every field. If the _spamCheck field is filled the form submission will be ignored. (optional) 
            var subject = subject_example;  // string | Optional subject of the email that will be sent. (optional) 
            var successMessage = successMessage_example;  // string | Optional success message to display if no _redirectTo present. (optional) 
            var to = to_example;  // string | The email address that submitted form should be sent to. Either this or _toAlias must be present for a form to be successfully submitted.. (optional) 
            var toAlias = toAlias_example;  // string | ID of an email alias to that form should be sent to. Aliases must be created before submission and can be used to hide an email address and reduce spam. (optional) 
            var otherParameters = otherParameters_example;  // string | All other parameters or fields will be accepted and attached to the sent email. This includes files and any HTML form field with a name. These fields will become the body of the email that is sent. (optional) 

            try
            {
                // Submit a form to be parsed and sent as an email to an address determined by the form fields
                string result = apiInstance.SubmitForm(emailAddress, redirectTo, spamCheck, subject, successMessage, to, toAlias, otherParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FormControllerApi.SubmitForm: " + e.Message );
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
 **emailAddress** | **string**| Email address of the submitting user. Include this if you wish to record the submitters email address and reply to it later. | [optional] 
 **redirectTo** | **string**| Optional URL to redirect form submitter to after submission. If not present user will see a success message. | [optional] 
 **spamCheck** | **string**| Optional but recommended field that catches spammers out. Include as a hidden form field but LEAVE EMPTY. Spam-bots will usually fill every field. If the _spamCheck field is filled the form submission will be ignored. | [optional] 
 **subject** | **string**| Optional subject of the email that will be sent. | [optional] 
 **successMessage** | **string**| Optional success message to display if no _redirectTo present. | [optional] 
 **to** | **string**| The email address that submitted form should be sent to. Either this or _toAlias must be present for a form to be successfully submitted.. | [optional] 
 **toAlias** | **string**| ID of an email alias to that form should be sent to. Aliases must be created before submission and can be used to hide an email address and reduce spam. | [optional] 
 **otherParameters** | **string**| All other parameters or fields will be accepted and attached to the sent email. This includes files and any HTML form field with a name. These fields will become the body of the email that is sent. | [optional] 

### Return type

**string**

### Authorization

[API_KEY](../README.md#API_KEY)

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

