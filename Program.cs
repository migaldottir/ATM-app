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
        void balance (CardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List <CardHolder> cardHolders= new List<CardHolder>();
        cardHolders.Add(new cardHolder("1212121212121212", 1234, "John", "Griffith", 150.21));
        cardHolders.Add(new cardHolder("2323232323232323", 1111, "Ashley", "Jones", 321.13));
        cardHolders.Add(new cardHolder("3131313131313131", 2222, "Frida", "Dickerson", 105.59));
        cardHolders.Add(new cardHolder("1414141414141414", 3333, "Muneeb", "Harding", 851.84));
        cardHolders.Add(new cardHolder("3434343434343434", 4444, "Dawn", "Smith", 54.27));

        //Prompt user

        Console.WriteLine("Welcome to SimpleATM!");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = " ";
        CardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against db (list of users)
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again.")}
            }

            catch { Console.WriteLine("Card not recognized. Please try again.")}
        }
    }
}