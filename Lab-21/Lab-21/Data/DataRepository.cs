using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Lab_21.Models;

namespace Lab_21.Data
{
    public class DataRepository : IDataRepository
    {
        public DataRepository(IConnectionStringManager connectionStringManager)
        {
            _connectionStringManager = connectionStringManager;
        }

        private readonly Dictionary<int, RegistrationModel> _data =
            new Dictionary<int, RegistrationModel>
            {
                { 1, new RegistrationModel
                    {
                        Id = 1,
                        UserName = "lottadam",
                        Email = "adam@coolemail.com",
                        Password = "Password123!"
                    }}
            };

        private readonly IConnectionStringManager _connectionStringManager;

        public RegistrationModel Get(int id)
        {
            if (_data.TryGetValue(id, out var registration))
            {
                return registration;
            }

            return null;
        }

        public void Add(RegistrationModel registration)
        {
            var id = _data.Keys.Max() + 1;
            _data[id] = registration;
            registration.Id = id;
        }

        public void Save(int id, RegistrationModel registration)
        {
            _data[id] = registration;
        }
    }
}
