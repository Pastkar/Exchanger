﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDay { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public int Passport { get; set; }
    }
}
