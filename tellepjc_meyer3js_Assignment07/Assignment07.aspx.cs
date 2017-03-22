/***********************************************************************************************************
 * Assignment 07
 * Connor Tellep and Justin Meyer
 * IT3047C-001 Spring Semester
 * tellepjc@mail.uc.edu | meyer3js@mail.uc.edu
 * This assignment demonstrates our ability to create a query based on user input while also generating a 
 * report from that input.
 * This class contains the events necessary to create a dynamic query based on user input.
 * Due Date: Wednesday, March 22nd, 2017 by 5:19pm
 * Citations: 
 * 
 * 
 * 
 * REFERENCES:
 * 
 * 
 * 
 * ALWAYS remember the cat
 * **********************************************************************************************************/
/*
-- Example query structure

SELECT        dbo.tStore.Store, SUM(dbo.tTransactionDetail.QtyOfProduct) AS sumQty
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
    string minQty = ""; // The minimum quantity of products sold in a transaction
    string maxQty = ""; // The maximum quantity of products sold in a transaction
    string startDate = ""; // The starting date of a transaction that the query will look in the db
    string endDate = ""; // The ending date of a transaction that the query will look in the db
    string storeList = ""; // The string that will contain the stores that the user selected
    
    protected void Page_Load(object sender, EventArgs e)
    {

        // Only run on initial page load
        if (!IsPostBack)
        {
            // Populate the checked box with data from the store table
            tStoreTableAdapter storeTableAdapter = new tStoreTableAdapter();
            dsStore.tStoreDataTable storeDataTable = storeTableAdapter.GetData();
            cbStore.DataTextField = "StoreWithAddress";
            cbStore.DataValueField = "Store";
            cbStore.DataSource = storeDataTable;
            cbStore.DataBind();
        }
    }

    /// <summary>
    /// Calls the methods to generate the query string before calling the method that combines them all together.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        GenerateStores();
        GenerateDateRange();
        GenerateQtyRange();
        GenerateQueryString();
    }

    /// <summary>
    /// Gathers the minimum and maximum product purchase quantities that will be ran against the database.
    /// </summary>
    private void GenerateQtyRange()
    {
        minQty = tbMinQty.Text;
        maxQty = tbMaxQty.Text;
    }

    /// <summary>
    /// Gathers the dates selected by the user and formats them correctly.
    /// </summary>
    private void GenerateDateRange()
    {
        startDate = String.Format("'{0}-{1}-{2}'", cStartDate.SelectedDate.Year, cStartDate.SelectedDate.Month, cStartDate.SelectedDate.Day);
        endDate = String.Format("'{0}-{1}-{2}'", cEndDate.SelectedDate.Year, cEndDate.SelectedDate.Month, cEndDate.SelectedDate.Day);
    }

    /// <summary>
    /// Traverses through the checked box list and appends "or" clauses for each store selected.
    /// </summary>
    private void GenerateStores()
    {
        bool hasRun = false;
        foreach (ListItem item in cbStore.Items)
        {
            if (item.Selected && !hasRun)
            {
                storeList += "dbo.tStore.Store = N'" + item.Value + "'";
                hasRun = true;
            }
            else if (item.Selected)
            {
                storeList += " OR dbo.tStore.Store = N'" + item.Value + "'";
            }
        }
    }
    /// <summary>
    /// Combines the results of the other methods into a query string that will be ran against the database to generate a report on the next page.
    /// </summary>
    private void GenerateQueryString() 
    {  
       Session["Query"] = String.Format("SELECT dbo.tStore.Store, SUM(dbo.tTransactionDetail.QtyOfProduct) AS sumQty FROM dbo.tTransaction INNER JOIN dbo.tTransactionDetail ON dbo.tTransaction.TransactionID = dbo.tTransactionDetail.TransactionID INNER JOIN dbo.tStore ON dbo.tTransaction.StoreID = dbo.tStore.StoreID WHERE({0}) AND (dbo.tTransactionDetail.QtyOfProduct BETWEEN {1} AND {2}) AND (dbo.tTransaction.DateOfTransaction BETWEEN {3} AND {4}) GROUP BY dbo.tStore.Store", storeList, minQty, maxQty, startDate, endDate);
    }
}