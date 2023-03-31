/*Monil Patel
Student Id:- 8775412
Assignment - 3 - Selenium Tests*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DefaultSuiteTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void test01ValidDataAge25DrivingExperience3Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen St N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        driver.FindElement(By.CssSelector(".card-body")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }
    [Test]
    public void test02ValidDataAge25DrivingExperience3Accidents4()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Street N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void test03ValidDataAge35DrivingExperience10Accidents2()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen St N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }
    [Test]
    public void test04InvalidPhoneNumberAge27DrivingExperience3Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437971549000");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    }
    [Test]
    public void test05InvalidEmailAddressAge28DrivingExperience3Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen St N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }
    [Test]
    public void test06InvalidPostalCodeAge35DrivingExperience17Accidents1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("123456789");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }
    [Test]
    public void test07AgeOmittedDrivingExperience5Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }
    [Test]
    public void test09YearsOfExperienceOmittedAge45DrivingExperience0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }
    [Test]
    public void test08AccidentsOmittedAge37DrivingExperience8()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void test10InvalidAgeAge14DrivingExperience1Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).SendKeys("4379715490");
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("14");
        driver.FindElement(By.Id("experience")).SendKeys("1");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
    }
    [Test]
    public void test11InvalidDrivingExperienceAge20DrivingExperience25Accidents2()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen St N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("30");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
        }
    }
    [Test]
    public void test12FirstNameOmittedAge25DrivingExperience2Accidents1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("2");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
    }
    [Test]
    public void test13LastNameOmittedAge30DrivingExperience5Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("lastName-error")).Text, Is.EqualTo("Last Name is required"));
    }
    [Test]
    public void test14CityOmittedAge40DrivingExperience10Accidents5()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("57 Queen Street N");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.16323002@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("40");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("5");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("city-error")).Text, Is.EqualTo("City is required"));
    }
    [Test]
    public void test15AddressOmittedAge50DrivingExperience25Accidents1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Monil");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2H 6T7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("437-971-5490");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("monil.1632003@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("50");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("25");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("address-error")).Text, Is.EqualTo("Address is required"));
    }
}
