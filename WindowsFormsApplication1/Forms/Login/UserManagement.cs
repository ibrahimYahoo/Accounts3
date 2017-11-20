using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms
{
    public partial class UserManagement : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        bool dd = false;
        int count3 = 2;
        int count25 = 4;
        int count6 = 2;
        int count13 = 2;
        int count17 = 2;
        int count9 = 4;
        int count12 = 5;


        SqlConnection conn = DBConn.GetInstance();
       // SqlDataAdapter dad = new SqlDataAdapter("", conn);

        //List<bool> CheckedBoxes = new List<bool>();
        List<CheckBox> Checkedboxes = new List<CheckBox>();

        public UserManagement()
        {
            InitializeComponent();
        }



        private void metroTile2_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

            checkBox10.Checked = true;
            // Iterates through all the controls (i.e. textboxes, buttons, labels, etc.) in the tab page.

            //foreach (CheckBox c in tabControl1.SelectedTab.Controls.OfType<CheckBox>())
            //{
            //    //if (c is CheckBox)
            //    //{

            //        c.CheckState = CheckState.Checked;
            //        Checkboxes.Add(c);
            //   // }


            //}
            // TabPage t = tabControl1.TabPages[0];
            foreach (CheckBox c in groupBox1.Controls.OfType<CheckBox>())
            {
                //if (c is CheckBox)
                //{
                //    ((CheckBox)c).CheckState = CheckState.Checked;
                //Checkedboxes.Add((c));
                c.Checked = true;
                // c.CheckState = CheckState.Checked;

                // Do stuff here ;]
                // }
            }
        }



        private void metroTile1_Click(object sender, EventArgs e)
        {















          //  new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration, AccountId, "Credit", RefNo, Decimal.Parse(txtRecieptAmount), 0, 00);
            string checkedboxes = "";
            bool firstime = true;

            foreach (CheckBox checkboxes in Checkedboxes)
            {
                if(firstime == true)
                {
                    firstime = false;
                    string str = checkboxes.Text;
                    str = str.Replace(" ", String.Empty);
                    str = str.Replace("/", String.Empty);

                    checkedboxes +=  str;
                    continue;

                }
                string str2 = checkboxes.Text;
                str2 = str2.Replace(" ", String.Empty);
                str2 = str2.Replace("/", String.Empty);

                checkedboxes += "," + str2;
            }



            string checkedboxesValues = "";
            bool firstime2 = true;

            foreach (CheckBox checkboxes in Checkedboxes)
            {
                if (firstime2 == true)
                {
                    firstime2 = false;
                    
                    
                    checkedboxesValues += "1";
                    continue;
                }

                checkedboxesValues += "," + "1";
            }


            string sql = "Insert INTO UserRoles(" + checkedboxes + ") values (" + checkedboxesValues + ")" ;
            //dad = new SqlDataAdapter("Insert INTO UserRoles(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@CBNo,@VoucherNo,@TransactionType)", conn);
                bool test = true;


            //dad = new SqlDataAdapter("Insert INTO Login(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@CBNo,@VoucherNo,@TransactionType)", conn);


            //dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
            //dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo);
            //dad.SelectCommand.Parameters.AddWithValue("@5", "sales");
            //dad.SelectCommand.Parameters.AddWithValue("@6", txtRecieptNarration);
            //dad.SelectCommand.Parameters.AddWithValue("@7", this.cmRecieptPayment.GetItemText(this.cmRecieptPayment.SelectedItem));
            //dad.SelectCommand.Parameters.AddWithValue("@8", Decimal.Parse(txtRecieptAmount));
            //dad.SelectCommand.Parameters.AddWithValue("@9", 0);
            //dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
            //dad.SelectCommand.Parameters.AddWithValue("@11", AccountId);
            //dad.SelectCommand.Parameters.AddWithValue("@CBNo", CBNo);
            //dad.SelectCommand.Parameters.AddWithValue("@VoucherNo", VoucherNo);
            //dad.SelectCommand.Parameters.AddWithValue("@TransactionType", "Credit");

            //dad.Fill(dt);
            //conn.Close();

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.CheckState == CheckState.Checked)
            {

                foreach (CheckBox c in groupBox1.Controls.OfType<CheckBox>())
                {
                    switch (c.Name)
                    {
                        case "checkBox10":
                            c.Checked = true;
                            continue;
                        case "checkBox3":
                            c.Checked = true;
                            continue;

                        case "checkBox6":
                            c.Checked = true;
                            continue;

                        case "checkBox9":
                            c.Checked = true;
                            continue;

                        case "checkBox13":
                            c.Checked = true;
                            continue;

                        case "checkBox17":
                            c.Checked = true;
                            continue;

                        case "checkBox25":
                            c.Checked = true;
                            continue;

                        case "checkBox14":
                            c.Checked = true;
                            continue;

                        case "checkBox12":

                            c.Checked = true;
                            continue;

                        default:
                            Checkedboxes.Add(c);
                            //Checkedboxes.Remove(c);
                            c.Checked = true;
                            continue;
                    }
                    //Checkedboxes.Add(c);
                    ////Checkedboxes.Remove(c);
                    //c.Checked = true;

                }
                 count3 = 2;
                 count25 = 4;
                 count6 = 2;
                 count13 = 2;
                 count17 = 2;
                 count9 = 4;
                 count12 = 5;
            }
            else
            {

                foreach (CheckBox c in groupBox1.Controls.OfType<CheckBox>())
                {
                    switch (c.Name)
                    {
                        case "checkBox10":
                            c.Checked = false;
                            continue;
                        case "checkBox3":
                            c.Checked = false;
                            continue;

                        case "checkBox6":
                            c.Checked = false;
                            continue;

                        case "checkBox9":
                            c.Checked = false;
                            continue;

                        case "checkBox13":
                            c.Checked = false;
                            continue;

                        case "checkBox17":
                            c.Checked = false;
                            continue;

                        case "checkBox25":
                            c.Checked = false;
                            continue;

                        case "checkBox14":
                            c.Checked = false;
                            continue;

                        case "checkBox12":

                            c.Checked = false;
                            continue;


                        default:
                            Checkedboxes.Remove(c);

                            c.Checked = false;

                            continue;
                    }
                    
                }
                count3 = 0;
                count25 = 0;
                count6 = 0;
                count13 = 0;
                count17 = 0;
                count9 = 0;
                count12 = 0;






            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if(cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox3)
                {

                    //dd = true;
                    count3 = 2;
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    Checkedboxes.Add(checkBox1);
                    Checkedboxes.Add(checkBox2);


                }
                else
                {
                    Checkedboxes.Add(cb);

                    // dd = true;
                    count3 += 1;

                    checkBox3.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox3)
                {
                    //dd = false;
                    count3 = 0;

                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    Checkedboxes.Remove(checkBox1 );
                    Checkedboxes.Remove(checkBox2 );

                }
                else
                {
                    count3 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count3 == 0)
                    {
                        checkBox3.Checked = false;

                    }






                }
            }

            

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox6)
                {

                    //dd = true;
                    count6 = 2;
                    checkBox5.Checked = true;
                    checkBox4.Checked = true;
                    Checkedboxes.Add(checkBox5 );
                    Checkedboxes.Add(checkBox4 );


                }
                else
                {
                    Checkedboxes.Add(cb);

                    // dd = true;
                    count6 += 1;

                    checkBox6.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox6)
                {
                    //dd = false;
                    count6 = 0;

                    checkBox5.Checked = false;
                    checkBox4.Checked = false;
                    Checkedboxes.Remove(checkBox5 );
                    Checkedboxes.Remove(checkBox4 );

                }
                else
                {
                    count6 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count6 == 0)
                    {
                        checkBox6.Checked = false;

                    }






                }
            }


        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox25)
                {
                    //dd = true;
                    count25 = 4;
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox16.Checked = true;
                    checkBox11.Checked = true;
                    Checkedboxes.Add(checkBox26 );
                    Checkedboxes.Add(checkBox27 );
                    Checkedboxes.Add(checkBox16 );
                    Checkedboxes.Add(checkBox11 );


                }
                else
                {
                    // dd = true;
                    count25 += 1;
                    Checkedboxes.Add(cb);

                    checkBox25.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox25)
                {
                    //dd = false;
                    count25 = 0;
                    checkBox26.Checked = false;
                    checkBox27.Checked = false;
                    checkBox16.Checked = false;
                    checkBox11.Checked = false;
                    Checkedboxes.Remove(checkBox26 );
                    Checkedboxes.Remove(checkBox27 );
                    Checkedboxes.Remove(checkBox16 );
                    Checkedboxes.Remove(checkBox11 );



                }
                else
                {
                    count25 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count25 == 0)
                    {
                        checkBox25.Checked = false;

                    }






                }
            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }




            if (cb.CheckState == CheckState.Checked)
            {

                    checkBox14.Checked = true;
                    checkBox15.Checked = true;
                Checkedboxes.Add(checkBox14 );
                Checkedboxes.Add(checkBox15 );


                //if (cb == "checkBox14")
                //{
                //    //dd = true;
                //    //count9 = 4;
                //    checkBox15.Checked = true;


                //}
                //else
                //{
                //    // dd = true;
                //    count9 += 1;

                //    checkBox9.Checked = true;
                //}
            }
            else
            {
                   checkBox15.Checked = false;
                   checkBox14.Checked = false;
                Checkedboxes.Remove(checkBox15 );
                Checkedboxes.Remove(checkBox14 );








            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox9)
                {
                    //dd = true;
                    count9 = 4;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox21.Checked = true;
                    checkBox22.Checked = true;
                    Checkedboxes.Add(checkBox7 );
                    Checkedboxes.Add(checkBox8 );
                    Checkedboxes.Add(checkBox21 );
                    Checkedboxes.Add(checkBox22 );


                }
                else
                {
                    // dd = true;
                    count9 += 1;
                    Checkedboxes.Add(cb);

                    checkBox9.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox9)
                {
                    //dd = false;
                    count9 = 0;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox21.Checked = false;
                    checkBox22.Checked = false;
                    Checkedboxes.Remove(checkBox7 );
                    Checkedboxes.Remove(checkBox8 );
                    Checkedboxes.Remove(checkBox21 );
                    Checkedboxes.Remove(checkBox22 );

                }
                else
                {
                    count9 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count9 == 0)
                    {
                        checkBox9.Checked = false;

                    }






                }
            }

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox13)
                {
                    //dd = true;
                    count13 = 2;
                    checkBox23.Checked = true;
                    checkBox24.Checked = true;
                    Checkedboxes.Add(checkBox23 );
                    Checkedboxes.Add(checkBox24 );


                }
                else
                {
                    // dd = true;
                    count13 += 1;
                    Checkedboxes.Add(cb);

                    checkBox13.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox13)
                {
                    //dd = false;
                    count13 = 0;

                    checkBox23.Checked = false;
                    checkBox24.Checked = false;
                    Checkedboxes.Remove(checkBox23 );
                    Checkedboxes.Remove(checkBox24 );
                }
                else
                {
                    count13 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count13 == 0)
                    {
                        checkBox13.Checked = false;

                    }






                }
            }


        }


        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox17)
                {
                    //dd = true;
                    count17 = 2;
                    checkBox18.Checked = true;
                    checkBox19.Checked = true;
                    Checkedboxes.Add(checkBox18 );
                    Checkedboxes.Add(checkBox19 );


                }
                else
                {
                    // dd = true;
                    count17 += 1;
                    Checkedboxes.Add(cb);

                    checkBox17.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox17)
                {
                    //dd = false;
                    count17 = 0;

                    checkBox18.Checked = false;
                    checkBox19.Checked = false;
                    Checkedboxes.Remove(checkBox18 );
                    Checkedboxes.Remove(checkBox19 );
                   
                }
                else
                {
                    count17 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count17 == 0)
                    {
                        checkBox17.Checked = false;

                    }






                }
            }


        }


        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox12)
                {
                    //dd = true;
                    count12 = 5;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox20.Checked = true;
                    checkBox30.Checked = true;
                    checkBox31.Checked = true;
                    Checkedboxes.Add(checkBox28);
                    Checkedboxes.Add(checkBox29);
                    Checkedboxes.Add(checkBox20);
                    Checkedboxes.Add(checkBox30);
                    Checkedboxes.Add(checkBox31);


                }
                else
                {
                    // dd = true;
                    count12 += 1;
                    Checkedboxes.Add(cb);

                    checkBox12.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox12)
                {
                    //dd = false;
                    count12 = 0;
                    checkBox28.Checked = false;
                    checkBox29.Checked = false;
                    checkBox20.Checked = false;
                    checkBox30.Checked = false;
                    checkBox31.Checked = false;
                    Checkedboxes.Remove(checkBox28);
                    Checkedboxes.Remove(checkBox29);
                    Checkedboxes.Remove(checkBox20);
                    Checkedboxes.Remove(checkBox30);
                    Checkedboxes.Remove(checkBox31);


                }
                else
                {
                    count12 -= 1;
                    Checkedboxes.Remove(cb);

                    if (count12 == 0)
                    {
                        checkBox12.Checked = false;

                    }






                }
            }


        }
    }
}
