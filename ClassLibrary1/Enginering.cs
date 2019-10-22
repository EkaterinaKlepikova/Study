using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;


namespace ClassLibrary1
{
    public class Enginering : BL.Person
    {

        private double oklad = 0.0;
        private double premiya = 0.0;
        private int categoria = 0;
        private double ZP = 0.0;

        public Enginering() { }

        public Enginering(int id, string surname, string name, string secondName, double oklad, double premiya, int categoria):base(id, surname, name, secondName)
        {
            this.oklad = oklad;
            this.premiya = premiya;
            this.categoria = categoria;
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondName = secondName;
        }
        public double Calc(double oklad, double premiya, int categoria)
        {
            return ZP = oklad * categoria + premiya;
        }
    }
}
