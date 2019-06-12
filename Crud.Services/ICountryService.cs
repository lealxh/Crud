using Crud.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Services
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int id);

        void Update(Country country);

        void Create(Country country);

        void Delete(int id);

    }
}
