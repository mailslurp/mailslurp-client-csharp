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
**To** | **List&lt;string&gt;** |  | 
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**TeamAccess** | **bool** |  | [optional] 
**Read** | **bool** |  | [optional] 
**BodyMD5Hash** | **string** |  | [optional] 
**BodyExcerpt** | **string** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

