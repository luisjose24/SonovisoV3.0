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
    public partial class FormGenero : System.Web.UI.Page
    {
        public IGeneroService GeneroService { get; set; }

        public FormGenero()
        {
            if (GeneroService==null)
            {
                GeneroService = new GeneroService();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Genero> GetGeneros()
        {
            return GeneroService.GetGeneros("");
        }

        protected void dpGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpText = dpGenero.SelectedItem.Text;
            lbGenero.Text = dpText;
        }
    }
}