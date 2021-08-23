using System;
using System.Collections.Generic;
using TestExampleForAviscloud.Model.Storage.Entities;

namespace TestExampleForAviscloud.WebApplication.Models
{
    public class WorkersViewModel
    {
        public DateTime MinDateOfBirth { get; set; }

        public DateTime MaxDateOfBirth { get; set; }

        public Worker Worker { get; set; }

        public List<Worker> Workers { get; set; }

        public Dictionary<Gender, string> Genders { get; set; }
    }
}
