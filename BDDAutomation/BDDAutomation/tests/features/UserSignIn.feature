Feature: UserSignIn
	Users want to manage their account

@basic
Scenario: User Login
	Given I am on the automationpractice home page
	When I click on the Sign In Button
	And I provide my email and password to login
	Then I should be redirected to my account page
