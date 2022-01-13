Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 2
	When the two numbers are multiply
	Then the result should be 10

Scenario: Divide two numbers
	Given the first number is 10
	And the second number is 2
	When the two numbers are divised
	Then the result should be 5

Scenario: Add multiples numbers
	Given all numbers is "3,4,3"
	When the multiple numbers are added
	Then the result should be 10

Scenario: Multiply multiples numbers
	Given all numbers is "1,5,2"
	When the multiple numbers are multiply
	Then the result should be 10
