# ITM Design Patterns

## Teamwork  ![favicon-16x16](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/a5830010-162b-48ce-8d79-c88b2a11000e)
- Diego Alejandro Arenas Tangarife.
- Diana Milena García Galarza.

### First Delivery
#### *Pattern:* Factory Method
#### *Scenario:* The ReserApp notifications module requires sending notifications of reservation management and incoming packages through different ways of notification such as WhatsApp, Email and Push
#### *Problem:* Each notification way has a different implementation, for example, WhatsApp must consume the Meta's API for WhatsApp, Email requires access to the SMTP server and Push requires connection to a third party service such as Firebase
#### *Class Diagram*
![Tarea1_Patrones-Factory Method](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/76e1b85a-7a64-4db6-8b34-2653b88c48c8)

-------------

#### *Pattern:* Builder
#### *Scenario:* A hamburger restaurant released a menu with two types of burgers, Traditional and Vegetarian, however, added the option to allow the customer can create his own burger by adding the ingredients of his choice. Note: When customizing the burger, an additional 10% of the cost of the ingredient is applied
#### *Problem:* The customer decides to create a new custom hamburger
#### *Class Diagram*
![Tarea1_Patrones-Builder_Burger](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/d22f50af-cf3b-4ffa-9d0e-8a9ad6435a01)
