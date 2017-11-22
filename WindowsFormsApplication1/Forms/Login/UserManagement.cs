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
        int count3 = 2;
        int count25 = 4;
        int count6 = 2;
        int count13 = 2;
        int count17 = 2;
        int count9 = 4;
        int count12 = 5;
        public static int RoleId = -1;

        int count3_gb2 = 2;
        int count25_gb2 = 4;
        int count6_gb2 = 2;
        int count13_gb2 = 2;
        int count17_gb2 = 2;
        int count9_gb2 = 4;
        int count12_gb2 = 5;
        int RoleId_gb2 = -1;

        //List<bool> CheckedBoxes = new List<bool>();
        List<CheckBox> Checkedboxes = new List<CheckBox>();
        List<CheckBox> Checkedboxes_gb2 = new List<CheckBox>();
        public string username = "";
        

        List<CheckBox> SelectedUserCheckedboxes = new List<CheckBox>();

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



            listBox1.DataSource = new DAO().getusers();
            listBox1.DisplayMember = "Username";
            listBox1.ValueMember = "RoleId";
            listBox1.SelectedIndex = -1;

           // checkBox10.Checked = true;
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                //  new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration, AccountId, "Credit", RefNo, Decimal.Parse(txtRecieptAmount), 0, 00);
                

                if (new DAO().GetUsers(textBox1.Text) != null)
                {

                    MessageBox.Show("User name already exist");
                    return;
                }


                if (textBox2.Text.Equals(textBox3.Text))
                {

                }
                else
                {
                    MessageBox.Show("password and confirm password does not match");

                    return;

                }
                string checkedboxes = "";
                bool firstime = true;

                foreach (CheckBox checkboxes in groupBox1.Controls)
                {
                    if (firstime == true)
                    {
                        firstime = false;
                        string str = checkboxes.Text;
                        str = str.Replace(" ", String.Empty);
                        str = str.Replace("/", String.Empty);

                        checkedboxes += str;
                        continue;

                    }
                    string str2 = checkboxes.Text;
                    str2 = str2.Replace(" ", String.Empty);
                    str2 = str2.Replace("/", String.Empty);

                    checkedboxes += "," + str2;
                }



                string checkedboxesValues = "";
                bool firstime2 = true;

                foreach (CheckBox checkboxes in groupBox1.Controls)
                {
                    if (firstime2 == true)
                    {
                        firstime2 = false;

                        bool chked = checkboxes.Checked;
                        if (chked)
                        {
                            checkedboxesValues += "1";

                        }
                        else
                        {
                            checkedboxesValues += "0";

                        }
                        //checkedboxesValues += "1";
                        continue;
                    }

                    bool chked2 = checkboxes.Checked;
                    if (chked2)
                    {
                        checkedboxesValues += "," + "1";

                    }
                    else
                    {
                        checkedboxesValues += "," + "0";

                    }


                }

                //string checkedboxes = "";
                //bool firstime = true;

                //foreach (CheckBox checkboxes in groupBox2.Controls)
                //{
                //    if (firstime == true)
                //    {
                //        firstime = false;
                //        string str = checkboxes.Text;
                //        str = str.Replace(" ", String.Empty);
                //        str = str.Replace("/", String.Empty);
                //        checkedboxes += str;
                //        continue;
                //    }  
                //        bool chked = checkboxes.Checked;
                //        if (chked)
                //        {

                //        }
                //        else
                //        {
                //            checkedboxes += str + "= 0";

                //        }
                //        continue;


                //    string str2 = checkboxes.Text;
                //    str2 = str2.Replace(" ", String.Empty);
                //    str2 = str2.Replace("/", String.Empty);

                //    bool chked2 = checkboxes.Checked;
                //    if (chked2)
                //    {
                //        checkedboxes += ", " + str2 + " = 1";

                //    }
                //    else
                //    {
                //        checkedboxes += ", " + str2 + " = 0";

                //    }
                //}


                string sql = "Insert INTO UserRoles(" + checkedboxes + ") values (" + checkedboxesValues + ")";


                DataTable dt = new DataTable();

                SqlConnection conn = DBConn.GetInstance();
                //SqlDataAdapter dad = new SqlDataAdapter("", conn);

                SqlDataAdapter dad = new SqlDataAdapter(sql, conn);
                dad.Fill(dt);
                conn.Close();



                int RoleId = new DAO().getLastRoleId();
                new DAO().AddUser(textBox1.Text, textBox2.Text,RoleId);

                



               
              
                MessageBox.Show("New User Added");
                listBox1.DataSource = new DAO().getusers();
                listBox1.DisplayMember = "Username";
                listBox1.ValueMember = "RoleId";
                listBox1.SelectedIndex = -1;


            }
            else
            {

                MessageBox.Show("please fill username and password");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.CheckState == CheckState.Checked)
            {

                foreach (CheckBox c in groupBox1.Controls.OfType<CheckBox>())
                {
                    //switch (c.Name)
                    //{
                    //    case "checkBox10":
                    //        c.Checked = true;
                    //        continue;
                    //    case "checkBox3":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox6":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox9":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox13":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox17":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox25":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox14":
                    //        c.Checked = true;
                    //        continue;

                    //    case "checkBox12":

                    //        c.Checked = true;
                    //        continue;

                    //    default:
                    //        
                    //        continue;
                    //}
                    //Checkedboxes.Add(c);
                    ////Checkedboxes.Remove(c);
                    //c.Checked = true;
                    Checkedboxes.Add(c);
                   // Checkedboxes.Remove(c);
                    c.Checked = true;

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
                    //switch (c.Name)
                    //{
                    //    case "checkBox10":
                    //        c.Checked = false;
                    //        continue;
                    //    case "checkBox3":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox6":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox9":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox13":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox17":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox25":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox14":
                    //        c.Checked = false;
                    //        continue;

                    //    case "checkBox12":

                    //        c.Checked = false;
                    //        continue;


                    //    default:
                    Checkedboxes.Remove(c);

                    c.Checked = false;

                    //        continue;
                    //}

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
                    Checkedboxes.Add(checkBox3);


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
                    Checkedboxes.Remove(checkBox3);

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
                    Checkedboxes.Add(checkBox6);


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
                    Checkedboxes.Remove(checkBox6);

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
                    Checkedboxes.Add(checkBox25);


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
                    Checkedboxes.Remove(checkBox25);



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
                    Checkedboxes.Add(checkBox9);


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
                    Checkedboxes.Remove(checkBox9);

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
                    Checkedboxes.Add(checkBox13);


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
                    Checkedboxes.Remove(checkBox13);

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

        public void updatelistbox()
        {
            
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
                    Checkedboxes.Add(checkBox17);


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
                    Checkedboxes.Remove(checkBox17);


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
                    Checkedboxes.Add(checkBox12);


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
                    Checkedboxes.Remove(checkBox12);


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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (!lb.Focused)
            {

                return;
            }

            DataRowView row = (DataRowView)listBox1.SelectedItem;
            if(row != null){
                RoleId = (int)row.Row["RoleId"];
                username = (string)row.Row["Username"];

            }
            else
            {
                return;
            }
            int i = 1;

            DataTable dt = new DAO().getRoles(RoleId);
            //foreach (DataRow dr in dt.Rows)
            //{
               foreach (CheckBox c in groupBox2.Controls)
                {
                    
                    c.Checked = bool.Parse(dt.Rows[0][i].ToString());

                     if (c.Checked == true)
                    {
                    Checkedboxes_gb2.Add(c);
                    }


                    i += 1;
                }



            //}



        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox56)
                {
                    //dd = true;
                    count9_gb2 = 4;
                    checkBox59.Checked = true;
                    checkBox58.Checked = true;
                    checkBox47.Checked = true;
                    checkBox46.Checked = true;

                    Checkedboxes_gb2.Add(checkBox56);
                    Checkedboxes_gb2.Add(checkBox59);
                    Checkedboxes_gb2.Add(checkBox58);
                    Checkedboxes_gb2.Add(checkBox47);
                    Checkedboxes_gb2.Add(checkBox46);


                }
                else
                {
                    // dd = true;
                    count9_gb2 += 1;
                    Checkedboxes_gb2.Add(cb);

                    checkBox56.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox56)
                {
                    //dd = false;
                    count9_gb2 = 0;
                    checkBox58.Checked = false;
                    checkBox48.Checked = false;
                    checkBox47.Checked = false;
                    checkBox59.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox56);
                    Checkedboxes_gb2.Remove(checkBox58);
                    Checkedboxes_gb2.Remove(checkBox47);
                    Checkedboxes_gb2.Remove(checkBox48);
                    Checkedboxes_gb2.Remove(checkBox59);

                }
                else
                {
                    count9_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count9_gb2 == 0)
                    {
                        checkBox56.Checked = false;

                    }






                }
            }

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTile3.Enabled = false;

            if (listBox1.SelectedIndex == -1)
            {

                MessageBox.Show("please select a user first");
                metroTile3.Enabled = true;
                return;

            }
            
            string checkedboxes = "";
            bool firstime = true;
            
            foreach (CheckBox checkboxes in groupBox2.Controls)
            {
                if (firstime == true)
                {
                    firstime = false;
                    string str = checkboxes.Text;
                    str = str.Replace(" ", String.Empty);
                    str = str.Replace("/", String.Empty);

                    bool chked = checkboxes.Checked;
                    if (chked)
                    {
                        checkedboxes += str + "= 1";

                    }
                    else
                    {
                        checkedboxes += str + "= 0";

                    }
                    continue;

                }
                string str2 = checkboxes.Text;
                str2 = str2.Replace(" ", String.Empty);
                str2 = str2.Replace("/", String.Empty);

                bool chked2 = checkboxes.Checked;
                if (chked2)
                {
                    checkedboxes += ", " + str2 + " = 1";

                }
                else
                {
                    checkedboxes += ", " + str2 + " = 0";

                }
            }


            DataTable dt = new DataTable();

            SqlConnection conn = DBConn.GetInstance();
            //SqlDataAdapter dad = new SqlDataAdapter("", conn);

            string sql = "UPDATE UserRoles SET " + checkedboxes + " WHERE RoleId = " + RoleId;

            SqlDataAdapter dad = new SqlDataAdapter(sql, conn);
            dad.Fill(dt);
            conn.Close();
            MessageBox.Show("User Roles updated");
            metroTile3.Enabled = true;

        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (checkBox53.CheckState == CheckState.Checked)
            {

                foreach (CheckBox c in groupBox2.Controls)
                {
                    Checkedboxes_gb2.Add(c);
                    // Checkedboxes.Remove(c);
                    c.Checked = true;

                }
                count3_gb2 = 2;
                count25_gb2 = 4;
                count6_gb2 = 2;
                count13_gb2 = 2;
                count17_gb2 = 2;
                count9_gb2 = 4;
                count12_gb2 = 5;
            }
            else
            {

                foreach (CheckBox c in groupBox2.Controls)
                {
                    Checkedboxes_gb2.Remove(c);

                    c.Checked = false;

                    
                }
                count3_gb2 = 0;
                count25_gb2 = 0;
                count6_gb2 = 0;
                count13_gb2 = 0;
                count17_gb2 = 0;
                count9_gb2 = 0;
                count12_gb2 = 0;






            }
        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox61)
                {

                    //dd = true;
                    count3_gb2 = 2;
                    checkBox60.Checked = true;
                    checkBox62.Checked = true;
                    Checkedboxes_gb2.Add(checkBox61);
                    Checkedboxes_gb2.Add(checkBox60);
                    Checkedboxes_gb2.Add(checkBox62);


                }
                else
                {
                    Checkedboxes_gb2.Add(cb);

                    // dd = true;
                    count3_gb2 += 1;

                    checkBox61.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox61)
                {
                    //dd = false;
                    count3_gb2 = 0;

                    checkBox60.Checked = false;
                    checkBox61.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox60);
                    Checkedboxes_gb2.Remove(checkBox61);
                    Checkedboxes_gb2.Remove(checkBox62);

                }
                else
                {
                    count3_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count3_gb2 == 0)
                    {
                        checkBox61.Checked = false;

                    }






                }
            }


        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox54)
                {

                    //dd = true;
                    count6_gb2 = 2;
                    checkBox57.Checked = true;
                    checkBox55.Checked = true;
                    Checkedboxes_gb2.Add(checkBox54);
                    Checkedboxes_gb2.Add(checkBox57);
                    Checkedboxes_gb2.Add(checkBox55);


                }
                else
                {
                    Checkedboxes_gb2.Add(cb);

                    // dd = true;
                    count6_gb2 += 1;

                    checkBox54.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox54)
                {
                    //dd = false;
                    count6_gb2 = 0;

                    checkBox57.Checked = false;
                    checkBox55.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox54);
                    Checkedboxes_gb2.Remove(checkBox57);
                    Checkedboxes_gb2.Remove(checkBox55);

                }
                else
                {
                    count6_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count6_gb2 == 0)
                    {
                        checkBox54.Checked = false;

                    }






                }
            }

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox43)
                {
                    //dd = true;
                    count13_gb2 = 2;
                    checkBox44.Checked = true;
                    checkBox45.Checked = true;
                    Checkedboxes_gb2.Add(checkBox43);
                    Checkedboxes_gb2.Add(checkBox44);
                    Checkedboxes_gb2.Add(checkBox45);


                }
                else
                {
                    // dd = true;
                    count13_gb2 += 1;
                    Checkedboxes_gb2.Add(cb);

                    checkBox43.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox43)
                {
                    //dd = false;
                    count13_gb2 = 0;

                    checkBox44.Checked = false;
                    checkBox45.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox43);
                    Checkedboxes_gb2.Remove(checkBox44);
                    Checkedboxes_gb2.Remove(checkBox45);

                }
                else
                {
                    count13_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count13_gb2 == 0)
                    {
                        checkBox43.Checked = false;

                    }






                }
            }

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox48)
                {
                    //dd = true;
                    count17_gb2 = 2;
                    checkBox49.Checked = true;
                    checkBox50.Checked = true;
                    Checkedboxes_gb2.Add(checkBox48);
                    Checkedboxes_gb2.Add(checkBox49);
                    Checkedboxes_gb2.Add(checkBox50);


                }
                else
                {
                    // dd = true;
                    count17_gb2 += 1;
                    Checkedboxes_gb2.Add(cb);

                    checkBox48.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox48)
                {
                    //dd = false;
                    count17_gb2 = 0;

                    checkBox49.Checked = false;
                    checkBox50.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox48);
                    Checkedboxes_gb2.Remove(checkBox49);
                    Checkedboxes_gb2.Remove(checkBox50);


                }
                else
                {
                    count17_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count17_gb2 == 0)
                    {
                        checkBox48.Checked = false;

                    }






                }
            }

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox40)
                {
                    //dd = true;
                    count25_gb2 = 4;
                    checkBox41.Checked = true;
                    checkBox42.Checked = true;
                    checkBox39.Checked = true;
                    checkBox38.Checked = true;
                    Checkedboxes_gb2.Add(checkBox40);
                    Checkedboxes_gb2.Add(checkBox41);
                    Checkedboxes_gb2.Add(checkBox42);
                    Checkedboxes_gb2.Add(checkBox39);
                    Checkedboxes_gb2.Add(checkBox38);


                }
                else
                {
                    // dd = true;
                    count25_gb2 += 1;
                    Checkedboxes_gb2.Add(cb);

                    checkBox25.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox25)
                {
                    //dd = false;
                    count25_gb2 = 0;
                    checkBox41.Checked = false;
                    checkBox42.Checked = false;
                    checkBox39.Checked = false;
                    checkBox38.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox40);
                    Checkedboxes_gb2.Remove(checkBox41);
                    Checkedboxes_gb2.Remove(checkBox42);
                    Checkedboxes_gb2.Remove(checkBox39);
                    Checkedboxes_gb2.Remove(checkBox38);



                }
                else
                {
                    count25_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count25_gb2 == 0)
                    {
                        checkBox40.Checked = false;

                    }






                }
            }

        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }




            if (cb.CheckState == CheckState.Checked)
            {

                checkBox51.Checked = true;
                checkBox52.Checked = true;
                Checkedboxes_gb2.Add(checkBox51);
                Checkedboxes_gb2.Add(checkBox52);


                         }
            else
            {
                checkBox51.Checked = false;
                checkBox52.Checked = false;
                Checkedboxes_gb2.Remove(checkBox51);
                Checkedboxes_gb2.Remove(checkBox52);








            }

        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            if (cb.CheckState == CheckState.Checked)
            {
                if (cb == checkBox35)
                {
                    //dd = true;
                    count12_gb2 = 5;
                    checkBox32.Checked = true;
                    checkBox33.Checked = true;
                    checkBox34.Checked = true;
                    checkBox36.Checked = true;
                    checkBox37.Checked = true;
                    Checkedboxes_gb2.Add(checkBox35);
                    Checkedboxes_gb2.Add(checkBox32);
                    Checkedboxes_gb2.Add(checkBox33);
                    Checkedboxes_gb2.Add(checkBox34);
                    Checkedboxes_gb2.Add(checkBox36);
                    Checkedboxes_gb2.Add(checkBox37);


                }
                else
                {
                    // dd = true;
                    count12_gb2 += 1;
                    Checkedboxes_gb2.Add(cb);

                    checkBox35.Checked = true;
                }
            }
            else
            {
                if (cb == checkBox35)
                {
                    //dd = false;
                    count12_gb2 = 0;
                    checkBox32.Checked = false;
                    checkBox33.Checked = false;
                    checkBox34.Checked = false;
                    checkBox36.Checked = false;
                    checkBox37.Checked = false;
                    Checkedboxes_gb2.Remove(checkBox35);
                    Checkedboxes_gb2.Remove(checkBox32);
                    Checkedboxes_gb2.Remove(checkBox33);
                    Checkedboxes_gb2.Remove(checkBox34);
                    Checkedboxes_gb2.Remove(checkBox36);
                    Checkedboxes_gb2.Remove(checkBox37);


                }
                else
                {
                    count12_gb2 -= 1;
                    Checkedboxes_gb2.Remove(cb);

                    if (count12_gb2 == 0)
                    {
                        checkBox35.Checked = false;

                    }
                    



                }
            }

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

                MessageBox.Show("please select a user first");
                metroTile3.Enabled = true;
                return;

            }else if(username == "Admin")
            {
                MessageBox.Show("Admin Account Cannot Be Deleted");
                metroTile3.Enabled = true;
                return;

            }
            else if (username == Login.username)
            {
                MessageBox.Show("Logged in  Account Cannot Be Deleted");
                metroTile3.Enabled = true;
                return;

            }


            ReqDelUser obj = new ReqDelUser(this);
            obj.Show();

            




        }

        public void PerformRefresh()
        {
            listBox1.DataSource = new DAO().getusers();
            listBox1.DisplayMember = "Username";
            listBox1.ValueMember = "RoleId";
            listBox1.SelectedIndex = -1;
        }

    }
}
