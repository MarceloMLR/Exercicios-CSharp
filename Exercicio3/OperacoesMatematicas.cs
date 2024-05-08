

namespace Exercicio3
{
    public class OperacoesMatematicas
    {
        public double Somar(double numero1, double numero2)
        {
            var result = numero1 + numero2;

            return(result);
        }

        public double Subtrair(double numero1, double numero2)
        {
            var result = (numero1 - numero2);

            return(result);
        }

        public double Multiplicar(double numero1, double numero2)
        {
            var result = (numero1 * numero2);

            return(result);
        }

        public object Dividir(double numero1, double numero2)
        {
            var result = new object();

            if(numero1 == 0 || numero2 == 0)
            {
                result = "Todo numero dividido por 0 é 0";
                return result;
            }
            else { 
                result = numero1 / numero2;
                return result;
            }
        }

        public double Media(double numero1, double numero2)
        {
            var result = (numero1 + numero2) / 2.00;

            return(result);
        }


    }
}
