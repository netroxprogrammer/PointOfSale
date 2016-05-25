using PointOfSale.DbConfiguration;
using PointOfSale.Utils.TablesClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Employee
{
    public partial class AddEmployee : Form
    {
        HandleEmployee employee;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Employee_SaveClose_btn_Click(object sender, EventArgs e)
        {
            TableEmployee names = new TableEmployee();
            TableEmployeeEmergancey emgnames = new TableEmployeeEmergancey();
            String emplName = Employee_Name_text.Text;
            String emplPhone = Employee_Phone_text.Text;
            String emplFatherName = Employee_FatherName_text.Text;
            String empCNIC = Employee_CNIC_text.Text;
            String epmlyAddress = Employee_Address_text.Text;
            String emplLocation = Employee_Employeelocation_comboBox.SelectedItem.ToString();

            String emergName = Employee_EmerganceName_text.Text;
            String emergContact = Employee_EmerganceContact_text.Text;
            String emergRelation = Employee_EmerganceRelation_text.Text;
            String emergLocation = Employee_Emergancelocation_comboBox.SelectedItem.ToString();


            names.EmployeeName = emplName;
            names.EmployeePhone = emplPhone;
            names.EmployeeFatherName = emplFatherName;
            names.EmployeeCNIC = empCNIC;
            names.EmployeeAddress = epmlyAddress;
            names.EmployeeLocation = emplLocation;

            
           int  id = employee.AddEmployees(names);
            
            if (id >  0)
            {
                emgnames.EmployeeId = id;
                emgnames.Name = emergName;
                emgnames.Contact = emergContact;
                emgnames.Relation = emergRelation;
                emgnames.Location = emergLocation;

               int  emgid = employee.AddEmerganceEmployeeContact(emgnames);
                if (emgid > 0)
                {
                    MessageBox.Show("One Employee Add");
                }
                else
                {
                    MessageBox.Show("Due to Any  issue Employee Not Save");
                }

            }
            else
            {
                MessageBox.Show("Due to Any  issue Employee Not Save");
            }
        
              }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
             employee = new HandleEmployee();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
