# mailslurp.Model.WebhookNewContactPayload
NEW_CONTACT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains a recipient that has not been saved as a contact.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Company** | **string** |  | [optional] 
**ContactId** | **Guid** |  | 
**CreatedAt** | **DateTime** |  | 
**EmailAddresses** | **List&lt;string&gt;** |  | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | [optional] 
**FirstName** | **string** |  | [optional] 
**GroupId** | **Guid** |  | [optional] 
**LastName** | **string** |  | [optional] 
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | [optional] 
**MetaData** | [**Object**]() |  | [optional] 
**OptOut** | **bool** |  | [optional] 
**PrimaryEmailAddress** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | [optional] 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

