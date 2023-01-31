using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem() {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public UserItem OwnerUser { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get;  set; }
        public bool IsPublic { get; private set; }
        public decimal UnitPrice { get; set; }
        public string Brand { get; set; }
    }
}

