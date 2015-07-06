﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF.Entities
{
    public class TrainingStudent
    {
        private String      _firstName;
        private String      _lastName;
        private String      _companyName;
        private int         _jobYear;
        private String      _courseName;
        private String      _teacherFirstName;
        private String      _teacherLastName;

        public TrainingStudent() { }

        public TrainingStudent(String firstName, String lastName, String companyName, int jobYear, String courseName, String teacherFirstName, String teacherLastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _companyName = companyName;
            _jobYear = jobYear;
            _courseName = courseName;
            _teacherFirstName = teacherFirstName;
            _teacherLastName = teacherLastName;
        }

        //GETTERS
        public String getFirstName()        { return _firstName; }
        public String getLastName()         { return _lastName; }
        public String getCompanyName()      { return _companyName; }
        public int    getJobYear()          { return _jobYear; }
        public String getCourseName()       { return _courseName; }
        public String getTeacherFirstName() { return _teacherFirstName; }
        public String getTeacherLastName()  { return _teacherLastName; }

        //SETTERS
        public void setFirstName(String firstName)                  { _firstName = firstName; }
        public void setLastName(String lastName)                    { _lastName = lastName; }
        public void setCompanyName(String companyName)              { _companyName = companyName; }
        public void setJobYear(int jobYear)                         { _jobYear = jobYear; }
        public void setCourseName(String courseName)                { _courseName = courseName; }
        public void getTeacherFirstName(String teacherFirstName)    { _teacherFirstName = teacherFirstName; }
        public void getTeacherLastName(String teacherLastName)      {_teacherLastName = teacherLastName; }
    }
}