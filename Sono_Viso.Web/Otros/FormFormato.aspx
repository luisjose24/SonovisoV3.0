<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormFormato.aspx.cs" Inherits="Sono_Viso.Web.Otros.FormFormato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <asp:Label Text="Formatos" runat="server" />
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="dpFormatos" runat="server"
                OnSelectedIndexChanged="dpFormatos_SelectedIndexChanged"
                CssClass="form-control input-sm"
                ItemType="Sono_Viso.BusinessEntities.Formato"
                SelectMethod="GetFormatos"
                DataTextField="Nombre"
                DataValueField="Id" AutoPostBack="True"
                >
        
    </asp:DropDownList>     
            <asp:Label ID="lbFormato" Text="Escoja" runat="server" />

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
