Feature: HeaderLinks
	In order to view Header pages
	As a user
	I want to be able to click on those links 

@HeaderLinks 
Scenario Outline: Check Header Pages load
	Given I navigate to BBC
	When I click on <headerlinks> 
	Then I see the <headerlinks> pages 
Examples: 
| headerlinks |
| News        |
| Sport       |
| Weather	  |