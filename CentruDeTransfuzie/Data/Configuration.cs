using System;
using System.Collections.Generic;
using System.Text;

namespace CentruDeTransfuzie
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=localhost\\SQLEXPRESS; Initial Catalog=CentruTransfuzii;Integrated Security=True;";
                //return "Data Source=.; Initial Catalog=CentruTransfuzii;Integrated Security=True;";
            }
        }
    }
}
