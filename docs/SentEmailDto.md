# mailslurp.Model.SentEmailDto
Sent email details
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ID of sent email | 
**UserId** | **Guid** | User ID | 
**InboxId** | **Guid** | Inbox ID email was sent from | 
**To** | **List&lt;string&gt;** | Recipients email was sent to | [optional] 
**From** | **string** |  | [optional] 
**ReplyTo** | **string** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**Attachments** | **List&lt;string&gt;** | Array of IDs of attachments that were sent with this email | [optional] 
**Subject** | **string** |  | [optional] 
**BodyMD5Hash** | **string** | MD5 Hash | [optional] 
**Body** | **string** |  | [optional] 
**Charset** | **string** |  | [optional] 
**IsHTML** | **bool** |  | [optional] 
**SentAt** | **DateTime** |  | 
**PixelIds** | **List&lt;Guid&gt;** |  | [optional] 
**MessageId** | **string** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

