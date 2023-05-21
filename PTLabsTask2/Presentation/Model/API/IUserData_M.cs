using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.API
{
    public interface IUserData_M
    {
        int Id
        {
            get;
            set;
        }
        string FirstName
        {
            get;
            set;
        }
        string LastName
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }
    }
}
