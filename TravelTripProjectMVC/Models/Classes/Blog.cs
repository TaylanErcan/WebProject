using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjectMVC.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Aciklama { get; set; }
        public string BlogImagePath { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
        // public ICollection<Comment> Comments { get; set; } property'si ile 'one to many' ilişkisi kuruyoruz.
        // Yani bir bloğa ait birden fazla yorum olabilir ancak bir yorum sadece spesifik bir bloğa ait olabilir/bir blok için geçerli olabilir.
    }
}