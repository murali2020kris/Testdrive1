using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Diagnostics;

public partial class SearchTime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtint.Text != "")
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;

            connetionString = WebConfigurationManager.ConnectionStrings["Adventureworks"].ConnectionString;
            sql = "Select rand_string from fyi_random where rand_integer= "+ txtint.Text;

            cnn = new SqlConnection(connetionString);
            Stopwatch watch = new Stopwatch();
            watch.Start();

            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                string count = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                cnn.Close();
                watch.Stop();
                lbltime1.Text = watch.Elapsed.Milliseconds.ToString();
                watch.Reset();
                lblstring.Text = count;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Can not open connection ! ");
            }
        }

     
        
        
        if(txtstring.Text != "")
        {

            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;

            connetionString = WebConfigurationManager.ConnectionStrings["Adventureworks"].ConnectionString;
            sql = "Select rand_integer from fyi_random where rand_string= \'" + txtstring.Text + "\'";

            cnn = new SqlConnection(connetionString);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                cnn.Close();

                watch.Stop();
                lbltime2.Text = watch.Elapsed.Milliseconds.ToString();
                watch.Reset();
             
                lblinteger.Text = count.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }

        }
    }
}