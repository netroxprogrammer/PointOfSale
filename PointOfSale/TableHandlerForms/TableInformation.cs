using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.TableInformationForm
{
    public partial class TableInformation : Form
    {
        private DatabaseCommands dbcommand;
        private bool FillList = false;
        public TableInformation()
        {    

            InitializeComponent();
        }

        private void TableInformatiion_Load(object sender, EventArgs e)
        {
            dbcommand = new DatabaseCommands();
            ArrayList tablename = dbcommand.getTableLists();
            foreach(String table in tablename)
            {
                tableInformation_viewTable_comboBox.Items.Add(table);
            }
        }

        private void tableInformation_viewTable_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {



        }

        private void tableInformation_View_brt_Click(object sender, EventArgs e)
        {

            if (tableInformation_viewTable_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Table");
            }
            else {
                if (tableInformation_viewTable_listView1.Items.Count > 0)
                {
                    tableInformation_viewTable_listView1.Items.Clear();
                    Debug.WriteLine("Size of  list:  " + tableInformation_viewTable_listView1.Items.Count);

                    saveDatainListView();
                }
                else {
                    saveDatainListView();
                }
            }
        }

        private void tableInformation_colmnName_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void saveDatainListView()
        {
           
            String tableName = tableInformation_viewTable_comboBox.SelectedItem.ToString();
            List<TableColumns> columnName = dbcommand.readTableColumn(tableName);


            foreach (TableColumns columns in columnName)
            {
                String[] rows = { columns.TableName, columns.DataType };
                ListViewItem itm = new ListViewItem(rows);
                tableInformation_viewTable_listView1.Items.Add(itm);
                  
            }
        }
    }
}
