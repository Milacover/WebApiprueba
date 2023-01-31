
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
        public int IdPerson { get; set; }
        public int IdRol { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }

        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            
            userItem.IdRol = IdRol;
            userItem.UserName = Name;
            userItem.Password = Password;

            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}
