﻿using UnitTest.ClassLibrary.Entities;

namespace UnitTest.ClassLibrary
{
    public class TeacherManager
    {
        List<Teacher> _memoryTeachers;

        public TeacherManager()
        {
            _memoryTeachers = new List<Teacher>();
        }

        public Teacher Insert(Teacher teacher)
        {
            teacher.Id = Guid.NewGuid();
            _memoryTeachers.Add(teacher);
            return teacher;
        }
    }
}