Feature: AddDressToShoppingCart
	In order to add a dress to the shopping cart
	As a dress store user
	I want to view dresses in the dresses section and then choose one

@basic
Scenario: 01 Visualize the list of dresses
	Given that I'm in the homepage of the automationpractice home page
    When I click on the Dresses button to check the dresses
	And I get redirected to the dresses page
	Then I should visualize the list of dresses

@basic
Scenario: 02 Add dress to the shopping cart
	Given That I'm in the automation practice dresses page
	And I visualize the list of dresses available,
	When I decide to add a dress to the shopping cart by clicking on the add to cart button 
	Then I should see the dress added in the shopping cart