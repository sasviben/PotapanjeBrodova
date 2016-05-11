using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {
        public KružniPucač(Polje prvoPogođeno, Mreža mreža)
        {
            this.prvoPogođeno = prvoPogođeno;
            this.mreža = mreža;
        }

        public Polje UputiPucanj()
        {
            int redak = prvoPogođeno.Redak;
            int stupac = prvoPogođeno.Stupac;
            //tražimo za sve smjerove broj slobodnih polja u tom smjeru 
            List<IEnumerable<Polje>> kandidati = new List<IEnumerable<Polje>>();
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer)))
            {
                kandidati.Add(mreža.DajPoljaUZadanomSmjeru(redak, stupac, smjer));
            }

            //sortiram te liste tako da je najdulja prva
            kandidati.Sort((lista1, lista2) => lista2.Count() - lista1.Count());
            //između najduljih biram jednu slučajnim odabirom 
            var grupe = kandidati.GroupBy(lista => lista.Count());
            var najdulji = grupe.First();
            if (najdulji.Count() == 1)
                return najdulji.First().First();
            int indeks = slučajni.Next(najdulji.Count());
            
            //iz nje vadim prvi polje
           return najdulji.ElementAt(indeks).First();

        }

        Polje prvoPogođeno;
        Mreža mreža;
        Random slučajni = new Random();
    }
}
