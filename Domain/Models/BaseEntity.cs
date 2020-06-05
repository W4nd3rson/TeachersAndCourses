using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.IModel;

namespace Domain.Models
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get ; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
