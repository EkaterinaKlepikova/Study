using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Worker : BL.Person
    {
    private double Test=100 //Тестовая переменная!
        private String test = "Тестовая переменная!";
         
        private int countDetail = 0;
        private int countPerson = 0;
        private int Razr = 0;
        private double ZP = 0.0;

        public Worker() { }

        public Worker(int id, string surname, string name, string secondName, int countDetail, int countPerson, int Razr) :base(id, surname, name, secondName)
        {
            this.countDetail = countDetail;
            this.countPerson = countPerson;
            this.Razr = Razr;
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondName = secondName;
        }
        public double Calc(int countSdelka, double summDetail, double okladMin)
        {
            return ZP = countDetail * countPerson * Razr;
        }
    }
}
