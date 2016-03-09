// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace LP_API_Implementation.LpApi.Models
{
    public partial class ValidateMemberPostRequestContent
    {
        

        [Required]
		[JsonProperty("memberId")]
        public string MemberId { get; set; }


		[JsonProperty("firstName")]
        public string FirstName { get; set; }


		[JsonProperty("lastName")]
        public string LastName { get; set; }
    } // end class

} // end Models namespace

