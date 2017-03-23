<%@ Page Title="" Language="C#" MasterPageFile="~/tellepjc_meyer3js_Assignment07/Assignment07.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="tellepjc_meyer3js_Assignment07_Report" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <asp:DataList CssClass="u-full-width" ID="dlResult" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingItemStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <div class="row">
                    <div class="two columns u-max-full-width">
                        Store
                    </div>
                    <div class="two columns u-max-full-width">
                        Address
                    </div>
                    <div class="two columns u-max-full-width">
                        Sum of Qty Sold
                    </div>
                    <div class="two columns u-max-full-width">
                        Name
                    </div>
                    <div class="two columns u-max-full-width">
                        Description
                    </div>
                    <div class="two columns u-max-full-width">
                        Manufacturer
                    </div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>

                <div class="row">
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblStore" runat="server" Text='<%# Eval("Store") %>'></asp:Label>
                    </div>
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                    </div>
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblSumQty" runat="server" Text='<%# Eval("sumQty") %>'></asp:Label>
                    </div>
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </div>
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    </div>
                    <div class="two columns u-max-full-width">
                        <asp:Label ID="lblManufacturer" runat="server" Text='<%# Eval("Manufacturer") %>'></asp:Label>
                    </div>
                </div>

            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </div>
</asp:Content>


