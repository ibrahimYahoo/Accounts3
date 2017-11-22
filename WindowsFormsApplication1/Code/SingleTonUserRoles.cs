using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Forms;

namespace WindowsFormsApplication1.Code
{
    public sealed class SingleTonUserRoles
    {
        private System.Data.DataTable dt;

        private SingleTonUserRoles()
        {
              dt = new DAO().getRoles(Login.RoleId);
            
        }


         static readonly SingleTonUserRoles Instance = new SingleTonUserRoles();

        public static SingleTonUserRoles GetInstance
        {
            get
            {
                //if(Instance == null)
                //{
                //    Instance = new SingleTonUserRoles();
                //}
                return Instance;

            }
        }

        public bool getCheckstate(string columnName)
        {
           
                return bool.Parse(dt.Rows[0][columnName].ToString());
            
        }


        public void changeUserRoles()
        {
            dt = new DAO().getRoles(Login.RoleId);

        }


    }
}
