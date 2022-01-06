# mailslurp.Model.PageEmailPreview
Paginated email preview results. EmailProjections and EmailPreviews are essentially the same but have legacy naming issues. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls. For emails there are several methods for fetching message bodies and attachments.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;EmailPreview&gt;**](EmailPreview) |  | [optional] 
**Pageable** | [**Pageable**](Pageable) |  | [optional] 
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

