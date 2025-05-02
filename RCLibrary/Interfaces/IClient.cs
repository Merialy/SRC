
using RCLibrary.Entities;

namespace RCLibrary.Interfaces
{
    //ToDo #1.1 Интерфейс для клиента. +
    public interface IClient
    {
        bool RentCar(Auto auto);
        bool ReturnCar(Auto auto);
    }
}
