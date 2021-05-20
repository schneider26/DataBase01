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

namespace DataBase01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void download_button1_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT * FROM table1";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
					
					DGV1.Rows.Add(dbReader["ID"], dbReader["Last_name"], dbReader["Name"], dbReader["Code"], dbReader["Phone"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void add_button1_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV1.SelectedRows[0].Index;
            if (DGV1.Rows[index].Cells[0].Value == null ||
                DGV1.Rows[index].Cells[1].Value == null ||
                DGV1.Rows[index].Cells[2].Value == null ||
                DGV1.Rows[index].Cells[3].Value == null ||
                DGV1.Rows[index].Cells[4].Value == null )
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string ID = DGV1.Rows[index].Cells[0].Value.ToString();
            string Last_name = DGV1.Rows[index].Cells[1].Value.ToString();
            string Name = DGV1.Rows[index].Cells[2].Value.ToString();
            string Code = DGV1.Rows[index].Cells[3].Value.ToString();
            string Phone = DGV1.Rows[index].Cells[4].Value.ToString();
           
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "INSERT INTO table1 VALUES " +
                "(" + ID + ", '" + Last_name + "', '" + Name + "', " + Code + ", '" + Phone +  "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");
            dbConnection.Close();
        }

        private void update_button1_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV1.SelectedRows[0].Index;
            if (DGV1.Rows[index].Cells[0].Value == null ||
                DGV1.Rows[index].Cells[1].Value == null ||
                DGV1.Rows[index].Cells[2].Value == null ||
                DGV1.Rows[index].Cells[3].Value == null ||
                DGV1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string ID = DGV1.Rows[index].Cells[0].Value.ToString();
            string Last_name = DGV1.Rows[index].Cells[1].Value.ToString();
            string Name = DGV1.Rows[index].Cells[2].Value.ToString();
            string Code = DGV1.Rows[index].Cells[3].Value.ToString();
            string Phone = DGV1.Rows[index].Cells[4].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "UPDATE table1 SET Last_name ='" + Last_name + "',Name = '" + Name + "',Code = " + Code + ",Phone = '" + Phone + "' WHERE ID = " +ID ;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные обновлены!", "Внимание");
            }
            dbConnection.Close();
        }

        private void delete_button1_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV1.SelectedRows[0].Index;
            if (DGV1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string ID = DGV1.Rows[index].Cells[0].Value.ToString();


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "DELETE FROM table1 WHERE ID = " + ID;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание");
                DGV1.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void download_button2_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB2.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT * FROM table2";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
                    DGV2.Rows.Add(dbReader["id2"], dbReader["Description"], dbReader["Price"], dbReader["Val"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void add_button2_Click(object sender, EventArgs e)
        {
            if (DGV2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV2.SelectedRows[0].Index;
            if (DGV2.Rows[index].Cells[0].Value == null ||
                DGV2.Rows[index].Cells[1].Value == null ||
                DGV2.Rows[index].Cells[2].Value == null ||            
                DGV2.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string id2 = DGV2.Rows[index].Cells[0].Value.ToString();
            string Description = DGV2.Rows[index].Cells[1].Value.ToString();
            string Price = DGV2.Rows[index].Cells[2].Value.ToString();
            string Val = DGV2.Rows[index].Cells[3].Value.ToString();
            
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB2.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "INSERT INTO table2 VALUES " +
                "(" + id2 + ", '" + Description + "', " + Price + ", '" + Val + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");
            dbConnection.Close();
        }

        private void update_button2_Click(object sender, EventArgs e)
        {
            if (DGV2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV2.SelectedRows[0].Index;
            if (DGV2.Rows[index].Cells[0].Value == null ||
                DGV2.Rows[index].Cells[1].Value == null ||
                DGV2.Rows[index].Cells[2].Value == null ||
                DGV2.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string id2 = DGV2.Rows[index].Cells[0].Value.ToString();
            string Description = DGV2.Rows[index].Cells[1].Value.ToString();
            string Price = DGV2.Rows[index].Cells[2].Value.ToString();
            string Val = DGV2.Rows[index].Cells[3].Value.ToString();
      
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB2.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "UPDATE table2 SET Description ='" + Description + "',Price = " + Price + ",Val = '" + Val +"'  WHERE id2 = " + id2;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные обновлены!", "Внимание");
            }
            dbConnection.Close();
        }

        private void delete_button2_Click(object sender, EventArgs e)
        {
            if (DGV2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Важно!");
                return;
            }
            int index = DGV2.SelectedRows[0].Index;
            if (DGV2.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Важно!");
                return;
            }
            string id2 = DGV2.Rows[index].Cells[0].Value.ToString();


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB2.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "DELETE FROM table2 WHERE id2 = " + id2;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка заполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание");
                DGV2.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
				string Familia = textBox1.Text;

				string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB1.mdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);
				dbConnection.Open();
				string query = "SELECT * FROM table1 WHERE Last_name = '"+ Familia+"'";//SELECT * FROM course WHERE dept_name=’Comp. Sci.’;
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
				OleDbDataReader dbReader = dbCommand.ExecuteReader();

				if (dbReader.HasRows == false)
				{
					MessageBox.Show("Данные не найдены", "Ошибка");
				}
				else
				{
					while (dbReader.Read())
					{
						DGV1.Rows.Clear();
						DGV1.Rows.Add(dbReader["ID"], dbReader["Last_name"], dbReader["Name"], dbReader["Code"], dbReader["Phone"]);
					}
				}
				textBox1.Text = "";
				dbReader.Close();
				dbConnection.Close();
			}
            catch (Exception)
            {

                throw;
            }

			

        }
    }
}
