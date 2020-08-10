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

        public SqlConnection Conn { get; set; }
        public BusinessEntity()
        {
            this.Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True");
            //this.Conn = new SqlConnection("Data Source=localhost;Initial Catalog=tp2_net;Integrated Security=True");
            this.State = States.New;
        }
    }


}
