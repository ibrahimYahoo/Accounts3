using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmBroker : MetroFramework.Forms.MetroForm
    {
        SingleTonUserRoles userRolesObj = SingleTonUserRoles.GetInstance;

        public frmBroker()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            gvCustomer.DataSource = new DAO().GetBrokersfrm();
            gvCustomer.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvCustomer.DataSource = new DAO().GetBrokersfrm();
            gvCustomer.Show();
        }

        private void metroTile5_MouseEnter(object sender, EventArgs e)
        {

        }
        public void PerformRefresh()
        {
            gvCustomer.DataSource = new DAO().GetBrokersfrm();
            gvCustomer.Show();

        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (userRolesObj.getCheckstate("AddEditBroker") == true)
            {
                AddBroker ac = new Forms.AddBroker();
                ac.ShowDialog();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //Forms.EditCus ec = new Forms.EditCus(this);
            //ec.txtCName.Text = this.gvCustomer.CurrentRow.Cells[1].Value.ToString();
            //ec.txtCAddress.Text = this.gvCustomer.CurrentRow.Cells[2].Value.ToString();
            //ec.txtCEmail.Text = this.gvCustomer.CurrentRow.Cells[3].Value.ToString();
            //ec.txtCPhone.Text = this.gvCustomer.CurrentRow.Cells[4].Value.ToString();
            //ec.txtCBalance.Text = this.gvCustomer.CurrentRow.Cells[5].Value.ToString();
            //ec.cid = int.Parse(this.gvCustomer.CurrentRow.Cells[0].Value.ToString());
            //ec.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int cid = 0;
            try
            {
                cid = int.Parse(this.gvCustomer.CurrentRow.Cells[0].Value.ToString());
                if (cid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Brokers where BId=@BID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@BID", cid);
                        dad.Fill(dt);
                        conn.Close();

                        lblmsg.Text = "Record Deleted Successfully! Message";
                        gvCustomer.DataSource = new DAO().GetBrokersfrm();
                    }
                }
                else if (cid == 0)
                {
                    lblmsg.Text =  "Please select record to Delete!  Error";
                }
                else
                { }

            }
            catch (Exception)
            {


            }


        }

        private void gvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings frm = new Settings();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().GetCust();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Parties.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["party"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        //    sw.WriteLine("Hello World!");
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        
        }
    }
