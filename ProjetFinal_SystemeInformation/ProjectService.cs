using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectService
    {
        private ProjectRepository _projectRepository = new ProjectRepository();

        public void CreateProject(Project project)
        {
            if (project == null)
                return;

            _projectRepository.CreateProject(project);
        }

        public List<Project> GetProjectsByUserId(int id)
        {
            return _projectRepository.GetProjectsByUserId(id);
        }

        public string GenerateJoinCode()
        {
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            return base64Guid;
        }
    }
}
