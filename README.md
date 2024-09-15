# PinCode-API-Project
# Google Sheets API Backend with Apps Script
This project is a custom API built on Google Apps Script to retrieve data on Google Sheets in real time. It enables users to automate Google Sheets workflows, fetch data, and integrate with third-party applications seamlessly. 
<br>
<br>
The PIN Code API provides functionalities related to PIN codes, initially developed using Google Apps Script and Google Sheets. Originally part of a bigger project, the API was created to handle large datasets efficiently. <br><br>
The API functionality was modified and now serves 3 purposes:
<br><br> 
+ Search By Pincode
+ Search By District
+ Search By Office Name
<br><br>
**I have changed the last part (i.e., Search By Office Name), so it is not functional. <br>
I present it to you for fixing the intentional bug and/or providing new functionality for the API.<br>
Feel free to integrate it into your projects. :)
<br>Do something creative! Good Luck!**
<br>
Detailed description of the working and type of response are provided below. 
<br><br>
NOTE: Method is GET for all scenarios
<br><br>
**cURL** <br>
--location 'https://script.google.com/macros/s/AKfycbznP4tVoAoSpaJ2XSR9u1wum3fZkUoLCvlYvIYTy6z-XIbyIDnjgh8NmsLCrvcSCFvN/exec?district=Indore'
<br><br>

Sample Sheet: 
![Loading image...](Images/samplesheet.png)


**Scenario 1: Searching by Pincode**
URL: https://script.google.com/macros/s/AKfycbyQ8f_u4mx77onOKUv3HZIWXmzyjoqqmleKxSKoLnpOCRDpgd7eAnsF79ZNFhqrirQp/exec?pincode=123456
<br><br>**Response:**
+	If no rows contains the pincode, it returns an error message.
+	If a single row matches the pincode, it returns the entire row as a JSON object.(E.g. 452012)<br>
![Loading image...](Images/Picture1.png)
+	If multiple rows match the pincode, it returns an array of office names. (E.g. 454001)
![Loading image...](Images/Picture2.png)

**Scenario 2: Searching by District**
URL: https://script.google.com/macros/s/AKfycbznP4tVoAoSpaJ2XSR9u1wum3fZkUoLCvlYvIYTy6z-XIbyIDnjgh8NmsLCrvcSCFvN/exec?district=exampleDistrict
<br><br>**Response:**
+	If no rows match the district, it returns an error message.
+	If rows match the district, it returns an array of objects with "Office Name", "Pincode", and "Delivery" values.
![Loading image...](Images/Picture3.png)

**Scenario 3: Searching by Office Name**
URL: https://script.google.com/macros/s/AKfycbyQ8f_u4mx77onOKUv3HZIWXmzyjoqqmleKxSKoLnpOCRDpgd7eAnsF79ZNFhqrirQp/exec?=exampleOfficeName
<br><br>**Response:**
+	If no rows match the office name, it returns an error message.
+	If a single row matches the office name, it returns the "Pincode" and "Delivery" values. 
![Loading image...](Images/Picture4.png)
<br>
+	If multiple rows match the office name, it returns an array of objects with "Circle Name", "Division Name", "Pincode", "District", and "StateName" values.<br>
<!--- ![Loading image...](Images/Picture5-COJAU6vIx-transformed.png) --->
<br><br>
**Contributing**<br>
We welcome contributions! Please follow these steps:
<br>
1. Fork the repository.<br>
2. Create a new branch (git checkout -b feature-branch).<br>
3. Make your changes.<br>
4. Commit your changes (git commit -m 'Add new feature').<br>
5. Push to the branch (git push origin feature-branch).<br>
6. Create a new Pull Request.<br>
<br><br>

In the future, I plan to re-implement this API using SpringBoot and AWS to enhance performance and scalability, as well as to explore database indexing in AWS for optimal performance.
<br><br>

**Contact**<br>
For any inquiries or feedback, please contact suyashbaoney58@gmail.com. 
<br>
 
