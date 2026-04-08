using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ProjectFacade
    {
        private ProjectService _projectService = new ProjectService();
        private ProjectMembersService _projectMembersService = new ProjectMembersService();

        public bool CreateProject(Project project)
        {
            if(project == null)
                return false;

            int projectId = _projectService.CreateProject(project);
            if (projectId <= 0)
                return false;

            return _projectMembersService.AddMemberToProject(projectId, project.UserId,
                    ProjectRole.Leader);
        }

        public List<Project> GetProjectsByUserId(int userId)
        {
            return _projectService.GetProjectsByUserId(userId);
        }

        public int GetProjectLeader(int id)
        {
            return _projectMembersService.GetProjectLeaderId(id);
        }

        public List<int> GetProjectMembers(int id)
        {
            return _projectMembersService.GetProjectMembers(id);
        }

        public bool JoinProject(string joinCode, int userId)
        {
            Project? project = _projectService.GetProjectByJoinCode(joinCode);
            if (project == null)
                return false;

           return _projectMembersService.AddMemberToProject(project.Id, userId, 
                ProjectRole.Member);
        }

        public string GenerateJoinCode()
        {
            return _projectService.GenerateJoinCode();
        }
    }
}