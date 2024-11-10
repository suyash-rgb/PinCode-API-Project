# Postal Probe - Pincode API 

## Description
**Postal Probe** is a robust and efficient API Solution designed to provide detailed postal information. Developed using ASP .NET Core and C#, this project aims to deliver rapid responses and a seamless user experience compared to its earlier version built with Google Apps Script.

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
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/3f656a4346267c228f867662d422f5bb9cde8a04/images/1.png)


3. **Search by Pincode**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/{{pincode}}`  
   **Description:**
     - Returns an error message if no rows contain the pincode.
     - Returns the entire record as a JSON object if a single row matches the pincode.
     - Returns an array of office names if multiple rows match the pincode.  
   **Response:** <br>
   **Single Matches:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/be2900228d4bc9ed9c721d2862d0cca908dc7a30/images/2.png)

   **Multiple Matches:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/71c284af05c174034e7009a4eac3a32f259111dc/images/3.png)


5. **Search by District**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/search/district/{{district}}`  
   **Description:**
     - Returns an error message if no rows match the district.
     - Returns an array of objects with "Office Name", "Pincode", and "Delivery" values if rows match the district.  
   **Response:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/677dc33f440e12ce55991ed01d4dd6695c5bd80f/images/4.png)


6. **Search by Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/search/officename/{{officeName}}`  
   **Description:**
     - Returns an error message if no rows match the office name.
     - Returns the "Pincode" and "Delivery" values if a single row matches the office name.
     - Returns an array of objects with "Circle Name", "Division Name", "Pincode", "District", and "StateName" values if multiple rows match the office name.  
   **Response:** <br>
   **Single Match:** <br> ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/fba0196e56608f54fabae72e966c9c2e0b51d020/images/5.png)

   **Multiple Matches:** ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/c02cbee70db5a88c8fae714fb91ea5e91b7dd323/images/6.png)


7. **Delivery Status for Pincode**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/pincode/{{pincode}}`  
   **Description:**
     - Returns the "Delivery" value as a message (e.g., "Delivery is available" for `true` and "Delivery is not available" for `false`) if a single record matches the pincode.
     - Returns an array of objects with "Office Name" and "Delivery" values if multiple records match the pincode.  
   **Response:**  <br>
   **Single Match:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/3652e25e6bc95027c8ac6164dc17ff5879f5d7f6/images/7.png)

   **Multiple Matches:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/ac251184e8b66ec449c2e46da4690f96ef03af81/images/8.png)


9. **Delivery Status for Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/officename/{{officeName}}`
   **Description:**
      - If a single record matches the office name, it returns the office name and delivery status.
     - If multiple records match the office name, it returns the pincode, office name, and delivery status for each matching record.  <br>
   **Response:**  <br>
   **Single Match:** ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/5e1d3e3ba5b3cd8564f003bf5cb8c14c139961e0/images/9.png)
   **Multiple Matches:** ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/b3b7bc93036dddb51a2df7bff11bbc7128ee9c70/images/10.png)

7. **Delivery Status for Primary Key**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/deliverystatus/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
   **Description:** User provides the complete composite primary key in the request and receives the delivery status in the response.  
   **Response:**
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/80fe5cae1037361fbc270105c2f652fafa3779bb/images/11.png)


9. **Add Pincode Record**  
   **Method:** POST  
   **cURL:** `https://localhost:44337/api/Pincode/add`  
   **Description:** Add a new pincode record (Basic Authentication Required)  
   **Response:** <br>
     **Authorised User:** "Pincode added successfully"  
     **Unauthorized User:** "You need to provide valid credentials to access this resource."

10. **Update Pincode Details**  
   **Method:** PUT  
   **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
   **Description:** All details of the pincode record can be updated except for the pincode (Basic Auth Required)  
   **Response:** <br>
     **Authorised User:** "Pincode details updated successfully"  
     **Unauthorized User:** "You need to provide valid credentials to access this resource."

11. **Delete Pincode Record**  
    **Method:** DELETE  
    **cURL:** `https://localhost:44337/api/Pincode/{{officeName}}/{{pincode}}/{{district}}/{{divisionName}}`  
    **Description:** Delete an existing Pincode record.  
    **Response:** <br>
      **Authorised User:** "Pincode deleted successfully"  
      **Unauthorized User:** "You need to provide valid credentials to access this resource."

12. **Offices In a District**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/district/{{district}}/{{officeType}}`  
   **Description:** Pass the District and Office Type values in the request and get a list of office names with the specific office type in the particular district.  
   **Response:** 
   ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/39545552caac5589422d10ef4b8d656167f9ba45/images/18.png)

    

13. **Offices In a Division**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/division/{{divisionName}}/{{officeType}}`  
   **Description:** Pass the Division and Office Type values in the request and get a list of office names with the specific office type in the particular division.  
   **Response:** 
    ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/dde08f4f948e5a7ec896eff7a9a4bdb3003630c2/images/19.png)
 

14. **Get Office Type for an Office Name**  
   **Method:** GET  
   **cURL:** `https://localhost:44337/api/Pincode/officetype/officename/{{officeName}}`  
   **Description:** Pass the Office Name value in the request and get the office type for the corresponding office name.
    - If a single record matches the office name, return the office type.
     - If multiple records match the office name, return detailed information for each matching record.  <br>
   **Response:**  <br>
   **Single Match:** 
     ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/44e0d2e84ec0a358019c605d8cab45403b579b03/images/20.png)

    **Multiple Matches:**
    ![Alt Text](https://github.com/suyash-rgb/PinCode-API-Project/blob/ba39be418fccde59ba3d4abc8b4f93f3c06208e7/images/21.png)

## Development Journey

## Initial Phase: Pincode Lookup

The journey of Postal Probe began with a project initially named Pincode Lookup. It was created using Google Apps Script and Google Sheets, intended for integration into a larger project. However, due to the substantial size of the database (containing over 1.5 lakh pincode records), the API response times were excessively slow, ranging from 15 to 20 seconds. Over time, additional functionalities were added to enhance the project.

## Transition to Postal Probe

To overcome the limitations of the initial version, I decided to replicate the database and integrate a portion of it statically into the service layer of Postal Probe. The decision to redevelop the API using C# and ASP .NET Core Framework was driven by several factors:

- **Familiarity:** C# is syntactically similar to Java, which is beneficial for me as a Java developer.
- **Exploration:** I wanted to explore the features of Swagger UI.
- **Testing:** I aimed to understand how unit testing is implemented in this environment.

## Database Complexity

The database architecture is intricate, consisting of the following nine attributes: CircleName, RegionName, DivisionName, OfficeName, Pincode, OfficeType, Delivery, District, and StateName. No single attribute could uniquely identify a record in the database. After extensive analysis and studying the data for several weeks, I identified that a combination of three attributes was required to uniquely identify a record. However, during development, I discovered instances where this combination still yielded multiple records.

## Composite Primary Key

To address this, I identified a fourth attribute that could be used along with the previous three to uniquely identify a record. Therefore, the composite primary key for the database was established as:  <br>
`COMPOSITE PRIMARY KEY (`OfficeName`, `Pincode`, `District`, `DivisionName`)`


## Future Aspirations

I envision further developing Postal Probe using Java, Spring Boot, and AWS. However, due to my current lack of expertise in AWS Cloud, I plan to learn and upskill before embarking on this part of the journey.

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
