Feature: People can be returned.

Scenario: Get a list of people
	Given A specflow controller is created
	When the GetPeople method is invoked
	Then the following people are returned
		| PersonId | FirstName | LastName   | EmailAddress        |
		| 1        | Danny     | Stephens   | danny@company.org   |
		| 2        | Emily     | Stone      | emily@company.org   |
		| 3        | Joe       | Fredericks | joe@company.org     |
		| 4        | Alice     | Cross      | alice@company.org   |
		| 5        | Michael   | Black      | michael@company.org |
