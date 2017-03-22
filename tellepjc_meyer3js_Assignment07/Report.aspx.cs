
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dsResultTableAdapters;
using System.Data.SqlClient;
using System.Data;
//using Microsoft.Reporting.WebForms;

public partial class tellepjc_meyer3js_Assignment07_Report : System.Web.UI.Page
{

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
        DataSet ds = new DataSet("Result");
       // tResultTableAdapter resultTableAdapter = new tResultTableAdapter();
       // dsResult.tResultDataTable resultDataTable = new dsResult.tResultDataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(Convert.ToString(Session["Query"]), selectConnectionString:"Data Source=il-server-001.uccc.uc.edu\\MSSQLSERVER2012;Initial Catalog=GroceryStoreSimulator;Persist Security Info=True;User ID=GroceryStoreSimulatorWebformLogin;Password=RememberTheCat");
        adapter.FillSchema(ds, SchemaType.Source, "tblSource");
        adapter.Fill(ds, "tblSource");

        DataTable tblResult;
        tblResult = ds.Tables["tblSource"];
       // dlResult.DataSource = ds;
       // dlResult.DataBind();
       // dlResult.DataTextField = "StoreWithAddress";
       // cbStore.DataValueField = "Store";
       // cbStore.DataSource = storeDataTable;

        foreach (DataRow drCurrent in tblResult.Rows)
        {

            lbResult.Items.Add(String.Format("{0} {1} {2} {3} {4} {5}", drCurrent[0].ToString(), drCurrent[1].ToString(), drCurrent[2].ToString(), drCurrent[3].ToString(), drCurrent[4].ToString(), drCurrent[5].ToString()));
            

            // adapter.Fill(ds);
        }
    }

    private void GenerateReport()
    {
        if (!IsPostBack)
        {
            
        }
   }
}