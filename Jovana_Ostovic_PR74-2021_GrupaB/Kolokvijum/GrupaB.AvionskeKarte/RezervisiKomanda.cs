using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class RezervisiKomanda : AvioCommand
    {
        public RezervisiKomanda(Rezervacije receiver, string brojSjedista, string putnik, Let let, INacinPlacanja nacinPlacanja, double cijena)
        {
            this.receiver = receiver;
            this.brojSjedista = brojSjedista;
            this.putnik = putnik;
            this.let = let;
            this.nacinPlacanja = nacinPlacanja;
            this.cijena = cijena;

        }

        public override void Execute()
        {
            receiver.Rezervisi(putnik, let, brojSjedista, cijena, nacinPlacanja);
        }

        public override void Undo()
        {
            receiver.Otkazi(putnik, let, brojSjedista);
        }
    }
}
