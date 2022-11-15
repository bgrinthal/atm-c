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
                Console.WriteLine("Transaction complete, thank you!");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        // random users
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4637184756916402", 1234, "Ben", "Grinthal", 150.31));
        cardHolders.Add(new cardHolder("4562958263458258", 4421, "Chloe", "Grace", 321.45));
        cardHolders.Add(new cardHolder("9395868983549673", 9999, "Cleo", "Cleeb", 105.27));
        cardHolders.Add(new cardHolder("5676452847523456", 2468, "Honey", "Badger", 1004.12));
        cardHolders.Add(new cardHolder("2342145266726456", 4826, "Kristen", "Bland", 639.78));


        //Prompt users
        Console.WriteLine("Welcome, please enter your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // Checks against our 'DB'
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized.  Please try again"); }
            }
            catch { Console.WriteLine("Card not recognized.  Please try again"); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while(true)
        {
            try
            {
                userPin =int.Parse(Console.ReadLine());
                // Checks against our 'DB'
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin.  Please try again"); }
            }
            catch { Console.WriteLine("Incorrect pin.  Please try again"); }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch {  }
            if(option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        } while (option != 4);
        Console.WriteLine("Thank you, have a nice day!")
    }

}