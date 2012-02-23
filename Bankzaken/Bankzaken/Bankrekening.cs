using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bankzaken
{
    class Bankrekening
    {
        private static int volgendVrijRekeningnummer = 2001; 

        /// <summary>
        /// Statische functie welke het volgend vrije rekeningnummer genereert
        /// </summary>
        private static string VolgendVrijRekeningnummer
        {
            get { return volgendVrijRekeningnummer++.ToString(); }
        }

        /// <summary>
        /// Het rekeningnummer van het account
        /// </summary>
        public string Rekeningnummer
        {
            get;
            private set;
        }

        /// <summary>
        /// De naam van de rekeninghouder
        /// </summary>
        public string Naam
        {
            get;
            private set;
        }

        /// <summary>
        /// Het saldo van de rekening in centen
        /// </summary>
        public int Saldo
        {
            get;
            private set;
        }

        /// <summary>
        /// Neem een bedrag in centen op van de rekening
        /// </summary>
        /// <param name="bedrag"></param>
        public void NeemOp(int bedrag)
        {
            if (bedrag > 0) 
                this.Saldo -= bedrag; // in de opdracht staat niet vermeld dat de rekeninghouder niet in de min mag, enkel dat de parameter 'bedrag' positief moet zijn            
        }

        /// <summary>
        /// Stort een bedrag op de rekening
        /// </summary>
        /// <param name="bedrag">Het bedrag in centen dat gestort moet worden</param>
        public void Stort(int bedrag)
        {
            if (bedrag > 0) 
                this.Saldo += bedrag;            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="naam">Naam van de rekeninghouder</param>
        public Bankrekening(string naam)
        {
            this.Naam = naam;
            this.Rekeningnummer = Bankrekening.VolgendVrijRekeningnummer;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="naam">Naam van de rekeninghouder</param>
        /// <param name="saldo">Het saldo van de rekeninghouder in centen</param>
        public Bankrekening(string naam, int saldo)
        {
            this.Naam = naam;
            this.Saldo = saldo;
            this.Rekeningnummer = Bankrekening.VolgendVrijRekeningnummer;
        }

        /// <summary>
        /// Maakt een bedrag over naar een ander rekeningnummer
        /// </summary>
        /// <param name="andereRekening">Het rekeningnummer waarnaar het geld moet worden overgemaakt</param>
        /// <param name="bedrag">Het bedrag dat overgemaakt wenst te worden</param>
        /// <returns>true als de overboeking succesvol is afgehandeld, anders false</returns>
        public bool MaakOverNaar(Bankrekening andereRekening, int bedrag)
        {
            if (bedrag <= 0 || this.Saldo < bedrag) return false;

            andereRekening.Stort(bedrag);
            this.Saldo -= bedrag;

            return true;
        }
    }
}
