# mailslurp.Model.AliasDto
Email alias representation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**EmailAddress** | **string** | The alias&#39;s email address for receiving email | [optional] 
**MaskedEmailAddress** | **string** | The underlying email address that is hidden and will received forwarded email | [optional] 
**UserId** | **Guid** |  | [optional] 
**InboxId** | **Guid** | Inbox that is associated with the alias | [optional] 
**Name** | **string** |  | [optional] 
**UseThreads** | **bool** | If alias will generate response threads or not when email are received by it | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Verified** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

