using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prac.Models
{
    public class Calculadora
    {
        public int Operador1 {get;set;}
        public DateTime Operador2 {get;set;}
        public int Operador3 {get;set;}

       public DateTime now = DateTime.Now.Date ;

       
        


        public string Operando {get;set;}
    }
}