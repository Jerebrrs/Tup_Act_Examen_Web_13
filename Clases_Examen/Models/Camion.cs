

namespace Guia_Examen_13.Models
{
    public class Camion
    {
        private double pesoControl=0;
        public int patente { get; set; }
        public double PesoMax { get; set; }
        private Stack<Paquete> manifiesto = new Stack<Paquete>();
        public Camion(int patente, double peso)
        {
            this.patente = patente;
            this.PesoMax = peso;
        }

        public bool AgregarPaquete(Paquete unPaquete)
        {
            if (unPaquete != null)
            {
                if (pesoControl< PesoMax)
                {
                    manifiesto.Push(unPaquete);
                    pesoControl += unPaquete.Peso;
                    return true;
                }
                else
                {
                    throw new Exception("");
                }

            }
            else
            {
                throw new Exception("El paquete es nulo.");
            }
           
        }

        public double CargaEnKg()
        {
            return pesoControl;
        }

        public Paquete QuitarPaquete()
        {
            if (manifiesto.Count() >0)
            {
                return manifiesto.Pop();
            }
            return null;
        }

        public string[] VerCarga()
        {
            string[] lista = new string[manifiesto.Count];
            int n = 0;
            foreach (Paquete paq in manifiesto)
            {
                lista[n++] = paq.ToString();
            }
            return lista;
        }

        public override string ToString()
        {
            return @$"{patente};{PesoMax}";
        }
    }
}
