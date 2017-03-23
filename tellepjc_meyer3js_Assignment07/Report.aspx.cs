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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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