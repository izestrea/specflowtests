Feature: Brushing Of Teeth
 
Scenario: Successful brushing
	Given I have the following tools:
	| ToolName | ToolQuality |
	| paste    | medium      |
	| brush    | high      |
	| water    | low      |
	And the month is open
	When the back teeth are brushed
	Then the teeth look clean
	And the month feels fresh
	But the braces aren't damaged
