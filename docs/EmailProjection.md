# mailslurp.Model.EmailProjection
A compact representation of a full email. Used in list endpoints to keep response sizes low. Body and attachments are not included. To get all fields of the email use the `getEmail` method with the email projection's ID. See `EmailDto` for documentation on projection properties.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**BodyMD5Hash** | **string** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | 
**From** | **string** |  | [optional] 
**Id** | **Guid** |  | 
**InboxId** | **Guid** |  | 
**Read** | **bool** |  | [optional] 
**Subject** | **string** |  | [optional] 
**TeamAccess** | **bool** |  | [optional] 
**To** | **List&lt;string&gt;** |  | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

