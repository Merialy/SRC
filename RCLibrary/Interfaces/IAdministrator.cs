
using RCLibrary.Entities;

namespace RCLibrary.Interfaces
{
    //ToDo #1.3 Інтерфейс для адміністратора. +
    public interface IAdministrator : IManager
    {
        bool AddManager(Manager manager);
        bool RemoveManager(int value);

        bool AddAdmin(Administrator administrator);
        bool RemoveAdmin(int value);
    }
}
