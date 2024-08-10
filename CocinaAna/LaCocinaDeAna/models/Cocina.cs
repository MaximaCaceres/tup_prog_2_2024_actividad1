using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCocinaDeAna.models
{
	public class Cocina
	{
		public Alacena Alacena { get; private set; }
		public Amasador Amasador { get; private set; }
		public Cocinera Cocinera { get; private set; }


		public Cocina(Alacena alacena, Amasador amasador, Cocinera cocinera)
		{
			this.Alacena = alacena;
			this.Amasador = amasador;
			this.Cocinera = cocinera;
		}
	}
	public class Cocinera
	{
		public string Nombre { get; private set; }
		public string estado;
		public Cocinera(string nombre)
        {
			this.Nombre = nombre;
        }
		#region Metodos
		public void CortaLaMasa()
		{
			estado = "Cortando la masa";
		}

		public void FormaLaMasa()
		{
			estado = "Formando La Masa";
		}

		public void Hornea()
		{
			estado = "Horneando";
		}

		public string Contestar()
		{
			return estado;
		}

		#endregion
	}
	public class Alacena
	{
		public double Harina { get; private set; }
		public double Fruta { get; private set; }
		
        #region Metodos
        public void ReponerHarina(double cantH)
        {
			Harina += cantH;
        }
		public void ReponerFruta(double cantF)
        {
			Fruta += cantF;
        }
		public double TomarHarina(double requeH)
		{
			double devuelto = 0;
			if (requeH < Harina)
			{
				devuelto = requeH;
				Harina -= requeH;
			}
			else
			{
				devuelto = Harina;
				Harina = 0;
			}
			return devuelto;
		}

		public double TomarFruta(double requeF)
        {
			double devuelto = 0;
			if(requeF < Harina)
            {
				devuelto = requeF;
				Fruta -= requeF;
            }
            else
            {
				devuelto = Fruta;
				Fruta = 0;
            }
			return devuelto;
        }
        #endregion

    }
	public class Amasador
    {
		public double CantidadHarina { get; private set; }
		public double Amasar(double cantH)
        {
			double producido = 1.3 * cantH;
			return producido;
        }
    }
}
