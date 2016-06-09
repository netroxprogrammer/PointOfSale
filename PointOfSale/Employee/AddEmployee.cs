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
         private String employeId;
        public  String EmployeId
        {
            set
            {
                employeId = value;
            }
        }
        public String EmpName
        {
            set
            {
                Employee_Name_text.Text = value;
            }
        }
        public  String EmpPhoneN
        {
            set
            {
                Employee_Phone_text.Text = value;
            }
        } 
        public String empFatherName
        {
            set
            {
                Employee_FatherName_text.Text = value;
            }
        }
        
        public String empCNIC
        {
            set
            {
                Employee_CNIC_text.Text = value;
            }
        }
        public String empAddress
        {
            set
            {
                Employee_Address_text.Text = value;
            }
        }
        
        public String empLocation
        {
            set
            {
                Employee_Employeelocation_comboBox.Text = value;
            }
        }
        public String EmerName
        {
            set { 
            Employee_EmerganceName_text.Text = value;
        }
        }

        public String EmerContact
        {
            set
            {
                Employee_EmerganceContact_text.Text = value;
            }
        }

        public String EmerRelation
        {
            set
            {
                Employee_EmerganceRelation_text.Text = value;
            }
        }
        public String Emerlocatiion
        {
            set
            {
                Employee_Emergancelocation_comboBox.Text = value;
            }
        }
     





        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Employee_SaveClose_btn_Click(object sender, EventArgs e)
        {
            addNewEmployee();
            if (!String.IsNullOrEmpty(Employee_Name_text.Text))
            {
                Close();
            }
           
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
             employee = new HandleEmployee();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewEmployee();
        }

        /**
        *
        *  Add New Employee Data
        */

        public void addNewEmployee()
        {

            String emLocation = null;
            String emerLocation = null;
            String emplName = null;
            TableEmployee names = new TableEmployee();
            TableEmployeeEmergancey emgnames = new TableEmployeeEmergancey();

            // check Employee Name is Empty  or  Not

            if (String.IsNullOrEmpty(Employee_Name_text.Text))  
            {
                Employee_Name_text.BackColor = Color.Red;
            }
            else
            {
                emplName = Employee_Name_text.Text;
            }
            String emplPhone = Employee_Phone_text.Text;
            String emplFatherName = Employee_FatherName_text.Text;
            String empCNIC = Employee_CNIC_text.Text;
            String epmlyAddress = Employee_Address_text.Text;
            if (Employee_Employeelocation_comboBox.SelectedIndex == -1)
            {
                emLocation = "";
            }


            String emergName = Employee_EmerganceName_text.Text;
            String emergContact = Employee_EmerganceContact_text.Text;
            String emergRelation = Employee_EmerganceRelation_text.Text;
            if (Employee_Emergancelocation_comboBox.SelectedIndex == -1)
            {
                emerLocation = "";
            }

            if (!String.IsNullOrEmpty(emplName))
            {

                names.EmployeeName = emplName;
                names.EmployeePhone = emplPhone;
                names.EmployeeFatherName = emplFatherName;
                names.EmployeeCNIC = empCNIC;
                names.EmployeeAddress = epmlyAddress;
                names.EmployeeLocation = emLocation;


                int id = employee.AddEmployees(names);

                if (id > 0)
                {
                    emgnames.EmployeeId = id;
                    emgnames.Name = emergName;
                    emgnames.Contact = emergContact;
                    emgnames.Relation = emergRelation;
                    emgnames.Location = emerLocation;

                    int emgid = employee.AddEmerganceEmployeeContact(emgnames);
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
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Employee_Name_text_TextChanged(object sender, EventArgs e)
        {
            Employee_Name_text.BackColor = Color.White;
        }

        private void AddNewEmployee_UpdateButtom_Click(object sender, EventArgs e)
        {
            String emLocation = null;
            String emerLocation = null;
            String emplName = null;
            TableEmployee names = new TableEmployee();
            TableEmployeeEmergancey emgnames = new TableEmployeeEmergancey();

            // check Employee Name is Empty  or  Not

            if (String.IsNullOrEmpty(Employee_Name_text.Text))
            {
                Employee_Name_text.BackColor = Color.Red;
            }
            else
            {
                emplName = Employee_Name_text.Text;
            }
            String emplPhone = Employee_Phone_text.Text;
            String emplFatherName = Employee_FatherName_text.Text;
            String empCNIC = Employee_CNIC_text.Text;
            String epmlyAddress = Employee_Address_text.Text;
            if (Employee_Employeelocation_comboBox.SelectedIndex == -1)
            {
                emLocation = "";
            }
            else
            {
                emLocation = Employee_Employeelocation_comboBox.Text;
            }

            String emergName = Employee_EmerganceName_text.Text;
            String emergContact = Employee_EmerganceContact_text.Text;
            String emergRelation = Employee_EmerganceRelation_text.Text;
            if (Employee_Emergancelocation_comboBox.SelectedIndex == -1)
            {
                emerLocation = "";
            }

            if (!String.IsNullOrEmpty(emplName))
            {
               
                names.EmployeeName = emplName;
                names.EmployeePhone = emplPhone;
                names.EmployeeFatherName = emplFatherName;
                names.EmployeeCNIC = empCNIC;
                names.EmployeeAddress = epmlyAddress;
                names.EmployeeLocation = emLocation;
                names.EmployeeId = Int32.Parse(employeId);

            
                //    emgnames.EmployeeId = id;
                    emgnames.Name = emergName;
                    emgnames.Contact = emergContact;
                    emgnames.Relation = emergRelation;
                    emgnames.Location = emerLocation;

                    employee.UpdateEmployeeInformation(names);
                  

            }
            
        }
    }
}
