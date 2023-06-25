using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOSWinForm
{
    public partial class BlogManagement : Form
    {
        private string connStr = "Server=SMILEE\\SQLEXPRESS;Database=BMOS;User Id=sa;Password=12345;";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public BlogManagement()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            string sqlStr = "SELECT * FROM Tbl_Blog";
            myAdapter = new SqlDataAdapter(sqlStr, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "Tbl_Blog");
            dt = ds.Tables["Tbl_Blog"];
            txtId.Enabled = false;

            dgvBlog.AutoGenerateColumns = false;
            dgvBlog.DataSource = dt;

            conn.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BlogManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Detail(object sender, EventArgs e)
        {

        }

        private void button_Delete(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("You surely want to delete?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();


                    string sqlStr = "DELETE FROM Tbl_Blog WHERE blog_id='" + txtId.Text + "'";
                    comm = new SqlCommand(sqlStr, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    LoadData();
                    MessageBox.Show("Successfully");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button_Edit(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();


                string sqlStr = "UPDATE Tbl_Blog SET name='" + txtName.Text + "', description='" + txtDesc.Text + "', date='" + txtDate.Text + "', status='" + cbStatus.Checked + "' WHERE blog_id='" + txtId.Text + "'";
                comm = new SqlCommand(sqlStr, conn);
                comm.ExecuteNonQuery();

                conn.Close();
                LoadData();
                MessageBox.Show("Successfully");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button_Add(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                if (
                    txtId.Text.Length > 0 &&
                    txtDate.Text.Length > 0 &&
                    txtDesc.Text.Length > 0 &&
                    txtName.Text.Length > 0)
                {




                    string sqlStr = "INSERT INTO Tbl_Blog (blog_id,name,description,date,status) VALUES ('" + txtId.Text + "', '" + txtName.Text + "', '" + txtDesc.Text + "', '" + txtDate.Text + "', '" + cbStatus.Checked + "')";
                    comm = new SqlCommand(sqlStr, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    LoadData();
                    MessageBox.Show("Successfully");
                }
                else { MessageBox.Show("Please type in!"); }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        private void button_Search(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            string sqlStr = "SELECT * FROM Tbl_Blog WHERE name = '" + txtSearch.Text + "'";
            myAdapter = new SqlDataAdapter(sqlStr, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "Tbl_Blog");
            dt = ds.Tables["Tbl_Blog"];
            txtId.Enabled = false;

            dgvBlog.AutoGenerateColumns = false;
            dgvBlog.DataSource = dt;

            conn.Close();
        }
        private void dgvBlog_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtId.Text = dt.Rows[row]["blog_id"].ToString();
            txtName.Text = dt.Rows[row]["name"].ToString();
            cbStatus.Checked = dt.Rows[row]["status"].ToString() == "True";
            txtDate.Text = dt.Rows[row]["date"].ToString();
            txtDesc.Text = dt.Rows[row]["description"].ToString();
        }

        private void dgvBlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Clear(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtName.Text = null;
            cbStatus.Checked = false;
            txtDate.Text = null;
            txtDesc.Text = null;
            txtId.Enabled = true;
        }
    }
}
