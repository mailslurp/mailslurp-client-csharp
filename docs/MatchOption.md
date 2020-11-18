# mailslurp.Model.MatchOption
Options for matching emails in an inbox. Each match option object contains a `field`, `should` and `value` property. Together they form logical conditions such as `SUBJECT` should `CONTAIN` value.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The email property to match on. One of SUBJECT, TO, BCC, CC or FROM | [optional] 
**Should** | **string** | What criteria to apply. CONTAIN or EQUAL. Note CONTAIN is recommended due to some SMTP servers adding new lines to fields and body content. | [optional] 
**Value** | **string** | The value you wish to compare with the value of the field specified using the &#x60;should&#x60; value passed. For example &#x60;BODY&#x60; should &#x60;CONTAIN&#x60; a value passed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

