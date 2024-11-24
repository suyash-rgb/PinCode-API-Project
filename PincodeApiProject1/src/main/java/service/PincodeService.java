package service;

import entity.Pincode;
import entity.PincodePrimaryKey;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import repository.PincodeRepository;

import java.util.List;
import java.util.Optional;

@Service
public class PincodeService {

    @Autowired
    private PincodeRepository pincodeRepository;


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

    public void updatePincode(Pincode pincode) {
        pincodeRepository.save(pincode);
    }
}
