using System.Drawing;
using System.Windows.Forms;

namespace winFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Text = "JF Marwen";
            buttonAddCargaison = new Button();
            buttonAddMarchandise = new Button();
            textBoxDistance = new TextBox();
            textBoxPoids = new TextBox();
            textBoxVolume = new TextBox();
            textBoxCout = new TextBox();
            comboBoxTye = new ComboBox();
            listBoxCargaisons = new ListBox();
            dataGridViewMarchandise = new DataGridView();
            labelDistance = new Label();
            labelType = new Label();
            labelPoids = new Label();
            labelVolume = new Label();
            labelCout = new Label();
            buttonAddCargaison.Name = "buttonAddCargaison";
            buttonAddCargaison.Text = "Add";
            buttonAddMarchandise.Name = "buttonAddMarchandise";
            buttonAddMarchandise.Text = "Add";
            textBoxDistance.Name = "textBoxDistance";
            labelDistance.Text = "Distance:";
            labelType.Text = "Type:";
            labelPoids.Text = "Poids";
            labelVolume.Text = "Volume";
            labelCout.Text = "Coût";

            comboBoxTye.Anchor = AnchorStyles.Bottom;
            comboBoxTye.DropDownWidth = 150;
            comboBoxTye.Items.AddRange(new object[] { "Routière", "Aérienne" });
            dataGridViewMarchandise.ColumnCount = 3;
            dataGridViewMarchandise.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewMarchandise.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewMarchandise.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewMarchandise.Font, FontStyle.Bold);
            dataGridViewMarchandise.Location = new System.Drawing.Point(450, 150);
            dataGridViewMarchandise.Size = new System.Drawing.Size(400, 90);
            dataGridViewMarchandise.Columns[0].Name = "Numéro";
            dataGridViewMarchandise.Columns[1].Name = "Poids";
            dataGridViewMarchandise.Columns[2].Name = "Volume";

            labelDistance.Location = new System.Drawing.Point(20, 20);
            textBoxDistance.Location = new System.Drawing.Point(120, 20);
            textBoxDistance.Size = new System.Drawing.Size(150, 25);
            labelType.Location = new System.Drawing.Point(20, 60);
            comboBoxTye.Location = new System.Drawing.Point(120, 60);
            comboBoxTye.Size = new System.Drawing.Size(150, 25);
            buttonAddCargaison.Location = new System.Drawing.Point(290, 59);
            buttonAddCargaison.Size = new System.Drawing.Size(50, 26);
            labelPoids.Location = new System.Drawing.Point(450, 80);
            labelVolume.Location = new System.Drawing.Point(550, 80);
            textBoxPoids.Location = new System.Drawing.Point(450, 105);
            textBoxPoids.Size = new System.Drawing.Size(80, 25);
            textBoxVolume.Location = new System.Drawing.Point(550, 105);
            textBoxVolume.Size = new System.Drawing.Size(80, 25);
            buttonAddMarchandise.Location = new System.Drawing.Point(650, 104);
            buttonAddMarchandise.Size = new System.Drawing.Size(50, 26);
            listBoxCargaisons.Location = new System.Drawing.Point(20, 160);
            listBoxCargaisons.Size = new System.Drawing.Size(320, 80);
            labelCout.Location = new System.Drawing.Point(20, 250);
            textBoxCout.Location = new System.Drawing.Point(120, 250);
            this.Controls.Add(buttonAddCargaison);
            this.Controls.Add(labelDistance);
            this.Controls.Add(labelType);
            this.Controls.Add(textBoxDistance);
            this.Controls.Add(comboBoxTye);
            this.Controls.Add(listBoxCargaisons);
            this.Controls.Add(labelPoids);
            this.Controls.Add(labelVolume);
            this.Controls.Add(textBoxPoids);
            this.Controls.Add(textBoxVolume);
            this.Controls.Add(buttonAddMarchandise);
            this.Controls.Add(dataGridViewMarchandise);
            this.Controls.Add(labelCout);
            this.Controls.Add(textBoxCout);
        }

        private Button buttonAddCargaison;
        private Button buttonAddMarchandise;
        private TextBox textBoxDistance;

        private TextBox textBoxPoids;
        private TextBox textBoxVolume;
        private TextBox textBoxCout;
        private ComboBox comboBoxTye;
        private DataGridView dataGridViewMarchandise;

        private Label labelDistance;
        private Label labelType;
        private Label labelPoids;
        private Label labelVolume;
        private Label labelCout;
        private ListBox listBoxCargaisons;

        #endregion
    }
}

