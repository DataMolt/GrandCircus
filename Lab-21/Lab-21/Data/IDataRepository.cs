using Lab_21.Models;

namespace Lab_21.Data
{
    public interface IDataRepository
    {
        RegistrationModel Get(int id);
        void Add(RegistrationModel registration);
        void Save(int id, RegistrationModel registration);
    }
}