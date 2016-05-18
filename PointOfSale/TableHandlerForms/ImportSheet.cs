using PointOfSale.applications;
using PointOfSale.DbConfiguration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.TableHandlerForms
{
    public partial class ImportSheet : Form
    {
        DatabaseCommands dbCommands;
        public ImportSheet()
        {
            InitializeComponent();
        }

        private void importSheet_uplaod_Button_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem();
            DialogResult result = importSheet_uplaod_openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = importSheet_uplaod_openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);

                    String extionsion = Path.GetExtension(file);
                    if (extionsion == ".ods")    // check file  extenion
                    {
                        importSheet_uplaod_TextBox.Text = file;
                      string[] data=  new UploadExcelSheet().getUploadFilePath(file);
//Debug.WriteLine("My Size" + myvalues.Length);
                        for (int i = 1; i <= 100; i++)
                        {
                            //    progressBar1.Value =  (myvalues.Length/ i) ;
                            Thread.Sleep(100);
                            // Report progress.
                            importSheet_uplaod_progressBar.Value = i;
                        }
                        if (importSheet_uplaod_progressBar.Value == 100)
                        {
                            MessageBox.Show("file upalod ");
                        }
                        foreach (string clm in data)
                        {
                            Debug.WriteLine(clm);
                            //items.SubItems.Add(clm);
                            String[] rows = { clm };
                            ListViewItem itm = new ListViewItem(rows);
                            importSheet_uplaod_listView.CheckBoxes = true;
                         
                            importSheet_uplaod_listView.Items.Add(itm);

                        }
                       
                    }
                    else
                    {

                        MessageBox.Show("Only Spreed Sheet Alow");
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void ImportSheet_Load(object sender, EventArgs e)
        {

            dbCommands = new DatabaseCommands();
            ArrayList tablename = dbCommands.getTableLists();
            foreach (String table in tablename)
            {
                importSheet_table_lcomboBox.Items.Add(table);
            }
        }
    }
        
}
