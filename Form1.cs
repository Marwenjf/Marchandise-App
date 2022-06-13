using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport;

namespace winFormApp
{
    public partial class Form1 : Form
    {    //int counter=1;
        public Form1()
        {
            InitializeComponent();
           buttonAddCargaison.Click += buttonAddCargaison_Click;
           buttonAddMarchandise.Click += btnAddMarch_Click;
           listBoxCargaisons.SelectedIndexChanged += listBoxCargaisons_SelectedIndexChanged;
            //button.Text = "Counter: "+counter;
        }

        private void buttonAddCargaison_Click(object sender,EventArgs e){
          int distance = int.Parse(textBoxDistance.Text);
          string type = (string)comboBoxTye.SelectedItem;
          Cargaison cargaison;
          if (type.Equals("Routière"))
          {
              cargaison = new CargaisonRoutiere(distance);
          }
          else
          {
             cargaison = new CargaisonAerienne(distance);
          }
          listBoxCargaisons.Items.Add(cargaison);
        }

        private void btnAddMarch_Click(object sender,EventArgs e)
        {
             Cargaison cargaison;
             object o = listBoxCargaisons.SelectedItem;
             if (o!=null)
             {
                 cargaison = (Cargaison)o;
                 double poids = double.Parse(textBoxPoids.Text);
                 double volume = double.Parse(textBoxVolume.Text);
                 Marchandise marchandise = new Marchandise(poids,volume);
                 cargaison.Add(marchandise);
                 dataGridViewMarchandise.Rows.Add(marchandise.Numero,marchandise.Poids,marchandise.Volume);
             }
        }

        private void listBoxCargaisons_SelectedIndexChanged(object sender, EventArgs e)
        {
           Cargaison cargaison=null;
             object o = listBoxCargaisons.SelectedItem;
             if (o!=null)
             {
                 cargaison = (Cargaison)o;
                 List<Marchandise> listMarch = cargaison.getMarchandises();
                 dataGridViewMarchandise.Rows.Clear();
                 foreach (Marchandise m in listMarch)
                 {
                     dataGridViewMarchandise.Rows.Add(m.Numero,m.Poids,m.Volume);
                 }
                 textBoxCout.Text = cargaison.cout().ToString();
             }
        }

    }
}
