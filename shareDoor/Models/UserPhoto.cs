﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shareDoor.Models
{
    public class UserPhoto : Photo
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
       
    }
}