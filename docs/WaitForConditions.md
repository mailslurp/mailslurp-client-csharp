
# mailslurp.Model.WaitForConditions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | Number of results that should match conditions | [optional] 
**CountType** | **string** | Should exactly count number of results be returned or at least that many. | [optional] 
**InboxId** | **Guid** | Inbox to search within | [optional] 
**Matches** | [**List&lt;MatchOption&gt;**](MatchOption.md) | Conditions that should be matched | [optional] 
**SortDirection** | **string** | Direction to sort matching emails by created time | [optional] 
**Timeout** | **long** | Max time in milliseconds to wait until conditions are met | [optional] 
**UnreadOnly** | **bool** | Apply only to unread emails | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

