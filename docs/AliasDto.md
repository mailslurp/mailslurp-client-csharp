# mailslurp.Model.AliasDto
Email alias representation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**EmailAddress** | **string** | The alias&#39;s email address for receiving email | 
**MaskedEmailAddress** | **string** | The underlying email address that is hidden and will received forwarded email | [optional] 
**UserId** | **Guid** |  | 
**InboxId** | **Guid** | Inbox that is associated with the alias | 
**Name** | **string** |  | [optional] 
**UseThreads** | **bool?** | If alias will generate response threads or not when email are received by it | [optional] 
**IsVerified** | **bool** | Has the alias been verified. You must verify an alias if the masked email address has not yet been verified by your account | 
**CreatedAt** | **DateTime?** |  | [optional] 
**UpdatedAt** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

