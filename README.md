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

## **EndPoints**

1. **Get All Pincodes**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/all`
   - **Description:** List all the pincodes available in the database
   - **Response:**

2. **Search by Pincode**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/{{pincode}}`
   - **Description:**
     - Returns an error message if no rows contain the pincode.
     - Returns the entire row as a JSON object if a single row matches the pincode.
     - Returns an array of office names if multiple rows match the pincode.
   - **Response:**
     - **Single Matches:**
     - **Multiple Matches:**

3. **Search by District**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/search/district/{{district}}`
   - **Description:**
     - Returns an error message if no rows match the district.
     - Returns an array of objects with "Office Name", "Pincode", and "Delivery" values if rows match the district.
   - **Response:**

4. **Search by Office Name**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/search/officename/{{officeName}}`
   - **Description:**
     - Returns an error message if no rows match the office name.
     - Returns the "Pincode" and "Delivery" values if a single row matches the office name.
     - Returns an array of objects with "Circle Name", "Division Name", "Pincode", "District", and "StateName" values if multiple rows match the office name.
   - **Response:**
     - **Single Match:**
     - **Multiple Matches:**

5. **Delivery Status for Pincode**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/pincode/{{pincode}}`
   - **Description:**
     - Returns the "Delivery" value as a message (e.g. "Delivery is available" for ‘true’ and "Delivery is not available" for ‘false’) if a single record matches the pincode.
     - Returns an array of objects with "Office Name" and "Delivery" values if multiple records match the pincode.
   - **Response:**
     - **Single Match:**
     - **Multiple Matches:**

6. **Delivery Status for Office Name**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/officename/{{officeName}}`
   - **Response:**

7. **Delivery Status for Primary Key**
   - **Method:** GET
   - **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`
   - **Description:** User provides the complete composite primary key in the request and receives the delivery status in the response.
   - **Response:**

8. **Add Pincode Record**
   - **Method:** POST
   - **cURL:** `https://localhost:44337/api/Pincode/add`
   - **Description:** Add a new pincode record (Basic Authentication Required)
   - **Response:**
     - **Authorised User:** "Pincode added successfully"
     - **Unauthorized User:** “You need to provide valid credentials to access this resource.”

9. **Update Pincode Details**
   - **Method:** PUT
   - **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`
   - **Description:** All details of the pincode record can be updated except for the pincode. (Basic Auth Required)
   - **Response:**
     - **Authorised User:** "Pincode details updated successfully"
     - **Unauthorized User:** “You need to provide valid credentials to access this resource.”

10. **Delete Pincode Record**
    - **Method:** DELETE
    - **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`
    - **Description:** Delete an existing Pincode record.
    - **Response:**
      - **Authorised User:** "Pincode deleted successfully"
      - **Unauthorized User:** “You need to provide valid credentials to access this resource.”

11. **Offices In a District**
    - **Method:** GET
    - **cURL:** `https://localhost:44337/api/Pincode/officetype/district/{{district}}/{{officeType}}`
