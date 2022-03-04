﻿using RestWithASPNETUdemy.Models;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersorService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(Person person);
    }
}