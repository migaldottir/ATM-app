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

    public String getCardNum() {
        return cardNum; }

    public int getPin() { return pin;
    }

    public String getFirstName() { 
        return firstName; }
    public String getLastName() { 
        return lastName; }
    public double getBalance() { 
        return balance; }


    public void setNum(String newNum) { cardNum = newNum }
    public void setPin(int newPin) { setPin = newPin }
    public void setFirstName(String newName) { firstName = newName}
    public void setLastName(String newLast) { lastName = newLast }
    public void setBalance(double newBalance) { balance = newBalance }



    public static void Main(Sting[] args)
    { 
    }
}