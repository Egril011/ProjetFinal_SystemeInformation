using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ProjectFacade
    {
        private ProjectService _projectService;
        private ProjectMembersService _projectMembersService;

        public ProjectFacade(ProjectService projectService, ProjectMembersService projectMembersService)
        {
            _projectService = projectService;
            _projectMembersService = projectMembersService;
        }

        public bool CreateProject(Project project)
        {
            if (project == null)
                return false;

            int projectId = _projectService.CreateProject(project);
            if (projectId <= 0)
                return false;

            return _projectMembersService.AddMemberToProject(projectId, project.UserId,
                    ProjectRole.Leader);
        }

        public void DeleteProject(int projectId, int userId)
        {
            if (_projectMembersService.IsUserProjectOwner(projectId, userId))
            {
                _projectMembersService.RemoveAllMembersFromProject(projectId);
                _projectService.DeleteProject(projectId);
                return;
            }

            _projectMembersService.RemoveMemberFromProject(projectId, userId);
        }

        public List<Project> GetProjectsByUserId(int userId)
        {
            return _projectService.GetProjectsByUserId(userId);
        }

        public int GetProjectLeader(int userId)
        {
            return _projectMembersService.GetProjectLeaderId(userId);
        }

        public List<int> GetProjectMembers(int projectId)
        {
            return _projectMembersService.GetProjectMembers(projectId);
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