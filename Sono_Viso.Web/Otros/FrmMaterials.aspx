<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmMaterials.aspx.cs" Inherits="Sono_Viso.Web.Otros.FrmMaterials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
    <div class="form-group col-sm-4">
        <h1>PARTE 1</h1>
        <asp:Button Text="Activar Panel 2" runat="server" OnClick="Unnamed1_Click" />
        
        <asp:Panel ID="panel1" runat="server">
            <asp:FormView ID="fvMaterials" DefaultMode="Insert" runat="server"
                ItemType="Sono_Viso.BusinessEntities.Material"
                SelectMethod="GetMaterial"
                InsertMethod="AddMaterial"
                UpdateMethod="EditMaterial">
                <ItemTemplate></ItemTemplate>

                <InsertItemTemplate>
                    
                    <%--<div class="form-group">
                        <div class="form-inline col-sm-3" style="display: none" >
                            <label>Id: </label>
                        </div>
                        <div class="col-sm-9" style="display: none">
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Text="<%# BindItem.Id %>" />
                        </div>
                    </div>--%>

                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Categoria: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="DropDownList1" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.CategoriaMaterial"
                                SelectMethod="GetCategoriaMaterial"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.CategoriaMaterialId %>"
                                >
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Modelo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Text="<%# BindItem.Modelo %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Marca: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Text="<%# BindItem.Marca %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Serie: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtSerie" runat="server" CssClass="form-control" Text="<%# BindItem.NumSerie %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Año: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control" Text="<%# BindItem.Anio %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Ingreso: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtIngreso" runat="server" CssClass="form-control" Text="<%# BindItem.FechaIngreso %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>V. Util: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtVidaUtil" runat="server" CssClass="form-control" Text="<%# BindItem.VidaUtil %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Disponible" Checked="<%# BindItem.Estado %>" runat="server" />
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
                        <div class="form-inline col-sm-3" style="display: none" >
                            <label>Id: </label>
                        </div>
                        <div class="col-sm-9" style="display: none">
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Text="<%# BindItem.Id %>" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Categoria: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="DropDownList1" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.CategoriaMaterial"
                                SelectMethod="GetCategoriaMaterial"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.CategoriaMaterialId %>"
                                >
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Modelo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Text="<%# BindItem.Modelo %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Marca: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Text="<%# BindItem.Marca %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Serie: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtSerie" runat="server" CssClass="form-control" Text="<%# BindItem.NumSerie %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Año: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control" Text="<%# BindItem.Anio %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Ingreso: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtIngreso" runat="server" CssClass="form-control" Text="<%# BindItem.FechaIngreso %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>V. Util: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtVidaUtil" runat="server" CssClass="form-control" Text="<%# BindItem.VidaUtil %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Disponible" Checked="<%# BindItem.Estado %>" runat="server" />
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
        <h1>PARTE 2</h1>
        
        <label class="control-label">Criterio:</label>
                    <div class="form-group">
                        <asp:TextBox ID="txtCriterio" CssClass="form-control input-sm col-sm-5" runat="server"/>
                        <asp:Button Text="Buscar" ID="Button1" CssClass="btn btn-success col-sm-offset-0" runat="server" />
                        <a href = "/Otros/FrmMaterials.aspx?acc=nuevo" class="btn btn-success col-sm-offset-1">
                            <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>Registrar
                        </a>
                    </div>
                    
                    <p><br/></p>
        
        <asp:Panel ID="panel2" runat="server">
            
            <asp:ListView ID="lvMaterials" runat="server" 
                        ItemType="Sono_Viso.BusinessEntities.Material"
                        SelectMethod="GetMaterials">
                        <LayoutTemplate>
                            <table class="table table-hover table-striped table-condensed">
                                <thead>
                                <tr>
                                    <th>Categoria</th>
                                    <th>Marca</th>
                                    <th>Modelo</th> 
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
                                <td><%# Item.CategoriaMaterial.Nombre %></td>
                                <td><%# Item.Marca %></td>
                                <td><%# Item.Modelo %></td>
                                <td><%# Item.Estado.Equals(1)?"No Disponible":"Disponible" %></td>
                                <%--<td><%# Item.Tipo=="J"?"Juridico":"Natural" %></td>--%>
                                <td><a href="/Otros/FrmMaterials.aspx?acc=editar&id=<%# Item.Id %>">Editar</a><a>  |  </a>
                                    <a href="FrmMaterials.aspx?acc=eliminar&id=<%# Item.Id %>"
                                        onclick="return confirm('Desea eliminar: <%# Item.CategoriaMaterial.Nombre + " "+Item.Marca +" "+Item.Modelo %>');">Eliminar</a>
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
