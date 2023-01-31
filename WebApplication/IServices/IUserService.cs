using Entities.Entities;
using Resources.RequestModels;
using Resources.FilterModels;

namespace APIService.IServices
{
    public interface IUserService
    {
        int InsertUser(NewUserRequest newProductRequest);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(UserFilter userFilter);
    }
}