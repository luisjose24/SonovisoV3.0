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
    public partial class FrmMedios : System.Web.UI.Page
    {
        public IProduccionService ProduccionService { get; set; }
        public IAreaService AreaService { get; set; }
        public IGeneroService GeneroService { get; set; }
        public IFormatoService FormatoService { get; set; }
        public IMedioService MedioService { get; set; }

        public FrmMedios()
        {
            if ((ProduccionService == null) || (AreaService == null) || (GeneroService == null)|| (FormatoService == null) || (MedioService==null))
            {
                ProduccionService = new ProduccionService();
                AreaService = new AreaService();
                GeneroService = new GeneroService();
                FormatoService = new FormatoService();
                MedioService = new MedioService();

            }
        }
        protected bool enable = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;

            var acc = Request.QueryString["acc"];

            var idMedio = Request.QueryString["id"];

            if (acc != null && acc.Equals("editar"))
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                enable = true;
                fvMedios.DefaultMode = FormViewMode.Edit;
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
                fvMedios.DefaultMode = FormViewMode.Insert;
                fvMedios.EnableViewState = true;
            }
            else if (acc != null && idMedio != null && acc.Equals("eliminar"))
            {
                var id = idMedio;
                MedioService.DeleteMedio(id);
                Response.Redirect("FrmMedios.aspx");
            }
            else
            {
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }


        public IEnumerable<Produccion> GetProduccions()
        {
            return ProduccionService.GetProduccions("");

        }

        public IEnumerable<Area> GetAreas()
        {
            return AreaService.GetAreas("");
        }

        public IEnumerable<Genero> GetGeneros()
        {
            return GeneroService.GetGeneros("");
        }

        public IEnumerable<Formato> GetFormatos()
        {
            return FormatoService.GetFormatos("");
        }

        public void AddMedio(Medio medio)
        {
            if (ModelState.IsValid)
            {
                MedioService.AddMedio(medio);
                Response.Redirect("FrmMedios.aspx");
            }
        }

        public void EditMedio(Medio medio)
        {
            if (ModelState.IsValid)
            {
                MedioService.EditMedio(medio);
                Response.Redirect("FrmMedios.aspx");
            }
        }

        public IEnumerable<Medio> GetMedios([Control("txtCriterio")] string criterio)
        {
            MedioService = new MedioService();
            return MedioService.GetMedios(criterio);
        }
        public Medio GetMedio([QueryString("id")] string idMedio)
        {
            Medio medio = null;
            if (idMedio != null)
            {
                medio = MedioService.GetMedio(idMedio);
            }
            else
            {
                Response.Redirect("FrmMedios.aspx");
            }
            return medio;


            //string ident = Request.QueryString["id"];
            //MedioService = new MedioService();
            //return MedioService.GetMedio(id);
        }

    }
}