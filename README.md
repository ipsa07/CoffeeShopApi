# Summary of RestFul API

## Coffee Shop API:

The system is a RESTFul API for coffee shop application. 

###### Technical stack:

 * ASP.net CORE Web API
 
 * SQL Server
 
 * Postman for testing api's
 
 ###### Actors:
 **Users** : Users can see the coffee shop menu with available products and sub products (if any). Upon selection, user can place an order.
 
 ###### Requirements:

1. **GetMenu** : User sees the menu with all the available products with details.
2. **Order** : Submits order for a particular product or sub-products(if selected) to the coffee shop.

###### Features :

 * created a Rest Api via Entity Framework Code First Approach with all the advanced functions.
 
 * Implemented Status Codes
 
    * 200 Ok
    
    * 201 Created
    
    * 204 No Content
    
    * 400 Bad Request
    
    * 401 Unauthorized
    
    * 404 Not Found
 
 * Adding Migrations in Web Api's
 
 * Added Content Negotiation and implemented Validation in Web Api’s

 * Implemented Authentication and Authorization and secured Api with JWT
 
 * Setup Auth0 and added cache inside the Api.
