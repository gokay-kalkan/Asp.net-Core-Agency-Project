﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Contact
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

    }
}
