# mailslurp.Model.Email
Email model (also referred to as EmailDto). Represents an email that was received by an inbox. If you want the original SMTP message see the `getRawEmail` endpoint.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Analysis** | [**EmailAnalysis**](EmailAnalysis.md) |  | [optional] 
**Attachments** | **List&lt;string&gt;** | List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension. | [optional] 
**Bcc** | **List&lt;string&gt;** | List of &#x60;BCC&#x60; recipients email was addressed to | [optional] 
**Body** | **string** | The body of the email message | [optional] 
**Cc** | **List&lt;string&gt;** | List of &#x60;CC&#x60; recipients email was addressed to | [optional] 
**Charset** | **string** | Detected character set of the email body such as UTF-8 | [optional] 
**CreatedAt** | **DateTime** | When was the email received by MailSlurp | [optional] 
**From** | **string** | Who the email was sent from | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Id** | **Guid** | ID of the email | [optional] 
**InboxId** | **Guid** | ID of the inbox that received the email | [optional] 
**IsHTML** | **bool** | Was HTML sent in the email body | [optional] 
**Read** | **bool** | Has the email been viewed ever | [optional] 
**Subject** | **string** | The subject line of the email message | [optional] 
**To** | **List&lt;string&gt;** | List of &#x60;To&#x60; recipients email was addressed to | [optional] 
**UpdatedAt** | **DateTime** | When was the email last updated | [optional] 
**UserId** | **Guid** | ID of user that email belongs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

