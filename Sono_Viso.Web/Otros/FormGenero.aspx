<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormGenero.aspx.cs" Inherits="Sono_Viso.Web.Otros.FormGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label Text="Areas" runat="server" />
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="dpGenero" runat="server"
                OnSelectedIndexChanged="dpGenero_SelectedIndexChanged"
                CssClass="form-control input-sm"
                ItemType="Sono_Viso.BusinessEntities.Genero"
                SelectMethod="GetGeneros"
                DataTextField="Nombre"
                DataValueField="Id" AutoPostBack="True"
                >
        
    </asp:DropDownList>     
            <asp:Label ID="lbGenero" Text="Escoja" runat="server" />

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
