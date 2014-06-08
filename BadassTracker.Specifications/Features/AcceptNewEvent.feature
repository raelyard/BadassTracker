Feature: CreateNewEvent
	In order to track an event
	As a quantified individual
	I want to key my event and save it

Scenario: Track Sickness Episode
	Given I am Creating a Sickness Episode Event
	When I press add
	Then My Sickness Episode should be tracked

Scenario: Track Sickness Episode With Explicit End Time
	Given I am Creating a Sickness Episode Event
	When I specify an End Time
	And I press add
	Then My Sickness Episode should be tracked
	And it should reflect my desired End Time

Scenario: Track Sickness Episode With Explicit Start Time
	Given I am Creating a Sickness Episode Event
	When I specify an Start Time
	And I press add
	Then My Sickness Episode should be tracked
	And it should reflect my desired Start Time
