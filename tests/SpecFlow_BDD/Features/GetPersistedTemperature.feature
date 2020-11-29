Feature: GetPersistedTemperature
@mytag
Scenario: Get the temperature from the persistence storage
	Given a database name is configured in the application configuration file 
	When a query is created to recuperate all the persisted temperature data
	Then all the existing persisted temperature data should be returned