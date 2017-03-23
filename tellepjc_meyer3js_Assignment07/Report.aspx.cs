/***********************************************************************************************************
 * Assignment 07
 * Connor Tellep and Justin Meyer
 * IT3047C-001 Spring Semester
 * tellepjc@mail.uc.edu | meyer3js@mail.uc.edu
 * This assignment demonstrates our ability to create a query based on user input while also generating a 
 * report from that input.
 * This class contains the methods necessary to generate a report based on the query generated from user input
 * from the Assignment07.aspx page.
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
    static DataTable tblResult; // class level variable to allow the datalist to bind to it without scope issues.

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateDataSet();
            GenerateReport();
        }
        
    }

    /// <summary>
    /// Creates and populates the dataset with the query gathered from the Assignment07.aspx page
    /// </summary>
    private void PopulateDataSet()
    {
        DataSet ds = new DataSet("Result");
        SqlDataAdapter adapter = new SqlDataAdapter(Convert.ToString(Session["Query"]), selectConnectionString: "Data Source=il-server-001.uccc.uc.edu\\MSSQLSERVER2012;Initial Catalog=GroceryStoreSimulator;Persist Security Info=True;User ID=GroceryStoreSimulatorWebformLogin;Password=RememberTheCat");
        adapter.FillSchema(ds, SchemaType.Source, "tblSource");
        adapter.Fill(ds, "tblSource");

        tblResult = ds.Tables["tblSource"];
    }

    /// <summary>
    /// Binds the datalist with the contents of the datatable
    /// </summary>
    private void GenerateReport()
    {
        dlResult.DataSource = tblResult;
        dlResult.DataBind();
    }
}