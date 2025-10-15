using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class IzmjeniKomanda : AvioCommand
    {
        public IzmjeniKomanda(Rezervacije receiver, string brojSjedista, string putnik, Let let, INacinPlacanja nacinPlacanja, double cijena)
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
            throw new NotImplementedException();
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
