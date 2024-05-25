# ITM Design Patterns  ![favicon-32x32](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/b987e36b-5ca4-46c7-96ba-8602caaee562)

## Teamwork
- Diego Alejandro Arenas Tangarife.
- Diana Milena García Galarza.


### *Pattern:* Factory Method
#### *Scenario:* The ReserApp notifications module requires sending notifications of reservation management and incoming packages through different ways of notification such as WhatsApp, Email and Push
#### *Problem:* Each notification way has a different implementation, for example, WhatsApp must consume the Meta's API for WhatsApp, Email requires access to the SMTP server and Push requires connection to a third party service such as Firebase
#### *Class Diagram*
![Tarea1_Patrones-Factory Method](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/422aa9df-8f8a-4b7f-97d2-cee81a489bb2)


-------------

### *Pattern:* Builder
#### *Scenario:* A hamburger restaurant released a menu with two types of burgers, Traditional and Vegetarian, however, added the option to allow the customer can create his own burger by adding the ingredients of his choice. Note: When customizing the burger, an additional 10% of the cost of the ingredient is applied
#### *Problem:* The customer decides to create a new custom hamburger
#### *Class Diagram*
![Tarea1_Patrones-Builder_Burger](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/659ffae6-3c76-4177-8415-4db73eea9aba)


-------------

### *Pattern:* Proxy
#### *Scenario:* ReserApp exposes the Common Area service via API
#### *Problem:* The service takes about 3 seconds to respond per request and the user perceives the application as slow
#### *Class Diagram*
![Tarea1_Patrones-Proxy-Cache](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/cb3a9b3d-1113-4c73-825d-6f5c351024f7)


-------------

### *Pattern:* Adapter
#### *Scenario:* ReserApp is using a free reporting library that will deprecated during the second half of 2024, and this must be replaced by a new paid library that will provide support for as long as its license is paid
#### *Problem:* There are currently 35 reports that should not be affected in the migration process to the new library
#### *Class Diagram*
![Tarea1_Patrones-Adapter](https://github.com/dtarenas/ITM.DesignPatterns/assets/42014718/c9042d2d-6571-43f4-8723-405be3a3faa7)


