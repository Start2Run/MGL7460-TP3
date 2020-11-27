Feature: RequestTemperatureModelPersistence
@mytag
Scenario: Get the temperature from the REST API endpoint and save it to persistance storage
	Given a valid endpoint address and database name are configured in the application configuration file 
	When the request is sent with success to the endpoint address
	Then a temperature data model should be pesisted into the DB

Scenario: Nothing should be savd into the persistance storage if the request fails
	Given a valid endpoint address and database name are configured in the application configuration file 
	When the request fails to be sent the endpoint address
	Then nothing should be pesisted into the DB