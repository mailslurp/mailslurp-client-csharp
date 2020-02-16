
# mailslurp.Model.SendEmailOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** | Optional list of attachment IDs to send with this email. You must first upload each attachment separately in order to obtain attachment IDs | [optional] 
**Bcc** | **List&lt;string&gt;** | Optional list of bcc destination email addresses | [optional] 
**Body** | **string** | Contents of email. If body contains HTML then set &#x60;isHTML&#x60; to true. You can use moustache template syntax in the body in conjunction with &#x60;toGroup&#x60; contact variables or &#x60;templateVariables&#x60; data. | [optional] 
**Cc** | **List&lt;string&gt;** | Optional list of cc destination email addresses | [optional] 
**Charset** | **string** | Optional charset | [optional] 
**From** | **string** | Optional from address. If not set source inbox address will be used | [optional] 
**IsHTML** | **bool** | Optional HTML flag. If true the &#x60;content-type&#x60; of the email will be &#x60;text/html&#x60; | [optional] 
**ReplyTo** | **string** | Optional replyTo header | [optional] 
**Subject** | **string** | Optional email subject line | [optional] 
**Template** | **Guid** | Optional template ID to use for body. Will override body if provided | [optional] 
**TemplateVariables** | [**Object**](.md) | Optional map of template variables. Will replace moustache syntax variables in subject and body or template with the associated values | [optional] 
**To** | **List&lt;string&gt;** | List of destination email addresses. Even single recipients must be in array form. Max 100 recipients. | [optional] 
**ToContacts** | **List&lt;Guid&gt;** | Optional list of contact IDs to send email to | [optional] 
**ToGroup** | **Guid** | Optional contact group ID to send email to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

