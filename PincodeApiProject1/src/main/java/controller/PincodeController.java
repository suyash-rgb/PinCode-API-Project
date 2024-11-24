package controller;

import entity.PincodePrimaryKey;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import service.PincodeService;
import entity.Pincode;

import java.util.List;
import java.util.Optional;


@RestController
@RequestMapping("/pincode-api")
public class PincodeController {

    @Autowired
    private PincodeService pincodeService;

    @GetMapping("/searchbypincode/{pincode}")
    public ResponseEntity<?> searchByPincode(@PathVariable int pincode) {
        List<Pincode> pincodes = pincodeService.searchByPincode(pincode);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No rows found for this pincode");
        } else if (pincodes.size() == 1) {
            return ResponseEntity.ok(pincodes.get(0));
        } else {
            return ResponseEntity.ok(pincodes.stream().map(Pincode::getOfficeName).toList());
        }
    }

    @GetMapping("/searchbydistrict/{district}")
    public ResponseEntity<?> searchByDistrict(@PathVariable String district) {
        List<Pincode> pincodes = pincodeService.searchByDistrict(district);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No rows found for this district");
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
    public ResponseEntity<?> searchByOfficeName(@PathVariable String officeName) {
        List<Pincode> pincodes = pincodeService.searchByOfficeName(officeName);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No rows found for this office name");
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
    public ResponseEntity<?> getDeliveryStatusByPincode(@PathVariable int pincode) {
        List<Pincode> pincodes = pincodeService.searchByPincode(pincode);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No rows found for this pincode");
        }
        return ResponseEntity.ok(pincodes.get(0).getDelivery());
    }

    @GetMapping("/delivery/primary-key")
    public ResponseEntity<?> getDeliveryStatusForPrimaryKey(@RequestBody PincodePrimaryKey primaryKey) {
        Optional<Pincode> pincode = pincodeService.getPincodeByPrimaryKey(primaryKey);
        if (pincode.isPresent()) {
            return ResponseEntity.ok(pincode.get().getDelivery());
        } else {
            return ResponseEntity.status(404).body("No record found for the provided composite key");
        }
    }

    @PostMapping("/office-type")
    public ResponseEntity<?> getOfficeTypeForDistrict(@RequestParam String district, @RequestParam String officeType) {
        List<Pincode> pincodes = pincodeService.searchByDistrict(district);
        if (pincodes.isEmpty()) {
            return ResponseEntity.status(404).body("No rows found for this district");
        }
        return ResponseEntity.ok(
                pincodes.stream()
                        .filter(p -> p.getOfficeType().equals(officeType))
                        .map(Pincode::getOfficeName)
                        .toList()
        );
    }

    @PutMapping("/update")
    public ResponseEntity<?> updatePincodeDetails(@RequestBody Pincode pincode) {
        pincodeService.updatePincode(pincode);
        return ResponseEntity.ok("Pincode details updated successfully");
    }
}
