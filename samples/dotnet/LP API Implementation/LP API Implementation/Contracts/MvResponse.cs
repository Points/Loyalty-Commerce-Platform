// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace LP_API_Implementation.LpApi.Models
{
    public partial class MvResponse
    {
        

        [Required]
		[JsonProperty("balance")]
        public int Balance { get; set; }


		[JsonProperty("language")]
        public string Language { get; set; }


		[JsonProperty("countryCode")]
        public string CountryCode { get; set; }


		[JsonProperty("accountCreationDate")]
        public string AccountCreationDate { get; set; }


		[JsonProperty("membershipLevel")]
        public string MembershipLevel { get; set; }


		[JsonProperty("accountStatus")]
        public string AccountStatus { get; set; }

        [Required]
		[JsonProperty("status")]
		[JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        [Required]
		[JsonProperty("statusMessage")]
		[JsonConverter(typeof(StringEnumConverter))]
        public StatusMessage StatusMessage { get; set; }
    } // end class

} // end Models namespace

