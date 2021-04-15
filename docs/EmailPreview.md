# mailslurp.Model.EmailPreview
Preview of an email message. For full message (including body and attachments) call the `getEmail` or other email endpoints with the provided email ID.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** | List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension. | [optional] 
**Bcc** | **List&lt;string&gt;** | List of &#x60;BCC&#x60; recipients email was addressed to | [optional] 
**Cc** | **List&lt;string&gt;** | List of &#x60;CC&#x60; recipients email was addressed to | [optional] 
**CreatedAt** | **DateTime** | When was the email received by MailSlurp | [optional] 
**From** | **string** | Who the email was sent from | [optional] 
**Id** | **Guid** | ID of the email | [optional] 
**Read** | **bool** | Has the email been viewed ever. This means viewed in the dashboard or requested via the full email entity endpoints | [optional] 
**Subject** | **string** | The subject line of the email message | [optional] 
**To** | **List&lt;string&gt;** | List of &#x60;To&#x60; recipients email was addressed to | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

