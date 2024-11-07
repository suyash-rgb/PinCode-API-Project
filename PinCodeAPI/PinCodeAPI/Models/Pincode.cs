namespace PinCodeAPI.Models
{
    public class Pincode
    {
        public PincodeId Id { get; set; }
        public string CircleName { get; set; }
        public string OfficeType { get; set; }
        public bool Delivery { get; set; }
        public string StateName { get; set; }

    }
}
