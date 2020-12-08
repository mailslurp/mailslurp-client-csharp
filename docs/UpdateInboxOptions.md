# mailslurp.Model.UpdateInboxOptions
Options for updating inbox properties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Optional description of an inbox for labelling purposes | [optional] 
**ExpiresAt** | **DateTime** | When, if ever, will the inbox expire and be deleted. If null then this inbox is permanent and the emails in it won&#39;t be deleted. Timestamp passed as string. | [optional] 
**Favourite** | **bool** | Is the inbox favorited. Favouriting inboxes is typically done in the dashboard for quick access | [optional] 
**Name** | **string** | Optional name of the inbox. Displayed in the dashboard for easier search | [optional] 
**Tags** | **List&lt;string&gt;** | Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

