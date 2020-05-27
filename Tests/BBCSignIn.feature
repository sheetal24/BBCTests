Feature: BBCSignIn
	In order to login in BBC
	As a user
	I want to be able to validate login details 

@BBCSignIn
Scenario: Sign in to BBC
	Given I navigate to BBC
	When I click signin
	And I login with valid user details 
	Then I see login is succesful 
