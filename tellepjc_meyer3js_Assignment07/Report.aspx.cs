
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dsResultTableAdapters;
using System.Data.SqlClient;

public partial class tellepjc_meyer3js_Assignment07_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dsResult result = new dsResult();
        tResultTableAdapter resultTableAdapter = new tResultTableAdapter();
        dsResult.tResultDataTable resultDataTable = new dsResult.tResultDataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = new SqlCommand(Convert.ToString(Session["Query"]));
        adapter.Fill(result);
        
        
        
        /* result.GetData.
         dsResult.tResultDataTable resultDataTable = storeTableAdapter.GetData();

         cbStore.DataTextField = "StoreWithAddress";
         cbStore.DataValueField = "Store";
         cbStore.DataSource = storeDataTable;
         cbStore.DataBind();*/

    }
}