using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public class SimpleDriver                    //класс отвечает за создание нового экземпляра браузера
{
    public IWebDriver Driver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            //return new ChromeDriver(
            //    @"C:\Users\edini\source\repos\TeachMeSkills\AQA_MTS_new\SeleniumBasic\Resources\");  //плохой вариант запуска

            //return new ChromeDriver(path + @"/Resources/");

            return new ChromeDriver(basePath + @"/Resources/");
            //return new ChromeDriver(); еще такой вариант, когда скачана соответствующая версия селениум веб драйвер и хром драйвер, но он тоже не ок
        }
    }
}