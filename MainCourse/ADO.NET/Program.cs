using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace ADO.NET
{
    using System.Configuration;
    using System.Data.SqlClient;

    using ADO.NET.Models;

    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {


            using (SqlConnection connection = GetConnection())
            {
                SqlCommand sqlCommand = new SqlCommand("select Name from Student", connection);

                var result = sqlCommand.ExecuteScalar();

                var students = GetAllStudents(connection);
                connection.Close();
            }
        }

        private static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoConnection"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        private static List<Student> GetAllStudents(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "select Id, Name, BirthDate, PhoneNumber, Email, GitHubLink, Notes from Student",
                connection);
            const int IdColumnIndex = 0;
            List<Student> students = new List<Student>();
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    student.BirthDate = reader.GetDateTime(2);
                    student.PhoneNumber = reader.GetString(3);
                    student.Email = reader.GetString(4);
                    student.GitHubLink = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    student.Notes = reader.IsDBNull(6) ? "" : reader.GetString(6);

                    student.Group = GetStudentGroup(student.Id);
                    student.Courses = GetStudentCourses(student.Id);
                    students.Add(student);
                }
            }

            return students;
        }

        private static List<Course> GetStudentCourses(int studentId)
        {
            List<Course> result = new List<Course>();
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand sqlCommand = new SqlCommand(
                    $@"
                   SELECT [Id]
                  ,[Name]
                  ,[StartDate]
                  ,[EndDate]
                  ,[PassCredits]
                  ,[HomeTasksCount]
              FROM [dbo].[Course] as c
              join StudentCourse as sc on sc.CourseId=c.Id
              where sc.StudentId =  {studentId}", connection);

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Course course = new Course();
                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        course.StartDate = reader.GetDateTime(2);
                        course.EndDate = reader.GetDateTime(3);
                        course.PassCredits = reader.GetInt32(4);
                        course.HomeTasksCount = reader.GetInt32(5);
                        result.Add(course);
                    }
                }
            }

            return result;
        }

        private static Group GetStudentGroup(int studentId)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand sqlCommand = new SqlCommand(
                    $@"
              SELECT g.Id
              ,g.GroupName
              FROM [dbo].[Group] as g
              join StudentGroup as sg on sg.GroupId = g.Id
              where sg.StudentId =  {studentId}",
                    connection);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    Group group = new Group();
                    group.Id = reader.GetInt32(0);
                    group.Name = reader.GetString(1);
                    return group;
                }
            }
        }
    }
}
