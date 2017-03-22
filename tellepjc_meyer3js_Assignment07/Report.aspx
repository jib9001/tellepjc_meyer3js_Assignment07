<%@ Page Title="" Language="C#" MasterPageFile="~/tellepjc_meyer3js_Assignment07/Assignment07.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="tellepjc_meyer3js_Assignment07_Report" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <rsweb:ReportViewer ID="rvResult" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <LocalReport ReportPath="tellepjc_meyer3js_Assignment07\rResult.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>


