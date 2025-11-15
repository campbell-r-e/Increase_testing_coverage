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



        [Fact]
        public void Test_Deposit_value()
        {
            var result = testAtm.Deposit(25);
            Assert.True(result);
            Assert.Equal(125, testAtm.GetBalance());
        }




        [Fact]
        public void Test_Deposit()
        {
            var result = testAtm.Deposit(0);
            Assert.False(result);
           
        }




        [Fact]
        public void Test_Withdrawl_false()
        {
            var result = testAtm.Withdraw(0);
            Assert.False(result);
           
        }
    }
}
