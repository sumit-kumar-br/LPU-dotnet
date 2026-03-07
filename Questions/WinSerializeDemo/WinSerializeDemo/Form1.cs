using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
// for binary serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ClearAllTextBoxes()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();

                }
            }
        }


        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            // Binary Serialization Code Below
            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);

            fs.Close();
            ClearAllTextBoxes();
            MessageBox.Show("Record Added...");

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp1 = (Employee)bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.EmpID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();

        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            ClearAllTextBoxes();
            fs.Close();


        }
        private void btnXMLDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee emp1 = (Employee)xs.Deserialize(fs);

            txtEmployeeID.Text = emp1.EmpID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }


        private void btnSoapSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            // SOAP Serialization Below
            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\SOAPSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);
            fs.Close();

            ClearAllTextBoxes();

            MessageBox.Show("Record Added...");

        }

        private void btnSOAPDeserialize_Click(object sender, EventArgs e)
        {
            // Deserialization here
            FileStream fs = new FileStream(@"C:\CS\LPU-dotnet\WinSerializeDemo\SOAPSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);

            txtEmployeeID.Text = emp1.EmpID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();

        }




    }
}
