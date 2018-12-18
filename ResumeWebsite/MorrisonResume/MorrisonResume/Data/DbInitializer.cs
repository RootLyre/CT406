using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MorrisonResume.Models;
namespace MorrisonResume.Data
{
    //This class initializes the database with pre-loaded information into the 3 databases: Student, Company and Job
    public class DbInitializer
    {
        public static void Initialize(MorrisonResumeContext context)
        {
            //if student database is already created, return it
            if (context.Student.Any())
            {
                return;
            }

            //if not, create it with the specified entries
            var students = new Student[]
            {
                new Student{StudentId=1,FirstName="Alan",LastName="Morrison"}
            };

            //save it to the MorrisonResumeContext
            foreach(Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            //create a database for Jobs
            var jobs = new Job[]
            {
                new Job{JobId=0001, JobTitle="Clerk 1", StartDate="June 2015", EndDate="August 2015"},
                new Job{JobId=0002, JobTitle="Bakery Clerk", StartDate="March 2018", EndDate="October 2018"}
            };

            //save it to context
            foreach(Job j in jobs)
            {
                context.Job.Add(j);
            }
            context.SaveChanges();


            //create database for companies
            var companies = new Company[]
            {
                new Company{CompanyName="Trax at Goddard Space Flight Center", StudentId=1, JobId=0001},
                new Company{CompanyName="Safeway", StudentId=1, JobId=0002}
            };

            //save it to context
            foreach(Company c in companies)
            {
                context.Company.Add(c);
            }
            context.SaveChanges();
        }
    }
}
