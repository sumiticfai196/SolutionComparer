using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;

namespace MyXrmToolBoxPlugin1
{

    public partial class MyPluginControl : MultipleConnectionsPluginControlBase
    // public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }



        private void loadSolution_Click(object sender, EventArgs e)
        {
            sourceConnection.Text = ((Microsoft.Xrm.Tooling.Connector.CrmServiceClient)Service).ConnectedOrgFriendlyName;

            ExecuteMethod(CustomCode);
        }
        private void CustomCode()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();

            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.Black;
            dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting solutions",
                Work = (worker, args1) =>
                {
                    // Instantiate QueryExpression QEsolution
                    var QEsolution = new QueryExpression("solution");
                    // Add columns to QEsolution.ColumnSet
                    QEsolution.ColumnSet.AddColumns("createdon", "version", "uniquename", "solutiontype", "solutionid", "description");


                    // Instantiate QueryExpression QEsolution

                    EntityCollection solutionRecords = Service.RetrieveMultiple(QEsolution);
                   
                    args1.Result = solutionRecords;
                },

                PostWorkCallBack = (args1) =>
                {
                    if (args1.Error != null)
                    {
                        MessageBox.Show(args1.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result1 = args1.Result as EntityCollection;
                    sourceSolutionCount.Text = string.Format("Count - {0}", result1.Entities.Count.ToString());

                    if (result1 != null)
                    {





                        foreach (Entity x1 in result1.Entities)
                        {
                            int n = dataGridView1.Rows.Add();

                            //if (n % 2 == 0)
                            //{
                            //    dataGridView1.DefaultCellStyle.BackColor = Color.White;
                            //}
                            //else
                            //{
                            //    dataGridView1.DefaultCellStyle.BackColor = Color.Blue;
                            //}
                            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                            //dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
                            dataGridView1.Rows[n].Cells[0].Value = x1.GetAttributeValue<string>("uniquename");
                            dataGridView1.Rows[n].Cells[1].Value = x1.GetAttributeValue<string>("version");
                            dataGridView1.Rows[n].Cells[2].Value = x1.GetAttributeValue<DateTime>("createdon");
                            dataGridView1.Rows[n].Cells[4].Value = x1.GetAttributeValue<Guid>("solutionid");
                            dataGridView1.Rows[n].Cells[3].Value = x1.GetAttributeValue<string>("description");


                        }




                    }
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdditionalOrganization();
            ExecuteMethod(CustomCode2);
        }

        private void CustomCode2()
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();

            foreach (var detail in AdditionalConnectionDetails)
            {
                var resp = detail.GetCrmServiceClient().Execute(new WhoAmIRequest()) as WhoAmIResponse;
                targetConnection.Text = detail.GetCrmServiceClient().ConnectedOrgFriendlyName;

            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting solutions",
                Work = (worker, args2) =>
                {
                    EntityCollection solutionRecords = new EntityCollection();
                    // Instantiate QueryExpression QEsolution
                    var QEsolution = new QueryExpression("solution");
                    // Add columns to QEsolution.ColumnSet
                    QEsolution.ColumnSet.AddColumns("createdon", "version", "uniquename", "solutiontype", "solutionid", "description");

                    foreach (var detail in AdditionalConnectionDetails)
                    {

                        solutionRecords = detail.GetCrmServiceClient().RetrieveMultiple(QEsolution);
                        
                    }
                    args2.Result = solutionRecords;
                },


                PostWorkCallBack = (args2) =>
                {
                    if (args2.Error != null)
                    {
                        MessageBox.Show(args2.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result2 = args2.Result as EntityCollection;

                    targetSolutionCo.Text = string.Format("Count - {0}", result2.Entities.Count.ToString());
                    if (result2 != null)
                    {
                        foreach (Entity x1 in result2.Entities)
                        {
                            int m = dataGridView2.Rows.Add();

                            //if (m % 2 == 0)
                            //{
                            //    dataGridView2.DefaultCellStyle.BackColor = Color.White;
                            //}
                            //else
                            //{
                            //    dataGridView2.DefaultCellStyle.BackColor = Color.Blue;
                            //}
                            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                            dataGridView2.Rows[m].Cells[0].Value = x1.GetAttributeValue<string>("uniquename");
                            dataGridView2.Rows[m].Cells[1].Value = x1.GetAttributeValue<string>("version");
                            dataGridView2.Rows[m].Cells[2].Value = x1.GetAttributeValue<DateTime>("createdon");
                            dataGridView2.Rows[m].Cells[4].Value = x1.GetAttributeValue<Guid>("solutionid");
                            dataGridView2.Rows[m].Cells[3].Value = x1.GetAttributeValue<string>("description");

                        }

                    }
                }
            });
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            exportToExcel.Visible = true;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            int match = 0;
            int notamatch = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                int x = dataGridView3.Rows.Add();
                var NotAMatch = true;
                for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
                {
                    if (dataGridView1.Rows[i].Cells["SolutionName"].Value.Equals(dataGridView2.Rows[j].Cells["SolutionName2"].Value))
                    {
                        match++;
                        dataGridView3.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells["SolutionName"].Value.ToString();
                        dataGridView3.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells["VersionNumber"].Value.ToString();
                        dataGridView3.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells["CreatedOn"].Value.ToString();
                        dataGridView3.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                        dataGridView3.Rows[i].Cells[3].Value = "Match";
                        NotAMatch = false;
                        break;

                    }
                }

                if (NotAMatch)
                {
                    notamatch++;
                    dataGridView3.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells["SolutionName"].Value.ToString();
                    dataGridView3.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells["VersionNumber"].Value.ToString();
                    dataGridView3.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells["CreatedOn"].Value.ToString();
                    dataGridView3.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                    dataGridView3.Rows[i].Cells[3].Value = "Not a Matches";
                }
            }
            compareCount.Text = string.Format("Count of Match Solution - {0} :: Count of Non-Matching Solution {1}", match, notamatch);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //object value = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                    }

                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = String.Empty;
                    }
                }
            }
            // save the application 
            try
            {
                workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            catch (Exception ex)
            {
            }// Exit from the application  
            app.Quit();

        }
    }
}
