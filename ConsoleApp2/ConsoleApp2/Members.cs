using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;

  
        public Members(string memberName , string jobTitle, int salary, int age) 
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.age = age;
            Console.WriteLine($"Wellcome to the company {memberName}.");
        }

        //member property - exposes jobTitle safely 
        public string JobTitle 
        {
            get 
            { 
                return jobTitle; 
            } 
            set 
            {  
                jobTitle = value; 
            } 
        }

        // public member Method - can be called from order classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName} , and my job title is {jobTitle} . I'm {age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statement
            Console.WriteLine("Destruction of Members object.");
            Debug.Write("Destruction of member object.");
        }
    }
}
