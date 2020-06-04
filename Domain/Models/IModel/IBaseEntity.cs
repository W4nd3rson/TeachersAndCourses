using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.IModel
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreationDate { get; set; }
    }
}
