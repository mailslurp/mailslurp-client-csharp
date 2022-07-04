# mailslurp.Model.EmailProjection
A compact representation of a full email. Used in list endpoints to keep response sizes low. Body and attachments are not included. To get all fields of the email use the `getEmail` method with the email projection's ID. See `EmailDto` for documentation on projection properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**From** | **string** |  | [optional] 
**Subject** | **string** |  | [optional] 
**InboxId** | **Guid** |  | 
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**To** | **List&lt;string&gt;** |  | 
**CreatedAt** | **DateTime** |  | 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**TeamAccess** | **bool** |  | 
**Read** | **bool** |  | 
**BodyMD5Hash** | **string** |  | [optional] 
**BodyExcerpt** | **string** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

