using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ClassLibrary1
{
    public class Manager : BL.Person
    {
        private double Test=100 //Тестовая переменная!
        private String test = "Это тестовая переменная созданная в октябре 2019 года, для гитхаба";
        private int countSdelka = 0;
        private double summDetail = 0.0;
        private double okladMin = 0.0;
        private double ZP = 0.0;

        public Manager() { }

        public Manager(int id, string surname, string name, string secondName, int countSdelka, double summDetail, double okladMin) :base(id, surname, name, secondName)
        {
            this.countSdelka = countSdelka;
            this.summDetail = summDetail;
            this.okladMin = okladMin;
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondName = secondName;
        }
        public double Calc(int countSdelka, double summDetail, double okladMin)
        {
            return ZP = countSdelka * summDetail + okladMin;
        }
    }
}
