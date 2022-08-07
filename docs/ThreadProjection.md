# mailslurp.Model.ThreadProjection
A thread is a message thread created for a message received by an alias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of thread | [optional] 
**Id** | **Guid** | ID of email thread | 
**Subject** | **string** | Thread subject | [optional] 
**UserId** | **Guid** | User ID | 
**InboxId** | **Guid** | Inbox ID | 
**To** | **List&lt;string&gt;** | To recipients | 
**Bcc** | **List&lt;string&gt;** | BCC recipients | [optional] 
**Cc** | **List&lt;string&gt;** | CC recipients | [optional] 
**CreatedAt** | **DateTime** | Created at DateTime | 
**UpdatedAt** | **DateTime** | Updated at DateTime | 
**AliasId** | **Guid** | Alias ID | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

