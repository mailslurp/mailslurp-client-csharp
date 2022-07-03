# mailslurp.Model.PageSentEmailWithQueueProjection
Paginated sent email results for emails sent with queue. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full sent email entity use the projection ID with individual method calls.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;SendWithQueueResult&gt;**](SendWithQueueResult) | Collection of items | 
**Pageable** | [**PageableObject**](PageableObject) |  | [optional] 
**Total** | **long** |  | [optional] 
**Size** | **int** | Size of page requested | 
**Number** | **int** | Page number starting at 0 | 
**NumberOfElements** | **int** | Number of items returned | 
**TotalPages** | **int** | Total number of pages available | 
**TotalElements** | **long** | Total number of items available for querying | 
**Last** | **bool** |  | [optional] 
**Sort** | [**Sort**](Sort) |  | [optional] 
**First** | **bool** |  | [optional] 
**Empty** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

