# mailslurp.Model.AbstractWebhookPayload
Abstract webhook payload. Use the correct payload type for your webhook event type in order to access all the specific properties for that event. See the `NEW_EMAIL`,`NEW_CONTACT`, `NEW_ATTACHMENT` and `EMAIL_OPENED` payloads for the properties available for those events.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookName** | **string** |  | [optional] 
**EventName** | **string** |  | 
**WebhookId** | **Guid** |  | 
**MessageId** | **string** |  | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

