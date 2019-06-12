using Crud.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Services
{
    public interface IStateService
    {
        IEnumerable<State> GetStates();
        State GetState(int id);

        void Create(State state);

        void Edit(State state);

        void Delete(State state);
        

    }
}
