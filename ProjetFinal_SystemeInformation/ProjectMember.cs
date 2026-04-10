using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ProjectMember
    {
        public int ProjectId {get; private set;}
        public int UserId {get; private set;}
        public ProjectRole ProjectRole {get; private set;}
        public DateTime JoinedAt {get; private set;}

        public ProjectMember(int projectId, int userId, ProjectRole role)
        {
            ProjectId = projectId;
            UserId = userId;
            ProjectRole = role;
            JoinedAt = DateTime.Now;
        }
    }
}
