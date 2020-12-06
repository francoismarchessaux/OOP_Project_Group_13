﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    class ButtonClass : Button
    {
        public Course course { get; set; }
        public string name { get; set; }
        public ButtonClass() { }

        public ButtonClass(string _name)
        {
            name = _name;
        }
        public ButtonClass(Course _course)
        {
            course = _course;
        }
    }
}