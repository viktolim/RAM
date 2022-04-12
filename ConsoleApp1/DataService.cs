using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DataService
    {
        public void putData(string name, int keyFirst, int keySecond)
        {
            String command= "insert into creator(Name,FirstKey,SecondKey) values('"+name +"','"+keyFirst+"','"+keySecond+"');";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=RSA");
            MySqlCommand cmd = new MySqlCommand(command, con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
