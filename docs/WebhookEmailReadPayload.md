# mailslurp.Model.WebhookEmailReadPayload
EMAIL_READ webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is read. This happens when an email is requested in full from the API or a user views the email in the dashboard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**EmailId** | **Guid** | ID of the email that was received. Use this ID for fetching the email with the &#x60;EmailController&#x60;. | 
**InboxId** | **Guid** | Id of the inbox that received an email | 
**EmailIsRead** | **bool** | Is the email read | 
**CreatedAt** | **DateTime** | Date time of event creation | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

