﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
   public  class Grade
    {
        private int note;
        private string nomCC;
        private int coeff;
        private string matiere;

        public Grade(int note,string nomCC,int coeff,string matiere)
        {
            this.note = note;
            this.nomCC = nomCC;
            this.coeff = coeff;
            this.matiere = matiere;
        }
        public int Note
        {
            get
            {
                return this.note;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The grade must be 0 or higher");
                }
                else
                {
                    this.note = value;
                }
            }
        }
        public string NomCC
        {
            get
            {
                return this.nomCC;
            }
            set
            {
                this.nomCC = value;
            }
        }
        public int Coeff
        {
            get
            {
                return this.coeff;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The coeff must be higher than 0");
                }
                else
                {
                    this.coeff = value;
                }
            }
        }
        public string Matiere
        {
            get
            {
                return this.matiere;
            }
            set
            {
                this.matiere = value;
            }
        }

    }
}
