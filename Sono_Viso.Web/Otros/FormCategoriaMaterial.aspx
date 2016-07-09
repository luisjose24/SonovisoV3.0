<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCategoriaMaterial.aspx.cs" Inherits="Sono_Viso.Web.Otros.FormCategoriaMaterial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label Text="Categorias" runat="server" />
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="dpCategorias" runat="server"
                OnSelectedIndexChanged="dpCategorias_SelectedIndexChanged"
                CssClass="form-control input-sm"
                ItemType="Sono_Viso.BusinessEntities.CategoriaMaterial"
                SelectMethod="GetCategoriaMaterials"
                DataTextField="Nombre"
                DataValueField="Id" AutoPostBack="True"
                >
        
    </asp:DropDownList>     
            <asp:Label ID="lbCategorias" Text="Escoja" runat="server" />

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
