# mailslurp.Model.WebhookPayload
MailSlurp webhook payload schema. This schema describes the JSON object that is sent via HTTP POST to webhook urls when an email is received by an inbox that a webhook is attached to. Payloads may be delivered multiple times so use the ID as a key for event uniqueness. The payload contains IDs for the email and inbox affected. Use these to fetch more data related to the event using appropriate inbox and email endpoints. See https://www.mailslurp.com/guides/email-webhooks/ for more information. Your webhook endpoint should accept POST HTTP request and return a 200 in under 30 seconds. Process the webhook asynchronously if you need to.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttachmentMetaDatas** | [**List&lt;AttachmentMetaData&gt;**](AttachmentMetaData) | List of attachment meta data objects if attachments present | [optional] 
**Bcc** | **List&lt;string&gt;** | List of &#x60;BCC&#x60; recipients email was addressed to | [optional] 
**Cc** | **List&lt;string&gt;** | List of &#x60;CC&#x60; recipients email was addressed to | [optional] 
**CreatedAt** | **DateTime** | Date time of event creation | [optional] 
**EmailId** | **Guid** | ID of the email that was received. Use this ID for fetching the email | [optional] 
**EventName** | **string** | Name of the event type webhook is being triggered for | [optional] 
**From** | **string** | Who the email was sent from | [optional] 
**InboxId** | **Guid** | Id of the inbox that receive an email | [optional] 
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | [optional] 
**Subject** | **string** | The subject line of the email message | [optional] 
**To** | **List&lt;string&gt;** | List of &#x60;To&#x60; recipients email was addressed to | [optional] 
**WebhookId** | **Guid** | ID of webhook entity being triggered | [optional] 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

