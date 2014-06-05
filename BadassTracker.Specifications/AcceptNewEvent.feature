Feature: CreateNewEvent
	In order to track an event
	As a quantified induvidual
	I want to key my event and save it

Scenario: Track Sickness Episode
	Given I am Creating a Sickness Episode Event
	When I press add
	Then My Sickness Episode should be tracked
