﻿namespace APIService.IServices
{
    public interface ISecurityService
    {
        bool ValidateUserCredentials(string userName, string userPassWord, int idRol);
    }
}
