using IMDBProject.AccessLayer.Context;
using IMDBProject.AccessLayer.Repositories.Concrete;
using IMDBProject.AccessLayer.Repositories.Interface;
using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.UI
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();

        }
        ProjectContext db = new ProjectContext();
        EfAppUserRepository ef = new EfAppUserRepository();
        private void AppUserPage_Load(object sender, EventArgs e)
        {
            ef.GetRole(cbxRole);
            dataGridView1.DataSource = ef.GetUser();
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ef.CreateAppUser(txtFirstName.Text,txtLastName.Text,txtUserName.Text,txtPassWord.Text,(Role)Enum.Parse(typeof(Role), cbxRole.Text));
            dataGridView1.DataSource = ef.GetUser();
            ef.Eraser(gbxUserProcess);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ef.PassiveAppUser(int.Parse(txtFindById.Text));
            dataGridView1.DataSource = ef.GetUser();
            ef.Eraser(gbxUserProcess);
            
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            ef.GetFindById(int.Parse(txtFindById.Text),txtFirstName,txtLastName,txtUserName,txtPassWord);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ef.ModifiedAppUser(int.Parse(txtFindById.Text),txtFirstName.Text,txtLastName.Text,txtUserName.Text,txtPassWord.Text,(Role)Enum.Parse(typeof(Role), cbxRole.Text));
            db.SaveChanges();
            dataGridView1.DataSource = ef.GetUser();
            ef.Eraser(gbxUserProcess);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ef.GetAll();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ef.GetUser();
        }
    }
}
