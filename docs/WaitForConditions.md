# mailslurp.Model.WaitForConditions
Conditions to apply to emails that you are waiting for
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InboxId** | **Guid** |  | [optional] 
**Count** | **int** | Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation. | [optional] 
**DelayTimeout** | **long** | Max time in milliseconds to wait between retries if a &#x60;timeout&#x60; is specified. | [optional] 
**Timeout** | **long** | Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met. | 
**UnreadOnly** | **bool** | Apply conditions only to **unread** emails. All emails begin with &#x60;read&#x3D;false&#x60;. An email is marked &#x60;read&#x3D;true&#x60; when an &#x60;EmailDto&#x60; representation of it has been returned to the user at least once. For example you have called &#x60;getEmail&#x60; or &#x60;waitForLatestEmail&#x60; etc., or you have viewed the email in the dashboard. | [optional] 
**CountType** | **string** | How result size should be compared with the expected size. Exactly or at-least matching result? | [optional] 
**Matches** | [**List&lt;MatchOption&gt;**](MatchOption) |  | [optional] 
**SortDirection** | **string** |  | [optional] 
**Since** | **DateTime** |  | [optional] 
**Before** | **DateTime** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

