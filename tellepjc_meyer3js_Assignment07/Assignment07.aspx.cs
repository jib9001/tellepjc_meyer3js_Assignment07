using dsStoreTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tellepjc_meyer3js_Assignment07_Assignment07 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // Only run on initial page load
        if (!IsPostBack)
        {
            // Get Computer case data and initialize first selected index in ddl.
            tStoreTableAdapter storeTableAdapter = new tStoreTableAdapter();
            dsStore.tStoreDataTable storeDataTable = storeTableAdapter.GetData();
            lbStore.DataTextField = "StoreWithAddress";
            lbStore.DataValueField = "StoreID";
            lbStore.DataSource = storeDataTable;
            lbStore.DataBind();
           // lbStore.SelectedIndex = 0;
            //GetParts(ddlComputerCase.SelectedValue);
        }

    }
}