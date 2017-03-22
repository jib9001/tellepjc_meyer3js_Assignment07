
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dsResultTableAdapters;
using System.Data.SqlClient;
//using Microsoft.Reporting.WebForms;

public partial class tellepjc_meyer3js_Assignment07_Report : System.Web.UI.Page
{

    dsResult result;
    protected void Page_Load(object sender, EventArgs e)
    {
        PopulateDataSet();
        GenerateReport();
           
        /* result.GetData.
         dsResult.tResultDataTable resultDataTable = storeTableAdapter.GetData();

         cbStore.DataTextField = "StoreWithAddress";
         cbStore.DataValueField = "Store";
         cbStore.DataSource = storeDataTable;
         cbStore.DataBind();*/

    }

    private void PopulateDataSet()
    {
        result = new dsResult();
        tResultTableAdapter resultTableAdapter = new tResultTableAdapter();
        dsResult.tResultDataTable resultDataTable = new dsResult.tResultDataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(Convert.ToString(Session["Query"]), selectConnectionString:"Data Source=il-server-001.uccc.uc.edu\\MSSQLSERVER2012;Initial Catalog=GroceryStoreSimulator;Persist Security Info=True;User ID=GroceryStoreSimulatorWebformLogin;Password=RememberTheCat");


        
        adapter.Fill(result);
        
    }

    private void GenerateReport()
    {
        if (!IsPostBack)
        {
            
        }
   }
}