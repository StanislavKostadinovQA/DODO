@ContactPage
Feature: ContactPage
This test 

Background:
Given I open the Contact Page
	

Scenario Outline: Contact Page Subscription for newslater
	When I am on the Contact Page
	And I fullfill the form with my '<firstname>' , '<lastname>' , '<company>' and '<email>'
	And I click the Term of Use cehckbox in Contact Page
	And Confirm the subscribtion
	Then I should see a success message

Examples: 
| firstname | lastname | company | email |
|  Johny    |   Doe       |   Apple      |  Stan22@gmail.com     |

