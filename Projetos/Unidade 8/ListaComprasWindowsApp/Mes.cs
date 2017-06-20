using System.Globalization;

namespace ListaComprasWindowsApp
{
    public class Mes
    {
      
        public Mes(int numero)
        {
            this.Numero = numero;
            this.Nome = DateTimeFormatInfo.CurrentInfo.GetMonthName(numero);
        }
        
        public int Numero { get; private set; }

        public string Nome { get;  private set; }

        public override string ToString()
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Nome);            
        }

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Mes))
        //        return false;

        //    Mes mes = (Mes)obj;

        //    return mes.Numero == Numero;
        //}
    }
}