using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ProjectMembersService
    {
        private ProjectMembersRepository _projectMembersRepository;

        public ProjectMembersService(ProjectMembersRepository projectMembersRepository) 
        {
            _projectMembersRepository = projectMembersRepository;
        }

        public bool AddMemberToProject(int projectId, int userId, ProjectRole projectRole)
        {
            if (_projectMembersRepository.MemberExists(projectId, userId))
                return false;

            ProjectMember projectMember
                = new ProjectMember(projectId, userId, projectRole);

            _projectMembersRepository.AddMemberToProject(projectMember);
            return true;
        }

        public void RemoveAllMembersFromProject(int projectId)
        {
            _projectMembersRepository.RemoveAllMembersFromProject(projectId); 
        }

        public bool RemoveMemberFromProject(int projectId, int userId)
        {
            if (!_projectMembersRepository.MemberExists(projectId, userId))
                return false;

            _projectMembersRepository.RemoveMemberFromProject(projectId, userId);
            return true;
        }

        public int GetProjectLeaderId(int projectId)
        {
            return _projectMembersRepository.GetProjectLeaderId(projectId);
        }

        public bool IsUserProjectOwner(int projectId, int userId)
        {
            if(!_projectMembersRepository.MemberExists(projectId, userId))
                return false;

            return _projectMembersRepository.IsUserProjectLeader(projectId, userId);
        }

        public List<int> GetProjectMembers(int projectId)
        {
            return _projectMembersRepository.GetProjectMembers(projectId);
        }
    }
}