using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Code
{
    public sealed class SingleTonUserRoles
    {

        private SingleTonUserRoles()
        {

        }
        private static SingleTonUserRoles Instance = null;

        public static SingleTonUserRoles GetInstance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new SingleTonUserRoles();
                    return Instance;
                }
            }
        }

        public void printDetails()
        {
            Console.WriteLine("yos");
        }


    }
}
