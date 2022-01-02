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
    [TestFixture]
    public class TestSizeRadius
    {
        [Test]
        public void Square() //Создаем объекты класса Square в методе Test
        {
            //Создал переменные s1, s2, s3 присвоил ссылку на новый объект класса Square. Каждый вызов конструктора создает объект. Дальше можно на него ссылаться из нескольких мест: Передавать его в качестве параметров методы, присваивать переменные. Когда никто больше не ссылается, объект исчезает
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            //проверяем, что размер первого квадрата = 5, второго = 10, третьего = 5
            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;
            Assert.AreEqual(s1.Size, 15);

            s2.Colored = true;

        }

        [Test]
        public void Circle() 
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Radius, 5);
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = 15;
            Assert.AreEqual(s1.Radius, 15);

            s2.Colored = true;
        }
    }
}
