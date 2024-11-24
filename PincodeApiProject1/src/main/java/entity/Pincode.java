package entity;

import jakarta.persistence.*;
import utility.BooleanConverter;

@Entity
@Table(name="Pincode")
public class Pincode {

    @EmbeddedId
    private PincodePrimaryKey pincodePrimaryKey;

    @Column(name="CircleName")
    private String circleName;

    @Column(name="RegionName")
    private String regionName;

    @Column(name="OfficeType")
    private String officeType;

    @Column(name="Delivery")
    @Convert(converter = BooleanConverter.class)
    private Boolean delivery;

    @Column(name="StateName")
    private String stateName;

    public Pincode() {
    }

    public Pincode(PincodePrimaryKey pincodePrimaryKey, String circleName, String regionName, String officeType, Boolean delivery, String stateName) {
        this.pincodePrimaryKey = pincodePrimaryKey;
        this.circleName = circleName;
        this.regionName = regionName;
        this.officeType = officeType;
        this.delivery = delivery;
        this.stateName = stateName;
    }

    public PincodePrimaryKey getPincodePrimaryKey() {
        return pincodePrimaryKey;
    }

    public void setPincodePrimaryKey(PincodePrimaryKey pincodePrimaryKey) {
        this.pincodePrimaryKey = pincodePrimaryKey;
    }

    public String getCircleName() {
        return circleName;
    }

    public void setCircleName(String circleName) {
        this.circleName = circleName;
    }

    public String getRegionName() {
        return regionName;
    }

    public void setRegionName(String regionName) {
        this.regionName = regionName;
    }

    public String getOfficeType() {
        return officeType;
    }

    public void setOfficeType(String officeType) {
        this.officeType = officeType;
    }

    public Boolean getDelivery() {
        return delivery;
    }

    public void setDelivery(Boolean delivery) {
        this.delivery = delivery;
    }

    public String getStateName() {
        return stateName;
    }

    public void setStateName(String stateName) {
        this.stateName = stateName;
    }

    // Adding getters from Embedded Id (Composite primary key)
    public String getOfficeName() {
        return this.pincodePrimaryKey.getOfficeName();
    }

    public int getPincode() {
        return this.pincodePrimaryKey.getPincode();
    }

    public String getDistrict() {
        return this.pincodePrimaryKey.getDistrict();
    }

    public String getDivisionName() {
        return this.pincodePrimaryKey.getDivisionName();
    }
}
