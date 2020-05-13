﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string EmailAddress{ get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Profession{ get; set; }

    }
}
