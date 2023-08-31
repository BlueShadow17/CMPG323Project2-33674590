# CMPG323Project2-33674590
# Table of Contents
 -[Introduction](#Introduction)
 
 -[Prerequisites](#prerequisites)
 
 -[Installation](#installation)
 
 -[Usage](#usage)
 
-[Endpoints](#endpoints)
    - [GET All Customers](#get-all-customers)
    - [GET Customer by ID](#get-customer-by-id)
    - [GET Orders by Customer ID](#get-orders-by-customer-id)
    - [POST Create Customer](#post-create-customer)
    - [POST Create Order](#post-create-order)

-[Refrence List](#Refrence)
    
## Introduction
API project for CMPG 323
This API gets data from a datbase that is hosted on Azure, and uses that data to show Customers, Orders, OrderDetails and Products on the web throught the use of the API I made using visual studio. This is mainly backend. The link to the API is below.
This link will not show a page because there is no rooting for it to go to. Use the Swagger portal that has the swagger rooting.

https://project-2api.azurewebsites.net/

The swagger portal is below:

https://project-2api.azurewebsites.net/swagger/index.htmls

## Prerequisites

List any prerequisites that users need to have installed before they can use your API. For example:
-Download packages from NuGet packages
1. Microsoft.EntityFrameworkCore  V 6.0.21
2. Microsoft.EntityFrameworkCore.Design V 6.0.21
3. Microsoft.EntityFrameworkCore.SqlServe V 6.0.21
4. Microsoft.EntityFrameworkCore.Tools V 6.0.21

-These where the packages i had to install to scaffold the controllers and make the models.

## Installation

Provide step-by-step instructions for users to install and set up your API. This could include:

1. Clone this repository.
2. Open the solution in visual studio.
3. Configure your database connection string (see below).
4. Build the solution.
5. Run the application.

## Configure Database Connection String
Explain how users should configure their database connection string. They might need to create an `appsettings.json` or set environment variables.

## Usage
  Using the endpoint you will be able to see each root and path for the methods that was implemented to show how the database data is used for the API. See endpoints below:
## Endpoints
1. Customers
   
   -GET: /api/Customers
   
   -POST: /api/Customers

   -GET: /api/Customers/{id}

   -PUT: /api/Customers/{id}

   -DELETE: /api/Customers/{id}

3.OrderDetails
   
   -GET: /api/OrderDetails
   
   -POST: /api/OrderDetails
   
   -GET: /api/OrderDetails/{id}
   
   -PUT: /api/OrderDetails/{id}
   
   -DELETE: /api/OrderDetails/{id}

5. Orders

   -GET: /api/Orders

   -POST: /api/Orders

   -GET: /api/Orders/{id}

   -PUT: /api/Orders/{id}

   -DELETE: /api/Orders/{id}

7. Products

   -GET: /api/Products

   -POST: /api/Products

   -GET: /api/Products/{id}

   -PUT: /api/Products/{id}

   -DELETE: /api/Products/{id}

## Refrence List



