using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms.Accounts;
namespace WindowsFormsApplication1.Code
{
    class DAO
    {
        SqlDataAdapter dad;
        SqlConnection conn = DBConn.GetInstance();
        public string getSellingTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(TotalCost) as Total from Orders where ODate like '%" + month + "%' AND (DATEPART(yy,PDate)=" + year + "  ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

       

        public string getSellingTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(TotalCost) as Total from Orders where ODate like '%" + DateTime.Today.Month + "%' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }
        public string getExpensesTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(ExpCost) as Total from Expenses where ExpDate like '%" + DateTime.Today.Month + "%' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public DataTable GetExpensesforMonth()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID WHERE e.ExpDate like '%" + DateTime.Today.Month + "%' order by e.ExpId", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public string getExpensesTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(ExpCost) as Total from Expenses where ExpDate like '%" + month + "%'  AND (DATEPART(yy,PDate)=" + year + " ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = (0.00).ToString();
                return total;

            }
        }
        public string getPurchaseTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(Total) as Total from Purchase where PDate like '%" + DateTime.Today.Month + "' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public string getPurchaseTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(Total) as Total from Purchase where PDate like '%" + month + "%' AND (DATEPART(yy,PDate)=" + year + ") ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public string getsaldate(string d1, string d2)
        {

            SqlCommand cmd = new SqlCommand("select SalDate from Salaries where SalDate BETWEEN @d1 AND @d2 ", conn);
            cmd.Parameters.AddWithValue("@d1", d1);
            cmd.Parameters.AddWithValue("@d2", d2);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 1.ToString();
                return total;

            }






        }
        //   public void UpdateSalFromAtt()
        //   {

        //       dad = new SqlDataAdapter("select count(a.atttypeid) as 'Days',e.EmployeeID,e.ESalary from Attendance a right outer join Employees e on e.EmployeeID = a.EmployeeID where attdate like '%" + DateTime.Today.Month + "%' and AtttypeId = 1 or AtttypeId = 3 group by e.EName,e.EmployeeID,e.ESalary order by e.EmployeeID;", conn);
        //       DataTable dt = new DataTable();
        //       dad.Fill(dt);

        //       foreach (DataRow row in dt.Rows)
        //       {
        //           int eid = int.Parse(row["EmployeeID"].ToString());

        ////           int bamount = getBonusEmp(eid);

        //           int total = 0;
        //           int days = int.Parse(row["Days"].ToString());
        //           int salaryday = int.Parse(row["ESalary"].ToString());

        //           total = salaryday * days;
        //         //  total = total + bamount;

        //           DataTable dts = new DataTable();


        //           SqlDataAdapter dad = new SqlDataAdapter("Update Salaries SET TotalSalary=@t where EmployeeID = @a", conn);


        //           dad.SelectCommand.Parameters.AddWithValue("@t", total);
        //           dad.SelectCommand.Parameters.AddWithValue("@a", eid);


        //           dad.Fill(dt);
        //           conn.Close();


        //       }

        //   }
        public int GetSalfromEMP(int eid)
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(TotalSalary,0) from Salaries where EmployeeID=@eid AND SalDate like '%" + DateTime.Today.Month + "%'", conn);
            cmd.Parameters.AddWithValue("@eid", eid);
            int total = int.Parse(cmd.ExecuteScalar().ToString());

            return total;
        }



        public void UpdateSalFromBonus(int eid, int bamount)
        {
            try
            {
                if (eid != 0)
                {


                    int total = GetSalfromEMP(eid);

                    total = total + bamount;
                    DataTable dt = new DataTable();


                    SqlDataAdapter dad = new SqlDataAdapter("Update Salaries SET SalDate=@date,TotalSalary=@t where EmployeeID = @a", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());

                    dad.SelectCommand.Parameters.AddWithValue("@t", total);
                    dad.SelectCommand.Parameters.AddWithValue("@a", eid);


                    dad.Fill(dt);
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Please fill the textboxes!", "ERROR!", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show( "Error, Please try Again!", "Stopped!", MessageBoxButtons.OKCancel);
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetEmpName()
        {
            DataTable dtEmpl = new DataTable();

            dad = new SqlDataAdapter("Select EmployeeID , EName as Name,ESalary as 'Salary/Day'  from [Employees] ", conn);
            dad.Fill(dtEmpl);
            conn.Close();
            return dtEmpl;

        }
        public DataTable PayDetails()
        {
            DataTable dtBonus = new DataTable();

            dad = new SqlDataAdapter("Select e.EName , b.BAmount,b.BDate from Bonus b INNER JOIN Employees e ON b.EmployeeID=e.EmployeeID ORDER BY b.EmployeeId", conn);
            dad.Fill(dtBonus);
            conn.Close();
            return dtBonus;
        }
        public DataTable getItemsFromPurchase(int sid)
        {
            DataTable dtItems = new DataTable();

            dad = new SqlDataAdapter("select p.*,i.IName from Purchase p, Items i where p.IId = i.IId and SId = @sid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", sid);
            dad.Fill(dtItems);
            conn.Close();
            return dtItems;
        }

        public DataTable BonusDetails()
        {
            DataTable dtBonus = new DataTable();

            dad = new SqlDataAdapter("Select b.BId,e.EName , b.BAmount,b.BDate from Bonus b INNER JOIN Employees e ON b.EmployeeID=e.EmployeeID ORDER BY b.EmployeeId", conn);
            dad.Fill(dtBonus);
            conn.Close();
            return dtBonus;
        }
        public DataTable GetEmpForCMB()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select EmployeeID,EName as 'Display'  from [Employees] ", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public void InsertSupplierPayment(string spdate, int sid, int cbalance, int cpamount)
        {
            SqlCommand cmd = new SqlCommand("Insert into SupplierPayment (SpDate,SId,SBalance,SpAmount) values (@cpdate,@cid,@cbalance,@cpamount)", conn);
            cmd.Parameters.AddWithValue("@cpdate", spdate);
            cmd.Parameters.AddWithValue("@cid", sid);
            cmd.Parameters.AddWithValue("@cbalance", cbalance);
            cmd.Parameters.AddWithValue("@cpamount", cpamount);
            cmd.ExecuteNonQuery();
        }
        public int TotalEmployees()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(EmployeeID) from [Employees]", conn);

            dad.Fill(dtProduct);

            int totalEmp = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return totalEmp;
        }

        public DataTable GetOrderDetails(int OrderNo)
        {
            DataTable dt = new DataTable();
            dad = new SqlDataAdapter("select Top 1 o.OrderNo,o.ODate,o.CId from orders o where o.OrderNo = @orderno order by OrderNo desc;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", OrderNo);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable ComboType()
        {
            DataTable dtType = new DataTable();

            dad = new SqlDataAdapter("Select AttTypeID, AttType as 'Attendance' from [AttendType]", conn);
            dad.Fill(dtType);
            conn.Close();
            return dtType;
        }

        public DataTable CreateAttendanceGV()
        {
            DataTable dtAttend = new DataTable();
            string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID WHERE a.AttDate =@date order by a.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtAttend);


            conn.Close();

            return dtAttend;

        }


        public DataTable SearchCashbook(DateTime start, DateTime end, int amount,int chequeNo,int BankCode, string InvoiceNo,string RefNo)
        {
            DataTable dtAttend = new DataTable();
            dad = new SqlDataAdapter("SELECT CBId,Date,ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook WHERE Date BETWEEN @start AND @end  ", conn);
           // dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtAttend);


            conn.Close();

            return dtAttend;

        }





        public string getEmpByID(string b)
        {
            SqlCommand cmd = new SqlCommand("Select EmployeeID from Employees WHERE EName = '" + b + "' ", conn);
            string name = cmd.ExecuteScalar().ToString();
            return name;
        }

        public DataTable GetAttendance()
        {
            DataTable dtAttend = new DataTable();
            string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId WHERE a.AttDate =@date order by a.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtAttend);


            conn.Close();

            return dtAttend;

        }

        internal object getAttDateLike(string date)
        {
            SqlCommand cmd = new SqlCommand("Select count(AttID) as 'Attendance-ID' from Attendance WHERE AttDate = '" + date + "' ", conn);
            int present = int.Parse(cmd.ExecuteScalar().ToString());
            return present;

        }

        internal object getAttByDate(string date)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate = @date order by e.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable GetCustomers()
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'ContactNumber', CBalance as Balance  from [Customer]", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }


        public DataTable GetParties()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'ContactNumber', PBalance as Balance, POwnerBal as OwnersBalance  from [Party]", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public DataTable GetPartiesFrmAccount()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select AccountId as 'Party-ID',Accountname as 'Name' from AccountChart WHERE DetailType = 'Party'", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public DataTable GetJournals()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select JournalId, Date, Description, DebitAccount as Debit, CreditAccount as 'Credit', DebitAmount,CreditAmount from Journal Order by Date", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public DataTable GetOrderIds(int AccountId)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select OrderId from Orders WHERE AccountId = @1 AND Status != 'Paid'", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", AccountId);

            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }
        public DataTable GetOrderIdsForEdit(int AccountId)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select OrderId from Orders WHERE AccountId = @1", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", AccountId);

            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }


        public DataTable GePurchaseIds( int AccountId)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select PurId from Purchase WHERE AccountId = @AccountId AND Status != 'Paid'", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);

            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public DataTable GePurchaseIds()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select PurId from Purchase", conn);

            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }
        public DataTable GeExpenseNames()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT AccountId,AccountName from AccountChart WHERE AccountType = 'EXPENSE'", conn);

            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public int GetAccountId(string AccountName)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT AccountId from AccountChart WHERE AccountName = '" + AccountName + "'"   , conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountName", AccountName);

            dad.Fill(dtparties);
            conn.Close();

            int id = int.Parse(dtparties.Rows[0][0].ToString());

            return id;

        }

        public string GetAccountDetailType(int  AccountName)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT DetailType from AccountChart WHERE AccountId = @AccountName", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountName", AccountName);

            dad.Fill(dtparties);
            conn.Close();

            if (dtparties.Rows[0][0].ToString() !=  null)
            {

                

                string DetailType = dtparties.Rows[0][0].ToString();

                if(DetailType == "Cash Or Cash Equivalent")
                {
                    return DetailType;


                }
                if (DetailType == "Bank")
                {
                    return DetailType;


                }

                return "";
            }
            else
            {
                return "";
            }

        }


        public DataTable GetAccountChartEntries()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT * from AccountChart", conn);
           // dad.SelectCommand.Parameters.AddWithValue("@AccountName", AccountName);

            dad.Fill(dtparties);
            conn.Close();

            //int id = int.Parse(dtparties.Rows[0][0].ToString());

            return dtparties;

        }


        public string GetAccountName(int AccountId)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT AccountName from AccountChart WHERE AccountId = @AccountId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);

            dad.Fill(dtparties);
            conn.Close();
            string PName = "";
            try
            {
                 PName = dtparties.Rows[0][0].ToString();


            }

            catch (Exception ex)
            {
            }






            return PName;

        }

        public DataTable GetCashBookRefNo(int CBId)
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT ReferenceNo,CBNo,VoucherNo from CashBook WHERE CBId = @CBId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@CBId", CBId);

            dad.Fill(dtparties);
            conn.Close();
            





            return dtparties;

        }

        public DataTable GetAccountNames()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT AccountId,AccountName from AccountChart", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }

        public DataTable GetfullAccountNames()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("SELECT AccountId,AccountName,AccountType from AccountChart", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }




        public AutoCompleteStringCollection GetPartyNames()
        {
            //DataTable dtparties = new DataTable();


            //dad = new SqlDataAdapter("Select  [PName] as Name FROM [Party]", conn);


            //dad.Fill(dtparties);
            //conn.Close();
            //return dtparties;
            //conn.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            string querry = @"Select  [PName] from [Party]";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    namesCollection.Add(dr["PName"].ToString());

            }

            dr.Close();
            conn.Close();

            return namesCollection;




        }



        public DataTable GetCustomers(int cusid)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer] where CId = @cid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@cid", cusid);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }


        public DataTable GetParties(int PId)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from [Party] where PId = @PId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PId", PId);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;

        }

        public DataTable GetParty(string PName)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from Party where PName = @PName", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PName", PName);
            dad.Fill(dtParties);
            conn.Close();
            if (dtParties.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dtParties;


            }

        }

        public DataTable GetBroker(string PName)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select BId  from Brokers where BrokerName = @PName", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PName", PName);
            dad.Fill(dtParties);
            conn.Close();
            if (dtParties.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dtParties;


            }

        }

        public DataTable GetParties(string name)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from [Party] where PName like '" + name + "%'", conn);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;

        }
        public decimal GetPartyBalance(int PId)
        {
            DataTable dtParties = new DataTable();
            decimal balance=0;
            dad = new SqlDataAdapter("Select PBalance from [Party] where PId = @PId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PId", PId);
            dad.Fill(dtParties);
            
            conn.Close();

            try
            {
                balance = Decimal.Parse(dtParties.Rows[0]["PBalance"].ToString());

            }

            catch (Exception ex)
            {
                if (balance.Equals(null))
                {
                    return 0;
                }


            }




            return balance;

        }


        public decimal GetCashBookBalance()
        {
            DataTable dtParties = new DataTable();
            decimal balance = 0;
            dad = new SqlDataAdapter("SELECT  TOP 1 Balance FROM CashBook ORDER BY CBId DESC", conn);
            dad.Fill(dtParties);

            conn.Close();

            try
            {
                balance = Decimal.Parse(dtParties.Rows[0]["Balance"].ToString());

            }

            catch (Exception ex)
            {
                if (balance.Equals(null))
                {
                    return 0;
                }


            }




            return balance;

        }



        public int GetInvoiceBalance(string InvoiceNo)
        {
            DataTable dtParties = new DataTable();
            int balance = 0;
            dad = new SqlDataAdapter("SELECT TotalCost,AmountPaid from Orders where OrderId = @InvoiceNo", conn);
            dad.SelectCommand.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
            dad.Fill(dtParties);


            conn.Close();

            balance = int.Parse(dtParties.Rows[0]["TotalCost"].ToString()) - int.Parse(dtParties.Rows[0]["AmountPaid"].ToString());



            return balance;

        }

        public DataTable GetCustomers(string name)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer] where CName like '" + name + "%'", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }

        public DataTable GetCustomersBalance()
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName as 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId order by ODate desc;", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }

        public DataTable getInvoiceReportData(string OrderId)
        {
            //DataTable dtCustomers = new DataTable();

            //dad = new SqlDataAdapter("select P.PName as 'CustomerName',o.OrderId, o.ODate as 'Date',i.IGarden as 'Garden',o.Qty as Quantity,o.Cost as Cost,o.TotalCost as TotalCost,o.AmountPaid from Orders o,Party P,Items i where o.PId = P.PId and o.IId = i.IId AND o.OrderId = @OrderId ORDER by ODate desc;", conn);
            //dad.SelectCommand.Parameters.AddWithValue("@OrderId", OrderId);

            //dad.Fill(dtCustomers);
            //conn.Close();
            //return dtCustomers;

            SqlCommand com = new SqlCommand("Sp_InvoiceReportData", conn);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@OrderId", OrderId);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }

        public DataTable getRecieptReportData(string OrderId)
        {
            
            SqlCommand com = new SqlCommand("Sp_RecieptReportData", conn);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@OrderId", OrderId);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }


        public DataTable getOrderaData()
        {

            SqlCommand com = new SqlCommand("GetOrdersDetails", conn);

            com.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }

        public DataTable getDeliveryOrderData(string OrderId)
        {

            SqlCommand com = new SqlCommand("Sp_DeliveryOrderData", conn);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@OrderId", OrderId);


            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }


        public DataTable getRecieptReportData(int  CBId)
        {
            
          SqlCommand com = new SqlCommand("Sp_PVdata", conn);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@CBId", CBId);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }

        public DataTable getGlReportData(int GLTransId, DateTime startDate, DateTime endDate)
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("SELECT x.GLTransId,x.Date,x.Narrative,x.TransType,x.Reference,x.Debit,x.Credit,SUM(y.bal) Balance FROM (SELECT *, Debit - Credit bal FROM GlTransactions ) x JOIN ( SELECT *, Debit - Credit bal FROM Gltransactions ) y ON y.GLTransId <= x.GLTransId where x.AccountId = @1 AND y.AccountId = @1 AND x.Date BETWEEN @2 AND @3  GROUP BY x.GLTransId,x.Date,x.Narrative,x.transType,x.Debit,x.Reference,x.Credit;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", GLTransId);
            dad.SelectCommand.Parameters.AddWithValue("@2", startDate);
            dad.SelectCommand.Parameters.AddWithValue("@3", endDate);
            dad.Fill(dtCustomers);

            DataRow secondRow = dtCustomers.NewRow();

            secondRow["Narrative"] = "Balance b/d";

            secondRow["Date"] = DateTime.Parse(dtCustomers.Rows[0][1].ToString());


            secondRow["GLTransId"] = 000;

            secondRow["TransType"] = "";

            secondRow["Reference"] = "";

            secondRow["Debit"] = 000;

            secondRow["Credit"] = 000;



            if (int.Parse(dtCustomers.Rows[0][5].ToString()) == 0)
            {
                secondRow["Balance"] = int.Parse(dtCustomers.Rows[0][7].ToString()) - int.Parse(dtCustomers.Rows[0][6].ToString());

            }
            else
            {
                secondRow["Balance"] = int.Parse(dtCustomers.Rows[0][7].ToString()) - int.Parse(dtCustomers.Rows[0][5].ToString());

            }

            //dtAccountTransactions.Rows.Add(newRow);


            dtCustomers.Rows.InsertAt(secondRow, 0);

            conn.Close();
            return dtCustomers;
        }



        public DataTable getGlReportDatafrAccName(int GLTransId, DateTime startDate, DateTime endDate)
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("SELECT AccountName FROM AccountChart where AccountId = @1;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", GLTransId);
            //dad.SelectCommand.Parameters.AddWithValue("@2", startDate);
            //dad.SelectCommand.Parameters.AddWithValue("@3", endDate);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }

        public DataTable GetCustomersBalance(string name, string from, string to)
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId and c.cName like '" + name + "%' and o.ODate between '" + from + "' and '" + to + "';", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }

        public DataTable GetCustomersBalance(string name)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName as 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId and c.cName like '" + name + "%'", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }
        public int NetTotal(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.CId = @cid", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int nettotal = int.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public int NetTotal(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.CId = @cid and o.ODate between '" + from + "' and '" + to + "' ", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int nettotal = int.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public int NetTotal(string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.ODate between '" + from + "' and '" + to + "' ", conn);
            int nettotal = int.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public int NetTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o", conn);
            int nettotal = int.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public int PaidAmount(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int paidamount = int.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }



      

        public int PaidAmount(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CId = @cid and CpDate between '" + from + "' and '" + to + "'", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int paidamount = int.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }
        public int PaidAmount(string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CpDate between '" + from + "' and '" + to + "'", conn);
            int paidamount = int.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }
        public int PaidAmount()
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment;", conn);
            int paidamount = int.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }

        public int Balance(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from Customer where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public int Balance(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from CustomerPayment where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }
        public int Balance()
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from Customer;", conn);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public DataTable GetEmp()
        {
            DataTable dtEmpl = new DataTable();

            dad = new SqlDataAdapter("Select EmployeeID as 'Employee-ID', EName as Name, EJobTitle as Title, EHireDate as 'Date of Hire', EAddress as 'Address', EContact as Contact, ESalary as 'Salary/Day'  from [Employees] ", conn);
            dad.Fill(dtEmpl);
            conn.Close();
            return dtEmpl;

        }

        public DataTable GetSupplier()
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] ", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplier(int sid)
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] where SId = @sid ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", sid);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplier(string sname)
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] where SName like '" + sname + "%' ", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplierBalanceSheet()
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }


        public int getSupplierBalance()
        {
            SqlCommand cmd = new SqlCommand("Select SUM(SBalance) from supplier", conn);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public int getSupplierBalance(int sid)
        {
            SqlCommand cmd = new SqlCommand("Select SBalance from supplier where sid = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", sid);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }



        public int getSupplierBalance(int sid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select top 1 SBalance from SupplierPayment where SpDate between '" + from + "' and '" + to + "' and SId = @sid order by SpId desc;", conn);
            cmd.Parameters.AddWithValue("@sid", sid);
            int balance = int.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }


        public DataTable GetSupplierBalanceSheet(string name)
        {
            DataTable dtSupplier = new DataTable();
            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId and s.SName like '" + name + "%' order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplierBalanceSheet(string name, string from, string to)
        {
            DataTable dtSupplier = new DataTable();
            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId and s.SName like '" + name + "%' and sp.SpDate between '" + from + "' and '" + to + "' order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }


        public DataTable GetTypes()
        {
            DataTable dtType = new DataTable();

            dad = new SqlDataAdapter("Select TypeId as 'Type-ID', Type  from [Type] ", conn);
            dad.Fill(dtType);
            conn.Close();
            return dtType;

        }


        public DataTable GetTypeforCMB()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select TypeId,Type as 'Display'  from [Type] ", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable GetExpenses()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID order by e.ExpId", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable getExpByDate(string date)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID  WHERE e.ExpDate = @date order by e.ExpId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        internal DataTable getExpByDate(string text1, string text2)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID  WHERE e.ExpDate Between '" + text1 + "' AND '" + text2 + "'", conn);

            dad.Fill(dtype);
            conn.Close();

            return dtype;

        }

        public DataTable getItems()
        {
            SqlCommand com = new SqlCommand("sp_getItems", conn);

            com.CommandType = CommandType.StoredProcedure;

           // com.Parameters.AddWithValue("@OrderId", OrderId);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }

        public int getMaxOrderOderNo()
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(max(OrderNo),0) from Orders", conn);
            int orderno = int.Parse(cmd.ExecuteScalar().ToString());
            return orderno;
        }

        public int getCost(int itemid)
        {
            SqlCommand cmd = new SqlCommand("select IPrice from Items where IId = @itemid", conn);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            int cost = int.Parse(cmd.ExecuteScalar().ToString());
            return cost;
        }

        public int getTotal(int orderno)
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(sum(TotalCost),0) from Orders where OrderNo = @orderno;", conn);
            cmd.Parameters.AddWithValue("@orderno", orderno);
            int total = int.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }

        public void RemoveQty(decimal iqty, int itemid)
        {
            SqlCommand cmd = new SqlCommand("Update Items set IQty = @nqty where IId = @itemid", conn);
            cmd.Parameters.AddWithValue("@nqty", iqty);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            cmd.ExecuteNonQuery();
        }

        public void RemoveWt(decimal iqty, int itemid)
        {
            SqlCommand cmd = new SqlCommand("Update Items set ITotalWeight = @nqty where IId = @itemid", conn);
            cmd.Parameters.AddWithValue("@nqty", iqty);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            cmd.ExecuteNonQuery();
        }


        public decimal getQty(int itemid)
        {
            SqlCommand cmd = new SqlCommand("select IQty from Items where IId = @itemid;", conn);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            decimal qty = Decimal.Parse(cmd.ExecuteScalar().ToString());
            return qty;
        }

        public DataTable Get_Cart(int orderno)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderId as 'ID',o.OrderNo as 'OrderNo',o.ODate as 'Date', o.PId as 'PartyID', o.IId as ItemID, i.IName as ItemName,o.Qty,o.Cost,o.TotalCost from orders o join items i on i.IId = o.IId where OrderNo = @orderno", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", orderno);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }

        public DataTable GetOrders(int orderno)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderId,o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where OrderNo = @orderno and o.PId = p.PId and o.IId = i.IId;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", orderno);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }

        public DataTable GeSaleTrans()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select * from GLtransactions;", conn);
           // dad.SelectCommand.Parameters.AddWithValue("@orderno", orderno);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }

        public DataTable GetOrdersByDate(string from, string to)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where o.ODate between '" + from + "' and '" + to + "' and o.PId = p.PId and o.IId = i.IId;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }
        public void UpdateCart(int qty, int cost, int totalcost, int orderno)
        {
            SqlCommand cmd = new SqlCommand("Update Orders set qty = @qty, cost = @cost, totalcost = @totalcost where orderno = @orderno", conn);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@totalcost", totalcost);
            cmd.Parameters.AddWithValue("@orderno", orderno);
            cmd.ExecuteNonQuery();
        }

        public void RemoveOrder(int orderid)
        {
            SqlCommand cmd = new SqlCommand("delete from Orders where orderid = @orderid", conn);
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.ExecuteNonQuery();
        }


        public void AddDboAccount(string AccountName,string AccountType, string DetailType)
        {
            SqlCommand cmd = new SqlCommand("Insert into AccountChart (AccountName,AccountType,DetailType) values (@AccountName,@AccountType,@DetailType)", conn);
            cmd.Parameters.AddWithValue("@AccountName", AccountName);
            cmd.Parameters.AddWithValue("@AccountType", AccountType);

            cmd.Parameters.AddWithValue("@DetailType", DetailType);


            cmd.ExecuteNonQuery();
        }

        public void AddPartyGlAccount(string AccountName,string Type)
        {
            SqlCommand cmd = new SqlCommand("Insert into AccountChart (AccountName,AccountType,DetailType) values (@AccountName,'ASSET',@Type)", conn);
            cmd.Parameters.AddWithValue("@AccountName", AccountName);
            cmd.Parameters.AddWithValue("@Type", Type);


            cmd.ExecuteNonQuery();
        }

        public void AddCustomerPayment(string cpdate, int cid,int cbalance, int cpamount)
        {
            SqlCommand cmd = new SqlCommand("Insert into CustomerPayment (CpDate,CId,CBalance,CpAmount) values (@cpdate,@cid,@cbalance,@cpamount)", conn);
            cmd.Parameters.AddWithValue("@cpdate", cpdate);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@cbalance", cbalance);
            cmd.Parameters.AddWithValue("@cpamount", cpamount);
            cmd.ExecuteNonQuery();
        }

        public int getLastPurchaseNo()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 PurNo FROM Purchase ORDER BY PurNo DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 1;


            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]);

            }
            catch(Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 1;
                }
                
            }

            
            return purchaseNo;

        }


        public int getLastOrderNo()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 OrderNo FROM Orders ORDER BY OrderNo DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 1;


            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]);

            }
            catch (Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 1;
                }

            }


            return purchaseNo;

        }


        public int getLastCBNoByCredit()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 CBNo FROM CashBook WHERE TransactionType = 'Credit' ORDER BY CBNo DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 0;


            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]);

            }
            catch (Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 0;
                }

            }


            return purchaseNo;

        }


        public int getLastCBNoByDebit()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 CBNo FROM CashBook WHERE TransactionType = 'Debit' ORDER BY CBNo DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 0;


            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]);

            }
            catch (Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 0;
                }

            }


            return purchaseNo;

        }



        public int getLastCBId()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 CBId FROM CashBook ORDER BY CBId DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 0;


            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]);

            }
            catch (Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 0;
                }

            }


            return purchaseNo;

        }


        public int getLastJournalNo()
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("SELECT  TOP 1 JournalNo FROM Journal ORDER BY JournalNo DESC;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            int purchaseNo = 1;
            try
            {
                purchaseNo = Convert.ToInt16(dtOrders.Rows[0][0]) + 1;

            }
            catch (Exception ex)
            {
                if (purchaseNo.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return purchaseNo;
                }
            }
            
            return purchaseNo;

        }


        public void UpdateGlTransaction(DateTime date, string Narrative, int AccountId, string TransType, string Reference, decimal Credit, decimal Debit, decimal Balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update GLtransactions SET date=@date, Narrative=@Narrative, AccountId= @AccountId,TransType= @TransType, Reference= @Reference,Balance = @Balance, Credit = @Credit, Debit = @Debit where Reference = @Reference AND AccountId = @AccountId AND date = @date AND TransType= @TransType ", conn);

                //SqlCommand cmd = new SqlCommand("Insert into GLtransactions (date,Narrative,AccountId,TransType,Reference,Balance,Credit,Debit) values (@date,@Narrative,@AccountId,@TransType,@Reference,@Balance,@Credit,@Debit)", conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@Narrative", Narrative);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@TransType", TransType);
                cmd.Parameters.AddWithValue("@Reference", Reference);
                cmd.Parameters.AddWithValue("@Balance", Balance);
                cmd.Parameters.AddWithValue("@Credit", Credit);
                cmd.Parameters.AddWithValue("@Debit", Debit);


                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void AddGlTransactions(DateTime date,string Narrative,int AccountId,string TransType, string Reference,decimal Credit,decimal Debit,decimal Balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into GLtransactions (date,Narrative,AccountId,TransType,Reference,Balance,Credit,Debit) values (@date,@Narrative,@AccountId,@TransType,@Reference,@Balance,@Credit,@Debit)", conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@Narrative", Narrative);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@TransType", TransType);
                cmd.Parameters.AddWithValue("@Reference", Reference);
                cmd.Parameters.AddWithValue("@Balance", Balance);
                cmd.Parameters.AddWithValue("@Credit", Credit);
                cmd.Parameters.AddWithValue("@Debit", Debit);


                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getCashBookdata()
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("SELECT CBId,Date,ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook", conn);





            // dt.Rows.Add(0, new string[] {"12/6/17", "yos", "ord2","352"});

            dad.Fill(dt);
            //DataRow newRow = dt.NewRow();
            //newRow["Date"] = "12/7/17";
            //newRow["Narration"] = "Balance b/d";
            //newRow["Cash"] = 3432;

            //dt.Rows.InsertAt(newRow, 0);
            conn.Close();
            return dt;
        }


        public DataTable getCashBookEntries()
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();
            SqlDataAdapter dad = new SqlDataAdapter("SELECT x.CBId,x.Date,x.Category,x.Description,x.AmountType,x.Income,x.Expense,SUM(y.bal) Balance FROM (SELECT *, Income - Expense bal FROM CashBook ) x JOIN ( SELECT *, Income - Expense bal FROM CashBook ) y ON y.CBId <= x.CBId GROUP BY x.CBId,x.Date,x.Category,x.Description,x.AmountType,x.Income,x.Expense;", conn);

            //SqlDataAdapter dad = new SqlDataAdapter("SELECT CBId,Date,ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook", conn);
            




            // dt.Rows.Add(0, new string[] {"12/6/17", "yos", "ord2","352"});

            dad.Fill(dt);
            //DataRow newRow = dt.NewRow();
            //newRow["Date"] = "12/7/17";
            //newRow["Narration"] = "Balance b/d";
            //newRow["Cash"] = 3432;

            //dt.Rows.InsertAt(newRow, 0);
            conn.Close();
            return dt;
        }
        public DataTable getCashBookPayments()
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("SELECT Date, Narration, ReferenceNo,Cash,Bank from CashBook WHERE Type = 'Payments' ", conn);

            dad.Fill(dt);
            conn.Close();
            return dt;
        }

        public string getPartyName(int PId)
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("SELECT PName from Party WHERE PId = @1", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", PId);
            string PartyName = dt.Rows[0][0].ToString();





            dad.Fill(dt);


            conn.Close();
            return PartyName;
        }





        //public void AddGlSalesTransaction(DateTime date, string Narrative, int AccountId, string TransType, string Reference, int Balance)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into GLtransactions (date,Narrative,AccountId,TransType,Reference,Balance) values (@date,@Narrative,@AccountId,@TransType,@Reference,@Balance)", conn);
        //        cmd.Parameters.AddWithValue("@date", date);
        //        cmd.Parameters.AddWithValue("@Narrative", Narrative);
        //        cmd.Parameters.AddWithValue("@AccountId", AccountId);
        //        cmd.Parameters.AddWithValue("@TransType", TransType);
        //        cmd.Parameters.AddWithValue("@Reference", Reference);
        //        cmd.Parameters.AddWithValue("@Balance", Balance);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        int i = 0;
        //    }
        //}


        public void AddOrderTransaction(int PId, int debit, int credit ,int IId,int itemQuantity,string description,DateTime date ,int itemBought, int balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Ledger (PId,Debit,Credit,IId,itemQuantity,date,itemBought,Balance) values (@PId,@debit,@credit,@IId,@itemQuantity,@date,@itemBought,@balance)", conn);
                cmd.Parameters.AddWithValue("@PId", PId);
                cmd.Parameters.AddWithValue("@debit", debit);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.Parameters.AddWithValue("@IId", IId);
                cmd.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@itemBought", itemBought);
                cmd.Parameters.AddWithValue("@balance", balance);
            
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                int i = 0;
            }
        }

        public void AddPurchaseTransaction(int AccountId, int debit, int credit, int IId, int itemQuantity, string description, DateTime date, int itemBought, int balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Ledger (AccountId,Debit,Credit,IId,itemQuantity,date,itemBought,Balance) values (@AccountId,@debit,@credit,@IId,@itemQuantity,@date,@itemBought,@balance)", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@debit", debit);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.Parameters.AddWithValue("@IId", IId);
                cmd.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@itemBought", itemBought);
                cmd.Parameters.AddWithValue("@balance", balance);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                int i = 0;
            }
        }

        internal int PresentDayCount(string eid, string dt, string dt1)
        {

            SqlCommand cmd = new SqlCommand("select count(AttTypeId) from Attendance where EmployeeID=@emp AND (AttDate BETWEEN @date1 AND @date) AND AttTypeId = 1 OR AttTypeId =3", conn);
            cmd.Parameters.AddWithValue("@emp", eid);
            cmd.Parameters.AddWithValue("@date1", dt);
            cmd.Parameters.AddWithValue("@date", dt1);
            int total = int.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }

        internal int getBonusEmp(int eid, string dt1, string dt2)
        {

            DataTable dtPay = new DataTable();



            dad = new SqlDataAdapter("select SUM(BAmount) from Bonus where EmployeeID=@eid AND BDate Between @dt1 AND @dt2", conn);
            dad.SelectCommand.Parameters.AddWithValue("@eid", eid);
            dad.SelectCommand.Parameters.AddWithValue("@dt1", dt1);
            dad.SelectCommand.Parameters.AddWithValue("@dt2", dt2);
            dad.Fill(dtPay);
            conn.Close();

            int bonus = 0;
            try
            {
                bonus = int.Parse(dtPay.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                bonus = 0;
            }



            return bonus;

        }

        //internal object getSalary()
        //{
        //   // UpdateSalFromAtt();
        //    DataTable dtPay = new DataTable();
        //    conn = DBConn.GetInstance();


        //    dad = new SqlDataAdapter("select e.EName as 'Name', e.ESalary as 'Salary/Day', ISNULL(SUM(b.BAmount),0) as 'Bonus', s.SalDate as 'Salary-Date', s.TotalSalary as 'TotalSalary' from Employees e left outer join Bonus b ON b.EmployeeID = e.EmployeeID  left outer join Salaries s ON s.EmployeeID= e.EmployeeID WHERE s.SalDate  like '%' GROUP BY e.EmployeeID,e.EName, e.ESalary,s.SalDate,s.TotalSalary ORDER  BY e.EmployeeID;", conn);
        //  //  dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today.Month);
        //    dad.Fill(dtPay);


        //    dad = new SqlDataAdapter("select count(ISNULL(a.atttypeid,0)) as 'Days',e.eName from Attendance a right outer join Employees e on e.EmployeeID = a.EmployeeID where attdate like '%"+DateTime.Today.Month+"%' and AtttypeId = 1 or AtttypeId = 3 group by e.EName,e.EmployeeID order by e.EmployeeID;", conn);
        //    DataTable dt = new DataTable();
        //    dad.Fill(dt);

        //    dtPay.Columns.Add("WorkingDays");

        //    try
        //    {

        //        for (int i = 0; i < dtPay.Rows.Count; i++)
        //        {

        //            dtPay.Rows[i]["WorkingDays"] = dt.Rows[i]["Days"];


        //        }

        //    }
        //    catch (IndexOutOfRangeException e)
        //    {


        //    }

        //    conn.Close();
        //    return dtPay;
        //}

        public DataTable GetCustomersss()
        {
            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CId , CName  as'Display' from [Customer] ", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }


        public void checkOrderSatus(string OrderId, decimal amountPaid, int AccountId)
        {

            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select TotalCost,AmountPaid,Status  from Orders where AccountId = @AccountId AND OrderId = @OrderId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);
            dad.SelectCommand.Parameters.AddWithValue("@OrderId", OrderId);
            dad.Fill(dtCustomers);

            int totalcost = int.Parse(dtCustomers.Rows[0][0].ToString());
            decimal amountpaidhis = decimal.Parse(dtCustomers.Rows[0][1].ToString()) + amountPaid;

            if (totalcost <= amountpaidhis)
            {

                SqlCommand cmd = new SqlCommand("Update Orders set Status = 'Paid', AmountPaid = @amountPaid where AccountId = @AccountId AND OrderId = @OrderId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                cmd.ExecuteNonQuery();


            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Orders set Status = 'PartialPaid', AmountPaid = @amountPaid where AccountId = @AccountId AND OrderId = @OrderId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                cmd.ExecuteNonQuery();

            }
            conn.Close();



        }


        public void checkEditOrderSatus(string OrderId, decimal amountPaid, int AccountId,decimal PreviousAmountPaid)
        {

            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select TotalCost,AmountPaid,Status  from Orders where AccountId = @AccountId AND OrderId = @OrderId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);
            dad.SelectCommand.Parameters.AddWithValue("@OrderId", OrderId);
            dad.Fill(dtCustomers);

            int totalcost = int.Parse(dtCustomers.Rows[0][0].ToString());
            decimal amountpaidhis = decimal.Parse(dtCustomers.Rows[0][1].ToString()) - PreviousAmountPaid  + amountPaid;

            if (totalcost <= amountpaidhis)
            {

                SqlCommand cmd = new SqlCommand("Update Orders set Status = 'Paid', AmountPaid = @amountPaid where AccountId = @AccountId AND OrderId = @OrderId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                cmd.ExecuteNonQuery();


            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Orders set Status = 'PartialPaid', AmountPaid = @amountPaid where AccountId = @AccountId AND OrderId = @OrderId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                cmd.ExecuteNonQuery();

            }
            conn.Close();



        }





        public void checkPurchaseSatus(string PurId, decimal amountPaid, int AccountId)
        {

            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select Total,AmountPaid,Status  from Purchase where AccountId = @AccountId AND PurId = @PurId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);
            dad.SelectCommand.Parameters.AddWithValue("@PurId", PurId);
            dad.Fill(dtCustomers);

            decimal totalcost = decimal.Parse(dtCustomers.Rows[0][0].ToString());
            decimal amountpaidhis = decimal.Parse(dtCustomers.Rows[0][1].ToString()) + amountPaid;

            if (totalcost <= amountpaidhis)
            {

                SqlCommand cmd = new SqlCommand("Update Purchase set Status = 'Paid', AmountPaid = @amountPaid where AccountId = @AccountId AND PurId = @PurId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@PurId", PurId);
                cmd.ExecuteNonQuery();


            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Purchase set Status = 'PartialPaid', AmountPaid = @amountPaid where AccountId = @AccountId AND PurId = @PurId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@PurId", PurId);
                cmd.ExecuteNonQuery();

            }
            conn.Close();



        }


        public void checkEditPurchaseSatus(string PurId, decimal amountPaid, int AccountId,decimal PreviousAmountPaid)
        {

            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select Total,AmountPaid,Status  from Purchase where AccountId = @AccountId AND PurId = @PurId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);
            dad.SelectCommand.Parameters.AddWithValue("@PurId", PurId);
            dad.Fill(dtCustomers);

            decimal totalcost = decimal.Parse(dtCustomers.Rows[0][0].ToString());
            decimal amountpaidhis = decimal.Parse(dtCustomers.Rows[0][1].ToString()) - PreviousAmountPaid    + amountPaid;

            if (totalcost <= amountpaidhis)
            {

                SqlCommand cmd = new SqlCommand("Update Purchase set Status = 'Paid', AmountPaid = @amountPaid where AccountId = @AccountId AND PurId = @PurId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@PurId", PurId);
                cmd.ExecuteNonQuery();


            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Purchase set Status = 'PartialPaid', AmountPaid = @amountPaid where AccountId = @AccountId AND PurId = @PurId", conn);
                cmd.Parameters.AddWithValue("@AccountId", AccountId);
                cmd.Parameters.AddWithValue("@amountPaid", amountpaidhis);

                cmd.Parameters.AddWithValue("@PurId", PurId);
                cmd.ExecuteNonQuery();

            }
            conn.Close();



        }



        public void UpdateCustomerBalance(int cid, int balance)
        {
            SqlCommand cmd = new SqlCommand("Update Customer set CBalance = CBalance + @balance where CId = @cid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.ExecuteNonQuery();
        }

        public void UpdatePartyBalance(int pid, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("Update Party set PBalance = @balance  where PId = @pid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
        }






        

        public void UpdateOwnerBalance(int pid, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("Update Party set PBalance = @balance where PId = @pid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
        }


        public DataTable ShowCatList1()
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("Select CatId, CatDesc as'Display' from Category ", conn);

            dad.Fill(dt);
            conn.Close();
            return dt;
        }
        public int GetCatIdfromDesc(string desc)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CatId  from Category where CatDesc = '" + desc + "'", conn);
            dad.Fill(dtProduct);
            int catid = (Convert.ToInt32(dtProduct.Rows[0][0]));
            conn.Close();
            return catid;
        }

        public string GetCatDescfromCatId(int catid)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select catdesc from Category where catid = " + catid + "", conn);
            dad.Fill(dtProduct);
            string catdesc = dtProduct.Rows[0][0].ToString();
            conn.Close();
            return catdesc;
        }
        public int GetCatId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(CatId) from [Category] ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return orderId;
        }

        public DataTable GetItems()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IId, IGarden  from [Items] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        // public DataTable GetGardens()
        //{
        //    DataTable dtProduct = new DataTable();
        //    conn = DBConn.GetInstance();


        //    dad = new SqlDataAdapter("Select DISTINCT IGarden  from [Items] ", conn);
        //    dad.Fill(dtProduct);
        //    conn.Close();
        //    return dtProduct;

        //}


        public AutoCompleteStringCollection GetGardens()
        {
            //DataTable dtparties = new DataTable();


            //dad = new SqlDataAdapter("Select  [PName] as Name FROM [Party]", conn);


            //dad.Fill(dtparties);
            //conn.Close();
            //return dtparties;
            //conn.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            string querry = @"Select DISTINCT [IGarden]  from [Items] ";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    namesCollection.Add(dr["IGarden"].ToString());

            }

            dr.Close();
            conn.Close();

            return namesCollection;




        }

        public DataTable GetLotNoS()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IId,LotNo  from [Items] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public DataTable SearchLotNo(int LotNo)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IId  from Items WHERE lotNo =@LotNo", conn);
            dad.SelectCommand.Parameters.AddWithValue("@LotNo", LotNo);
            dad.Fill(dtProduct);
            conn.Close();

            if (dtProduct != null && dtProduct.Rows.Count > 0)
            {
                return dtProduct;

            }
            else
            {
                return null;
            }



        }




        public DataTable GetItemsforOrder(int IId)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IGarden,IGrade,IQty,IWtPerBag,ITotalWeight  from [Items] WHERE IId = @IId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@IId", IId);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public DataTable GetItemsforLotNo(int IId)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IGarden,IGrade,IQty,IWtPerBag,ITotalWeight,IId  from [Items] WHERE LotNo = @IId ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@IId", IId);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }


        public DataTable GetBrokers()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select BId,BrokerName  from Brokers WHERE BId != 2 ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public DataTable GetBrokersfrm()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select BId,BrokerName,Address,Email,ContactNo  from Brokers WHERE BId != 2 ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public DataTable GetCategory()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Category] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int getItemIdFromName(int LotNo)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();
            int itemid;

            dad = new SqlDataAdapter("Select IId  from Items where LotNo = @LotNo", conn);
            dad.SelectCommand.Parameters.AddWithValue("@LotNo", LotNo);

            dad.Fill(dtProduct);
            try
            {
                itemid = (Convert.ToInt32(dtProduct.Rows[0][0]));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            conn.Close();
            return itemid;
        }
        public DataTable GetSuppliers()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Supplier] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int getSupplierIdFromName(string sName)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SId  from Supplier where SName = @sname", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sname", sName);
            dad.Fill(dtProduct);
            int SId = (Convert.ToInt32(dtProduct.Rows[0][0]));
            conn.Close();
            return SId;
        }
        public DataTable getusers()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Login] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public void SubSuppBalance(int Sid, int total)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("update Supplier set SBalance=SBalance-@total from [Supplier] where SId = @sid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", Sid);
            dad.SelectCommand.Parameters.AddWithValue("@total", total);


            dad.Fill(dtProduct);



            conn.Close();
        }

        public void insertItem(int LotNo, string Grade,string IGarden,decimal totalBags,decimal WtPerBag,decimal IRatePerKg,decimal ITotalCost,decimal ITotalWeight)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("Insert into Items(LotNo,IGrade,IQty,IGarden,IWtPerBag,IRatePerKg,ITotalCost,ITotalWeight) values(@LotNo,@Grade,@totalBags,@IGarden,@WtPerBag,@IRatePerKg,@ITotalCost,@ITotalWeight)", conn);
            dad.SelectCommand.Parameters.AddWithValue("@LotNo", LotNo);
            dad.SelectCommand.Parameters.AddWithValue("@Grade", Grade);
            dad.SelectCommand.Parameters.AddWithValue("@IRatePerKg", IRatePerKg);
            dad.SelectCommand.Parameters.AddWithValue("@IGarden", IGarden);
            dad.SelectCommand.Parameters.AddWithValue("@totalBags", totalBags);
            dad.SelectCommand.Parameters.AddWithValue("@WtPerBag", WtPerBag);
            dad.SelectCommand.Parameters.AddWithValue("@ITotalCost", ITotalCost);
            dad.SelectCommand.Parameters.AddWithValue("@ITotalWeight", ITotalWeight);


            dad.Fill(dt);
            conn.Close();
        }

        public void EditItem(int LotNo,string Grade, string IGarden, decimal totalBags, decimal WtPerBag, decimal IRatePerKg, decimal ITotalCost, decimal ITotalWeight,int IId)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConn.GetInstance();


            //SqlDataAdapter dad = new SqlDataAdapter("Insert into Items(LotNo,IGrade,IQty,IGarden,IWtPerBag,IRatePerKg,ITotalCost,ITotalWeight) values(@LotNo,@Grade,@totalBags,@IGarden,@WtPerBag,@IRatePerKg,@ITotalCost,@ITotalWeight)", conn);
            SqlDataAdapter dad = new SqlDataAdapter("Update Items Set LotNo=@LotNo,IGrade=@Grade, IQty=@totalBags,IGarden=@IGarden, IWtPerBag=@WtPerBag,IRatePerKg = @IRatePerKg, ITotalCost = @ITotalCost, ITotalWeight = @ITotalWeight where IId = @IId", conn);

            dad.SelectCommand.Parameters.AddWithValue("@LotNo", LotNo);

            dad.SelectCommand.Parameters.AddWithValue("@IId", IId);
            dad.SelectCommand.Parameters.AddWithValue("@Grade", Grade);
            dad.SelectCommand.Parameters.AddWithValue("@IRatePerKg", IRatePerKg);
            dad.SelectCommand.Parameters.AddWithValue("@IGarden", IGarden);
            dad.SelectCommand.Parameters.AddWithValue("@totalBags", totalBags);
            dad.SelectCommand.Parameters.AddWithValue("@WtPerBag", WtPerBag);
            dad.SelectCommand.Parameters.AddWithValue("@ITotalCost", ITotalCost);
            dad.SelectCommand.Parameters.AddWithValue("@ITotalWeight", ITotalWeight);



            dad.Fill(dt);
            conn.Close();
        }



        public DataTable GetInvestors()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Customer] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int GetSuppBalance(int id)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SBalance from [Supplier] WHERE SId = '" + id + "' ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return orderId;
        }

        public void SubInvestorBalance(int CId, int total)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("update Customer set CBalance=CBalance-@Qty from [Customer] where CId = '" + CId + "' ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@Qty", total);


            dad.Fill(dtProduct);



            conn.Close();
        }

        public DataTable GetSupp()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SId,SName as'Display' FROM [Supplier] order by  SId", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;
        }

        public DataTable GetParticularCustomer()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CId, (CName) as'Display' FROM [Customer] where CName not in (select cname from Customer where cname like 'Walk In') order by  CId ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }



        public int GetCustomerBalance(int CId)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CBalance from [Customer] WHERE CId = '" + CId + "' ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return orderId;
        }

        public int GetCustomerId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(CId) from [Customer] ", conn);

            dad.Fill(dtProduct);

            int CId = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return CId;
        }
        //public DataTable GetPurchases()
        //{
        //    DataTable dtProduct = new DataTable();
        //    conn = DBConn.GetInstance();

        //    //dad = new SqlDataAdapter(" SELECT Purchase.PurId, Purchase.PurDate as 'Purchase Date', Items.IName as 'Item Name',Party.PName as 'Party Name', Purchase.IPrice as 'Selling Price',Purchase.PurPrice as 'Purchase Price', Purchase.ItemQty, Purchase.Total FROM Purchase INNER JOIN Items ON Items.IId = Purchase.IId INNER JOIN Party ON Purchase.PId = Party.PId", conn);

        //    dad = new SqlDataAdapter("SELECT * FROM Purchase", conn);
        //    dad.Fill(dtProduct);
        //    conn.Close();
        //    return dtProduct;
        //}

        public DataTable GetPurchases()
        {

            SqlCommand com = new SqlCommand("GetPurchaseDetails", conn);

            com.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }


        public DataTable GetTransactions(string name)
        {

            //DataTable dtLedger = new DataTable();
            //conn = DBConn.GetInstance();

            //dad = new SqlDataAdapter("select o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where OrderNo = @orderno and o.PId = p.PId and o.IId = i.IId;", conn);

            //dad = new SqlDataAdapter(" SELECT ledger.PId, ledger.Debit as 'Debit',ledger.Credit as 'Credit',  Ledger.IId.IName as 'ItemName', ledger.Balance from ledger where ledger.PId.PName like '" + name + "%'", conn);
            //dad.Fill(dtLedger);
            //conn.Close();
            //return dtLedger;


            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select l.TransId, p.PName as Name, p.PEmail as Email, l.Debit,l.Credit,i.IId,i.IName as 'ItemName', l.Balance from  ledger l,Party p,Items i where l.PId = p.PId and l.IId = i.IId and PName like '" + name + "%'", conn);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;



        }

        public DataTable GetItemsDesc()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();
            dad = new SqlDataAdapter("Select i.IId,c.CatDesc,i.IName,(c.CatDesc+' : '+i.IName) as'Display' FROM [Category] c INNER JOIN [Items] i ON i.CatId=c.CatId order by c.CatDesc, i.IName", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public DataTable ShowItemsByID(float IID)
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();
            SqlDataAdapter dad = new SqlDataAdapter("Select * from Items where IId=@IID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@IId", IID);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetParticularItem(string IName)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select i.IId,c.CatDesc,i.IName,(c.CatDesc+' : '+i.IName) as'Display' FROM [Category] c INNER JOIN [Items] i ON c.CatId=i.CatId  WHERE IName = '" + IName + "' ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public int GetPurchaseId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(PId) from [Purchase] ", conn);

            dad.Fill(dtProduct);

            int pid = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return pid;
        }
        public void UpdateQtyAdd(int IId, float qty)
        {
            SqlCommand cmd = new SqlCommand("update Items set IQty=IQty+@Qty from [Items] where IId = @iid", conn);
            cmd.Parameters.AddWithValue("@iid", IId);
            cmd.Parameters.AddWithValue("@Qty", qty);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteQty(int IId, float qty)
        {
            SqlCommand cmd = new SqlCommand("update Items set IQty=IQty-@Qty from [Items] where IId = @iid", conn);
            cmd.Parameters.AddWithValue("@iid", IId);
            cmd.Parameters.AddWithValue("@Qty", qty);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void AddSuppBalance(int SId, int total)
        {
            SqlCommand cmd = new SqlCommand("update Supplier set SBalance=SBalance+@bal from [Supplier] where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SId);
            cmd.Parameters.AddWithValue("@bal", total);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DelSuppBalance(int SId, int total)
        {
            SqlCommand cmd = new SqlCommand("update Supplier set SBalance=SBalance-@bal from [Supplier] where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SId);
            cmd.Parameters.AddWithValue("@bal", total);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet getatt()
        {
            SqlCommand command = new SqlCommand("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate like '%2017%' order by a.AttId", conn);
            command.Parameters.AddWithValue("@date", DateTime.Today.Year);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "bb");

            conn.Close();
            return ds;
        }

        public DataSet GetCust()
        {
            SqlCommand command = new SqlCommand("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer]", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");

            conn.Close();
            return ds;
        }

        public DataSet GetSuppDataset()
        {
            SqlCommand command = new SqlCommand("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] ", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Suppliers");

            conn.Close();
            return ds;
        }

        public DataSet GetStock()
        {
            SqlCommand command = new SqlCommand("SELECT i.IId as 'Item-ID', c.CatDesc as 'Category', i.IName as 'Name', i.IPrice as 'Price' ,i.IQty as 'Quantity' FROM Items i INNER JOIN Category c ON i.CatId = c.CatId;", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Stock");

            conn.Close();
            return ds;
        }
        public DataSet getEmployeesDataset()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Employee-ID', EName as Name, EJobTitle as Title, EHireDate as 'Date of Hire', EAddress as 'Address', EContact as Contact, ESalary as 'Salary/Day'  from[Employees]", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            conn.Close();
            return ds;
        }

        public DataSet getExpDataset()
        {
            SqlCommand command = new SqlCommand("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID order by e.ExpId", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");

            conn.Close();
            return ds;
        }
        public DataSet getattDataset()
        {
            SqlCommand command = new SqlCommand(" Select a.AttID as 'Attendance-ID', a.AttDate as 'DATE', e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID= e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate like '%" + DateTime.Today.Year + "%' order by a.AttId", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Attendance");

            conn.Close();
            return ds;
        }


        public DataSet GetSalary()
        {
            SqlCommand command = new SqlCommand("select e.EName as 'Name', e.ESalary as 'Salary/Day', ISNULL(SUM(b.BAmount),0) as 'Bonus',b.BDate as 'Bonus-Date', s.SalDate as 'Salary-Date', s.TotalSalary as 'TotalSalary' from Employees e left outer join Bonus b ON b.EmployeeID = e.EmployeeID  left outer join Salaries s ON s.EmployeeID= e.EmployeeID WHERE s.SalDate  like '%" + DateTime.Today.Year + "%' GROUP BY e.EmployeeID,e.EName, e.ESalary,s.SalDate,s.TotalSalary,b.BDate ORDER  BY e.EmployeeID;", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Salary");

            conn.Close();
            return ds;
        }
        public int getTotalBalanceSupplier(int Sid)
        {
            SqlCommand cmd = new SqlCommand("select sum(SBalance) from SupplierPayment Where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", Sid);
            int total = int.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }
    }
}
