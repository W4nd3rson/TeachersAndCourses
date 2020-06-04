using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.IModel;

namespace Domain.Models
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get ; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
