using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectMembersService
    {
        private ProjectMembersRepository _projectMembersRepository = new ProjectMembersRepository();

        public bool AddMemberToProject(int projectId, int userId, ProjectRole projectRole)
        {
            if (_projectMembersRepository.MemberExists(projectId, userId))
                return false;

            ProjectMember projectMember
                = new ProjectMember(projectId, userId, projectRole);

            _projectMembersRepository.AddMemberToProject(projectMember);
            return true;
        }

        public int GetProjectLeaderId(int projectId)
        {
            return _projectMembersRepository.GetProjectLeaderId(projectId);
        }

        public List<int> GetProjectMembers(int projectId)
        {
            return _projectMembersRepository.GetProjectMembers(projectId);
        }
    }
}