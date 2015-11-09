using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration; 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            loadprodcategoryddl();
            loadddlsubcatddl();
        }

        loaddeptgridview();
      
   
    }

    public void loaddeptgridview()
    {
        string sql = "select Name, Color, Listprice,Size, Weight from [SalesLT].[Product] where ProductCategoryID= " + ddlsubcat.SelectedValue.ToString() ;
         
        string strSQLconnection = "Server=tcp:wmazuresqldb.database.windows.net,1433;Database=mursql1;User ID=mursqlsrv1@wmazuresqldb;Password=Murtest1;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection sqlConnection = new SqlConnection(strSQLconnection);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
        adapter.Fill(ds);
        grdcustomer.DataSource = ds;
        grdcustomer.DataBind();

    }
    protected void grdcustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdcustomer.PageIndex = e.NewPageIndex;
        loaddeptgridview();
    }

    public void loadprodcategoryddl()
    {

        SqlConnection con = new SqlConnection(
            WebConfigurationManager.ConnectionStrings["Adventureworks"].ConnectionString);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter("select ProductCategoryID, Name from [SalesLT].[ProductCategory] where parentproductcategoryid is null", con);
        adapter.Fill(ds);
       
        ddlParentCategory.DataSource = ds.Tables[0];
        ddlParentCategory.DataTextField = "Name";
        ddlParentCategory.DataValueField = "ProductCategoryID";
        ddlParentCategory.DataBind();
       
    }

   public void  loadddlsubcatddl()
    {
        SqlConnection con = new SqlConnection(
           WebConfigurationManager.ConnectionStrings["Adventureworks"].ConnectionString);
        DataSet ds = new DataSet();
        string sql = "select ProductCategoryID, Name from [SalesLT].[ProductCategory] where parentproductcategoryid = " + ddlParentCategory.SelectedValue.ToString();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        adapter.Fill(ds);

        ddlsubcat.DataSource = ds.Tables[0];
        ddlsubcat.DataTextField = "Name";
        ddlsubcat.DataValueField = "ProductCategoryID";
        ddlsubcat.DataBind();
    }
   protected void ddlParentCategory_SelectedIndexChanged(object sender, EventArgs e)
   {
       ddlsubcat.Items.Clear();
       loadddlsubcatddl();
   }
   protected void ddlsubcat_SelectedIndexChanged(object sender, EventArgs e)
   {
       loaddeptgridview();
   }
}