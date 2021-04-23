# mailslurp.Model.PageEmailPreview
Paginated email preview results. EmailProjections and EmailPreviews are essentially the same but have legacy naming issues. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls. For emails there are several methods for fetching message bodies and attachments.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;EmailPreview&gt;**](EmailPreview) |  | [optional] 
**Empty** | **bool** |  | [optional] 
**First** | **bool** |  | [optional] 
**Last** | **bool** |  | [optional] 
**Number** | **int** |  | [optional] 
**NumberOfElements** | **int** |  | [optional] 
**Pageable** | [**Pageable**](Pageable) |  | [optional] 
**Size** | **int** |  | [optional] 
**Sort** | [**Sort**](Sort) |  | [optional] 
**TotalElements** | **long** |  | [optional] 
**TotalPages** | **int** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

