package repository;

import entity.Pincode;
import entity.PincodePrimaryKey;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface PincodeRepository extends JpaRepository<Pincode, PincodePrimaryKey> {

    List<Pincode> findByPincodePrimaryKeyPincode(int pincode);

    List<Pincode> findByPincodePrimaryKeyDistrict(String district);

    List<Pincode> findByPincodePrimaryKeyOfficeName(String officeName);
}
