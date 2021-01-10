# mailslurp.Model.AliasDto
Email alias representation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] 
**EmailAddress** | **string** | The alias&#39;s email address for receiving email | [optional] 
**Id** | **Guid** |  | 
**InboxId** | **Guid** | Inbox that is associated with the alias | [optional] 
**IsVerified** | **bool** | Has the alias been verified. You must verify an alias if the masked email address has not yet been verified by your account | [optional] 
**MaskedEmailAddress** | **string** | The underlying email address that is hidden and will received forwarded email | [optional] 
**Name** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**UseThreads** | **bool** | If alias will generate response threads or not when email are received by it | [optional] 
**UserId** | **Guid** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

