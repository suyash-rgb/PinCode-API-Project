using System.Collections.Generic;
using PinCodeAPI.Models;

namespace PinCodeAPI.Services
{
    public class PincodeService
    {
        private List<Pincode> pincodes = new List<Pincode>();

        public PincodeService()
        {
            // Add static pincode records here
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "testOffice", Pincode = 123456, District = "testDistrict", DivisionName = "testDivision" }, CircleName = "testCircle", OfficeType = "HO", Delivery = true, StateName = "testState" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Army Head Quarter S.O", Pincode = 452006, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Baolia khurd B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Bicholi Mardana B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Bijasan Road S.O", Pincode = 452005, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Buranakhedi B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Dudhia B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Gurunanak Chauk S.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Cat S.O", Pincode = 452013, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore CGO Complex S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore City 2 S.O", Pincode = 452002, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Cloth Market S.O", Pincode = 452002, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Collectorate S.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Courts S.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore DDU Nagar S.O", Pincode = 452010, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore G.P.O.", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "HO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Kanadia Road S.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Khajrana S.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Kumar Khadi S.O", Pincode = 452015, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Manorama Ganj S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Nagar H.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "HO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Nipaniya SO", Pincode = 452010, District = "Indore", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Pardesipura S.O", Pincode = 452003, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore R.S.S.Nagar S.O", Pincode = 452011, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Ram Bagh S.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Siyaganj S.O", Pincode = 452007, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Takshashila S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Tillaknagar S.O", Pincode = 452018, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Tukoganj S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Indore Uchchanyayalay S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Industrial Estate S.O (Indore)", Pincode = 452015, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Jhalaria B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Kanadia B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Khatiwala Tank S.O", Pincode = 452014, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Khudel B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Lokmanya Nagar Indore S.O", Pincode = 452009, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Nanda Nagar S.O", Pincode = 452011, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Radio Colony Indore S.O", Pincode = 452001, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Rajendra Nagar S.O (Indore)", Pincode = 452012, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Sanawadia B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Sanwer Link Road Indore S.O", Pincode = 452010, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = false, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Semlia Chau B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Sivani B.O", Pincode = 452016, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "BO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Sudama Nagar S.O", Pincode = 452009, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Vallabhnagar S.O (Indore)", Pincode = 452003, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            pincodes.Add(new Pincode { Id = new PincodeId { OfficeName = "Vijay Nagar S.O", Pincode = 452010, District = "INDORE", DivisionName = "Indore City Division" }, CircleName = "Madhya Pradesh Circle", OfficeType = "SO", Delivery = true, StateName = "Madhya Pradesh" });
            
            //.
            //.
            //.
            // Add more records as needed
        }

        public List<Pincode> GetAllPincodes()
        {
            return pincodes;
        }

        public Pincode GetPincode(PincodeId id)
        {
            foreach (var pincode in pincodes)
            {
                if (pincode.Id.OfficeName == id.OfficeName && pincode.Id.Pincode == id.Pincode && pincode.Id.District == id.District && pincode.Id.DivisionName == id.DivisionName)
                {
                    return pincode;
                }
            }
            return null;
        }

        public List<Pincode> GetPincodesByPincode(int pincode)
        {
            List<Pincode> result = new List<Pincode>();
            foreach (var pin in pincodes)
            {
                if (pin.Id.Pincode == pincode)
                {
                    result.Add(pin);
                }
            }
            return result;
        }

        public List<object> GetPincodesByDistrict(string district)
        {
            List<Pincode> matchedPincodes = new List<Pincode>();

            foreach (var pin in pincodes)
            {
                if (pin.Id.District.Equals(district, System.StringComparison.OrdinalIgnoreCase))
                {
                    matchedPincodes.Add(pin);
                }
            }

            if (matchedPincodes.Count == 0)
            {
                return null; // No records found
            }

            List<object> result = new List<object>();

            foreach (var pin in matchedPincodes)
            {
                result.Add(new
                {
                    OfficeName = pin.Id.OfficeName,
                    Pincode = pin.Id.Pincode,
                    Delivery = pin.Delivery
                });
            }

            return result;
        }

        public List<Pincode> GetPincodesByOfficeName(string officeName) { 
            List<Pincode> result = new List<Pincode>(); 
            foreach (var pin in pincodes) { 
                if (pin.Id.OfficeName.Equals(officeName, System.StringComparison.OrdinalIgnoreCase)) 
                { 
                    result.Add(pin); 
                } 
            } return result; 
        }

        public void AddPincode(Pincode pincode) => pincodes.Add(pincode);

        public void DeletePincode(PincodeId id) => pincodes.RemoveAll(p => p.Id.Equals(id));

        public void UpdatePincode(PincodeId id, Pincode updatedPincode)
        {
            var existingPincode = GetPincode(id);
            if (existingPincode != null)
            {
                existingPincode.Id.OfficeName = updatedPincode.Id.OfficeName;
                existingPincode.Id.District = updatedPincode.Id.District;
                existingPincode.Id.DivisionName = updatedPincode.Id.DivisionName;
                existingPincode.CircleName = updatedPincode.CircleName;
                existingPincode.OfficeType = updatedPincode.OfficeType;
                existingPincode.Delivery = updatedPincode.Delivery;
                existingPincode.StateName = updatedPincode.StateName;
            }
        }

        public string GetOfficeTypeForOfficeName(string officeName)
        {
            foreach (var pin in pincodes)
            {
                if (pin.Id.OfficeName.Equals(officeName, System.StringComparison.OrdinalIgnoreCase))
                {
                    return pin.OfficeType;
                }
            }
            return null;
        }

        public List<string> GetOfficeTypeForDistrict(string district, string officeType)
        {
            List<string> results = new List<string>();
            foreach (var pin in pincodes)
            {
                if (pin.Id.District.Equals(district, System.StringComparison.OrdinalIgnoreCase) && pin.OfficeType.Equals(officeType, System.StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(pin.Id.OfficeName);
                }
            }
            return results;
        }

        public List<string> GetOfficeTypeForDivision(string divisionName, string officeType)
        {
            List<string> results = new List<string>();
            foreach (var pin in pincodes)
            {
                if (pin.Id.DivisionName.Equals(divisionName, System.StringComparison.OrdinalIgnoreCase) && pin.OfficeType.Equals(officeType, System.StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(pin.Id.OfficeName);
                }
            }
            return results;
        }

    }
}
