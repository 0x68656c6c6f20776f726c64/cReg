﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cReg_WebApp.Models.Objects
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; }
        private List<Course> CourseSet = new List<Course>();
        private List<Student> StudentSet = new List<Student>();

        public Faculty() { }

        public Faculty(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public bool AddToCourseSet(Course course)
        {
            //To prevent duplicates
            bool result = false;
            foreach (var cor in CourseSet) if (!result)
                {
                    if (cor.Id == course.Id)
                    {
                        CourseSet.Remove(cor);
                        result = true;
                    }
                }
            CourseSet.Add(course);
            return result;
        }

        public void RemoveFromCourseSet(Course course)
        {
            CourseSet.Remove(course);
        }

        public List<Student> GetStudents()
        {
            return StudentSet;
        }

        public List<Course> GetCoursesOffered()
        {
            return CourseSet;
        }

        public bool AddStudentToFaculty(Student student)
        {
            //To prevent duplicates
            bool result = false;
            foreach (var stu in StudentSet) if (!result)
                {
                    if (stu.Id == student.Id)
                    {
                        StudentSet.Remove(stu);
                        result = true;
                    }
                }
            StudentSet.Add(student);
            return result;
        }

        public void RemoveStudentFromFaculty(Student student)
        {
            StudentSet.Remove(student);
        }
    }
}