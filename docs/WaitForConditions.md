# mailslurp.Model.WaitForConditions
Conditions that a `waitForXEmails` endpoint operates on. The methods wait until given conditions are met or a timeout is reached. If the conditions are met without needing to wait the results will be returned immediately. Can include `unreadOnly` to ignore already read emails that were returned in an API call or viewing in the dashboard. Can also include matches for emails containing `from`, `subject`, `hasAttachments` etc.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation. | [optional] 
**CountType** | **string** | How should the found count be compared to the expected count. | [optional] 
**InboxId** | **Guid** | ID of inbox to search within and apply conditions to. Essentially filtering the emails found to give a count. | [optional] 
**Matches** | [**List&lt;MatchOption&gt;**](MatchOption) | Conditions that should be matched for an email to qualify for results. Each condition will be applied in order to each email within an inbox to filter a result list of matching emails you are waiting for. | [optional] 
**SortDirection** | **string** | Direction to sort matching emails by created time | [optional] 
**Timeout** | **long** | Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met. | [optional] 
**UnreadOnly** | **bool** | Apply conditions only to **unread** emails. All emails begin with &#x60;read&#x3D;false&#x60;. An email is marked &#x60;read&#x3D;true&#x60; when an &#x60;EmailDto&#x60; representation of it has been returned to the user at least once. For example you have called &#x60;getEmail&#x60; or &#x60;waitForLatestEmail&#x60; etc., or you have viewed the email in the dashboard.  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

