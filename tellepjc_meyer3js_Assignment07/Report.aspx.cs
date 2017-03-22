
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
        lbResult.Items.Add(String.Format("Store | Address | sumQty | Name | Description | Manufacturer"));
        
        foreach (DataRow drCurrent in tblResult.Rows)
        {
            string test = "";
            test = drCurrent[0].ToString().PadRight(30, '\u00A0');
            test += drCurrent[1].ToString().PadRight(30, '\u00A0');
            test += drCurrent[2].ToString().PadRight(30, '\u00A0');
            test += drCurrent[3].ToString().PadRight(40, '\u00A0');
            test += drCurrent[4].ToString().PadRight(30, '\u00A0');
            test += drCurrent[5].ToString().PadRight(30, '\u00A0');
            lbResult.Items.Add(test);
            

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