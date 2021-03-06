﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    class PanelCourse : Panel
    {
        public Label name { get; set; }
        public Label averageLabel { get; set; }
        public Label average { get; set; }
        public List<LabelGrade> grades { get; set; }
        public Label attRate { get; set; }
        public Label attNumber { get; set; }
        public CheckBox check { get; set; }
        public Label lateLabel { get; set; }
        public CheckBox late { get; set; }

        public Label status { get; set; }
        public PanelCourse(Label name, Label averageLabel, Label average, List<LabelGrade> grades)
        {
            this.name = name;
            this.averageLabel = averageLabel;
            this.average = average;
            this.grades = grades;
        }
        public PanelCourse(Label name, Label attRate,Label attNumber)
        {
            this.name = name;
            this.attRate = attRate;
            this.attNumber = attNumber;
        }
        public PanelCourse(Label name, Label status, CheckBox check, Label lateLabel, CheckBox late)
        {
            this.name = name;
            this.status = status;
            this.check = check;
            this.lateLabel = lateLabel;
            this.late = late;
            Controls.Add(status);
            Controls.Add(name);
            Controls.Add(check);
            Controls.Add(lateLabel);
            Controls.Add(late);
        }

    }
}
