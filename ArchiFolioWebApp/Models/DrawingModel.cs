using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiFolioWebApp.Models
{
    public class DrawingModel
    {
        //public int DrawingId { get; set; }
        [Display(Name = "Drawing Name")]
        [Required(ErrorMessage = "You need to provide the name of the drawing.")]
        public string Name { get; set; }
        [Display(Name = "Drawing Type")]
        [Required(ErrorMessage = "You need to provide the type of the drawing, e.g. plan/section/isometric.")]
        public string Type { get; set; }
        [StringLength(500, ErrorMessage = "Description must be less than 500 characters.")]
        [Required(ErrorMessage = "You need to provide a description for the drawing.")]
        public string Description { get; set; }
        public string ImagePath { get; set; }

    }
}