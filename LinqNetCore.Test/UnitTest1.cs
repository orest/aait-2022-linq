namespace LinqNetCore.Test {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var s = new OrganizationStats();
            
            //Act 
            var actual = s.GetTotalLeslie();

            //Assert 
            Assert.AreEqual(17,actual);
        }
    }
}