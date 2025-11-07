



using System.Security.Cryptography.X509Certificates;

namespace Guia_Examen_13.Models
{
    public class Sistema
    {
        public List<Paquete>listaPaquetes =new List<Paquete>();
        private List<Camion> listacamiones= new List<Camion>();

        public Sistema()
        {
            listacamiones.Add(new Camion(123, 985));
            listacamiones.Add(new Camion(456, 985));
            listacamiones.Add(new Camion(789, 985));
        }

        public string[] CamionesCargados()
        {
            string[]lista= new string[listacamiones.Count];
            int n = 0;
            foreach (Camion c in listacamiones) {

                lista[n++] = @$"{c.patente.ToString()};{c.PesoMax.ToString()}";
            }
            return lista;
        }

        public double CargarPaquete(int camionElegido, Paquete seleccionado)
        {
            Camion c = listacamiones[camionElegido];

            if (c.AgregarPaquete(seleccionado))
            {
                listaPaquetes.Remove(seleccionado);
            }

            return c.CargaEnKg();
        }

        public void Descargar(Stream fs)
        {
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();

                string[] datos = linea.Split(';');

                int id = Convert.ToInt32(datos[0]);
                double peso = Convert.ToDouble(datos[1]);
                string zona = datos[2];

                Paquete paquete = new Paquete(id, peso, zona);
                listaPaquetes.Add(paquete);
            }

            sr.Close();
        }
        public void RetirarCamion(Stream fs, int posicion)
        {
            StreamWriter sr = new StreamWriter(fs);

            foreach (string p in VerCargaCamion(posicion))
            {
                sr.WriteLine(p.ToString());
            }


            sr.Close();
        }
        public double RetirarPaquete(int pocision)
        {
            Camion camion = listacamiones[pocision];
            Paquete paq=camion.QuitarPaquete();
            if (paq == null) throw new Exception("El paquete es nulo");
            listaPaquetes.Add(paq);
            return camion.CargaEnKg();
        }

        public string[] VerCargaCamion(int pos)
        {
            Camion cam = listacamiones[pos];
            if (cam!=null)
            {
                return cam.VerCarga();
            }
            return null;
        }
    }
}
