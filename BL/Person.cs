using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL
    {
        private String FIO = ""; // ТАК НЕ ДОЛЖНО БЫТЬ, НУЖНО РАЗДЕЛИТЬ НА ОТДЕЛЬНЫЕ ФАМИЛИЯ, ИМЯ И ОТЧЕСТВО


        private int id = 0; //код
        private string surname = ""; //фамилия
        private string name = ""; // имя
        private string secondName = ""; //отчество
        private int age = 0; //возраст
        private string position = ""; //должность
        private double wages = 0.0; //заработная плата

        //Конструктор = 
        public BL() { }

        //Конструктор с параметрами = 
        public BL (int id,  string surname, string name, string secondName) {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondName = secondName;
        }

        public string fullName()
        {
            string fullName = surname + " " +  name.Substring(0, 1) + "." + secondName.Substring(0, 1) + ".";

            return fullName;
        }

    }
}
