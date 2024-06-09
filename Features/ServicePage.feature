@ServicePage
Feature: ServicePage


Background: 
	Given I navigate to Service Page

Scenario Outline: Validate main screen sections
When I am on the Service Page
Then I Should see the main screen sections
