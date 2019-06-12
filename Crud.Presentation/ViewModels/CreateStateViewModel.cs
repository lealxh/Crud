using Crud.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Presentation.ViewModels
{
    public class CreateStateViewModel
    {
        public IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CountriesList { get; set; }
        public State State { get; set; }
    }
}
