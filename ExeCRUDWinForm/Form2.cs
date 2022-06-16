using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUDWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barang_inputDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.barang_inputDataSet.Table);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=Barang_input;User ID=sa;Password=***********;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Table(Id_Barang,Nama,Tipe,Barang) VALUES(@Id_Barang,@Nama,@Tipe,@Barang)", con);
            cmd.Parameters.AddWithValue("@Id_Barang", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@Nama", int.Parse(txtnm.Text));
            cmd.Parameters.AddWithValue("@Tipe", int.Parse(txttp.Text));
            cmd.Parameters.AddWithValue("@Barang", int.Parse(txtbr.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtnm.Text = "";
            txttp.Text = "";
            txtbr.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=Barang_input;User ID=sa;Password=***********;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Table SET Nama Pembeli=@Nama Tipe Barang=@Tipe Nama Barang=@Barang WHERE Id Barang=@Id_Barang)", con);
            cmd.Parameters.AddWithValue("@Id_Barang", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@Nama", int.Parse(txtnm.Text));
            cmd.Parameters.AddWithValue("@Id_Barang", int.Parse(txttp.Text));
            cmd.Parameters.AddWithValue("@Id_Barang", int.Parse(txtbr.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtnm.Text = "";
            txttp.Text = "";
            txtbr.Text = "";

            MessageBox.Show("Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=Barang_input;User ID=sa;Password=***********;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Table WHERE Id Barang=@Id_Barang", con);
            cmd.Parameters.AddWithValue("@Id_Barang", int.Parse(txtid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtnm.Text = "";
            txttp.Text = "";
            txtbr.Text = "";

            MessageBox.Show("Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=Barang_input;User ID=sa;Password=***********;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Table", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
