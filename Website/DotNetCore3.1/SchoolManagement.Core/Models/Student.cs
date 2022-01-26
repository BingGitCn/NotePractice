﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagement.Core.Models.Enums;

namespace SchoolManagement.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 主修科目
        /// </summary>
        public MajorEnum Major { get; set; }
        public string Email { get; set; }
    }
}