<%@ Page Title="" Language="C#" MasterPageFile="~/tellepjc_meyer3js_Assignment07/Assignment07.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="tellepjc_meyer3js_Assignment07_Report" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="ten columns offset-by-one">
            <asp:ListBox style="overflow-x:auto;" SelectionMode="Multiple" CssClass="u-max-full-width" Height="500px" FontFamily="Monospace" ID="lbResult" runat="server"></asp:ListBox>
        </div>
    </div>
</asp:Content>


