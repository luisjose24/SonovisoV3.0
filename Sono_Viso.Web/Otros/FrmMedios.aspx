<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmMedios.aspx.cs" Inherits="Sono_Viso.Web.Otros.FrmMedios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <div class="form-group col-sm-4">
        <h1>PARTE 1</h1>
        <asp:Button Text="Activar Panel 2" runat="server" OnClick="Unnamed1_Click" />
        
        <asp:Panel ID="panel1" runat="server">
            <asp:FormView ID="fvMedios" DefaultMode="Insert" runat="server"
                ItemType="Sono_Viso.BusinessEntities.Medio"
                SelectMethod="GetMedio"
                InsertMethod="AddMedio"
                UpdateMethod="EditMedio">
                <ItemTemplate></ItemTemplate>

                <InsertItemTemplate>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Codigo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Text="<%# BindItem.Id %>" Enabled="True" />
                            </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Titulo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" Text="<%# BindItem.Titulo %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Descripcion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Text="<%# BindItem.Descripcion %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Produccion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpProduccion" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Produccion"
                                SelectMethod="GetProduccions"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.ProduccionId %>"
                                >
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Area: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpArea" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Area"
                                SelectMethod="GetAreas"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.AreaId %>"
                                >
                                <%--<asp:ListItem Value="0"> Seleccionar... </asp:ListItem>--%>
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Genero: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpGenero" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Genero"
                                SelectMethod="GetGeneros"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.GeneroId %>"
                                >
                                
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Formato: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpFormato" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Formato"
                                SelectMethod="GetFormatos"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.FormatoId %>"
                                >
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Duracion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control" Text="<%# BindItem.Duracion %>" />
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
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Disponible" Checked="<%# BindItem.IsActivo %>" runat="server" />
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
                            <asp:LinkButton ID="linkCancelar" runat="server" PostBackUrl="/Otros/FrmMedios.aspx"
                                        CssClass="btn btn-info col-sm-4" Visible="<%# enable %>">
                                         <span class="glyphicon glyphicon-share-alt" aria-hidden="true"></span>Cancelar
                                    </asp:LinkButton> 
                        </div>

                </InsertItemTemplate>

                <EditItemTemplate>
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Codigo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Text="<%# BindItem.Id %>" Enabled="False" />
                            </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Titulo: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" Text="<%# BindItem.Titulo %>" />
                        </div>
                    </div>
                                
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Descripcion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Text="<%# BindItem.Descripcion %>" />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Produccion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpProduccion" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Produccion"
                                SelectMethod="GetProduccions"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.ProduccionId %>"
                                >
                                <%--<asp:ListItem Value="0"> Seleccionar... </asp:ListItem>--%>
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Area: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpArea" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Area"
                                SelectMethod="GetAreas"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.AreaId %>"
                                >
                                <asp:ListItem Value="0"> Seleccionar... </asp:ListItem>
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Genero: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpGenero" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Genero"
                                SelectMethod="GetGeneros"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.GeneroId %>"
                                >
                                <asp:ListItem Value="0"> Seleccionar... </asp:ListItem>
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Formato: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="dpFormato" runat="server"
                                CssClass="form-control input-sm"
                                ItemType="Sono_Viso.BusinessEntities.Formato"
                                SelectMethod="GetFormatos"
                                DataTextField="Nombre"
                                DataValueField="Id"
                                SelectedValue="<%# BindItem.FormatoId %>"
                                >
                                <asp:ListItem Value="0"> Seleccionar... </asp:ListItem>
                                </asp:DropDownList> 
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="form-inline col-sm-3">
                            <label>Duracion: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control" Text="<%# BindItem.Duracion %>" />
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
                            <label>Estado: </label>
                        </div>
                        <div class="col-sm-9">
                            <asp:CheckBox ID="chkEstado" Text="Disponible" Checked="<%# BindItem.IsActivo %>" runat="server" />
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
                            <asp:LinkButton ID="linkCancelar" runat="server" PostBackUrl="/Otros/FrmMedios.aspx"
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
                        <a href = "/Otros/FrmMedios.aspx?acc=nuevo" class="btn btn-success col-sm-offset-1">
                            <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>Registrar
                        </a>
                    </div>
                    
                    <p><br/></p>
        
        <asp:Panel ID="panel2" runat="server">
            
            <asp:ListView ID="lvMedios" runat="server" 
                        ItemType="Sono_Viso.BusinessEntities.Medio"
                        SelectMethod="GetMedios">
                        <LayoutTemplate>
                            <table class="table table-hover table-striped table-condensed">
                                <thead>
                                <tr>
                                    <th>Codigo</th>
                                    <th>Titulo</th>
                                    <th>Area</th> 
                                    <th>Formato</th>
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
                                <td><%# Item.Id %></td>
                                <td><%# Item.Titulo %></td>
                                <td><%# Item.Area.Nombre %></td>
                                <td><%# Item.Formato.Nombre %></td>
                                <%--<td><%# Item.IsActivo. %></td>--%>
                                <td><%# Item.IsActivo.Equals(1)?"No Disponible":"Disponible" %></td>
                                <td><a href="/Otros/FrmMedios.aspx?acc=editar&id=<%# Item.Id %>">Editar</a><a>  |  </a>
                                    <a href="FrmMedios.aspx?acc=eliminar&id=<%# Item.Id %>"  onclick="return confirm('Desea eliminar: <%# Item.Titulo %>');">Eliminar</a>
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
