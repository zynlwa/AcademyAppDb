﻿using AcademyApp.Core.Entities.Common;

namespace AcademyApp.Core.Entities
{
    public class Group:BaseEntity
    {
        public string No { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; } 


    }
}
