Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Background: 
	Given following existing clients
	| Username		| Password		| BirthDate  |
	| JLouisVieux   | totoVieux     | 05/05/1998 |
	| JLouis		| toto			| 05/05/2002 |
	| JLouisMineur  | totoMineur    | 05/05/2010 |
	Given following existing vehicules
	| Immat       | ChevauxFisc |	PrixReservation | TarifKil	   |
	| BZ2-H67-KKL |     7       |	950				|     0.3      |
	| AAA-444-PPP |     15      |	4000			|     0.9      |
	| QQQ-HGH-9KO |     10      |	2000			|     0.5      |

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


Scenario: Client connection - Client under 18 years old
	Given my username is "JLouisMineur"
	And Start date is "01/01/2021"
	And End date is "01/01/2022"
	Given Client choose immatriculation "AAA-444-PPP"
	When I make a reservation
	Then the success message is "Client can't reserve because he is minor"

Scenario: Client connection - Client under 21 years old
	Given my username is "JLouis"
	And Start date is "01/01/2021"
	And End date is "01/01/2022"
	Given Client choose immatriculation "AAA-444-PPP"
	When I make a reservation
	Then the success message is "Client can't reserve this car because he is too young (-21)"

Scenario: Client connection - Client under 25 years old
	Given my username is "JLouisVieux"
	And Start date is "01/01/2021"
	And End date is "01/01/2022"
	Given Client choose immatriculation "AAA-444-PPP"
	When I make a reservation
	Then the success message is "Client can't reserve this car because he is too young (-25)"

Scenario: Client reservation - Correct Location
	Given my username is "JLouis"
	And Kilometer's number planned is "500"
	And Start date is "01/01/2021"
	And End date is "01/01/2022"
	And End date is "01/01/2022"
	Given Client choose immatriculation "BZ2-H67-KKL"
	When I make a reservation
	Then the success message is "JLouis : Reservation accepted for BZ2-H67-KKL vehicule from 01/01/2021 to 01/01/2022 and it will cost 1100€"

