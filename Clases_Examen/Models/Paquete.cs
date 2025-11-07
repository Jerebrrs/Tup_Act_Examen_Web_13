
namespace Guia_Examen_13.Models
{
    [Serializable]
    public class Paquete
    {
        public int NroRegistro { get; set; }
        public double Peso {  get; set; }
        public string ZonaDestino { get; set; }
        public Paquete(int id, double peso,string zona)
        {
            this.NroRegistro = id;
            this.Peso = peso;
            this.ZonaDestino = zona;
        }

        public override string ToString()
        {
            return $@"({NroRegistro};{Peso};{ZonaDestino})";
        }



    }
}
