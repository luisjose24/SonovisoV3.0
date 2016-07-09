using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Service;
using System.Web.ModelBinding;

namespace Sono_Viso.Web.Otros
{
    public partial class FrmCliente : System.Web.UI.Page
    {
        public IClienteService ClienteService { get; set; }

        public FrmCliente()
        {
            if (ClienteService == null)
            {
                ClienteService = new ClienteService();
            }
        }
        protected bool enable = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;

            var acc = Request.QueryString["acc"];

            var idCliente = Request.QueryString["id"];

            if (acc != null && acc.Equals("editar"))
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                enable = true;
                fvCliente.DefaultMode = FormViewMode.Edit;
            }
            //else if (acc != null && acc.Equals("detalles"))
            //{
            //    panel1.Enabled = false;
            //    panel2.Enabled = true;
            //    enable = false;
            //    fvMedios.DefaultMode = FormViewMode.Edit;
            //}
            else if (acc != null && acc.Equals("nuevo"))
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                enable = true;
                fvCliente.DefaultMode = FormViewMode.Insert;
                fvCliente.EnableViewState = true;
            }
            else if (acc != null && idCliente != null && acc.Equals("eliminar"))
            {
                var id = Int32.Parse(idCliente);
                ClienteService.DeleteCliente(id);
                Response.Redirect("FrmCliente.aspx");
            }
            else
            {
            }
        }

        public void AddCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClienteService.AddCliente(cliente);
                Response.Redirect("FrmCliente.aspx");
            }
        }
        public void EditCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClienteService.EditCliente(cliente);
                Response.Redirect("FrmCliente.aspx");
            }
        }
        public IEnumerable<Cliente> GetClientes([Control("txtCriterio")] string criterio)
        {
            ClienteService = new ClienteService();
            return ClienteService.GetClientes(criterio);
        }

        public Cliente GetCliente([QueryString("id")] Int32? idCliente)
        {
            Cliente cliente = null;
            if (idCliente.HasValue)
            {
                cliente = ClienteService.GetCliente(idCliente.Value);
            }
            else
            {
                Response.Redirect("FrmCliente.aspx");
            }
            return cliente;
        }

    }
}