using System.Numerics;

namespace Matematica.Negocio
{
    public class Calculadora
    {
        public Calculadora()
        {
        }
       
        public double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
   
        public Complejo Sumar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real + segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria + segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
            
        }
       
        public double Dividir(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                throw new System.ArgumentException();
            }
            return dividendo / divisor;
        }
       
        public object Restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        
        public Complejo Restar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real - segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria - segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }
        
        public object Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        

        public Complejo Multiplicar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real * segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria * segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }

        public Complejo multiplicacionEscalar(double numero, Complejo primerNumero)
        {
            var parteReal = numero * primerNumero.Real;

            var parteImaginaria = numero * primerNumero.Imaginaria;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }


    }
}