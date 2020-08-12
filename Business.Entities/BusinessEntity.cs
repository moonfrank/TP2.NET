using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public int ID { get; set; }
        public States State { get; set; }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
