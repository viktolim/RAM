using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class DataService
    {
        public void putData(string name, int keyFirst, int keySecond, int keyThird)
        {
            String command= "insert into creator(Name,FirstKey,SecondKey,ThirdKey) values('"+name +"','"+keyFirst+"','"+keySecond+"','"+ keyThird + "')";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=RSA");
            MySqlCommand cmd = new MySqlCommand(command, con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int[] getData(string name)
        {
            int[] temp = new int[2];
            String command = "select * from creator where Name ='"+name+"'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rsa");
            MySqlCommand cmd = new MySqlCommand(command, con);
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            temp[0]=int.Parse(dt.Rows[0].ItemArray[2].ToString());
            temp[1] = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            return temp;

        }
        public void putDataInTxt(double[] data)
        {
            string temp = null;
            for(int i=0; i<data.Length; i++)
            {
                temp = temp +data[i]+";";
            }
            TextWriter txt = new StreamWriter(@"C:\Users\Viktorija\source\repos\ConsoleApp1\ConsoleApp1\Sifruotas.txt");
            txt.Write(temp);
            txt.Close();

        }
        public int[] GetDataFromTxt()
        {
           
            string text =File.ReadAllText(@"C:\Users\Viktorija\source\repos\ConsoleApp1\ConsoleApp1\Sifruotas.txt");
            int[] temp = text.Split(';').Select(int.Parse).ToArray();
            return temp;
          

        }

        public int[] getPrivateKey(string name)
        {
            int[] temp = new int[2];
            String command = "select * from creator where Name ='" + name + "'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rsa");
            MySqlCommand cmd = new MySqlCommand(command, con);
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            temp[0] = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            temp[1] = int.Parse(dt.Rows[0].ItemArray[4].ToString());
            return temp;

        }
    }
}
