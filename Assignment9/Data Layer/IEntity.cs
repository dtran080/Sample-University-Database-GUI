using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Data_Layer
{
    public interface IEntity
    {
        void SetFields(DataRow dr);
    }
}
