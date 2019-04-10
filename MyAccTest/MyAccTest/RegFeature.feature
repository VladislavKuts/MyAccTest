Feature: Registration page
	In order to use maximarkets
	As a new user
	I want to create my account

Background: 
	Given My account registration page  opened


Scenario: Create account with valid data
	When I enter 'unique email' in e-mail field
	And I enter 'qwerty12345' in password field
	And I enter 'qwerty12345' in confirm-password field
	And I click Send button
	Then Personal page opened

Scenario: Go to authorization page
	When I click on link Sign In
	Then Authorization page opened

Scenario Outline: Create account with invalid or empty email
	When I enter '<email>' in e-mail field
	And I enter '<password>' in password field
	And I enter '<password>' in confirm-password field
	And I click Send button
	Then Error '<message>' showed under email-field
Examples:
	| email       | password    | message           |
	| qwe@@qwe.qe | qwerty12345 | Email is invalid  |
	|             | qwerty123   | Email is required |
