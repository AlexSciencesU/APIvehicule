Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Background: 
	Given following existing clients
	| Username | Password |
	| JLouis   | toto     |

Scenario: Client connection - Username not recognized
	Given my username is "Jean-Louis"
	And my password is "toto"
	When I try to connect to my account
	Then the connection is refused
	And the error message is "Username not recognized"


Scenario: Client connection - Username recognized
	Given my username is "JLouis"
	And my password is "toto"
	When I try to connect to my account
	Then the connection is accepted
	And the connection is established

Scenario: Client connection - Username recognized but incorrect password
	Given my username is "JLouis"
	And my password is "toto111"
	When I try to connect to my account
	Then the connection is refused
	And the error message is "Incorrect password"

Scenario: Client reservation - Start date / End date
	Given Start date is "01/01/2021"
	And End date is "01/01/2022"
	When I make a reservation
	Then the success message is "Reservation accepted"
