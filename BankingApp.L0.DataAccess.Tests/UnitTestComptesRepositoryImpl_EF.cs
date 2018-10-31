﻿using System;
using System.Collections.Generic;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L0.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestCreate()
        {
            // ARRANGE
            var nouveau = new Compte
              { Numero="C4000", Proprietaire = "Seifeddine", Solde=4000M};
            var underTest = new ComptesRepositoryImpl_EF();

            // ACT
            underTest.Create(nouveau);

            // ASSERT
        }
        [TestMethod]
        public void TestFindById_Nominal()
        {
            // ARRANGE
            var underTest = new ComptesRepositoryImpl_EF();
            var numero = "C4000";
            var expected = new Compte { Numero = "C4000", Proprietaire = "Seifeddine", Solde = 4000M };
           

            // ACT
            var actual = underTest.FindById(numero);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFindById_Degradé()
        {
            // ARRANGE
            var underTest = new ComptesRepositoryImpl_EF();
            var numero = "NNNNNNN";        


            // ACT
            var actual = underTest.FindById(numero);

            // ASSERT
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void TestFindAll()
        {
            // ARRANGE
            var underTest = new ComptesRepositoryImpl_EF();
            
            // ACT
            var actual =  (List<Compte>)underTest.FindAll();

            // ASSERT
            Assert.AreEqual(actual.Count, 4 );
        }
    }
}
