using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiFolioWebApp.Models
{
    public class ProjectModel
    {
        //public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "You need to provide a name for your project.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You need to provide a description.")]
        [StringLength(500, ErrorMessage = "Description must be less than 500 characters.")]
        public string  Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Project Location")]
        [Required(ErrorMessage = "You need to provide the place of the project.")]
        public string Location { get; set; }
        public string Budget { get; set; }
        [Display(Name = "Type of project")]
        [Required(ErrorMessage = "You need to provide the type, e.g. Industrial/Dwelling/Housing.")]
        public string Type { get; set; }
    }
}