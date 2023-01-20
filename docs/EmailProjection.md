# mailslurp.Model.EmailProjection
A compact representation of a full email. Used in list endpoints to keep response sizes low. Body and attachments are not included. To get all fields of the email use the `getEmail` method with the email projection's ID. See `EmailDto` for documentation on projection properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**From** | **string** |  | [optional] 
**Subject** | **string** |  | [optional] 
**InboxId** | **Guid** |  | 
**CreatedAt** | **DateTime** |  | 
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**To** | **List&lt;string&gt;** |  | 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**DomainId** | **Guid?** |  | [optional] 
**BodyMD5Hash** | **string** |  | [optional] 
**Read** | **bool** |  | 
**BodyExcerpt** | **string** |  | [optional] 
**TeamAccess** | **bool** |  | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

