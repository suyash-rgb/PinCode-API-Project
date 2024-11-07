using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PinCodeAPI.Models;
using PinCodeAPI.Services;
using System.Collections.Generic;

namespace PinCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PincodeController : ControllerBase
    {
        private readonly PincodeService _pincodeService;

        public PincodeController(PincodeService pincodeService)
        {
            _pincodeService = pincodeService;
        }

        [HttpGet("all")]
        public ActionResult GetAllPincodes()
        {
            var pincodes = _pincodeService.GetAllPincodes();
            return Ok(pincodes);
        }

        [HttpGet("search/district/{district}")]
        public ActionResult SearchByDistrict(string district)
        {
            var result = _pincodeService.GetPincodesByDistrict(district);

            if (result == null || result.Count == 0)
            {
                return NotFound("No records found for the given district.");
            }

            return Ok(result);
        }

        [HttpGet("{pincode}")]
        public ActionResult GetPincodesByPincode(int pincode)
        {
            var pincodes = _pincodeService.GetPincodesByPincode(pincode);

            if (pincodes.Count == 0)
            {
                return NotFound("No records found for the given pincode.");
            }
            else if (pincodes.Count == 1)
            {
                return Ok(pincodes[0]);
            }
            else
            {
                List<string> officeNames = new List<string>();
                foreach (var pin in pincodes)
                {
                    officeNames.Add(pin.Id.OfficeName);
                }
                return Ok(officeNames);
            }
        }

        [HttpGet("search/officename/{officeName}")] 
        public ActionResult SearchByOfficeName(string officeName) { 
            var results = _pincodeService.GetPincodesByOfficeName(officeName); 
            if (results.Count == 0) 
            { 
                return NotFound("No records found for the given office name."); 
            } else if (results.Count == 1) 
            { 
                var record = results[0]; 
                return Ok(new { Pincode = record.Id.Pincode, Delivery = record.Delivery }); 
            } else 
            { 
                List<object> response = new List<object>(); 
                foreach (var pin in results) { 
                    response.Add(new { 
                        CircleName = pin.CircleName, 
                        DivisionName = pin.Id.DivisionName, 
                        Pincode = pin.Id.Pincode, 
                        District = pin.Id.District, 
                        StateName = pin.StateName }); 
                } 
                return Ok(response);
            } 
        }

        [HttpGet("deliverystatus/pincode/{pincode}")]
        public ActionResult GetDeliveryStatusByPincode(int pincode)
        {
            var pincodes = _pincodeService.GetPincodesByPincode(pincode);

            if (pincodes.Count == 0)
            {
                return NotFound("No records found for the given pincode.");
            }
            else if (pincodes.Count == 1)
            {
                var deliveryStatus = pincodes[0].Delivery ? "Delivery is available" : "Delivery is not available";
                return Ok(new { Message = deliveryStatus });
            }
            else
            {
                List<object> officeNames = new List<object>();
                foreach (var pin in pincodes)
                {
                    officeNames.Add(new { OfficeName = pin.Id.OfficeName });
                }
                return Ok(officeNames);
            }
        }

        [HttpGet("deliverystatus/officename/{officeName}")]
        public ActionResult GetDeliveryStatusByOfficeName(string officeName)
        {
            var results = _pincodeService.GetPincodesByOfficeName(officeName);

            if (results.Count == 0)
            {
                return NotFound("No records found for the given office name.");
            }
            else if (results.Count == 1)
            {
                var deliveryStatus = results[0].Delivery ? "Delivery is available" : "Delivery is not available";
                return Ok(new { Message = deliveryStatus });
            }
            else
            {
                return BadRequest("Multiple records found for the given office name.");
            }
        }


        [HttpGet("deliverystatus/{officeName}/{pincode}/{district}/{divisionName}")]
        public ActionResult GetDeliveryStatus(string officeName, int pincode, string district, string divisionName)
        {
            var id = new PincodeId { OfficeName = officeName, Pincode = pincode, District = district, DivisionName = divisionName };
            var pincodeRecord = _pincodeService.GetPincode(id);

            if (pincodeRecord == null)
            {
                return NotFound("No records found for the given primary key");
            }
            var deliveryStatus = pincodeRecord.Delivery ? "Delivery is available" : "Delivery is not available";
            return Ok(new {Message = deliveryStatus});
        }

        [HttpPost]
        public ActionResult AddPincode([FromBody] Pincode pincode)
        {
            _pincodeService.AddPincode(pincode);
            return Ok("Pincode added successfully");
        }

        [HttpPut("{officeName}/{pincode}/{district}/{divisionName}")]
        public ActionResult UpdatePincode(string officeName, int pincode, string district, string divisionName, [FromBody] Pincode updatedPincode)
        {
            var id = new PincodeId { OfficeName = officeName, Pincode = pincode, District = district, DivisionName = divisionName };
            var existingPincode = _pincodeService.GetPincode(id);
            if (existingPincode == null) 
                return NotFound("Pincode not found.");
            _pincodeService.UpdatePincode(id, updatedPincode);
            return Ok("Pincode details updated successfully");
        }

        [HttpDelete("{officeName}/{pincode}/{district}/{divisionName}")]
        public ActionResult DeletePincode(string officeName, int pincode, string district, string divisionName)
        {
            var id = new PincodeId { OfficeName = officeName, Pincode = pincode, District = district, DivisionName = divisionName };
            _pincodeService.DeletePincode(id);
            return Ok("Pincode deleted successfully");
        }

        [HttpGet("officetype/officename/{officeName}")]
        public ActionResult GetOfficeTypeForOfficeName(string officeName)
        {
            var result = _pincodeService.GetOfficeTypeForOfficeName(officeName);

            if (result == null)
            {
                return NotFound("No records found for the given office name.");
            }
            return Ok(result);
        }

        [HttpGet("officetype/district/{district}/{officeType}")]
        public ActionResult GetOfficeTypeForDistrict(string district, string officeType)
        {
            var results = _pincodeService.GetOfficeTypeForDistrict(district, officeType);

            if (results.Count == 0)
            {
                return NotFound("No records found for the given district and office type.");
            }
            return Ok(results);
        }

        [HttpGet("officetype/division/{divisionName}/{officeType}")]
        public ActionResult GetOfficeTypeForDivision(string divisionName, string officeType)
        {
            var results = _pincodeService.GetOfficeTypeForDivision(divisionName, officeType);

            if (results.Count == 0)
            {
                return NotFound("No records found for the given division and office type.");
            }
            return Ok(results);
        }

    }
}
