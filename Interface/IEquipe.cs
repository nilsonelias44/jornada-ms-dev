using E_JOGOSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOSS.Interface
{
    interface IEquipe
    {
        //create
        void Create(Equipe nova_equipe);

        //read all
        List<Equipe> ReadAll();

        //update
        void Update(Equipe equipe);

        //delete
        void Delete(int idEquipe);
    }
}
