﻿using BankingApp.L0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Facade
{
    public interface IComptesRepository
    {
        // CRUD Contract

        void Create(Compte c);  // C du CRUD
        Compte FindById(string id); //  R (Retrieve) = Find = Get

        IEnumerable<Compte> FindAll();    // un autre R

        void Update(Compte c);    // U du CRUD

        void Delete(string id); // D du CRUD

    }
}
