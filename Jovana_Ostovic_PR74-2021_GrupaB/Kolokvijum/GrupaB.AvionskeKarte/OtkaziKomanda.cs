using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class OtkaziKomanda : AvioCommand
    {
        public OtkaziKomanda(Rezervacije receiver, string brojSjedista, string putnik, Let let, INacinPlacanja nacinPlacanja, double cijena)
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
            receiver.Otkazi(putnik, let, brojSjedista);
        }

        public override void Undo()
        {
            receiver.Rezervisi(putnik, let, brojSjedista, cijena, nacinPlacanja);
            
        }
    }
}
