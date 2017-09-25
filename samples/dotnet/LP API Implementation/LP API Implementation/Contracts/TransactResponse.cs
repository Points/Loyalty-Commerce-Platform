// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace LP_API_Implementation.LpApi.Models
{
    public partial class TransactResponse
    {
        

        [Required]
		[JsonProperty("transactionId")]
        public string TransactionId { get; set; }

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
