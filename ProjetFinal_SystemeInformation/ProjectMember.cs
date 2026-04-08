using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectMember
    {
        private int _projectId;
        private int _userId;
        private ProjectRole _projectRole;
        private DateTime _joinedAt;

        public ProjectMember(int projectId, int userId, ProjectRole role)
        {
            _projectId = projectId;
            _userId = userId;
            _projectRole = role;
            _joinedAt = DateTime.Now;
        }

        public int ProjectId => _projectId;
        public int UserId => _userId;
        public ProjectRole ProjectRole => _projectRole;
        public DateTime JoinedAt => _joinedAt;
    }
}
