
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.RequestModels
{
    public class NewUserRequest
    {
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string UserName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int IdRol { get; set; }
        public string Password { get; set; }

        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            
            userItem.IdRol = IdRol;
            userItem.UserName = UserName;
            userItem.Password = Password;
            userItem.Email = Email;
            userItem.Id = Id;
            userItem.IdWeb = IdWeb;
            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}
