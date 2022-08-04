# mailslurp.Model.WebhookNewEmailPayload
NEW_EMAIL webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to. Use the email ID to fetch the full email body or attachments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**InboxId** | **Guid** | Id of the inbox that received an email | 
**DomainId** | **Guid** | Id of the domain that received an email | [optional] 
**EmailId** | **Guid** | ID of the email that was received. Use this ID for fetching the email with the &#x60;EmailController&#x60;. | 
**CreatedAt** | **DateTime** | Date time of event creation | 
**To** | **List&lt;string&gt;** | List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names. | 
**From** | **string** | Who the email was sent from. An email address - see fromName for the sender name. | 
**Cc** | **List&lt;string&gt;** | List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names. | 
**Bcc** | **List&lt;string&gt;** | List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names. | 
**Subject** | **string** | The subject line of the email message as specified by SMTP subject header | [optional] 
**AttachmentMetaDatas** | [**List&lt;AttachmentMetaData&gt;**](AttachmentMetaData) | List of attachment meta data objects if attachments present | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

