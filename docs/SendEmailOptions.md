# mailslurp.Model.SendEmailOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** | Optional list of attachment IDs to send with this email. You must first upload each attachment separately in order to obtain attachment IDs | [optional] 
**Bcc** | **List&lt;string&gt;** | Optional list of bcc destination email addresses | [optional] 
**Body** | **string** | Contents of email. If HTML set isHTML to true. You can use moustache templates here if you provide a templateVariables option | [optional] 
**Cc** | **List&lt;string&gt;** | Optional list of cc destination email addresses | [optional] 
**Charset** | **string** | Optional charset | [optional] 
**From** | **string** | Optional from address. If not set source inbox address will be used | [optional] 
**Html** | **bool?** |  | [optional] 
**ReplyTo** | **string** | Optional replyTo header | [optional] 
**Subject** | **string** | Optional email subject line | [optional] 
**TemplateVariables** | [**Object**](.md) | Optional map of template variables. Will replace moustache syntax variables in subject or body with the associated values | [optional] 
**To** | **List&lt;string&gt;** | List of destination email addresses. Even single recipients must be in array form. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

