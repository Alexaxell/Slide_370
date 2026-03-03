namespace Slide_370
{
    public class Scuola
    {
        public List<Insegnante> Insegnanti { get; set; }
        public List<Studente> Studenti { get; set; }        

        public double MediaStudente(Studente studente)
        {
            return studente.Voti.Average(v => v.Valore);
        }

        public List<double> MediaStudentePerMese(Studente studente, DateTime anno) 
        {
            var mediaPerMese = new List<double>();
            int meseCorrente = 1;
            double count = 0;
            double somma = 0;
            while (meseCorrente != 13)
            {
                foreach (var voto in studente.Voti)
                {
                    while (voto.Data.Month == meseCorrente && voto.Data.Year == anno.Year)
                    {
                        somma += voto.Valore;
                        count++;
                    }
                    mediaPerMese.Add(somma);
                    meseCorrente++;
                    somma = 0;
                }
            }
            return mediaPerMese;
        }
    }
}
