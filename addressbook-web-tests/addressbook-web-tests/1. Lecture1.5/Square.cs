using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{  
    class Square : Figure // :Figure означаетч, что наследует данные от класса Figure и свои собственные имеет
    {   
        private int size; //size - поле size (объект. Локальная переменная)
        private bool colored = false; //квадрат не закрашен

        public Square(int size) // Создание конструктора. Он называется так же, как и класс. Параметр size возвращаемого значения не указывается. Т.к он возвращает объект этого типа. Новый создаваемый объект. Указываются параметры - size. 

        {
            this.size = size;  //this - ссылка на текущий объект. В его поле помещаем значение, переданное в качестве параметра

        }
        public int Size
        { 
            get 
            { 
                return size;
            } 
            set
            {  
                size = value; 
            }
        }
    }
}
