﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Repositories

{
    public interface IRepository<T> : IDisposable
            where T : class
    {
        IEnumerable<T> GetAll(); // получение всех объектов
        T GetById(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }


}
