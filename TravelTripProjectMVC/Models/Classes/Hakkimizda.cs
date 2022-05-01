using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjectMVC.Models.Classes
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Aciklama { get; set; }
    }
}