
using NUnit.Framework;
using OpenQA.Selenium;


namespace DataDrivenTesting
{
     public class ReadDataFromFile : BaseClass.Base
    {
        [Test]
        public void ReadingDataFromExcelTestMethod()
        {
            AccessExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\DataDrivenTesting\DataDrivenTesting\TestData.xlsx");
            driver.FindElement(By.Name("email")).SendKeys(AccessExcelData.ReadData(1, "Username"));
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("pass")).SendKeys(AccessExcelData.ReadData(1, "Password"));
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(8000);


        }


    }
}
