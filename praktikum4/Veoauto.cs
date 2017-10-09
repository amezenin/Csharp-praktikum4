using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum4
{

    class Veoauto:Auto
    {
        private bool _kallutab = false;

        public Veoauto() : base(70) //anname maxKiirus 100 baas klassis
        {

        }

        public void hakkaKallutama()
        {
            base.Stop(); // poordu baas klassile ja peatame auto
            _kallutab = true; // kallutame

        }

        public override void Kiirenda(int kiirus) // sellega saab ylekirjutada meetod baas klassis
        {
            if (!_kallutab)
            {
                base.Kiirenda(kiirus);
            }
        }

        public override string hetkeSeis()
        {
            return _kallutab ? "Kallutab" : base.hetkeSeis();
        }
    }
}
