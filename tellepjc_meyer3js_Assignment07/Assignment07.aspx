<%@ Page Title="" Language="C#" MasterPageFile="~/tellepjc_meyer3js_Assignment07/Assignment07.master" AutoEventWireup="true" CodeFile="Assignment07.aspx.cs" Inherits="tellepjc_meyer3js_Assignment07_Assignment07" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="three columns offset-by-three">
                    <asp:Label ID="lblStarDate" runat="server" Text="Start Date"></asp:Label>
                    <br />
                    <asp:Calendar runat="server" ID="cStartDate"></asp:Calendar>
                </div>
                <div class="three columns">
                    <asp:Label ID="lblEndDate" runat="server" Text="Through Date"></asp:Label>
                    <br />
                    <asp:Calendar runat="server" ID="cEndDate"></asp:Calendar>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="three columns offset-by-three u-max-full-width">
                    <asp:Label ID="lblMinQty" runat="server" Text="Minimum Quantity"></asp:Label>
                    <br />
                    <asp:TextBox runat="server" ID="tbMinQty"></asp:TextBox>
                </div>
                <div class="three columns u-max-full-width">
                    <asp:Label ID="lblMaxQty" runat="server" Text="Maximum Quantity"></asp:Label>
                    <br />
                    <asp:TextBox runat="server" ID="tbMaxQty"></asp:TextBox>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="four columns offset-by-four">
                    <div style="width: 320px; height: 300px; overflow-y: scroll; overflow-x: scroll;">
                        <asp:CheckBoxList ID="cbStore" runat="server"></asp:CheckBoxList>
                    </div>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="two columns offset-by-five">
                    <asp:Button runat="server" ID="btnSubmit" Text="Submit" CssClass="u-max-full-width" OnClick="btnSubmit_Click" />
                </div>
            </div>
            <hr />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

