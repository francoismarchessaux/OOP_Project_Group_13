﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13.Users
{
    public abstract class User
    {
        public string name { get; set; }
        public string firstName { get; set; }
        public string status { get; set; }
        public string password { get; set; }
        public int ID { get; set; }
        public string mail { get; set; }
        public int phone { get; set; }

        public User (string _name, string _firstName, string _status, string _password, int _ID, string _mail, int _phone)
        {
            name = _name;
            firstName = _firstName;
            status = _status;
            password = _password;
            ID = _ID;
            mail = _mail;
            phone = _phone;
        }
    }
}
