# mailslurp.Model.DomainDto
Domain plus verification records and status
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatchAllInboxId** | **Guid** | The optional catch all inbox that will receive emails sent to the domain that cannot be matched. | [optional] 
**CreatedAt** | **DateTime** |  | 
**DkimTokens** | **List&lt;string&gt;** | Unique token DKIM tokens | [optional] 
**Domain** | **string** | Custom domain name | [optional] 
**DomainNameRecords** | [**List&lt;DomainNameRecord&gt;**](DomainNameRecord) | List of DNS domain name records (C, MX, TXT) etc that you must add to the DNS server associated with your domain provider. | [optional] 
**DomainType** | **string** | The type of domain. SMTP or HTTP domains differ in what inboxes can be used with them. | [optional] 
**Id** | **Guid** |  | 
**IsVerified** | **bool** | Whether domain has been verified or not. If the domain is not verified after 72 hours there is most likely an issue with the domains DNS records. | [optional] 
**UpdatedAt** | **DateTime** |  | 
**UserId** | **Guid** |  | 
**VerificationToken** | **string** | Verification tokens | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

