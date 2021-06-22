# mailslurp.Model.PageSentEmailProjection
Paginated sent email results. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full sent email entity use the projection ID with individual method calls.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;SentEmailProjection&gt;**](SentEmailProjection) | Collection of items | [optional] 
**Empty** | **bool** |  | [optional] 
**First** | **bool** |  | [optional] 
**Last** | **bool** |  | [optional] 
**Number** | **int** | Page number starting at 0 | [optional] 
**NumberOfElements** | **int** | Number of items returned | [optional] 
**Pageable** | [**Pageable**](Pageable) |  | [optional] 
**Size** | **int** | Size of page requested | [optional] 
**Sort** | [**Sort**](Sort) |  | [optional] 
**TotalElements** | **long** | Total number of items available for querying | [optional] 
**TotalPages** | **int** | Total number of pages available | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

