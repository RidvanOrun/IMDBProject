
using IMDBProject.EntityLayer.Entities.Concrete;
using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.AccessLayer.Repositories.Interface
{
    public interface IAppUserRespository
    {
        void CreateAppUser(string firstName, string lastName, string userName, string passWord, Role role);
        void ModifiedAppUser(int id, string firstName, string lastName, string userName, string passWord, Role role);
        void PassiveAppUser(int id);
        void GetFindById(int id, TextBox txtFirstName, TextBox txtLastName,TextBox txtUserName,TextBox txtPassword);
        void GetRole(ComboBox comboBox);
      

        List<AppUser> GetAll();
        List<AppUser> GetUser();       
        
    }
}
