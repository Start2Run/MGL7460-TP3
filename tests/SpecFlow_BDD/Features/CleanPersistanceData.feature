Feature: CleanPersistanceData

@mytag
Scenario: Clean persistence storage
	Given a database name is configured in the application configuration file 
	When a query is created to celan the DB
	Then all the existing peristed temperature data should be deleted from the DB