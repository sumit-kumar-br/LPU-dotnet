using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For Ado.Net
using System.Data.SqlClient;
using System.Data;
using System.Net.Configuration;
using System.Diagnostics.SymbolStore;

namespace ConArchDemo
{
    /// <summary>
    /// Demo code for Connected Architecture in StudentDAL class
    /// </summary>
    public class StudentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = .\\Sqlexpress;Integrated Security=SSPI;Database=LPU_Db;TrustServerCertificate=True";
            // old version mein integrated security = true kaam nhi krta usmein ssip kaam ata hai
        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;
            // Code for connected Architecture below
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                // holding data via reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                // Convert table into list
                if(myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                foreach(DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        PhoneNo = drow[6].ToString()
                    };
                    if(sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return studList;
        }
        public List<Student> SearchByName(string name)
        {

            {
                List<Student> studList = null;
                // Code for connected Architecture below
                SqlParameter param1 = new SqlParameter("@Name", name);
                try
                {
                    con.Open();

                    cmd = new SqlCommand();
                    cmd.CommandText = "Select * from StudentInfo where Name=@Name";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    // Parameter is to be added
                    cmd.Parameters.Add(param1);

                    // holding data via reader
                    sdr = cmd.ExecuteReader();

                    DataTable myDt = new DataTable();
                    myDt.Load(sdr);

                    // Convert table into list
                    if (myDt.Rows.Count > 0)
                    {
                        studList = new List<Student>();
                    }
                    foreach (DataRow drow in myDt.Rows)
                    {
                        Student sObj = new Student()
                        {
                            RollNo = Convert.ToInt32(drow[0].ToString()),
                            Name = drow[1].ToString(),
                            Address = drow[3].ToString(),
                            PhoneNo = drow[6].ToString()
                        };
                        if (sObj != null)
                        {
                            studList.Add(sObj);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return studList;
            }
        }
        public Student SearchByRollNo(int rollNo)
        {
            Student student = null;
            return student;
        }
        public bool AddStudent(Student student)
        {
            bool flag = false;

            con.Open();
            SqlParameter[] param = new SqlParameter[5];
            for(int i=0; i<param.Length; i++)
            {
                param[i] = new SqlParameter();
            }

            param[0].ParameterName = "@RollNo";
            param[0].Value = student.RollNo;

            param[1].ParameterName = "@Name";
            param[1].Value = student.Name;

            param[2].ParameterName = "@Age";
            param[2].Value = student.Age;

            param[3].ParameterName = "@Addr";
            param[3].Value = student.Address;

            param[4].ParameterName = "@Phone";
            param[4].Value = student.PhoneNo;


            cmd = new SqlCommand();
            cmd.CommandText = "Insert into StudentInfo(RollNo,name,age,localAddr,perAddr,phoneNum) values(@RollNo,@Name,@Age,@Addr,@Addr,@Phone)";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddRange(param);

            int rowsCount = cmd.ExecuteNonQuery();  

            if(rowsCount > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
