using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Models
{
    public class FootballPlayer
    {
        [Key]
        public int Id { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Surname { get; set; }
        [BindProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public Sex Sex { get; set; }
        [BindProperty, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "d", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [BindProperty]
        public string TeamName { get; set; }
        [BindProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public Country Country { get; set; }
    }
}
