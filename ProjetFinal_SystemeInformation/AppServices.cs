using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class AppServices
    {
        private AuthFacade _authFacade = new AuthFacade();
        private ProjectFacade _projectFacade = new ProjectFacade();

        public AuthFacade Auth => _authFacade;

        public ProjectFacade Project => _projectFacade;
    }
}