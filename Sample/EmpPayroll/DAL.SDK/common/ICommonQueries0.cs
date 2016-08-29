using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalooCodeFirstSDK.common
{
    interface ICommonQueries0
    {

        public virtual List<T> GetAll();
            Models.Qustion GetById(int id);
            Models.Qustion Save(Models.Answer quest);
    }
}
