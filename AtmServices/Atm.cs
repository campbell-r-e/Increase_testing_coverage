namespace AtmServices
{
    public class Atm
    {
        private int balance;

        public Atm(int initialBalance)
        {
            balance = initialBalance;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= 0 || amount > balance)
                return false;

            balance -= amount;
            return true;
        }

        public bool Deposit(int amount)
        {
            if (amount <= 0)
                return false;

            balance += amount;
            return true;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
