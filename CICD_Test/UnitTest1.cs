using CiCD_AWSProject.Controllers;

namespace CICD_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckNameTest()
        {
            NameController nameController = new NameController();
            var actual=nameController.GetName();
            var expected = "Hello";
            Assert.AreEqual(expected, actual);  
            
        }
    }
}