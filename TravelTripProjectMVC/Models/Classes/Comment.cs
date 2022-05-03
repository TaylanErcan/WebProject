using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjectMVC.Models.Classes
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string Mail { get; set; }
        public string UserComment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
    }
}