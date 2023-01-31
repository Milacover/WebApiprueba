using Data;
using Entities.Entities;
using Logic.ILogic;
using APIService.IServices;

namespace APIService.Services
{
    
        public class SecurityService : ISecurityService
        {
            //private readonly ServiceContext _serviceContext;
            private readonly ISecurityLogic _securityLogic;
            public SecurityService(ServiceContext serviceContext, ISecurityLogic securityLogic)
            {
                //_serviceContext = serviceContext;
                _securityLogic = securityLogic;
            }
            public bool ValidateUserCredentials(string userName, string userPassWord, int idRol)
            {
                //esto iba en la lógica! upsi

                //sería así

                return _securityLogic.ValidateUserCredentials(userName, userPassWord, idRol);

            }
        }
    }

