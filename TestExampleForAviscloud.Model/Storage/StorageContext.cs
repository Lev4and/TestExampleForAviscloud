using System;
using System.Collections.Generic;
using TestExampleForAviscloud.Model.Storage.Entities;

namespace TestExampleForAviscloud.Model.Storage
{
    public class StorageContext
    {
        public List<Worker> Workers { get; set; }

        public Dictionary<Gender, string> Genders { get; }

        public StorageContext()
        {
            Workers = new List<Worker>()
            {
                new Worker()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пенкин Артем Вадимович",
                    Gender = Gender.Male,
                    Email = "penkin.artem.vadimovich.80@gmail.com",
                    DateOfBirth = new DateTime(1980, 9, 24),
                },
                new Worker()
                {
                    Id = Guid.NewGuid(),
                    Name = "Галактионов Сократ Ермакович",
                    Gender = Gender.Male,
                    Email = "galaktionov.socrates.ermakovich.97@gmail.com",
                    DateOfBirth = new DateTime(1997, 10, 20),
                },
                new Worker()
                {
                    Id = Guid.NewGuid(),
                    Name = "Меркулова Владлена Егоровна",
                    Gender = Gender.Female,
                    Email = "merkulova.vladlena.egorovna.80@mail.ru",
                    DateOfBirth = new DateTime(1987, 9, 20),
                },
                new Worker()
                {
                    Id = Guid.NewGuid(),
                    Name = "Смолова Клеопатра Владимировна",
                    Gender = Gender.Female,
                    Email = "smolova.cleopatra.vladimirovna.96@gmail.com",
                    DateOfBirth = new DateTime(1996, 12, 27),
                },
                new Worker()
                {
                    Id = Guid.NewGuid(),
                    Name = "Игнатова Раиса Эдуардовна",
                    Gender = Gender.Female,
                    Email = "ignatova.raisa.eduardovna.99@gmail.com",
                    DateOfBirth = new DateTime(1999, 7, 26),
                },
            };
            Genders = new Dictionary<Gender, string>()
            {
                { Gender.Male, "Мужской" },
                { Gender.Female, "Женский" }
            };
        }
    }
}
