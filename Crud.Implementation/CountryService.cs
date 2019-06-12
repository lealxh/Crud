using Crud.Entitities;
using Crud.Persistence;
using Crud.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Implementation
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> repository;

        public CountryService(IRepository<Country> repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Country> GetCountries()
        {
            return repository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return repository.GetSingle(id);
        }

        public void  Update(Country country)
        {
            repository.Update(country);
            repository.SaveChanges();
        }

        public void Create(Country country)
        {
            repository.Add(country);
            repository.SaveChanges();
        }

        public void Delete(int id)
        {
            repository.Delete(repository.GetSingle(id));
            repository.SaveChanges();
        }
    }
}
