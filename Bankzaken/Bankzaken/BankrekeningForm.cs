using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bankzaken
{
    public partial class BankrekeningForm : Form
    {
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;

        public BankrekeningForm()
        {
            InitializeComponent();

            bankrekeningLinks = new Bankrekening("Peter R", 5002);
            bankrekeningRechts = new Bankrekening("Jan Zonderachernaam", 5003);

            UpdateStatusLinks();
            UpdateStatusRechts();
        }

        private void UpdateStatusLinks()
        {
            txtNaamLinks.Text = bankrekeningLinks.Naam;
            txtRekeningnummerLinks.Text = bankrekeningLinks.Rekeningnummer;

            if (bankrekeningLinks.Saldo > 0)
            {
                int euros = bankrekeningLinks.Saldo / 100;
                int centen = bankrekeningLinks.Saldo % 100;

                txtSaldoLinks.Text = string.Format("{0},{1}", euros, centen.ToString("00"));
            }
            else
            {
                txtSaldoLinks.Text = "0";
            }            
        }

        private void UpdateStatusRechts()
        {
            txtNaamRechts.Text = bankrekeningRechts.Naam;
            txtRekeningnummerRechts.Text = bankrekeningRechts.Rekeningnummer;

            if (bankrekeningRechts.Saldo > 0)
            {
                int euros = bankrekeningRechts.Saldo / 100;
                int centen = bankrekeningRechts.Saldo % 100;

                txtSaldoRechts.Text = string.Format("{0},{1}", euros, centen.ToString("00"));
            }
            else
            {
                txtSaldoRechts.Text = "0";
            }       
        }

        /// <summary>
        /// Zet het bedrag in de vorm van [euro's,centen] om in centen
        /// </summary>
        /// <param name="invoer"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">De opgegeven parameter voldoet niet aan de eisen</exception>
        private int BedragInCenten(string invoer)
        {            
            try
            {                             
                return (int)(Convert.ToDouble(invoer.Replace(',', '.')) * 100);                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("De ingevoerde invoer voldoet niet aan de gestelde eisen!", "invoer", ex);
            }            
        }
        
        private void btAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void BankrekeningForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Controleert of het invoerbedrag aan alle gestelde voorwaarden voldoet
        /// </summary>
        /// <param name="bedrag"></param>
        /// <returns></returns>
        private bool IsGeldigeWaarde(string bedrag)
        {    
            if (bedrag.Count(c => (!char.IsDigit(c) && c != ',')) > 0 || bedrag.Split(',').Length != 2)            
            {
                MessageBox.Show(this, "Het bedrag is niet in de juiste vorm [euro's,centen] opgegeven!", "Foutmelding:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btNeemOpLinks_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragLinks.Text))
            {
                int bedrag = BedragInCenten(txtBedragLinks.Text);

                bankrekeningLinks.NeemOp(bedrag);

                UpdateStatusLinks();
            }            
        }

        private void btStortLinks_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragLinks.Text))
            {
                int bedrag = BedragInCenten(txtBedragLinks.Text);

                bankrekeningLinks.Stort(bedrag);

                UpdateStatusLinks();
            }            
        }

        private void btNeemOpRechts_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragRechts.Text))
            {
                int bedrag = BedragInCenten(txtBedragRechts.Text);

                bankrekeningRechts.NeemOp(bedrag);

                UpdateStatusRechts();
            }
        }

        private void btStortRechts_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragRechts.Text))
            {
                int bedrag = BedragInCenten(txtBedragRechts.Text);

                bankrekeningRechts.Stort(bedrag);

                UpdateStatusRechts();
            }
        }

        private void btMaakOverNaarLinks_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragOverMaken.Text))
            {
                int bedrag = BedragInCenten(txtBedragOverMaken.Text);

                bankrekeningRechts.MaakOverNaar(bankrekeningLinks, bedrag);

                UpdateStatusLinks();
                UpdateStatusRechts();
            }
        }

        private void btMaakOverNaarRechts_Click(object sender, EventArgs e)
        {
            if (IsGeldigeWaarde(txtBedragOverMaken.Text))
            {
                int bedrag = BedragInCenten(txtBedragOverMaken.Text);

                bankrekeningLinks.MaakOverNaar(bankrekeningRechts, bedrag);

                UpdateStatusLinks();
                UpdateStatusRechts();
            }
        }
    }
}
