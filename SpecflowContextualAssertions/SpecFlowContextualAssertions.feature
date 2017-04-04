Feature: SpecFlowContextualAssertions


Scenario: All assertions pass
	Given passing assertion
	When passing assertion
	Then passing assertion

Scenario: Given assertion fails
	Given failling assertion
	When passing assertion
	Then passing assertion

Scenario: When assertion fails
	Given passing assertion
	When failling assertion
	Then passing assertion

Scenario: Then assertion fails
	Given passing assertion
	When passing assertion
	Then failling assertion