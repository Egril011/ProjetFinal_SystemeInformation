using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class AppServices
    {
        private AuthFacade _authFacade;
        private ProjectFacade _projectFacade;

        public AppServices()
        {
            _authFacade = new AuthFacade(
                new AuthService(new UserRepository()), 
                new UserSession());

            _projectFacade = new ProjectFacade(
                new ProjectService(new ProjectRepository()), 
                new ProjectMembersService(new ProjectMembersRepository()));
        }

        public AuthFacade Auth => _authFacade;

        public ProjectFacade Project => _projectFacade;
    }
}