using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int UserId { get; set; }
        public string JoinCode { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Course} {JoinCode}";
        }
    }
}