# mailslurp.Model.UserDto
Representation a user's account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**ApiKey** | **string** |  | 
**EmailAddress** | **string** |  | 
**EmailAddressMd5** | **string** |  | 
**Created** | **DateTime** |  | [optional] 
**UserType** | **string** |  | [optional] 
**Organization** | **Guid** | Does user belong to an organization | [optional] 
**Verified** | **string** | Has user accepted an organization invite | [optional] 
**HasPassword** | **bool** |  | 
**IsFrozen** | **bool** |  | 
**AddNewContacts** | **bool** |  | [optional] 
**SsoProvider** | **string** |  | [optional] 
**CustomerId** | **string** |  | [optional] 
**HasOnboarded** | **bool** |  | [optional] 
**ImapUsername** | **string** |  | [optional] 
**ImapPassword** | **string** |  | [optional] 
**SmtpUsername** | **string** |  | [optional] 
**SmtpPassword** | **string** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

