using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Service;

namespace Sono_Viso.Web.Otros
{
    public partial class FormCategoriaMaterial : System.Web.UI.Page
    {
        public ICategoriaMaterialService CategoriaMaterialService { get; set; }

        public FormCategoriaMaterial()
        {
            if (CategoriaMaterialService ==null)
            {
                CategoriaMaterialService = new CategoriaMaterialService();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IEnumerable<CategoriaMaterial> GetCategoriaMaterials()
        {
            return CategoriaMaterialService.GetCategoriaMaterials("");
        }

        protected void dpCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpText = dpCategorias.SelectedItem.Text;
            lbCategorias.Text = dpText;
        }
    }
}