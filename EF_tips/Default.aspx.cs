using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF_tips
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gestion_commandeEntities DB = new gestion_commandeEntities();
                List<client> cli = DB.client.ToList();
                if (cli.Count>0)
                {
                    foreach (var item in cli)
                    {
                        divDatos.InnerHtml += item.nom_cl + " " + item.prenom_cl + " - " + item.vill + "<br/>";
                    }
                }
                else
                {
                    divDatos.InnerHtml = "no hay datos";
                }
            }
        }
    }
}