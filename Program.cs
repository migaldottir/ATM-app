using System

    public class CardHolder

{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public CardHolder(String cardNum, int pin, String firstName, String lastName double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }

    public String getCardNum() { return cardNum; }

    public int getPin() { return pin; }

    public String getFirstName() {  return firstName; }
    public String getLastName() { return lastName; }
    public double getBalance() { return balance; }


    public void setNum(String newNum) { cardNum = newNum }
    public void setPin(int newPin) { setPin = newPin }
    public void setFirstName(String newName) { firstName = newName}
    public void setLastName(String newLast) { lastName = newLast }
    public void setBalance(double newBalance) { balance = newBalance }



    public static void Main(Sting[] args)
    { 
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit (cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit:")
                double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Your new balance is: " + currentUser.getBalance());
        }

        void withdraw (CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw:")
                double withdrawal = Double.Parse(Console.ReadLine());
            //Check if the user has enough money
            if (currentUser.getBalance() > withdrawal)
            { Console.WriteLine("Insufficient balance")


            }
            else

            { currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go!");
            }
        }

    }
}