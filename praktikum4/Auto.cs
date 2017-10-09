using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum4
{
    class Auto:Mootorsoiduk
    {
        private bool _uksedAvatud = false;
        public Auto():base(100) //anname maxKiirus 100 baas klassile mootorsoiduk
        { }

        protected Auto(int maxKiirus):base(maxKiirus) { } // seda konstruktor votab veoauto klassist maxkiirus 
        //auto klassile ja edastab seda maxkiirust klassile Mootorsoiduk. kahekordne parilus


        public void avaUksed()
        {
            base.Stop(); // poordu,e baas klassile ja peatame auto
            _uksedAvatud = true; // avame uksed
        }

        public void SulgeUksed()
        {
            _uksedAvatud = false;
        }

        public override void Kiirenda(int kiirus) // sellega saab ylekirjutada meetod baas klassis
        {
            if(!_uksedAvatud)
            {
                base.Kiirenda(kiirus);
            }
        }

        public override string hetkeSeis()
        {

            // return _uksedAvatus ? "Uksed avatud" : base.hetkeSeis(); lyhine variant
            if (_uksedAvatud)
            {
                return "uksed on avatud ja auto seisab";
            }
            return base.hetkeSeis();
        }

    }
}
