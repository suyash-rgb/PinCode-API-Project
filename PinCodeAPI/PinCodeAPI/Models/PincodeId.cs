namespace PinCodeAPI.Models
{
    //attributes that form the composite primary key
    public class PincodeId
    {
        public string OfficeName { get; set; }
        public int Pincode { get; set; }
        public string District { get; set; }
        public string DivisionName { get; set; }
    }
}
