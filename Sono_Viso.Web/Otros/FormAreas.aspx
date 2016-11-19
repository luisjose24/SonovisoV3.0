<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormAreas.aspx.cs" Inherits="Sono_Viso.Web.Otros.FormAreas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label Text="Areas" runat="server" />
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="dpAreas" runat="server"
                OnSelectedIndexChanged="dpAreas_SelectedIndexChanged"
                CssClass="form-control input-sm"
                ItemType="Sono_Viso.BusinessEntities.Area"
                SelectMethod="GetAreas"
                DataTextField="Nombre"
                DataValueField="Id" AutoPostBack="True"
                              
                >
        
    </asp:DropDownList>     
            <asp:Label ID="lbArea" Text="Escoja" runat="server" />

        </ContentTemplate>
    </asp:UpdatePanel>
    
 
</asp:Content>
