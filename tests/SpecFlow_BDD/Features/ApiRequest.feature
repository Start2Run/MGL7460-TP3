Feature: ApiRequest
![REST_API]
	In order to monitor the outside temperature
	I *want* to automatically get the **temperature** from a ***REST API endpoint***

Link to a feature: [REST_API](SpecFlow-BDD/Features/Rest_Api.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: GET Api request should return the expected JSON data model
	Given a valid endpoint address is configured in the application configuration file 
	When the request is sent to a Rest Api endpoint
	Then the returned body data should have the format JSON data model

@mytag
Scenario: GET Api request should fail when the incorrect endpoint address is called
	Given a valid endpoint address is configured in the application configuration file 
	When the request is sent to a Rest Api endpoint
	And the enpoint address is no the same as the one from the configuration file
	Then the request should faild and return a null model

@mytag
Scenario: GET Api request should fail and return null model when the request timeout
	Given a valid endpoint address is configured in the application configuration file 
	When the request is sent to a Rest Api endpoint
	And the request timeout
	Then the request should faild and return a null model