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
    public partial class FormFormato : System.Web.UI.Page
    {
        public IFormatoService FormatoService { get; set; }

        public FormFormato()
        {
            if (FormatoService == null)
            {
                FormatoService = new FormatoService();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Formato> GetFormatos()
        {
            return FormatoService.GetFormatos("");
        }

        protected void dpFormatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFormato.Text = dpFormatos.SelectedItem.Text;
        }
    }
}