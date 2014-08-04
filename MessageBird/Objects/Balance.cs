﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageBird.Objects
{
    public enum PaymentMethod 
    {
        [EnumMember(Value = "prepaid")]
        Prepaid,
        [EnumMember(Value = "postpaid")]
        Postpaid
    }

    public enum PaymentType
    {
        [EnumMember(Value = "credits")]
        Credits,
        [EnumMember(Value = "euros")]
        Euros
    }

    public class Balance
    {
        [JsonProperty("payment"), JsonConverter(typeof(StringEnumConverter))]
        public PaymentMethod Payment { get; set; }

        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public PaymentType Type {get; set;}

        [JsonProperty("amount")]
        public string Amount {get; set;}

        public Balance()
        {
        }
    }
}
