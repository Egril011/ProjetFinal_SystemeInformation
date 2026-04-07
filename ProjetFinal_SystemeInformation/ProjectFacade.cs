using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ProjectFacade
    {
        private ProjectService _projectService = new ProjectService();

        public void CreateProject(Project project)
        {
            _projectService.CreateProject(project);
        }

        public List<Project> GetProjectsByUserId(int id)
        {
            return _projectService.GetProjectsByUserId(id);
        }

        public string GenerateJoinCode()
        {
            return _projectService.GenerateJoinCode();
        }
    }
}