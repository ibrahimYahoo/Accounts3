using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using MetroFramework;
using System.IO;
//using System.Runtime.InteropServices;

namespace WindowsFormsApplication1.Forms
{
    public partial class Stock : MetroFramework.Forms.MetroForm
    {

        //const int AW_SLIDE = 0X40000;
        //const int AW_HOR_POSITIVE = 0X1;
        //const int AW_HOR_NEGATIVE = 0X2;
        //const int AW_BLEND = 0X80000;

        //[DllImport("user32")]
        //static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public Stock()
        {
            InitializeComponent();
        }

        public void PerformRefresh()
        {
            gvStock.DataSource = new DAO().getItems();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
           // AnimateWindow(this.Handle, 0, AW_SLIDE | AW_HOR_POSITIVE);

            gvStock.DataSource = new DAO().getItems();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            Forms.Items ac = new Forms.Items(this);
            ac.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Forms.EditItem ec = new Forms.EditItem(this);
            ec.IId = int.Parse(this.gvStock.CurrentRow.Cells[0].Value.ToString());
            ec.txtItemName.Text = this.gvStock.CurrentRow.Cells[1].Value.ToString();
            //ec.cmbcatname.DataSource = new DAO().ShowCatList1();
            //ec.cmbcatname.DisplayMember = "Display";
            //ec.cmbcatname.ValueMember = "CatId";
            //ec.cmbcatname.Text = new DAO().GetCatDescfromCatId(int.Parse(gvStock.CurrentRow.Cells[2].Value.ToString()));
            ec.txtReOrder.Text = gvStock.CurrentRow.Cells[6].Value.ToString();
            ec.TxtitemPrice.Text = this.gvStock.CurrentRow.Cells[3].Value.ToString();
            ec.txtItemQuantity.Text = this.gvStock.CurrentRow.Cells[2].Value.ToString();
            ec.txtitemdesc.Text = this.gvStock.CurrentRow.Cells[7].Value.ToString();
            
            ec.Show();
        }
        void performRefresh()
        {
            gvStock.DataSource = new DAO().getItems();
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            int IId = 0;
            try
            {
                IId = int.Parse(this.gvStock.CurrentRow.Cells[0].Value.ToString());
                if (IId != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Items where IId=@IID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@IID", IId);
                        dad.Fill(dt);
                        conn.Close();

                      lblmsg.Text = "Record Deleted Successfully! ";
                        gvStock.DataSource = new DAO().getItems();
                    }
                }
                else if (IId == 0)
                {
                    lblmsg.Text = "Please select record to Delete! Error";
                }
                else
                { }

            }
            catch (Exception)
            {


            }


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvStock.DataSource = new DAO().getItems();
        }

        private void gvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //FormCollection fc = Application.OpenForms;

            //foreach (Form f in fc)
            //{

            //    if (f.Name == "Main")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}

            //if (IsOpen == true)
            //{
                
            //}

            //this.Hide();
            //Home f1obj = new Home();
            Main obj = new Main();
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            this.Hide();


            //this.Dispose();
            //Main frm = new Main();
            //frm.Show();
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Load the Form At Position of Main Form
        //    //int WidthOfMain = Application.OpenForms["Main"].Width;
        //    //int HeightofMain = Application.OpenForms["Main"].Height;
        //    //int LocationMainX = Application.OpenForms["Main"].Location.X;
        //    //int locationMainy = Application.OpenForms["Main"].Location.Y;

        //    //Set the Location
        //   // this.Location = new Point(LocationMainX + WidthOfMain, locationMainy + 10);
        //    //this.BackgroundImage = Application.OpenForms["Home"].BackgroundImage;

        //    //Animate form
        //}

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().GetStock();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Catalog.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Stock"].Rows.Count > 0)
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
