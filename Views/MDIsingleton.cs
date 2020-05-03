using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.Administrador;

namespace Views
{
    public class MDIsingleton
    {
        private MDIsingleton() { }
        private static FormAdministrador NewInstanceForm;
        public static FormAdministrador InstanceMDI()
        {
            if (NewInstanceForm == null)
            {
                NewInstanceForm = new FormAdministrador();
                return NewInstanceForm;
            }
            return NewInstanceForm;
        }
    }
}
