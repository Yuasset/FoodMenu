using DAL.Models.Concretes;

namespace BLL.Services.Abstracts
{
    public interface IMenuItemServiceManager : IServiceManager<MenuItem>
    {
        //Özel metotlar
        IEnumerable<MenuItem> GetMenuItems(int key);
    }
}
