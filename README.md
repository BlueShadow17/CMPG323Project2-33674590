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

[Link](https://project-2api.azurewebsites.net/)

The swagger portal is below:

[link](https://project-2api.azurewebsites.net/swagger/index.htmls)

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

2.OrderDetails
   
   -GET: /api/OrderDetails
   
   -POST: /api/OrderDetails
   
   -GET: /api/OrderDetails/{id}
   
   -PUT: /api/OrderDetails/{id}
   
   -DELETE: /api/OrderDetails/{id}

3. Orders

   -GET: /api/Orders

   -POST: /api/Orders

   -GET: /api/Orders/{id}

   -PUT: /api/Orders/{id}

   -DELETE: /api/Orders/{id}

4. Products

   -GET: /api/Products

   -POST: /api/Products

   -GET: /api/Products/{id}

   -PUT: /api/Products/{id}

   -DELETE: /api/Products/{id}

## Refrence List
The resourses used in the project:
From the word doc provided
  1. Microsoft. (2023). Tutorial: Create a web API with ASP.NET Core. [Link]([https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-6.0](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio))
  2. Microsoft. (2023). Create a web API with ASP.NET Core controllers - Learn. [Link](https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/)
  3. Microsoft. (2022). ASP.NET Core web API documentation with Swagger / OpenAPI. [Link]([https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-6.0](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1))
  4. Microsoft. (2023). Entity Framework Core 3.1 - Getting Started. [Link]([https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli](https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/)https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/)
  5. Microsoft. (2021). "Entity Framework Core Relationships - Joins and Navigation Properties." Microsoft Docs. [Link](https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/)
  6. Microsoft. (2023). "Publish an ASP.NET Core web API to Azure API Management with Visual Studio." Microsoft Docs. [Link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0)
  7. Automating ASP.NET Core Web API Creation That Communicates with Your Database in 60 Seconds or Less. (2020, August 10). TheJPanda. [link](https://thejpanda.com/2020/08/10/python-automating-asp-net-core-web-api-creation-that-communicates-with-your-database-in-60-seconds-or-less/)
  8. KunalKushwaha. (2022). "How to Understand Your API Quickly by Swagger" Youtube. [Link](https://www.youtube.com/watch?v=DndKwldJOlw)
  9. Microsoft. (2023). Get started with Azure. Microsoft Azure. [https://azure.microsoft.com/en-us/get-started/](https://azure.microsoft.com/en-us/get-started/)
  10. Microsoft (2023). Azure SQL Database documentation. [link](https://learn.microsoft.com/en-us/azure/azure-sql/?view=azuresql)


