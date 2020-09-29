﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Employee
    {
        //attributes
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string bsn { get; set; } //social security number in the Netherlands
        public string postion { get; set; }//their role in the company. To be potentially replaced by Enum later
        public int workinghours { get; set; }
        public string phoneNr { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string emergencyC { get; set; } //full name of emergency contact
        public string emergencyR { get; set; }//How this contact relates to the employee? (Spouse, sibling, parent etc)
        public string emergencyNr { get; set; } //emergency contact phone number for contact
        public string certifications { get; set; } //primarily relevant for depo workers
        public string languages { get; set; }//primarily relevant for sales reps, cashiers and customer support
        public string contract { get; set; }
        public string duration { get; set; }

        //string first_name, string last_name, DateTime date_of_birth, string bsn, string postion, int workinghours, string phoneNr, string address, string email, string emergencyC, string emergencyR, string emergencyNr, string certifications, string languages, string contract, string duratio
        //properties
        public int Id
        {
            get { return this.id; }
        }

        public string Firstname
        {
            get { return this.first_name; }
        }

        public string Lastname
        {
            get { return this.last_name; }
        }

        //constructors
        public Employee(string first_name, string last_name, DateTime date_of_birth, string bsn, string postion, int workinghours, string phoneNr, string address, string email, string emergencyC, string emergencyR, string emergencyNr, string certifications, string languages, string contract, string duration)
        {
            
            this.first_name = first_name;
            this.last_name = last_name;
            this.date_of_birth = date_of_birth;
            this.bsn = bsn;
            this.postion = postion;
            this.phoneNr = phoneNr;
            this.workinghours = workinghours;
            this.emergencyC = emergencyC;
            this.emergencyNr = emergencyNr;
            this.emergencyR = emergencyR;
            this.address = address;
            this.certifications = certifications;
            this.contract = contract;
            this.duration = duration;
            this.email = email;
            this.languages = languages;
            
        }

        public Employee(string first_name, string last_name)
        {

            this.first_name = first_name;
            this.last_name = last_name;
            

        }

        public Employee(int id, string first_name, string last_name)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
        }

        public Employee()
        {

        }



        //methods
        public string GetEmployeeInfo()
        {
            return $"{this.id} {this.first_name} {this.last_name}";
        }

    }
}
