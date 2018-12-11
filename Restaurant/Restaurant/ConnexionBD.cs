﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Restaurant
{
    class ConnexionBD
    {

         {
        private String cnx;
        private SqlConnection objetConnexion;

        public ConnexionBD()
        {
            this.cnx = "Data Source=localhost,1434;Initial Catalog=;User ID=;Password=";
            this.objetConnexion = new SqlConnection(this.cnx);
            this.objetConnexion.Open();
        }

        public DataTable execQuery(string v)
        {
            SqlCommand cmd = new SqlCommand(v, this.objetConnexion);
            cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 100));

            DataTable d1 = new DataTable();
            d1.Load(cmd.ExecuteReader());
            return d1;
        }

        public int execInsertUpdateDelete(string v)
        {
            SqlCommand cmd = new SqlCommand(v, this.objetConnexion);
            return cmd.ExecuteNonQuery();
        }

        public bool execID(string v)
        {
            SqlCommand cmd = new SqlCommand(v, this.objetConnexion);
            int i = (int)cmd.ExecuteScalar();
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
