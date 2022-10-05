using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer player = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = 50};

        [TestMethod()]
        public void IdValidatorTest()
        {
            player.IdValidator();

            FootballPlayer zeroId = new FootballPlayer() { Id = 0, Age = 23, Name = "Football player", ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentNullException>(() => zeroId.IdValidator());

            FootballPlayer minusId = new FootballPlayer() { Id = -1, Age = 23, Name = "Football player", ShirtNumber = 50 };
            minusId.IdValidator();
        }

        [TestMethod()]
        public void NameValidatorTest()
        {
            player.NameValidator();

            FootballPlayer nullName = new FootballPlayer() { Id = 0, Age = 23, Name = null, ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentNullException>(() => nullName.NameValidator());

            FootballPlayer lesThanTwoName = new FootballPlayer() { Id = 0, Age = 23, Name = "E", ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => lesThanTwoName.NameValidator());

            FootballPlayer emptyName = new FootballPlayer() { Id = 0, Age = 23, Name = "", ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => emptyName.NameValidator());

            FootballPlayer threeName = new FootballPlayer() { Id = 0, Age = 23, Name = "Mes", ShirtNumber = 50 };
            threeName.NameValidator();
        }

        [TestMethod()]
        public void AgeValidatorTest()
        {
            player.AgeValidator();

            FootballPlayer zeroAge = new FootballPlayer() { Id = 1, Age = 0, Name = "Football player", ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => zeroAge.AgeValidator());

            FootballPlayer oneAge = new FootballPlayer() { Id = 1, Age = 1, Name = "Football player", ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => oneAge.AgeValidator());

            FootballPlayer twoAge = new FootballPlayer() { Id = 1, Age = 2, Name = "Football player", ShirtNumber = 50 };
            twoAge.AgeValidator();
        }

        [TestMethod()]
        public void ShirtNumberValidatorTest()
        {
            player.ShirtNumberValidator();

            FootballPlayer zeroShirt = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = 0 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => zeroShirt.ShirtNumberValidator());

            FootballPlayer minusShirt = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = -1 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => minusShirt.ShirtNumberValidator());

            FootballPlayer oneShirt = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = 1 };
            oneShirt.ShirtNumberValidator();

            FootballPlayer ninetyNineShirt = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = 99 };
            ninetyNineShirt.ShirtNumberValidator();

            FootballPlayer hundredShirt = new FootballPlayer() { Id = 1, Age = 23, Name = "Football player", ShirtNumber = 100 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => hundredShirt.ShirtNumberValidator());
        }
    }
}