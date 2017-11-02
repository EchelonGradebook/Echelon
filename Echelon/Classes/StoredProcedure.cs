using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using System.Data;

namespace Echelon.Classes
{
    public class StoredProcedure
    {
        protected string ConStr = "Server=tcp:echelongradebook.database.windows.net,1433;Initial Catalog=GradeBook;Persist Security Info=False;User ID=joshpadams123;Password=Jpa12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        protected SqlConnection conn = null;
        protected SqlDataReader rdr = null;

        public List<string> getCourses(string user)
        {
            List<string> courses = new List<string>();
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                new SqlCommand("getCourses", conn).CommandType = CommandType.StoredProcedure;
                rdr = new SqlCommand("getCourses", conn).ExecuteReader();

                while (rdr.HasRows)
                {
                    courses.Add(rdr["CourseName"].ToString());
                }

                return courses;
            }
            finally{closeDB();}
        }
        public List<string> getCourseGrades(string user)
        {
            List<string> grades = new List<string>();
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                new SqlCommand("getCourseGrades", conn).CommandType = CommandType.StoredProcedure;
                rdr = new SqlCommand("getCourseGrades", conn).ExecuteReader();

                while (rdr.HasRows)
                {
                    grades.Add(rdr["CourseGrade"].ToString());
                }

                return grades;
            }
            finally { closeDB(); }
        }
        public List<string> getCourseAssignments(string user)
        {
            List<string> assignments = new List<string>();  
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                new SqlCommand("getCourseAssignments", conn).CommandType = CommandType.StoredProcedure;
                rdr = new SqlCommand("getCourseAssignments", conn).ExecuteReader();

                while (rdr.HasRows)
                {
                    assignments.Add(rdr["AssignmentName"].ToString());
                }

                return assignments;
            }
            finally { closeDB(); }
        }
        public List<string> getAssignmentGrades(string user, string course)
        {
            List<string> assignmentGrades = new List<string>();
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                new SqlCommand("getAssignmentGrades", conn).CommandType = CommandType.StoredProcedure;
                rdr = new SqlCommand("getAssignmentGrades", conn).ExecuteReader();

                while (rdr.HasRows)
                {
                    assignmentGrades.Add(rdr["AssignmentGrade"].ToString());
                }

                return assignmentGrades;
            }
            finally { closeDB(); }
        }
        public List<string> getAttendance(string user, string course)
        {
            List<string> attendance = new List<string>();
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                new SqlCommand("getAttendance", conn).CommandType = CommandType.StoredProcedure;
                rdr = new SqlCommand("getAttendance", conn).ExecuteReader();

                while (rdr.HasRows)
                {
                    attendance.Add(rdr["Attendance"].ToString());
                }

                return attendance;
            }
            finally { closeDB(); }
        }

        public void closeDB()
        {
            if (conn != null)
            {
                conn.Close();
            }
            if (rdr != null)
            {
                rdr.Close();
            }
        }
    }
}
