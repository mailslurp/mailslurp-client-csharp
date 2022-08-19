# mailslurp.Model.DomainDto
Domain plus verification records and status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**UserId** | **Guid** |  | 
**Domain** | **string** | Custom domain name | 
**VerificationToken** | **string** | Verification tokens | 
**DkimTokens** | **List&lt;string&gt;** | Unique token DKIM tokens | 
**IsVerified** | **bool** | Whether domain has been verified or not. If the domain is not verified after 72 hours there is most likely an issue with the domains DNS records. | 
**DomainNameRecords** | [**List&lt;DomainNameRecord&gt;**](DomainNameRecord) | List of DNS domain name records (C, MX, TXT) etc that you must add to the DNS server associated with your domain provider. | 
**CatchAllInboxId** | **Guid** | The optional catch all inbox that will receive emails sent to the domain that cannot be matched. | [optional] 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 
**DomainType** | **string** | Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails. | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

