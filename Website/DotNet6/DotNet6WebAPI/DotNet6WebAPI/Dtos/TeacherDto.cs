﻿using DotNet6WebAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotNet6WebAPI.Dtos
{
    public class TeacherDto
    {
        /// <summary>
        /// id
        /// </summary>
        [Required]
        public string Id { get; set; }
        /// <summary>
        /// name(名称)
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage = "The length of the name is 0-50.(名字的长度为0-50。)")]
        public string Name { get; set; }
        /// <summary>
        /// age(年龄)
        /// </summary>
        public int Age { get; set; }
        public TeacherLevel TeacherLevel { get; set; }
    }
}