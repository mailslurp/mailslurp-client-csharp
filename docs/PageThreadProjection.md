# mailslurp.Model.PageThreadProjection
Paginated email projection results. EmailProjections and EmailPreviews are essentially the same but have legacy naming issues. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full email entity use the projection ID with individual method calls. For emails there are several methods for fetching message bodies and attachments.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;ThreadProjection&gt;**](ThreadProjection) |  | [optional] 
**Pageable** | [**Pageable**](Pageable) |  | [optional] 
**TotalElements** | **long** |  | [optional] 
**TotalPages** | **int** |  | [optional] 
**Last** | **bool** |  | [optional] 
**Size** | **int** |  | [optional] 
**Number** | **int** |  | [optional] 
**Sort** | [**Sort**](Sort) |  | [optional] 
**NumberOfElements** | **int** |  | [optional] 
**First** | **bool** |  | [optional] 
**Empty** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

