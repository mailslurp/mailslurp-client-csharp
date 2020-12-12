# mailslurp.Model.DomainDto
Domain plus verification records and status
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | 
**DkimTokens** | **List&lt;string&gt;** | DNS records for DKIM approval | [optional] 
**Domain** | **string** | Custom domain name | [optional] 
**Id** | **Guid** |  | 
**IsVerified** | **bool** | Whether domain has been verified or not. If the domain is not verified after 72 hours there is most likely an issue with the domains DNS records. | [optional] 
**UpdatedAt** | **DateTime** |  | 
**UserId** | **Guid** |  | 
**VerificationToken** | **string** | A TXT record that you must place in the DNS settings of the domain to complete domain verification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

