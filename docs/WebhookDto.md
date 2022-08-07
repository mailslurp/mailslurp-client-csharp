# mailslurp.Model.WebhookDto
Representation of a webhook for an inbox. The URL specified will be using by MailSlurp whenever an email is received by the attached inbox. A webhook entity should have a URL that points to your server. Your server should accept HTTP/S POST requests and return a success 200. MailSlurp will retry your webhooks if they fail. See https://csharp.api.mailslurp.com/schemas/webhook-payload for the payload schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ID of the Webhook | 
**UserId** | **Guid** | User ID of the Webhook | 
**BasicAuth** | **bool** | Does webhook expect basic authentication? If true it means you created this webhook with a username and password. MailSlurp will use these in the URL to authenticate itself. | 
**Name** | **string** | Name of the webhook | [optional] 
**PhoneId** | **Guid?** | The phoneNumberId that the Webhook will be triggered by. If null then webhook triggered at account level or inbox level if inboxId set | [optional] 
**InboxId** | **Guid?** | The inbox that the Webhook will be triggered by. If null then webhook triggered at account level or phone level if phoneId set | [optional] 
**Url** | **string** | URL of your server that the webhook will be sent to. The schema of the JSON that is sent is described by the payloadJsonSchema. | 
**Method** | **string** | HTTP method that your server endpoint must listen for | 
**PayloadJsonSchema** | **string** | Deprecated. Fetch JSON Schema for webhook using the getJsonSchemaForWebhookPayload method | 
**CreatedAt** | **DateTime?** | When the webhook was created | 
**UpdatedAt** | **DateTime** |  | 
**EventName** | **string** | Webhook trigger event name | [optional] 
**RequestHeaders** | [**WebhookHeaders**](WebhookHeaders) |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

