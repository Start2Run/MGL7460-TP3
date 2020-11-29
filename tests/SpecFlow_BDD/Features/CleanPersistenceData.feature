Feature: CleanPersistenceData

@mytag
Scenario: Clean persistence storage
	Given a database name is configured in the application configuration file 
	When a query is created to clean the DB
	Then all the existing persisted temperature data should be deleted from the DB