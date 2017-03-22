﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dsResultTableAdapters;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

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
        dsResult result = new dsResult();
        tResultTableAdapter resultTableAdapter = new tResultTableAdapter();
        dsResult.tResultDataTable resultDataTable = new dsResult.tResultDataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = new SqlCommand(Convert.ToString(Session["Query"]));
        adapter.Fill(result);
    }

    private void GenerateReport()
    {
        LocalReport report = rvResult.LocalReport;
        report.ReportPath = "rvResult.rdlc";
        //ReportDataSource reportResult = new ReportDataSource();
        //reportResult.Value = ((dsResult)Session["dataset"]).Tables[""];
        //report.DataSources.Add(Session["dataset"]);
        
    }
}