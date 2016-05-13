using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
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

namespace PointOfSale.TableInformationForm
{
    public partial class TableInformation : Form
    {
        private DatabaseCommands dbcommand;
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
            
            
            String tableName = tableInformation_viewTable_comboBox.SelectedItem.ToString();
            ArrayList columnName =  dbcommand.readTableColumn(tableName);
            ListViewItem itm = new ListViewItem();
           
            foreach(TableColumns columns in columnName)
            {
                itm.SubItems.Add(columns.TableName);
                // itm.SubItems.Add(columns.DataType);
                tableInformation_colmnName_listView.Items.Add(itm);

            }
            tableInformation_colmnName_listView.Items.Add(itm);

        }

        private void tableInformation_colmnName_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
