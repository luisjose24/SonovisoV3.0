using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.Unity;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Service;

namespace Sono_Viso.Web.Otros
{
    public partial class FormAreas : System.Web.UI.Page
    {
        private string criterio = null;

        public IAreaService AreaService { get; set; }

        public FormAreas()
        {
            if (AreaService== null)
            {
                AreaService = new AreaService();
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Area> GetAreas()
        {
            return AreaService.GetAreas("");
        }

        protected void dpAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpText = dpAreas.SelectedItem.Text;
            lbArea.Text = dpText;

        }
    }
}