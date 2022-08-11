using NUnit.Framework;
using MyArea;

namespace TestMyArea
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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
            Area areas = new Area();
            float expresult = 75;
            float actresult = 0;
            actresult = areas.Circle(5);
            //Assert
            Assert.AreEqual(expresult, actresult,5,"Areas not matching");
         }
        [Test]
        public void TriangleTest()
        {
            Area area = new Area();
            float expresult = 12f;
            float actresult = 0;
            actresult = area.Triangle(6, 4);
            Assert.AreEqual(expresult, actresult, "Areas not matching");
        }
    }
}