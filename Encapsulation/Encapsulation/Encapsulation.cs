namespace Encapsulation
{
    public class Bank
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please Pass a Positive Value");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank();
                
                //We cannot access the Amount Variable directly
                //bank.Amount = 50; //Compile Time Error
                //Console.WriteLine(bank.Amount); //Compile Time Error
                
                //Setting Positive Value
                bank.SetAmount(25000);
                Console.WriteLine(bank.GetAmount());
                
                //Setting Negative Value
                bank.SetAmount(-150);
                Console.WriteLine(bank.GetAmount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}