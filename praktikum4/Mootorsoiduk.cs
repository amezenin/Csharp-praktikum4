using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum4
{
    class Mootorsoiduk
    {
        private int _kiirus = 0;
        private int _maxKiirus = 20;

        public Mootorsoiduk(int maxKiirus)
        {
            _maxKiirus = maxKiirus;
        }

        // void, ei pea tagastama
        public void Kiirenda()
        {

            Kiirenda(10);
            /*_kiirus = _kiirus + 10;
            if (_kiirus > _maxKiirus)
            {
                _kiirus = _maxKiirus;
            }*/

        }
            public virtual void Kiirenda(int kiirus) // virtual annab voimalus seda meetod allamklassis ylekirjutada

            {
                _kiirus = _kiirus + kiirus;
                if (_kiirus > _maxKiirus)
                {
                    _kiirus = _maxKiirus;
                }
            }

        public void Stop()
        {
            _kiirus = 0;
        }

        public virtual string hetkeSeis()
        {
            if (_kiirus > 0)
            {
                return $"Soiduk soidab kiirusega {_kiirus}";

            } else
            {
                return $"Soiduk seisab";
            }
        }

        public override string ToString()
        {
            return hetkeSeis();
        }


    }
}
