<%@ Page Title="" Language="C#" MasterPageFile="~/tellepjc_meyer3js_Assignment07/Assignment07.master" AutoEventWireup="true" CodeFile="Assignment07.aspx.cs" Inherits="tellepjc_meyer3js_Assignment07_Assignment07" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Calendar runat="server" ID="cStartDate"></asp:Calendar>
    <asp:Calendar runat="server" ID="cEndDate"></asp:Calendar>
    <asp:TextBox runat="server" ID="tbMinQty"></asp:TextBox>
    <asp:TextBox runat="server" ID="tbMaxQty"></asp:TextBox>
    <asp:ListBox runat="server" ID="lbStore"></asp:ListBox>
    <asp:Button runat="server" ID="btnSubmit" />
</asp:Content>

