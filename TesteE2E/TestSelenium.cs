using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;


namespace TesteE2E
{
    class TestSelenium
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://e2etec.com.br/";
            driver.Manage().Window.Maximize();

            var texto = driver.FindElement(By.Id("panel-w5f11b62f8fe0c-0-0-0")).Text;

            driver.Quit();

            string path = @"C:\temp";
            string pathFile = path + @"\textFile.txt";

            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            
            File.WriteAllText(pathFile, texto);
     
        }
    }
}
