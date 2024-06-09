@HomePage
Feature: HomePage
This test 

Background: 
	Given I navigate to Home page 

Scenario Outline: Validate Social Networks shortcuts 
When I am on the Home Page
And I scroll the to footer
Then I Should see Social Network Grid is displayed


Scenario: Validate headers main sections
When I am on the Home Page
Then I should see the main section grid is displayed

