# mailslurp.Model.Email
Email entity (also known as EmailDto). When an SMTP email message is received by MailSlurp it is parsed. The body and attachments are written to disk and the fields such as to, from, subject etc are stored in a database. The `body` contains the email content. If you want the original SMTP message see the `getRawEmail` endpoints. The attachments can be fetched using the AttachmentController
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Analysis** | [**EmailAnalysis**](EmailAnalysis) |  | [optional] 
**Attachments** | **List&lt;string&gt;** | List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension. | [optional] 
**Bcc** | **List&lt;string&gt;** | List of &#x60;BCC&#x60; recipients email was addressed to | [optional] 
**Body** | **string** | The body of the email message | [optional] 
**BodyMD5Hash** | **string** | A hash signature of the email message | [optional] 
**Cc** | **List&lt;string&gt;** | List of &#x60;CC&#x60; recipients email was addressed to | [optional] 
**Charset** | **string** | Detected character set of the email body such as UTF-8 | [optional] 
**CreatedAt** | **DateTime** | When was the email received by MailSlurp | [optional] 
**From** | **string** | Who the email was sent from | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Collection of SMTP headers attached to email | [optional] 
**Id** | **Guid** | ID of the email entity | [optional] 
**InboxId** | **Guid** | ID of the inbox that received the email | [optional] 
**IsHTML** | **bool** | Is the email body HTML | [optional] 
**Read** | **bool** | Read flag. Has the email ever been viewed in the dashboard or fetched via the API? If so the email is marked as read. | [optional] 
**ReplyTo** | **string** | The &#x60;replyTo&#x60; field on the received email message | [optional] 
**Subject** | **string** | The subject line of the email message | [optional] 
**TeamAccess** | **bool** | Can the email be accessed by organization team members | [optional] 
**To** | **List&lt;string&gt;** | List of &#x60;To&#x60; recipients that email was addressed to | [optional] 
**UpdatedAt** | **DateTime** | When was the email last updated | [optional] 
**UserId** | **Guid** | ID of user that email belongs to | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

