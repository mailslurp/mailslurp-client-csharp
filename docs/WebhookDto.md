
# mailslurp.Model.WebhookDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BasicAuth** | **bool** | Does webhook expect basic authentication? If true it means you created this webhook with a username and password. MailSlurp will use these in the URL to authenticate itself. | [optional] 
**CreatedAt** | **DateTime** | When the webhook was created | [optional] 
**Id** | **Guid** | ID of the Webhook | [optional] 
**InboxId** | **Guid** | The inbox that the Webhook will be triggered by | [optional] 
**Method** | **string** | HTTP method that your server endpoint must listen for | [optional] 
**Name** | **string** | Name of the webhook | [optional] 
**PayloadJsonSchema** | **string** | JSON Schema for the payload that will be sent to your URL via the HTTP method described. | [optional] 
**UpdatedAt** | **DateTime** |  | 
**Url** | **string** | URL of your server that the webhook will be sent to. The schema of the JSON that is sent is described by the payloadJsonSchema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

