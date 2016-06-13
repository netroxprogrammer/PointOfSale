using PointOfSale.DbConfiguration;
using PointOfSale.Employee;
using PointOfSale.Utils.TablesClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.ListForms
{
    public partial class EmployeList : Form
    {
        HandleEmployee employee;
        public EmployeList()
        {
            InitializeComponent();
        }

        private void EmployeList_Load(object sender, EventArgs e)
        {
            employee = new HandleEmployee();
            getEmployeeList();
        }

        public void getEmployeeList()
        {


            WorkingForm_EmployeList.Columns.Clear();
            WorkingForm_EmployeList.Items.Clear();
            WorkingForm_EmployeList.Columns.Add("Employee Id", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emloyee Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee Phone ", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Father Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee CNIC", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee Address", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Location", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Contact", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Relation", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Location", 110, HorizontalAlignment.Left);


            // WorkingForm_customerPanel.Visible = false;
         
            ArrayList empl = employee.getEmployee();

            foreach (TotalEmployeeData em in empl)
            {
                String[] rows = { em.EmployeeId.ToString(), em.EmployeeName, em.EmployeePhone, em.EmployeeFatherName,
                    em.EmployeeCNIC, em.EmployeeAddress, em.EmployeeLocation, em.Name, em.Contact, em.Relation, em.Location};
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_EmployeList.Items.Add(items);
            }


        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getEmployeeList();

        }

        private void WorkingForm_EmployeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {



            String id = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String name = WorkingForm_EmployeList.SelectedItems[0].SubItems[1].Text;
            String phone = WorkingForm_EmployeList.SelectedItems[0].SubItems[2].Text;
            String fName = WorkingForm_EmployeList.SelectedItems[0].SubItems[3].Text;
            String CNIC = WorkingForm_EmployeList.SelectedItems[0].SubItems[4].Text;
            String address = WorkingForm_EmployeList.SelectedItems[0].SubItems[5].Text;
            String location = WorkingForm_EmployeList.SelectedItems[0].SubItems[6].Text;
            String eName = WorkingForm_EmployeList.SelectedItems[0].SubItems[7].Text;
            String eContact = WorkingForm_EmployeList.SelectedItems[0].SubItems[8].Text;
            String eRelation = WorkingForm_EmployeList.SelectedItems[0].SubItems[9].Text;

            String eLocation = WorkingForm_EmployeList.SelectedItems[0].SubItems[10].Text;

            AddEmployee em = new AddEmployee();
            ArrayList empl = employee.getEmployee();

            foreach (TotalEmployeeData emm in empl)
            {
                if (emm.EmployeeId == Int32.Parse(id))
                {
                    em.EmployeId = id;
                    em.EmpName = name;
                    em.empFatherName = fName;
                    em.EmpPhoneN = phone;
                    em.empCNIC = CNIC;
                    em.empAddress = address;
                    em.empLocation = location;
                    em.EmerName = eName;
                    em.EmerContact = eContact;
                    em.EmerRelation = eRelation;
                    em.Emerlocatiion = eLocation;
                }
            }
            em.Show();
        }

        private void addNewEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
        }

        private void WorkingForm_EmployeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
