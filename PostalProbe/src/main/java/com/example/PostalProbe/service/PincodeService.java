package com.example.PostalProbe.service;

import com.example.PostalProbe.entity.Pincode;
import com.example.PostalProbe.entity.PincodePrimaryKey;
import com.example.PostalProbe.repository.PincodeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class PincodeService {

    @Autowired
    private PincodeRepository pincodeRepository;

    public List<Pincode> getAllPincodes(){
        return pincodeRepository.findAll();
    }

    public List<Pincode> searchByPincode(int pincode) {
        return pincodeRepository.findByPincodePrimaryKeyPincode(pincode);
    }

    public List<Pincode> searchByDistrict(String district) {
        return pincodeRepository.findByPincodePrimaryKeyDistrict(district);
    }

    public List<Pincode> searchByOfficeName(String officeName) {
        return pincodeRepository.findByPincodePrimaryKeyOfficeName(officeName);
    }

    public Optional<Pincode> getPincodeByPrimaryKey(PincodePrimaryKey primaryKey) {
        return pincodeRepository.findById(primaryKey);
    }

    public List<Pincode> getOfficesByDistrict(String district, String officeType){
        return pincodeRepository.findByDistrictAndOfficeType(district, officeType);
    }

    public List<Pincode> getOfficesByDivision(String division, String officeType){
        return pincodeRepository.findByDivisionAndOfficeType(division, officeType);
    }

    public Optional<String> getOfficeTypeByOfficeName(String officeName){
        return Optional.ofNullable(pincodeRepository.findOfficeTypeByOfficeName(officeName));
    }

    /*public Pincode UpdatePincode(PincodePrimaryKey primaryKey, Pincode newPincodeDetails){
        Optional<Pincode> optionalPincode = pincodeRepository.findById(primaryKey);
        if(optionalPincode.isPresent()){
            Pincode existingPincode = optionalPincode.get();

            existingPincode.setCircleName(newPincodeDetails.getCircleName());
            existingPincode.setDivisionName()
        }
    }
    */
}
