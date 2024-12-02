package com.example.PostalProbe.controller;

import com.example.PostalProbe.entity.Pincode;
import com.example.PostalProbe.entity.PincodePrimaryKey;
import com.example.PostalProbe.service.PincodeService;
//import io.swagger.annotations.Api;
//import io.swagger.annotations.ApiOperation;
//import io.swagger.annotations.ApiParam;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
//import io.swagger.v3.oas.annotations.media.Schema;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/pincode-api")
//@Api(value = "Pincode API", tags = { "Pincode API" })
public class PincodeController {

    @Autowired
    private PincodeService pincodeService;

    @GetMapping("/getallpincoderecords")
    public ResponseEntity<List<Pincode>> getAllPincodeRecords(){
        List<Pincode> pincodes = pincodeService.getAllPincodes();
        return ResponseEntity.ok(pincodes);
    }

    @GetMapping("/searchbypincode/{pincode}")
    //@ApiOperation(value = "Search by Pincode", notes = "Get details by pincode")
    public ResponseEntity<?> searchByPincode(
            //@ApiParam(value = "Pincode to search for", required = true)
            @PathVariable int pincode) {
        List<Pincode> pincodes = pincodeService.searchByPincode(pincode);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No record found for this pincode");
        } else if (pincodes.size() == 1) {
            return ResponseEntity.ok(pincodes.get(0));
        } else {
            return ResponseEntity.ok(pincodes.stream().map(Pincode::getOfficeName).toList());
        }
    }

    @GetMapping("/searchbydistrict/{district}")
    //@ApiOperation(value = "Search by District", notes = "Get details by district")
    public ResponseEntity<?> searchByDistrict(
            //@ApiParam(value = "District to search for", required = true)
            @PathVariable String district) {
        List<Pincode> pincodes = pincodeService.searchByDistrict(district);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No record found for this district");
        } else {
            return ResponseEntity.ok(
                    pincodes.stream().map(p -> new Object() {
                        public String officeName = p.getOfficeName();
                        public int pincode = p.getPincode();
                        public boolean delivery = p.getDelivery();
                    }).toList());
        }
    }

    @GetMapping("/searchbyoffice/{officeName}")
    //@ApiOperation(value = "Search by Office Name", notes = "Get details by office name")
    public ResponseEntity<?> searchByOfficeName(
            //@ApiParam(value = "Office name to search for", required = true)
            @PathVariable String officeName) {
        List<Pincode> pincodes = pincodeService.searchByOfficeName(officeName);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No record found for this office name");
        } else if (pincodes.size() == 1) {
            Pincode pincode = pincodes.get(0);
            return ResponseEntity.ok(new Object() {
                public int pincodeValue = pincode.getPincode();
                public boolean deliveryStatus = pincode.getDelivery();
            });
        } else {
            return ResponseEntity.ok(
                    pincodes.stream().map(p -> new Object() {
                        public String circleName = p.getCircleName();
                        public String divisionName = p.getDivisionName();
                        public int pincode = p.getPincode();
                        public String district = p.getDistrict();
                        public String stateName = p.getStateName();
                    }).toList());
        }
    }

    @GetMapping("/delivery/pincode/{pincode}")
    //@ApiOperation(value = "Get Delivery Status by Pincode", notes = "Get delivery status by pincode")
    public ResponseEntity<?> getDeliveryStatusByPincode(
            //@ApiParam(value = "Pincode to search for", required = true)
            @PathVariable int pincode) {
        List<Pincode> pincodes = pincodeService.searchByPincode(pincode);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No record found for this pincode");
        } else if (pincodes.size()==1) {
            String message = pincodes.get(0).getDelivery()?"Delivery Services Available":"Delivery Services Not Available for the entered Pincode";
            return ResponseEntity.ok(message);
        }
        else{
            return ResponseEntity.ok(
                    pincodes.stream().map(p -> new Object() {
                        String message = p.getDelivery()?"Delivery Services Available":"Delivery Services Not Available";
                        public String officeName = p.getOfficeName();
                        public String delivery = message;
                    }).toList());
        }
    }

    @GetMapping("/delivery/officeName/{officeName}")
    public ResponseEntity<?> getDeliveryStatusByOfficeName(
            @PathVariable String officeName) {
        List<Pincode> pincodes = pincodeService.searchByOfficeName(officeName);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No record found for this Office");
        }
        else if(pincodes.size()==1) {
            Boolean deliveryStatus = pincodes.get(0).getDelivery();
            String message = deliveryStatus?"Delivery Services Available":"Delivery Services Not Available for the entered Office";
            return ResponseEntity.ok(message);
        }
        else{
            return ResponseEntity.ok(
                    pincodes.stream().map(p -> new Object() {
                        String message = p.getDelivery()?"Delivery Services Available":"Delivery Services Not Available for the entered Office";
                        public int pincode = p.getPincode();
                        public String officeName = p.getOfficeName();
                        public String delivery = message;
                    }).toList());
        }
    }

    @GetMapping ("/delivery/primary-key")
    //@ApiOperation(value = "Get Delivery Status by Primary Key", notes = "Get delivery status by primary key")
    public ResponseEntity<?> getDeliveryStatusForPrimaryKey(
            //@ApiParam(value = "Primary key details", required = true)
            @RequestBody PincodePrimaryKey primaryKey) {
        Optional<Pincode> pincode = pincodeService.getPincodeByPrimaryKey(primaryKey);
        if (pincode.isPresent()) {
            return ResponseEntity.ok(pincode.get().getDelivery());
        } else {
            return ResponseEntity.status(404).body("No record found for the provided composite key");
        }
    }

    @GetMapping("/offices/district/{district}/type/{officeType}")
    public ResponseEntity<?> getOfficesByDistrictAndOfficeType( @PathVariable String district, @PathVariable String officeType) {
        List<Pincode> pincodes = pincodeService.getOfficesByDistrict(district, officeType);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No offices found for the specified district and office type");
        }
        return ResponseEntity.ok(pincodes);
    }

    @GetMapping("/offices/division/{division}/type/{officeType}")
    public ResponseEntity<?> getOfficesByDivisionAndOfficeType( @PathVariable String division, @PathVariable String officeType) {
        List<Pincode> pincodes = pincodeService.getOfficesByDivision(division, officeType);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No offices found for the specified division and office type");
        }
        return ResponseEntity.ok(pincodes);
    }

    @GetMapping("/office-type/{officeName}")
    public ResponseEntity<?> getOfficeTypeForOfficeName( @PathVariable String officeName) {
        Optional<String> officeType = pincodeService.getOfficeTypeByOfficeName(officeName);
        if (!officeType.isPresent()) {
            return ResponseEntity.status(404).body("No office type found for the specified office name");
        }
        return ResponseEntity.ok(officeType.get());
    }

}
