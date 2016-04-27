using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
        Napipavanje,
        Okruživanje,
        SustavnoUništavanje
    }
    public class Topništvo
    {
        public Topništvo()
        {
            PromjeniTaktikuUNapipavanju();
        }
        public Polje UputiPucanj(Flota flota)
        {

            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {

        }

        private void PromjeniTaktikuUNapipavanju()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
        }
        private void PromjeniTaktikuUOkruživanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Okruživanje;
        }

        private void PromjeniTaktikuUSustavnoUništavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.SustavnoUništavanje;
        }
        public TaktikaGađanja TrenutnaTaktika
        {
            get;
            private set;
        }
    }
}
