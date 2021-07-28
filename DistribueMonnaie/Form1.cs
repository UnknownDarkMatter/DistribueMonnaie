﻿using DistribueMonnaie.Business;
using DistribueMonnaie.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribueMonnaie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txbMontantARepartir.Text, out int montantARepartir))
            {
                MessageBox.Show("Le montant à répartir n'est pas un nombre entier (sans virgules)");
                return;
            }

            var monnaieRepartiteur = new MonnaieRepartiteur();
            var piecesEtBillets = monnaieRepartiteur.RépartitMontant(montantARepartir);
            AffichePiecesEtBillets(piecesEtBillets);
        }

        private void AffichePiecesEtBillets(List<IMonnaie> piecesEtBillets)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Montant");

            var monnaieGrouped = piecesEtBillets.GroupBy(m => m.Montant).Select(m => new { Montant = m.Key, Nb = m.Count(), Type=m.First().GetType() });

            foreach (var monnaie in monnaieGrouped)
            {
                var dr = dataTable.NewRow();
                dataTable.Rows.Add(dr);
                dr["Nombre"] = monnaie.Nb;
                dr["Type"] = monnaie.Type.Name;
                dr["Montant"] = monnaie.Montant;
            }

            this.dgvDataGridView1.DataSource = dataTable;
            this.dgvDataGridView1.Refresh();
        }

    }
}
