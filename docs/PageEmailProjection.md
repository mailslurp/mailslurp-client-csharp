# mailslurp.Model.PageEmailProjection
Paginated email projection results. EmailProjections and EmailPreviews are essentially the same but have legacy naming issues. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full email entity use the projection ID with individual method calls. For emails there are several methods for fetching message bodies and attachments.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;EmailProjection&gt;**](EmailProjection.md) |  | [optional] 
**Empty** | **bool** |  | [optional] 
**First** | **bool** |  | [optional] 
**Last** | **bool** |  | [optional] 
**Number** | **int** |  | [optional] 
**NumberOfElements** | **int** |  | [optional] 
**Pageable** | [**Pageable**](Pageable.md) |  | [optional] 
**Size** | **int** |  | [optional] 
**Sort** | [**Sort**](Sort.md) |  | [optional] 
**TotalElements** | **long** |  | [optional] 
**TotalPages** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

