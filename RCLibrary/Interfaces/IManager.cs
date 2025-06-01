
using RCLibrary.Entities;

namespace RCLibrary.Interfaces
{
    //ToDo #1.2 Інтерфейс менеджера. +
    public interface IManager
    {
        bool AddCar(Auto car);
        bool RemoveCar(int value);
        bool AddClient(Client client);
        bool RemoveClient(int value);

        bool AddContract(Contract newContract);
        bool RemoveContract(int value);
    }
}
