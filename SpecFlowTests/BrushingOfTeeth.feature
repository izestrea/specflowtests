Feature: Brushing Of Teeth
 
Scenario: Successful brushing
	Given there is 1 gram of Brand X toothpaste on the brush
	And the month is open
	When the back teeth are brushed
	And the from teeth are brushed
	Then the teeth look clean
	And the month feels fresh
	But the braces aren't damaged
