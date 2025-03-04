using c__contact.econtactClasses;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace c__contact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        contactClass conc = new contactClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conc.FirstName = txtFirstName.Text;
            conc.LastName = txtLastName.Text;
            conc.ContactNo = txtContactNo.Text;
            conc.Address = txtAddress.Text;
            conc.Gender = cmbGender.Text;

            bool success = conc.Insert(conc);

            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Try again.");
            }

            DataTable dt = conc.Select();
            dgvContactList.DataSource = dt;
        }

        private void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = conc.Select();
            dgvContactList.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtContactID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conc.ContactID = int.Parse(txtContactID.Text);
            conc.FirstName = txtFirstName.Text;
            conc.LastName = txtLastName.Text;
            conc.ContactNo = txtContactNo.Text;
            conc.Address = txtAddress.Text;
            conc.Gender = cmbGender.Text;

            bool successUpdate = conc.Update(conc);

            if (successUpdate == true)
            {
                MessageBox.Show("Contact has been successfully updated.");
                DataTable dt = conc.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact. Try again.");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conc.ContactID = Convert.ToInt32(txtContactID.Text);

            bool successDelete = conc.Delete(conc);

            if (successDelete)
            {
                MessageBox.Show("Contact has been successfully deleted.");
                DataTable dt = conc.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Try again.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%"+ keyword +"%' OR Address LIKE '%"+ keyword +"%' OR ContactNo LIKE '%"+ keyword +"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}
