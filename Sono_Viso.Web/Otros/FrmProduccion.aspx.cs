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
    public partial class FrmProduccion : System.Web.UI.Page
    {
        public IProduccionService ProduccionService { get; set; }

        public FrmProduccion()
        {
            if (ProduccionService==null)
            {
                ProduccionService = new ProduccionService();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Produccion> GetProduccions()
        {
            return ProduccionService.GetProduccions("");
            
        }

        protected void dpProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbProduccion.Text = dpProduccion.SelectedValue.ToString();
            Int32 id = Int32.Parse(dpProduccion.SelectedValue);
            lbProduccion.Text =  ProduccionService.GetProduccion(id).Nombre;
        }
    }
}