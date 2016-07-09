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
    public partial class FrmMaterials : System.Web.UI.Page
    {
        public ICategoriaMaterialService CategoriaMaterialService { get; set; }
        public IMaterialService MaterialService { get; set; }

        public FrmMaterials()
        {
            if ((MaterialService ==null) || (CategoriaMaterialService==null))
            {
                MaterialService = new MaterialService();
                CategoriaMaterialService= new CategoriaMaterialService();
            }
        }
        protected bool enable = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;

            var acc = Request.QueryString["acc"];

            var idMaterial = Request.QueryString["id"];

            if (acc != null && acc.Equals("editar"))
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                enable = true;
                fvMaterials.DefaultMode = FormViewMode.Edit;
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
                fvMaterials.DefaultMode = FormViewMode.Insert;
                fvMaterials.EnableViewState = true;
            }
            else if (acc != null && idMaterial != null && acc.Equals("eliminar"))
            {
                var id = Int32.Parse(idMaterial);
                MaterialService.DeleteMaterial(id);
                Response.Redirect("FrmMaterials.aspx");
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
        public IEnumerable<CategoriaMaterial> GetCategoriaMaterial()
        {
            return CategoriaMaterialService.GetCategoriaMaterials("");

        }

        public void AddMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                MaterialService.AddMaterial(material);
                Response.Redirect("FrmMaterials.aspx");
            }
        }

        public void EditMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                MaterialService.EditMaterial(material);
                Response.Redirect("FrmMaterials.aspx");
            }
        }

        public IEnumerable<Material> GetMaterials([Control("txtCriterio")] string criterio)
        {
            MaterialService = new MaterialService();
            return MaterialService.GetMaterials(criterio);
        }
        public Material GetMaterial([QueryString("id")] Int32? idMaterial)
        {
            Material material = null;
            if (idMaterial.HasValue)
            {
                material = MaterialService.GetMaterial(idMaterial.Value);
            }
            else
            {
                Response.Redirect("FrmMaterials.aspx");
            }
            return material;
        }

    }
}
