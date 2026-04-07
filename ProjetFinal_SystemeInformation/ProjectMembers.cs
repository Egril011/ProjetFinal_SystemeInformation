using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectMembers
    {
        private int _projectId;
        private string _userId;
        private ProjectRole projectRole;
        private DateTime _joinedAt;

        public ProjectMembers(int projectId, string userId, ProjectRole role)
        {
            _projectId = projectId;
            _userId = userId;
            projectRole = role;
            _joinedAt = DateTime.Now;
        }

        public int ProjectId => _projectId;
        public string UserId => _userId;
        public ProjectRole ProjectRole => projectRole;
        public DateTime JoinedAt => _joinedAt;
    }
}
