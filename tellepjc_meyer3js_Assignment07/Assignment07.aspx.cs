/*







-- Example query structure

SELECT        dbo.tStore.Store, SUM(dbo.tTransactionDetail.QtyOfProduct) AS Expr1
FROM            dbo.tTransaction INNER JOIN
                         dbo.tTransactionDetail ON dbo.tTransaction.TransactionID = dbo.tTransactionDetail.TransactionID INNER JOIN
                         dbo.tStore ON dbo.tTransaction.StoreID = dbo.tStore.StoreID
WHERE        (dbo.tStore.Store = N'Amelia' OR
                         dbo.tStore.Store = N'Anderson' OR
                         dbo.tStore.Store = N'Downtown' OR
                         dbo.tStore.Store = N'Eastgate' OR
                         dbo.tStore.Store = N'Fresno') AND (dbo.tTransactionDetail.QtyOfProduct BETWEEN 1 AND 6) AND (dbo.tTransaction.DateOfTransaction BETWEEN '2017-11-19' AND '2017-12-29')
GROUP BY dbo.tStore.Store

*/

using dsStoreTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tellepjc_meyer3js_Assignment07_Assignment07 : System.Web.UI.Page
{
    string minQty = "";
    string maxQty = "";
    string startDate = "";
    string endDate = "";
    string storeQueryList = "";

    protected void Page_Load(object sender, EventArgs e)
    {

        // Only run on initial page load
        if (!IsPostBack)
        {
            // Get Computer case data and initialize first selected index in ddl.
            tStoreTableAdapter storeTableAdapter = new tStoreTableAdapter();
            dsStore.tStoreDataTable storeDataTable = storeTableAdapter.GetData();
            cbStore.DataTextField = "StoreWithAddress";
            cbStore.DataValueField = "Store";
            cbStore.DataSource = storeDataTable;
            cbStore.DataBind();
            // lbStore.SelectedIndex = 0;
            //GetParts(ddlComputerCase.SelectedValue);


        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        GenerateStores();
        GenerateDateRange();
        GenerateQtyRange();
    }

    private void GenerateQtyRange()
    {
        minQty = tbMinQty.Text;
        maxQty = tbMaxQty.Text;
    }

    private void GenerateDateRange()
    {
        throw new NotImplementedException();
    }

    private void GenerateStores()
    {
        bool hasRun = false;
        foreach (ListItem item in cbStore.Items)
        {
            if (item.Selected && !hasRun)
            {
                storeQueryList += "dbo.tStore.Store = " + item.Value;
                hasRun = true;
            }
            else if (item.Selected)
            {
                storeQueryList += "or dbo.tStore.Store = " + item.Value;
            }
        }
    }
}