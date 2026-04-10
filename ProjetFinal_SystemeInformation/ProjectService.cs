using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectService
    {
        private ProjectRepository _projectRepository = new ProjectRepository();

        public int CreateProject(Project project)
        {
            if(project == null)
                return -1;

            return _projectRepository.CreateProject(project);
        }

        public void RemoveUserFromProject(int projectId, int userId)
        {
            _projectRepository.RemoveUserFromProject(projectId, userId);
        }

        public void DeleteProject(int projectId)
        {
            _projectRepository.DeleteProject(projectId);
        }

        public List<Project> GetProjectsByUserId(int id)
        {
            return _projectRepository.GetProjectsByUserId(id);
        }

        public Project? GetProjectByJoinCode(string joinCode)
        {
            if(joinCode == String.Empty)
                return null;

            return _projectRepository.GetProjectByJoinCode(joinCode);
        }

        public string GenerateJoinCode()
        {
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            base64Guid = base64Guid.Replace("/", "A").Replace("+", "B").Replace("=", "C")
                .Substring(0, 10);

            return base64Guid;
        }
    }
}