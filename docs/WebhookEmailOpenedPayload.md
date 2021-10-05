# mailslurp.Model.WebhookEmailOpenedPayload
EMAIL_OPENED webhook payload. Sent to your webhook url endpoint via HTTP POST when an email containing a tracking pixel is opened and the pixel image is loaded by a reader.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | Date time of event creation | [optional] 
**EventName** | **string** | Name of the event type webhook is being triggered for. | [optional] 
**InboxId** | **Guid** | Id of the inbox that received an email | [optional] 
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | [optional] 
**PixelId** | **Guid** | ID of the tracking pixel | [optional] 
**Recipient** | **string** | Email address for the recipient of the tracking pixel | [optional] 
**SentEmailId** | **Guid** | ID of sent email | [optional] 
**WebhookId** | **Guid** | ID of webhook entity being triggered | [optional] 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

