# mailslurp.Model.WebhookDeliveryStatusPayload
DELIVERY_STATUS webhook payload. Sent to your webhook url endpoint via HTTP POST when an email delivery status is created. This could be a successful delivery or a delivery failure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**Id** | **Guid** | ID of delivery status | 
**UserId** | **Guid** | User ID of event | 
**SentId** | **Guid?** | ID of sent email | [optional] 
**RemoteMtaIp** | **string** | IP address of the remote Mail Transfer Agent | [optional] 
**InboxId** | **Guid?** | Id of the inbox | [optional] 
**ReportingMta** | **string** | Mail Transfer Agent reporting delivery status | [optional] 
**Recipients** | **List&lt;string&gt;** | Recipients for delivery | [optional] 
**SmtpResponse** | **string** | SMTP server response message | [optional] 
**SmtpStatusCode** | **int?** | SMTP server status | [optional] 
**ProcessingTimeMillis** | **long?** | Time in milliseconds for delivery processing | [optional] 
**Received** | **DateTime?** | Time event was received | [optional] 
**Subject** | **string** | Email subject | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

