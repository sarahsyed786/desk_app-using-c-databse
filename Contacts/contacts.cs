using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace Contacts
{
    class contacts
    {

        public string c_name { get; set; }
        public string c_number { get; set; }

        public string add_c(string name, string number)
        {
            SqlConnection sql_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Syed Haris\source\repos\Contacts\Contacts\Database1.mdf; Integrated Security = True");


            string sql = "insert into contacts_table(name,number) values ('" + name + "','" + number + "') ";
            sql_con.Open();

            try
            {
                SqlCommand sql_cmd = new SqlCommand(sql, sql_con);
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Executed Successfully";

        }


        public List<contacts> get_all_contacts()
        {
            List<contacts> li = new List<contacts>();
            SqlConnection sql_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Syed Haris\source\repos\Contacts\Contacts\Database1.mdf; Integrated Security = True");
            string sql = "select * from contacts_table";

            sql_con.Open();

            SqlCommand sql_cmd = new SqlCommand(sql, sql_con);
            SqlDataReader sql_reader = sql_cmd.ExecuteReader();

            while (sql_reader.Read())
            {
                contacts cont = new contacts();

                cont.c_name = sql_reader["name"].ToString();
                cont.c_number = sql_reader["number"].ToString();

                li.Add(cont);

            }

            return li;
        }

       
       
    }

    
}
