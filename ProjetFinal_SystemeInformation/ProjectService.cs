using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectService
    {
        private ProjectRepository _projectRepository = new ProjectRepository();
        private ProjectMembersRepository _projectMembersRepository = new ProjectMembersRepository();

        public void CreateProject(Project project)
        {
            if (project == null)
                return;

            int projectId = _projectRepository.CreateProject(project);
            _projectMembersRepository.AddMemberToProject(projectId, project.UserId,
                ProjectRole.Leader);
        }

        public List<Project> GetProjectsByUserId(int id)
        {
            return _projectRepository.GetProjectsByUserId(id);
        }

        public bool JoinProject(string joinCode)
        {
            Project project = _projectRepository.GetProjectByJoinCode(joinCode);
            if (project == null)
                return false;

            if (_projectMembersRepository.ExistMember(project.Id, project.UserId))
                return false;

            _projectMembersRepository.AddMemberToProject(project.Id, project.UserId,
                ProjectRole.Member);

            return true;
        }

        public string GenerateJoinCode()
        {
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            base64Guid = base64Guid.Substring(0, 8);
            return base64Guid;
        }
    }
}
