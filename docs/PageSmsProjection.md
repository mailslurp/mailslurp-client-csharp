# mailslurp.Model.PageSmsProjection
Paginated SMS messages. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;SmsProjection&gt;**](SmsProjection) |  | [optional] 
**Pageable** | [**PageableObject**](PageableObject) |  | [optional] 
**Total** | **long** |  | [optional] 
**Last** | **bool** |  | [optional] 
**TotalPages** | **int** |  | [optional] 
**TotalElements** | **long** |  | [optional] 
**Size** | **int** |  | [optional] 
**Number** | **int** |  | [optional] 
**Sort** | [**Sort**](Sort) |  | [optional] 
**First** | **bool** |  | [optional] 
**NumberOfElements** | **int** |  | [optional] 
**Empty** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)
