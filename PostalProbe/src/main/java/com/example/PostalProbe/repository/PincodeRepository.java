package com.example.PostalProbe.repository;

import com.example.PostalProbe.entity.Pincode;
import com.example.PostalProbe.entity.PincodePrimaryKey;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface PincodeRepository extends JpaRepository<Pincode, PincodePrimaryKey> {


    List<Pincode> findByPincodePrimaryKeyPincode(int pincode);

    List<Pincode> findByPincodePrimaryKeyDistrict(String district);

    List<Pincode> findByPincodePrimaryKeyOfficeName(String officeName);

    List<Pincode> findByDistrictAndOfficeType(String district, String officeType);

    List<Pincode> findByDivisionAndOfficeType(String division, String officeType);

    @Query("SELECT p.officeType FROM Pincode p WHERE p.pincodePrimaryKey.officeName= :officeName")
    String findOfficeTypeByOfficeName(@Param("officeName") String officeName);



}
