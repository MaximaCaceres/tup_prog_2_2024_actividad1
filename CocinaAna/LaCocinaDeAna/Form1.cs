using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaCocinaDeAna.models;

namespace LaCocinaDeAna
{
    public partial class CocinaDeAna : Form
    {
        public CocinaDeAna()
        {
            InitializeComponent();
        }
        Cocina C;

        private void btnCrearCocina_Click(object sender, EventArgs e)
        {
            Alacena a = new Alacena();
            Amasador ama = new Amasador();
            Cocinera MasterChef = new Cocinera("Ana");

            C = new Cocina(a, ama,MasterChef);          
        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            double cantH = Convert.ToDouble(tbxCantH.Text);
            double cantF = Convert.ToDouble(tbxCantF.Text);

            Alacena a = C.Alacena;

            a.ReponerHarina(cantH);
            a.ReponerFruta(cantF);

            
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            Alacena a = C.Alacena;
            double requeH = Convert.ToDouble(tbxTH.Text);
            double requeF = Convert.ToDouble(tbxTF.Text);

            double CantidadHarina = a.TomarHarina(requeH);

            double CantidadFruta = a.TomarFruta(requeF);
            totH.Text = CantidadHarina.ToString();
            totF.Text = CantidadFruta.ToString();

            Amasador ama = C.Amasador;
            double masaP = ama.Amasar(CantidadHarina);
            totM.Text = masaP.ToString();

            Cocinera MasterChef = C.Cocinera;
            #region Ana en accion
            MasterChef.CortaLaMasa();

            lbxChat.Items.Add("Ana?...");
            lbxChat.Items.Add($"Ana - {MasterChef.Contestar()}");

            MasterChef.FormaLaMasa();

            lbxChat.Items.Add("Ana?...");
            lbxChat.Items.Add($"Ana - {MasterChef.Contestar()}");

            MasterChef.Hornea();

            lbxChat.Items.Add("Ana?...");
            lbxChat.Items.Add($"Ana - {MasterChef.Contestar()}");
            #endregion
        }

    }
}
