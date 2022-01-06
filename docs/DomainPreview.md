# mailslurp.Model.DomainPreview
Preview object for domain entity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Domain** | **string** |  | [optional] 
**CatchAllInboxId** | **Guid** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**DomainType** | **string** | Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails. | [optional] 
**Verified** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

