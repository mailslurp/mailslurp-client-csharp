# mailslurp.Model.WebhookNewContactPayload
NEW_CONTACT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains a recipient that has not been saved as a contact.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**ContactId** | **Guid** |  | 
**GroupId** | **Guid** |  | [optional] 
**FirstName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**Company** | **string** |  | [optional] 
**PrimaryEmailAddress** | **string** |  | [optional] 
**EmailAddresses** | **List&lt;string&gt;** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**MetaData** | **Object** |  | [optional] 
**OptOut** | **bool** |  | 
**CreatedAt** | **DateTime** |  | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

