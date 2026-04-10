using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class Project
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Course { get; private set; }
        public int UserId { get; private set; }
        public string JoinCode { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Project(string name, string course, int userId, string joinCode, DateTime createdAt)
        {
            Name = name;
            Course = course;
            UserId = userId;
            JoinCode = joinCode;
            CreatedAt = createdAt;
        }

        public Project(int id, string name, string course, int userId, string joinCode, DateTime created)
        {
            Id = id;
            Name = name;
            Course = course;
            UserId = userId;
            JoinCode = joinCode;
            CreatedAt = created;
        }

        public override string ToString()
        {
            return $"Project Name: {Name} - " +
                $"Course: {Course}";
        }
    }
}