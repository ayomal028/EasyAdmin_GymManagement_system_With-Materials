﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EasyAdmin.gym_management_system
{

   
    class DB
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database");

        //create a function to open the connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close the connection
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //create a fuction to return the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
