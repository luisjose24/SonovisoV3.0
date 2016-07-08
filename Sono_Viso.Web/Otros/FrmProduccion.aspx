<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmProduccion.aspx.cs" Inherits="Sono_Viso.Web.Otros.FrmProduccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <asp:Label Text="Produccion" runat="server" />
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="dpProduccion" runat="server"
                OnSelectedIndexChanged="dpProduccion_SelectedIndexChanged"
                CssClass="form-control input-sm"
                ItemType="Sono_Viso.BusinessEntities.Produccion"
                SelectMethod="GetProduccions"
                DataTextField="Nombre"
                DataValueField="Id" AutoPostBack="True"
                >
        
    </asp:DropDownList>     
            <asp:Label ID="lbProduccion" Text="Escoja" runat="server" />

        </ContentTemplate>
    </asp:UpdatePanel>
    

</asp:Content>
