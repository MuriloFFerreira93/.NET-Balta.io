using System;
using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace ConsoleBlog_DapperContrib.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection = Database.Connection;

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();

        public void Create(T model)
            => _connection.Insert(model);

        public void Update(T model)
            => _connection.Update(model);

        public void Delete(T model)
            => _connection.Delete(model);

        public void Delete(int Id)
        {
            var model = _connection.Get<T>(Id);
            _connection.Delete(model);
        }
    }
}
