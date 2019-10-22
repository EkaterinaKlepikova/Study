using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Person
    {
        private String FIO = ""; // ТАК НЕ ДОЛЖНО БЫТЬ, НУЖНО РАЗДЕЛИТЬ НА ОТДЕЛЬНЫЕ ФАМИЛИЯ, ИМЯ И ОТЧЕСТВО


        public int id = 0; //код
        public string surname = ""; //фамилия
        public string name = ""; // имя
        public string secondName = ""; //отчество
        public int age = 0; //возраст
        public string position = ""; //должность


        //Конструктор = 
        public Person() { }

        //Конструктор с параметрами = 
        public Person(int id, string surname, string name, string secondName)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondName = secondName;
        }

        public string fullName( )
        {
          return  surname + " " + name.Substring(0, 1) + "." + secondName.Substring(0, 1) + "." + id;

     
        }


    }
}
