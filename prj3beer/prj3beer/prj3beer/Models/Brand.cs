﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace prj3beer.Models
{
     /// <summary>
     /// This is our Brand Entity, this will store an ID and a name for each brand pulled from the API. 
     /// </summary>
    public class Brand
    {
        [Key] // Primary Key
        [JsonProperty("id")] // JSON Property
        public int brandID { get; set; }    

        [Required(ErrorMessage ="Brand Name Required")] // Validation - Required. If not set, will return error
        [MaxLength(60,ErrorMessage ="Brand Name Too Long, 60 Characters Max")] // Validation - Max Length of 60
        [JsonProperty("name")] // JSON property
        public String brandName { get; set; }
    }
}
