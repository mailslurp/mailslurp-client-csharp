# mailslurp.Model.WebhookNewContactPayload
NEW_CONTACT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains a recipient that has not been saved as a contact.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**ContactId** | **Guid** | Contact ID | 
**GroupId** | **Guid?** | Contact group ID | [optional] 
**FirstName** | **string** | Contact first name | [optional] 
**LastName** | **string** | Contact last name | [optional] 
**Company** | **string** | Contact company name | [optional] 
**PrimaryEmailAddress** | **string** | Primary email address for contact | [optional] 
**EmailAddresses** | **List&lt;string&gt;** | Email addresses for contact | 
**Tags** | **List&lt;string&gt;** | Tags for contact | 
**MetaData** | **Object** |  | [optional] 
**OptOut** | **bool** | Has contact opted out of emails | 
**CreatedAt** | **DateTime** | Date time of event creation | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

