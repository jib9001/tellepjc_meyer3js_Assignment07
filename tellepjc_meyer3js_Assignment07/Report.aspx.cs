
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dsResultTableAdapters;
using System.Data.SqlClient;
using System.Data;

public partial class tellepjc_meyer3js_Assignment07_Report : System.Web.UI.Page
{
    static DataTable tblResult;

    protected void Page_Load(object sender, EventArgs e)
    {
        PopulateDataSet();
        GenerateReport();
    }

    private void PopulateDataSet()
    {
        DataSet ds = new DataSet("Result");
        SqlDataAdapter adapter = new SqlDataAdapter(Convert.ToString(Session["Query"]), selectConnectionString: "Data Source=il-server-001.uccc.uc.edu\\MSSQLSERVER2012;Initial Catalog=GroceryStoreSimulator;Persist Security Info=True;User ID=GroceryStoreSimulatorWebformLogin;Password=RememberTheCat");
        adapter.FillSchema(ds, SchemaType.Source, "tblSource");
        adapter.Fill(ds, "tblSource");

        
        tblResult = ds.Tables["tblSource"];
    }

    private void GenerateReport()
    {
        dlResult.DataSource = tblResult;
        dlResult.DataBind();
    }
}