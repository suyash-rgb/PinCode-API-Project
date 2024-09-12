# PinCode-API-Project
# Google Sheets API Backend with Apps Script
This project is a custom API built on Google Apps Script to retrieve data on Google Sheets in real time. It enables users to automate Google Sheets workflows, fetch data, and integrate with third-party applications seamlessly.

**Scenario 1: Searching by Pincode**
URL: https://script.google.com/macros/s/AKfycbzs_5sOiH_PQQR7wnwBxwewPu4DvXygom3FHIIgBQ_U70OwmLzpJrBgVzEUy6plTg9O/exec?pincode=123456
<br>**Response:**
+	If no rows contains the pincode, it returns an error message.
+	If a single row matches the pincode, it returns the entire row as a JSON object.(452012)
 
+	If multiple rows match the pincode, it returns an array of office names. (454001)

**Scenario 2: Searching by District**
URL: https://script.google.com/macros/s/AKfycbzs_5sOiH_PQQR7wnwBxwewPu4DvXygom3FHIIgBQ_U70OwmLzpJrBgVzEUy6plTg9O/exec?district=exampleDistrict
**Response:**
•	If no rows match the district, it returns an error message.
•	If rows match the district, it returns an array of objects with "Office Name", "Pincode", and "Delivery" values.


**Scenario 3: Searching by Office Name**
URL: https://script.google.com/macros/s/AKfycbzs_5sOiH_PQQR7wnwBxwewPu4DvXygom3FHIIgBQ_U70OwmLzpJrBgVzEUy6plTg9O/exec?officeName=exampleOfficeName
**Response:**
•	If no rows match the office name, it returns an error message.
•	If a single row matches the office name, it returns the "Pincode" and "Delivery" values. 

 
•	If multiple rows match the office name, it returns an array of objects with "Circle Name", "Division Name", "Pincode", "District", and "StateName" values.
 

NOTE: Method is GET for all scenarios
