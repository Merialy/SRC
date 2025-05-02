
using RCLibrary.Entities;

namespace RCLibrary.Interfaces
{
    //ToDo #1.3 Интерфейс для администратора. +
    public interface IAdministrator : IManager
    {
        bool AddManager(Manager manager);
        bool RemoveManager(int value);

        bool AddAdmin(Administrator administrator);
        bool RemoveAdmin(int value);
    }
}
