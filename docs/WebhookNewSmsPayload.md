# mailslurp.Model.WebhookNewSmsPayload
NEW_SMS webhook payload. Sent to your webhook url endpoint via HTTP POST when an sms is received by the phone number that your webhook is attached to. Use the SMS ID to fetch the full SMS details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**SmsId** | **Guid** | ID of SMS message | 
**UserId** | **Guid** | User ID of event | 
**PhoneNumber** | **Guid** | ID of phone number receiving SMS | 
**ToNumber** | **string** | Recipient phone number | 
**FromNumber** | **string** | Sender phone number | 
**Body** | **string** | SMS message body | 
**Read** | **bool** | SMS has been read | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

