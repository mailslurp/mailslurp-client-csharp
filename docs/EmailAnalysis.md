# mailslurp.Model.EmailAnalysis
Analysis result for email. Each verdict property is a string PASS|FAIL|GRAY or dynamic error message
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DkimVerdict** | **string** | Verdict of DomainKeys Identified Mail analysis | [optional] 
**DmarcVerdict** | **string** | Verdict of Domain-based Message Authentication Reporting and Conformance analysis | [optional] 
**SpamVerdict** | **string** | Verdict of spam ranking analysis | [optional] 
**SpfVerdict** | **string** | Verdict of Send Policy Framework record spoofing analysis | [optional] 
**VirusVerdict** | **string** | Verdict of virus scan analysis | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

