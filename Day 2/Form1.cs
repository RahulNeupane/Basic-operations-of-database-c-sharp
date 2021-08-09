using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RAHUL\SQLEXPRESS;Initial Catalog=c#;Integrated Security=True"); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                //open sql connection 
                conn.Open();

                string st_name = std_name.Text;
                string st_address = std_address.Text;

                //save data to database
                //string query = "Insert into student_details(name,address) values ("+st_name+","+st_address+")";
                //SqlCommand cmd = new SqlCommand(query, conn);


                string query = "Insert into student_details(name,address) values (@parameter_name,@parameter_address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parameter_name", st_name);
                cmd.Parameters.AddWithValue("@parameter_address", st_address);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully");

                std_name.Text = "";
                std_address.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                //close sql connection
                conn.Close();
            }

            DisplayData();



            //string name = std_name.Text;
            //string address = std_address.Text;
            
            ////create new rows
            ////Std_list.Rows.Add();

            //Std_list.Rows.Add(Std_list.Rows.Count + 1, name, address);
        }

        private void DisplayData()
        {
            try
            {
                //open sql connection 
                conn.Open();


                string query = "Select * from student_details";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                Std_list.Rows.Clear();

                int sn = 0;
                foreach(DataRow dataRow in dt.Rows)
                {
                    sn++;
                    Std_list.Rows.Add(dataRow["ID"],sn, dataRow["name"], dataRow["address"],"Edit");
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                //close sql connection
                conn.Close();
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //for removing single row if any cell is clicked
            //Std_list.Rows.RemoveAt(Std_list.CurrentRow.Index);
            try
            {
                //open sql connection 
                conn.Open();

                

                //for removing single row if complete row is selected
                if (Std_list.SelectedRows.Count > 0)
                {

                    //for removing single row
                     //Std_list.Rows.RemoveAt(Std_list.SelectedRows[0].Index);


                    //for removing multiple rows
                    foreach (DataGridViewRow row in Std_list.SelectedRows)
                    {
                        

                        int id = Convert.ToInt32(row.Cells["stdID"].Value);

                        //passing parameter method
                        string query = "Delete from student_details where ID=@parameter_id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        Std_list.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed sucessfully");
                    }
                    

                }
                else
                {
                    MessageBox.Show("Please select row to delete");
                }
                //int i = 0;
                //foreach (DataGridViewRow row in Std_list.Rows)
                //{
                //    i++;
                //    row.Cells["SN"].Value = i;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                //close sql connection
                conn.Close();
            }
            DisplayData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        int student_id;
        private void Std_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == Std_list.Columns["Action"].Index)
            {
                string student_name = Std_list.CurrentRow.Cells["Student_name"].Value.ToString();
                student_id = Convert.ToInt32(Std_list.CurrentRow.Cells["SN"].Value.ToString());
                string student_address = Std_list.CurrentRow.Cells["Address"].Value.ToString();

                MessageBox.Show("Id: " + student_id + "\n Name: " + student_name);

                std_name.Text = student_name;
                std_address.Text = student_address;
            }
        }

        private void Update_click(object sender, EventArgs e)
        {
            try
            {
                if (student_id != 0)
                {//open sql connection 
                    conn.Open();

                    string st_name = std_name.Text;
                    string st_address = std_address.Text;

                    //save data to database
                    //string query = "Insert into student_details(name,address) values ("+st_name+","+st_address+")";
                    //SqlCommand cmd = new SqlCommand(query, conn);


                    string query = "Update student_details set name=@parameter_name ,address=@parameter_address where id = @parameter_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@parameter_name", st_name);
                    cmd.Parameters.AddWithValue("@parameter_address", st_address);
                    cmd.Parameters.AddWithValue("@parameter_id", student_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");

                    std_name.Text = "";
                    std_address.Text = "";
                    student_id = 0;
                }
                else
                {
                    MessageBox.Show("please edit data before update");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                //close sql connection
                conn.Close();
            }

            DisplayData();
        }

        private void Clear_click(object sender, EventArgs e)
        {
            std_name.Text = "";
            std_address.Text = "";
            student_id = 0;
        }
    }
}
