using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Entitities
{
    public class State :IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
