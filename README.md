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
```

## EndPoints

1. **Get All Pincodes**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/all`  
   **Description:** List all the pincodes available in the database  
   **Response:**

2. **Search by Pincode**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/{{pincode}}`  
   **Description:**
     - Returns an error message if no rows contain the pincode.
     - Returns the entire row as a JSON object if a single row matches the pincode.
     - Returns an array of office names if multiple rows match the pincode.  
   **Response:** <br>
   **Single Matches:**  
   **Multiple Matches:**

3. **Search by District**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/search/district/{{district}}`  
   **Description:**
     - Returns an error message if no rows match the district.
     - Returns an array of objects with "Office Name", "Pincode", and "Delivery" values if rows match the district.  
   **Response:**

4. **Search by Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/search/officename/{{officeName}}`  
   **Description:**
     - Returns an error message if no rows match the office name.
     - Returns the "Pincode" and "Delivery" values if a single row matches the office name.
     - Returns an array of objects with "Circle Name", "Division Name", "Pincode", "District", and "StateName" values if multiple rows match the office name.  
   **Response:** <br>
   **Single Match:** <br>
   **Multiple Matches:**

5. **Delivery Status for Pincode**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/pincode/{{pincode}}`  
   **Description:**
     - Returns the "Delivery" value as a message (e.g., "Delivery is available" for `true` and "Delivery is not available" for `false`) if a single record matches the pincode.
     - Returns an array of objects with "Office Name" and "Delivery" values if multiple records match the pincode.  
   **Response:**  <br>
   **Single Match:**  
   **Multiple Matches:**

6. **Delivery Status for Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/officename/{{officeName}}`  
   **Response:**

7. **Delivery Status for Primary Key**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
   **Description:** User provides the complete composite primary key in the request and receives the delivery status in the response.  
   **Response:**

8. **Add Pincode Record**  
   **Method:** POST  
   **cURL:** `https://localhost:44337/api/Pincode/add`  
   **Description:** Add a new pincode record (Basic Authentication Required)  
   **Response:** <br>
     **Authorised User:** "Pincode added successfully"  
     **Unauthorized User:** "You need to provide valid credentials to access this resource."

9. **Update Pincode Details**  
   **Method:** PUT  
   **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
   **Description:** All details of the pincode record can be updated except for the pincode (Basic Auth Required)  
   **Response:** <br>
     **Authorised User:** "Pincode details updated successfully"  
     **Unauthorized User:** "You need to provide valid credentials to access this resource."

10. **Delete Pincode Record**  
    **Method:** DELETE  
    **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
    **Description:** Delete an existing Pincode record.  
    **Response:** <br>
      **Authorised User:** "Pincode deleted successfully"  
      **Unauthorized User:** "You need to provide valid credentials to access this resource."

11. **Offices In a District**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/district/{{district}}/{{officeType}}`  
   **Description:** Pass the District and Office Type values in the request and get a list of office names with the specific office type in the particular district.  
   **Response:** 
    

12. **Offices In a Division**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/division/{{divisionName}}/{{officeType}}`  
   **Description:** Pass the Division and Office Type values in the request and get a list of office names with the specific office type in the particular division.  
   **Response:** 
     

13. **Get Office Type for an Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/officename/{{officeName}}`  
   **Description:** Pass the Office Name value in the request and get the office type for the corresponding office name.  
   **Response:** 

## Development Journey



1. **Planning:** We start with thorough planning and requirement gathering to ensure a clear understanding of the project goals.
2. **Design:** We focus on creating a robust architecture and design that can accommodate future scalability and maintainability.
3. **Implementation:** Our development process follows best practices and coding standards to ensure high-quality code.
4. **Testing:** We conduct rigorous testing at different stages to identify and fix bugs early in the development cycle.
5. **Deployment:** We use continuous integration and deployment practices to streamline the release process.
6. **Feedback:** We value feedback from users and contributors to continuously improve our project.

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch (git checkout -b feature-branch).
3. Make your changes.
4. Commit your changes (git commit -m 'Add new feature').
5. Push to the branch (git push origin feature-branch).
6. Create a new Pull Request.    
     
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### Summary of the MIT License

The MIT License is a permissive free software license that allows for reuse within proprietary software, provided that all copies include the original copyright notice and license. It is a simple and easy-to-understand license that places very few restrictions on reuse, making it a popular choice for open-source projects.

## Contact

For any inquiries or feedback, please contact [suyashbaoney58@gmail.com](mailto:suyashbaoney58@gmail.com).
