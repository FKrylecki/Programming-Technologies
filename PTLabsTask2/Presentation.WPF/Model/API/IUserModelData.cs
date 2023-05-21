using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.API
{
    public interface IUserModelData
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
