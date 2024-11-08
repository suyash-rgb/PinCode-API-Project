# Postal Probe

## Description
**Postal Probe** is a robust and efficient API designed to provide detailed postal information. Developed using ASP .NET MVC Core and C#, this project aims to deliver rapid responses and a seamless user experience compared to its earlier version built with Google Apps Script.

## Table of Contents
- [Prerequisites](#prerequisites)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Development Journey](#development-journey)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites
- .NET 5.0 SDK or later
- Visual Studio or any other C# IDE
- Postman for API testing

## Usage
Provide examples of how to use the API and any necessary authentication.

```sh
# Example request to fetch pincode details
GET https://localhost:44337/api/Pincode/{pincode}

## Endpoints

### 1. Get All Pincodes
- **Method**: GET
- **cURL**: 
  ```sh
  curl https://localhost:44337/api/Pincode/all
