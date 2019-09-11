# mailslurp.Model.MatchOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The email property to match on. One of SUBJECT, TO, BCC, CC or FROM | [optional] 
**Should** | **string** | What criteria to apply. CONTAIN or EQUAL. Note CONTAIN is recommended due to some SMTP servers adding new lines | [optional] 
**Value** | **string** | The value to compare to the field using EQUAL or CONTAIN | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

