function doGet(e) {
  try {
    var sheet = SpreadsheetApp.getActiveSpreadsheet().getSheetByName("Pincode_30052019");
    if (!sheet) {
      throw new Error("Sheet 'Pincode_30052019' not found"); //incase the sheet is renamed or deleted
    }

    var pincode = e.parameter.pincode;
    var district = e.parameter.district ? e.parameter.district.toLowerCase() : null; //introducing case-insensitivity for district
    var officeName = e.parameter.officeName ? e.prameter.officeName.toLowerCase() : null;

    if (!pincode && !district && !officeName) {
      throw new Error("Pincode, district, or officeName parameter is required");
    }

    // Getting all the data from the sheet
    var data = sheet.getDataRange().getValues();

    // difining headers for easy reference
    var headers = data[0];

    if (pincode) {
      var matchingRows = [];
      for (var i = 1; i < data.length; i++) {
        if (data[i][4] == pincode) {
          matchingRows.push(data[i]);
        }
      }

      if (matchingRows.length == 0) {
        return ContentService.createTextOutput(JSON.stringify({ error: "Pincode not found" })).setMimeType(ContentService.MimeType.JSON);
      } else if (matchingRows.length == 1) {
        var result = {};
        for (var j = 0; j < headers.length; j++) {
          result[headers[j]] = matchingRows[0][j];
        }
        return ContentService.createTextOutput(JSON.stringify(result)).setMimeType(ContentService.MimeType.JSON);
      } else {
        var officeNames = matchingRows.map(function (row) {
          var officeNameIndex = headers.indexOf('Office Name');
          return { "Office Name": row[officeNameIndex] };
        });
        return ContentService.createTextOutput(JSON.stringify(officeNames)).setMimeType(ContentService.MimeType.JSON);
      }
    }

    if (district) {
      var matchingRows = [];
      for (var i = 1; i < data.length; i++) {
        if (data[i][7].toLowerCase() == district) {
          matchingRows.push(data[i]);
        }
      }

      if (matchingRows.length == 0) {
        return ContentService.createTextOutput(JSON.stringify({ error: "District not found" })).setMimeType(ContentService.MimeType.JSON);
      } else {
        var districtResults = matchingRows.map(function (row) {
          var officeNameIndex = headers.indexOf('Office Name');
          var pincodeIndex = headers.indexOf('Pincode');
          var deliveryIndex = headers.indexOf('Delivery');
          return {
            "Office Name": row[officeNameIndex],
            "Pincode": row[pincodeIndex],
            "Delivery": row[deliveryIndex]
          };
        });
        return ContentService.createTextOutput(JSON.stringify(districtResults)).setMimeType(ContentService.MimeType.JSON);
      }
    }

    if (officeName) {
      var matchingRows = [];
      for (var i = 1; i < data.length; i++) {
        if (data[i][3] == officeName) {
          matchingRows.push(data[i]);
        }
      }

      if (matchingRows.length == 0) {
        return ContentService.createTextOutput(JSON.stringify({ error: "Office Name not found" })).setMimeType(ContentService.MimeType.JSON);
      }
      else if (matchingRows.length == 1) {
        var result = {};
        var pincodeIndex = headers.indexOf('Pincode');
        var deliveryIndex = headers.indexOf('Delivery');
        var districtIndex = headers.indexOf('District'); // Add logging
        console.log('Headers:', headers);
        console.log('District Index:', districtIndex);
        console.log('Row:', matchingRows[0]);

        result.Pincode = matchingRows[0][pincodeIndex];
        result.Delivery = matchingRows[0][deliveryIndex];
        // Check if districtIndex is valid before accessing
        if (districtIndex !== -1) {
          result.District = matchingRows[0][districtIndex];
        } else {
          console.error('District index not found');
        }

        return ContentService.createTextOutput(JSON.stringify(result)).setMimeType(ContentService.MimeType.JSON);
      } else {
        var officeDetails = matchingRows.map(function (row) {
          var circleNameIndex = headers.indexOf('Circle Name');
          var divisionNameIndex = headers.indexOf('Division Name');
          var pincodeIndex = headers.indexOf('Pincode');
          var districtIndex = headers.indexOf('District');
          var stateNameIndex = headers.indexOf('StateName');
          return {
            "Circle Name": row[circleNameIndex],
            "Division Name": row[divisionNameIndex],
            "Pincode": row[pincodeIndex],
            "District": row[districtIndex],
            "StateName": row[stateNameIndex]
          };
        });
        return ContentService.createTextOutput(JSON.stringify(officeDetails)).setMimeType(ContentService.MimeType.JSON);
      }
    }
  } catch (error) {
    return ContentService.createTextOutput(JSON.stringify({ error: error.message })).setMimeType(ContentService.MimeType.JSON);
  }
}
