using IMDBProject.AccessLayer.Context;
using IMDBProject.AccessLayer.Repositories.Interface;

using IMDBProject.EntityLayer.Entities.Concrete;
using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.AccessLayer.Repositories.Concrete
{
    public class EfAppUserRepository : EfBaseRepository, IBaseRepository, IAppUserRespository
    {
        public AppUser appuser;

        public EfAppUserRepository()
        {
            appuser = new AppUser();

        }
        
      
        
        public void CreateAppUser(string firstName, string lastName, string userName, string passWord, Role role)
        {
            appuser.FirstName = firstName;
            appuser.LastName = lastName;
            appuser.UserName = userName;
            appuser.PAssword = passWord;
            appuser.Role = role;
            appuser.CreateDate = DateTime.Now;           
            appuser.Status = Status.Active;
            db.AppUsers.Add(appuser);
            db.SaveChanges();

        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public void GetFindById(int id, TextBox txtFirstName, TextBox txtLastName, TextBox txtUserName,TextBox txtPassword)
        {
            appuser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            txtFirstName.Text = appuser.FirstName;
            txtLastName.Text = appuser.LastName;
            txtUserName.Text = appuser.UserName;
            txtPassword.Text = appuser.PAssword;
        }

        public void GetRole(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBox.SelectedIndex = 1;
        }

        public List<AppUser> GetUser()
        {
            return db.AppUsers.Where(x => x.Status != Status.Passive).ToList();
        }

        public void ModifiedAppUser(int id, string firstName, string lastName, string userName, string passWord, Role role)
        {
            appuser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appuser.FirstName = firstName;
            appuser.LastName = lastName;
            appuser.PAssword = passWord;
            appuser.Role = role;
            appuser.ModifiedDate = DateTime.Now;
            appuser.Status = Status.Modified;
            db.SaveChanges();
        }

        public void PassiveAppUser(int id)
        {
            appuser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appuser.ModifiedDate = DateTime.Now;
            appuser.Status = Status.Passive;
            db.SaveChanges();
        }
    }
}

