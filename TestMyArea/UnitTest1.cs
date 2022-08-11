using NUnit.Framework;
using MyArea;
using System.Collections.Generic;
namespace TestMyArea
{
    public class Tests
    {
        Area areas;
       
        [SetUp]
        public void Setup()
        {
            areas = new Area();
           
        }
        [TearDown]
        public void Close()
        {
            areas = null;
        }
        [Test]
        public void Test1()
        {   
            Assert.Pass();
        }
        [Test]
        public  void CircleTest()
        {
            //Arrange 
            //Area areas = new Area();
            float expresult = 75;
            float actresult = 0;
            actresult = areas.Circle(5);
            //Assert
            Assert.AreEqual(expresult, actresult,5,"Areas not matching");
         }
        [Test]
        public void TriangleTest()
        {
            //Area area = new Area();
            float expresult = 12;
            float actresult = 0;
            actresult = areas.Triangle(5, 5);
            Assert.AreEqual(expresult, actresult,5, "Areas not matching");
        }

        [Test]

        [TestCase(30,20,ExpectedResult = 600)]
        [TestCase(40,10,ExpectedResult =300)]
        [TestCase(25,25,ExpectedResult = 625)]
        [TestCase(90,90,ExpectedResult =8100)]
        [TestCase(60,60, ExpectedResult =3600)]

        public int RectangleTest(int l, int b)
        {
            int actresult = areas.Rectangle(l, b);
            return actresult;
        }

        [Test]
        [TestCase(3,5,ExpectedResult = 90)]
        [TestCase(4,6,ExpectedResult =12)]
        public float     TrTest(int b, int h)
        {
            float actresult = areas.Triangle(b, h);
            return actresult;
        }

        //[Test]
        //[TestCase("Admin","Admin",ExpectedResult ="Welcome Admin")]
        //[TestCase("Admin", "Admin123", ExpectedResult = "Welcome Admin")]

        //public string Logintest(string admin, string pass)
        //{
        //    string actresult = areas.Login(admin, pass);
        //    return actresult;
        //}
        [Test]
        public void Null_Message()
        {
            string expresult = "Username or pass null";
            string actresult = areas.Login("Tom", null);
            Assert.AreEqual(expresult, actresult, "Message not matching");
        }
        [Test]
        public void Login_Success()
        {
            string expresult = "Welcome Admin";
            string actresult = areas.Login("Admin", "Admin");
            Assert.AreEqual(expresult, actresult, "Message not matching");
        }
        [Test]
        public void Invalid_user()
        {
            string expresult = "Invalid User";
            string actresult = areas.Login("Tom", "Tom123");
            StringAssert.Contains("Invalid", actresult);
        }
        [Test]
        public void Names_Contains_Null()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreNotNull(names, "Null values present");
        }
        [Test]
        public void Names_has_Unique()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreUnique(names, "Null values not present");
        }
        [Test]
        public void Debit_Check()
        {
            Banking banking = new Banking { id = 1, name = "Jitin",Balance= 40000 };
            banking.Debit(5000);
            Assert.AreEqual(35000, banking.Balance, "Balance not Matching");
        }
        [Test]
        public void Credit_Message_Check()
        {
            Banking banking = new Banking { id = 2, name="Anshul", Balance=30000};
            string expresult = "Amount < 0";
            string actresult = null;
            Assert.AreEqual(expresult, actresult, "Balance not matching");
            //banking.Credit(-1500);
            //Assert.AreEqual(31500, banking.Balance, "Balance do not match");
        }
    }
}