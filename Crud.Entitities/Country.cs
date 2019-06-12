using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crud.Entitities
{
    public class Country:IEntity
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
