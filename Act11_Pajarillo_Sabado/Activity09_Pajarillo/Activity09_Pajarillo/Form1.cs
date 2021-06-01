using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Activity09_Pajarillo
{
    public partial class Form1 : Form
    {
        private OleDbConnection bookCon;
        private OleDbCommand oleDbcmd = new OleDbCommand();

        //   private String conParam = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jeivee\source\repos\Activity09_Pajarillo\book3.accdb";
        private String conParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jeivee\source\repos\Activity09_Pajarillo\book3.mdb";
        public Form1()
        {
            bookCon = new OleDbConnection(conParam);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet1.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet.bookrecords);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookCon.Open();
            oleDbcmd.Connection = bookCon;

            oleDbcmd.CommandText = "Insert into bookrecords (booktitle, description)" + " "
                + "values (' " + this.tb_bookTitle.Text + "', '" + this.tb_desc.Text + "');";

            int temp = oleDbcmd.ExecuteNonQuery();
            if (temp > 0)
            {
                tb_bookTitle.Text = null;
                tb_desc.Text = null;
                MessageBox.Show("Record Added Successfully!");
            }
            else
            {
                MessageBox.Show("Something went wrong! Try Again");
            }
            bookCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("Select * from bookrecords", conParam);
            OleDbDataAdapter dAdapter1 = new OleDbDataAdapter("Select * from bookrecords", conParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dTable = new DataTable();
            DataSet dSet = new DataSet();

            dAdapter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dTable.Rows[i][0], dTable.Rows[i][1]);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bookCon.Open();
            oleDbcmd.Connection = bookCon;
            string query = "delete from bookrecords where BookTitle ='" + tb_bookTitle.Text+ "'";
            oleDbcmd.CommandText = query;

            oleDbcmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted!");
            bookCon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_bookTitle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_desc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookCon.Open();
            oleDbcmd.Connection = bookCon;
            string query = "update bookrecords set BookTitle ='" + tb_bookTitle.Text + "' where Description = '" + tb_desc.Text + "'";
            oleDbcmd.CommandText = query;
           // MessageBox.Show(query);
             oleDbcmd.ExecuteNonQuery();
            MessageBox.Show("record update successfully");
            bookCon.Close();
        }
    }
}
    