using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookingLibrary.Infrastructure.DataPersistence.Rental.SQLServer
{
    public class Command
    {
        public Command(string sql, List<SqlParameter> parameters)
        {
            this.SQL = sql;
            this.Parameters = parameters;
        }

        public string SQL { get; set; }

        public List<SqlParameter> Parameters { get; set; }
    }
}