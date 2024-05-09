
namespace Exercicio5
{
    public class VerificaPlaca
    {
        public bool PlacaIsValid(string placa) 
        {

           placa = placa.Trim();

            if(placa.Length != 7)
            {
                return false;
            }
            else if (!placa[..3].All(char.IsLetter)) 
            {
                return false;
            }
            else if(!placa.Substring(3, 4).All(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }

          
        }
    }
}
