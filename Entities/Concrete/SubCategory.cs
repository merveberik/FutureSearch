using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SubCategory : IEntity
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
    }
}
