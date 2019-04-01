using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postgresql_net
{
    public partial class Testing : System.Web.UI.Page
    {
        string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=.;Database=testpostgres;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("insert into postgrestest(name,dob,gender,city,country) values('" + name.Text + "','" + dob.Text + "','" + gender.Value + "','" + city.Text + "','" + country.Text + "')", con);
            con.Open();
            int datainserted = cmd.ExecuteNonQuery();
            con.Close();
            if(datainserted > 0)
            {
                Response.Write("<script>alert('Data inserted successfully.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Something went wrong!!! Please try again.');</script>");
            }
        }
    }
}