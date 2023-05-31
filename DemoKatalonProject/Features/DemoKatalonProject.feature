Feature: DemoKatalonProject

As a user , i should be able to cart random four items , view my cart , search for lowest 
price and able to remove the lowest pice item in my cart and i should be able to verify 
three item in my cart.


@tag1
Scenario: AssertShoppingCarts
	Given I Navigate to "https://cms.demo.katalon.com/"
	And I Click on Add Cart on my first choice 
	And I Click on Add Cart on my second choice 
	And I Click on Add Cart on my third choice 
	And I Click on Add cart on my fourth choice
	And I Click on Cart Button
	When I Remove the Lowest Price Item from my cart
	Then I Should be able to verify three itemin my cart 
