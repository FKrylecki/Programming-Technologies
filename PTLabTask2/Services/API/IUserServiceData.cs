using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.API
{
    public interface IUserServiceData
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
