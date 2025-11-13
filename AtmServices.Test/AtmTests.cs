namespace AtmServices.Test
{
    public class AtmTests
    {
        Atm testAtm;
        int initialBalance = 100;

        public AtmTests()
        {
            testAtm = new Atm(initialBalance);
        }

        [Fact]
        public void Test_Withdraw()
        {
            var result = testAtm.Withdraw(25);
            Assert.True(result);
            Assert.Equal(75, testAtm.GetBalance());
        }
    }
}
