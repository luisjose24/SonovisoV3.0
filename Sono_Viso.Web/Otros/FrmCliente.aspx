<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCliente.aspx.cs" Inherits="Sono_Viso.Web.Otros.FrmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="form-group col-sm-4">
        <h1>Registrar Cliente</h1>
        
        
        <asp:Panel ID="panel1" runat="server">
            <asp:FormView ID="fvCliente" DefaultMode="Insert" runat="server"
                ItemType="Sono_Viso.BusinessEntities.Cliente"
                SelectMethod="GetCliente"
                InsertMethod="AddCliente"
                UpdateMethod="EditCliente">
                <ItemTemplate></ItemTemplate>

                <InsertItemTemplate>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Apellidos: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" Text="<%# BindItem.Apellidos %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Nombres: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" Text="<%# BindItem.Nombres %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>DNI: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" Text="<%# BindItem.DNI %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>E-mail: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text="<%# BindItem.EmailCliente %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Direccion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Text="<%# BindItem.Direccion %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Telefono: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Text="<%# BindItem.TelefCliente %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Habilitado" Checked="<%# BindItem.Estado %>" runat="server" />
                        </div>
                    </div>
                    
 
                    <div class="form-group">
                        <asp:LinkButton Text="" 
                            runat="server" />
                            <asp:Button Text="Registrar"
                                ID="btnGuardar"
                                CommandName="insert"
                                CssClass="btn btn-info btn-primary col-sm-3 col-sm-offset-5"
                                runat="server"
                                Visible="<%# enable %>" />
                            <asp:LinkButton ID="linkCancelar" runat="server" PostBackUrl="/Otros/FrmMaterials.aspx"
                                        CssClass="btn btn-info col-sm-4" Visible="<%# enable %>">
                                         <span class="glyphicon glyphicon-share-alt" aria-hidden="true"></span>Cancelar
                                    </asp:LinkButton> 
                        </div>

                </InsertItemTemplate>

                <EditItemTemplate>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3" style="display: none">
                            <label>ID: </label>
                        </div>
                        <div class="col-sm-9" style="display: none">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text="<%# BindItem.IdCliente %>" />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Apellidos: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" Text="<%# BindItem.Apellidos %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Nombres: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" Text="<%# BindItem.Nombres %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>DNI: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" Text="<%# BindItem.DNI %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>E-mail: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text="<%# BindItem.EmailCliente %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Direccion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Text="<%# BindItem.Direccion %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Telefono: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Text="<%# BindItem.TelefCliente %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Habilitado" Checked="<%# BindItem.Estado %>" runat="server" />
                        </div>
                    </div>
                    
 
                    <div class="form-group">
                        <asp:LinkButton Text="" 
                            runat="server" />
                            <asp:Button Text="Actualizar"
                                ID="btnGuardar"
                                CommandName="update"
                                CssClass="btn btn-info btn-primary col-sm-3 col-sm-offset-5"
                                runat="server"
                                Visible="<%# enable %>" />
                            <asp:LinkButton ID="linkCancelar" runat="server" PostBackUrl="/Otros/FrmMaterials.aspx"
                                        CssClass="btn btn-info col-sm-4" Visible="<%# enable %>">
                                         <span class="glyphicon glyphicon-share-alt" aria-hidden="true"></span>Cancelar
                                    </asp:LinkButton> 
                        </div>
                </EditItemTemplate>
            </asp:FormView>

        </asp:Panel>

    </div>
    <div class="form-group col-sm-1">
        <span></span>

    </div>
    <div class="form-group col-sm-7">
        <h1>Administrar Cliente</h1>
        
        <label class="control-label">Criterio:</label>
                    <div class="form-group">
                        <asp:TextBox ID="txtCriterio" CssClass="form-control input-sm col-sm-5" runat="server"/>
                        <asp:Button Text="Buscar" ID="Button1" CssClass="btn btn-success col-sm-offset-0" runat="server" />
                        <a href = "/Otros/FrmCliente.aspx?acc=nuevo" class="btn btn-success col-sm-offset-1">
                            <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>Registrar
                        </a>
                    </div>
                    
                    <p><br/></p>
        
        <asp:Panel ID="panel2" runat="server">
            
            <asp:ListView ID="lvClientes" runat="server" 
                        ItemType="Sono_Viso.BusinessEntities.Cliente"
                        SelectMethod="GetClientes">
                        <LayoutTemplate>
                            <table class="table table-hover table-striped table-condensed">
                                <thead>
                                <tr>
                                    <th>DNI</th>
                                    <th>Apellidos y Nombres</th>
                                    <th>E-mail</th> 
                                    <th>Estado</th> 
                                    <th>Acciones</th> 
                                </tr>
                                </thead>

                                <tbody>
                                <tr id="itemPlaceholder" runat="server"/>
                                </tbody>

                            </table>
                        </LayoutTemplate>
                        
                        <ItemTemplate>
                            <tr>
                                <td><%# Item.DNI %></td>
                                <td><%# Item.Apellidos +", "+Item.Nombres %></td>
                                <td><%# Item.EmailCliente %></td>
                                <td><%# Item.Estado.Equals(1)?"No Disponible":"Disponible" %></td>
                                <%--<td><%# Item.Tipo=="J"?"Juridico":"Natural" %></td>--%>
                                <td><a href="/Otros/FrmCliente.aspx?acc=editar&id=<%# Item.IdCliente %>">Editar</a><a>  |  </a>
                                    <a href="FrmCliente.aspx?acc=eliminar&id=<%# Item.IdCliente %>"
                                        onclick="return confirm('Desea eliminar a: <%# Item.Apellidos +", "+Item.Nombres %>');">Eliminar</a>
                                </td>

                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <h4>No Existen Datos</h4>
                        </EmptyDataTemplate>

                    </asp:ListView>

        </asp:Panel>

    </div>
 
    <div><br/></div>
    

</asp:Content>
