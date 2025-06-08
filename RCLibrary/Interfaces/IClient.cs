
using RCLibrary.Entities;

namespace RCLibrary.Interfaces
{
    //ToDo #1.1 Інтерфейс клієнта. +
    public interface IClient
    {
        bool RentCar(Auto auto);
        bool ReturnCar(Auto auto);
    }
}
