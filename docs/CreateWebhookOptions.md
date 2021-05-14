# mailslurp.Model.CreateWebhookOptions
Options for creating a webhook. Webhooks can be attached to inboxes and MailSlurp will POST a webhook payload to the URL specified whenever the inbox receives an email. Webhooks are great for processing many inbound emails.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BasicAuth** | [**BasicAuthOptions**](BasicAuthOptions) |  | [optional] 
**EventName** | **string** | Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60;. Payload differ according to the webhook event name. | [optional] 
**Name** | **string** | Optional name for the webhook | [optional] 
**Url** | **string** | Public URL on your server that MailSlurp can post WebhookNotification payload to when an email is received. The payload of the submitted JSON is described by https://api.mailslurp.com/schemas/webhook-payload | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

