Feature: CustomerOrder
	As a customer shopping for T Shirts at Your Logo website 
	I want to be able sign in to my account to place order for one or more T Shirts
	Add to basket and proceed to checkout to make payment and then verify order has been placed

Scenario Outline: Place a T Shirt Order
	Given Customer is at Your Logo website and login to their account using <email> and <password> and clicks sign in
	And Arrives at their account page and clicks T Shirts Tab to search for T Shirts
	And Arrives at T Shirts store page and select product displayed
	And Arrives at the product page and add to cart
	And Arrives at order Summary page and clicks Proceed to checkout
	And Verifies billing address and clicks Proceed to checkout 
	And Agrees to terms and conditions of service and clicks Proceed to checkout
	When Customer arrives at Payment method page and clicks Pay by bank wire
	And Arrives at Payment page and clicks I confirm my order
	And Arrives at Order Confrimation page and click on Back to Orders 
	Then Customer should arrive at Order history page to verify their order and click Back to your Account

Examples: Customer login info
| email                | password  |
| Jason.anya@yahoo.com | Jason1985 |

Scenario Outline: Update customer first name
	When Customer selects My personal information tab
	And Arrives at their identity page
	Then Customer should be able to update their <firstname> validate with their <password> and click save

Examples: Customer personal details
| firstname   | password  |
| Jasonnp     | Jason1985 |