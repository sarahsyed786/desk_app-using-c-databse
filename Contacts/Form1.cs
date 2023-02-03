using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Contacts
{
    public partial class MyContacts : Form
    {
        public MyContacts()
        {
            InitializeComponent();
        }

        private void MyContacts_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            contacts cont = new contacts();
            cont.add_c(txt_name.Text, txt_number.Text);
            MessageBox.Show("Created Successully");
        }

        private void view_Click(object sender, EventArgs e)
        {
            contacts cont = new contacts();
            List<contacts> cl = cont.get_all_contacts();
            dataGridView1.DataSource = cl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
