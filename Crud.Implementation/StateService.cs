using Crud.Entitities;
using Crud.Persistence;
using Crud.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Implementation
{
    public class StateService : IStateService
    {
        private readonly IRepository<State> repository;

        public StateService(IRepository<State> repository)
        {
            this.repository = repository;
        }

        public void Create(State state)
        {
            repository.Add(state);
            repository.SaveChanges();
        }

        public void Delete(State state)
        {
            repository.Delete(state);
            repository.SaveChanges();
        }

        public void Edit(State state)
        {
            repository.Update(state);
            repository.SaveChanges();
        }

        public State GetState(int id)
        {
            return repository.GetSingle(id);
        }


        public IEnumerable<State> GetStates()
        {
            return repository.GetAllWithIncludes(x => x.Country);
        }

      
    }
}
