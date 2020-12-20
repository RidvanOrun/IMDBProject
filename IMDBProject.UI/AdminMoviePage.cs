using IMDBProject.AccessLayer.Repositories.Concrete;
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
    public partial class AdminMoviePage : Form
    {
        public AdminMoviePage()
        {
            InitializeComponent();
        }
        EfMovieRepository efm = new EfMovieRepository();
        
        private void AdminMoviePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=efm.GetMovie();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        int id;
        void KayitSatiriSec()
        {
            // Burada datagridview de seçtiğimiz satırı Textboxlara dolduracak.
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            label5.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtMovieName.Text = dataGridView1.CurrentRow.Cells["MovieName"].Value.ToString();
            txtContent.Text = dataGridView1.CurrentRow.Cells["Content"].Value.ToString();
            txtImageUrl.Text = dataGridView1.CurrentRow.Cells["ImageUrl"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ProductionDate"].Value.ToString();
            txtREview.Text = dataGridView1.CurrentRow.Cells["MovieReview"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KayitSatiriSec();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            efm.ModifiedMovie(int.Parse(lbl5.Text) , txtMovieName.Text, txtContent.Text, txtImageUrl.Text, dateTimePicker1.Value, txtREview.Text);
            dataGridView1.DataSource = efm.GetMovie();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            efm.CreateMovie(txtMovieName.Text,txtContent.Text,txtImageUrl.Text,dateTimePicker1.Value,txtREview.Text);
            dataGridView1.DataSource= efm.GetMovie();
        }
    }
}
