# mailslurp.Model.ReplyToEmailOptions
Options for replying to email with API
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** | List of uploaded attachments to send with the reply. Optional. | [optional] 
**Body** | **string** | Body of the reply email you want to send | [optional] 
**Charset** | **string** | The charset that your message should be sent with. Optional. Default is UTF-8 | [optional] 
**From** | **string** | The from header that should be used. Optional | [optional] 
**IsHTML** | **bool** | Is the reply HTML | [optional] 
**ReplyTo** | **string** | The replyTo header that should be used. Optional | [optional] 
**SendStrategy** | **string** | When to send the email. Typically immediately | [optional] 
**Template** | **Guid** | Template ID to use instead of body. Will use template variable map to fill defined variable slots. | [optional] 
**TemplateVariables** | [**Object**]() | Template variables if using a template | [optional] 
**UseInboxName** | **bool** | Optionally use inbox name as display name for sender email address | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

