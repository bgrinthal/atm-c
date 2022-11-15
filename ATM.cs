using System;

public class cardHolder
{
    // variables
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    //constructor
    public cardHolder(String cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNumb = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    //getters for each variable
    public String getNum()
    {
        return cardNum
    }

    public int getPin()
    {
        return cardPin
    }

    public String getLastName()
    {
        return lastName
    }

    public String getFirstName()
    {
        return firstName
    }

    public double getBalance()
    {
        return balance
    }

    //setters for each variable
    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        cardPin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }    

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentBalance) //?????
            Console.WriteLine("Thank you for you $$.  Your new balanceis: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //Check if user has enough money to withdraw
            if(currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insuficient balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Transaction complete, thank you!")
            }
        }

    }

}