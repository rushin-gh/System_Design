/*
    Single Responsilibty Principle (SRP) :
        A class should have only one reason to change
        meaning it should have only one responsibility or job

*/

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace Bad_Way
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }

        public User(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
        }
        public void GetUserName()
        {
            // Returns the username of User (Avoid return-type)
        }

        public void UpdateUsername(string userName)
        {
            // Updates UserName
        }

        public void SaveToDatabase()
        {
            // Save Details in DB
        }

        public void SendMail()
        {
            // Sends mail
        }
    }

    /*
    Break Down of class
        1. User Data Management:
            The class is responsible for managing user data, such as userId and userName.
            This includes methods like GetUserName() and UpdateUsername().
    
        2. Database Operations:
            The SaveToDatabase() method is responsible for saving the user's details to the database. 
            This is a separate responsibility related to data persistence.

        3. Email Operations:
            The SendMail() method is responsible for sending an email, which is an entirely different 
            responsibility related to communication.

    Reasons for Change:
        User Data Management Changes
            If the way you handle user data changes (e.g., changing how usernames are updated or retrieved), 
            you'll need to modify the User class.

        Database Operation Changes
            If the database schema changes, or you change the way users are saved to the database, 
            you'll need to modify the User class.

        Email Operation Changes
            If you need to modify how emails are sent, such as changing the email provider or the 
            content of the email, you'll need to modify the User class.

    Total Reasons for Change: Three
        User data management (e.g., methods related to the user properties).
        Database operations (e.g., saving user details to a database).
        Email operations (e.g., sending an email).

    To adhere to the Single Responsibility Principle, you should split this class into multiple classes, 
    each responsible for a single aspect of the functionality.
    */
}

// Solution for Above Problem
namespace Good_Way
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }

        public User(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
        }
        public void GetUserName()
        {
            // Returns the username of User (Avoid return-type)
        }

        public void UpdateUsername(string userName)
        {
            // Updates UserName
        }
    }

    public class DBService
    {
        public void SaveToDatabase()
        {
            // Save Details in DB
        }
    }

    public class EmailService
    {
        public void SendMail()
        {
            // Sends mail
        }
    }
}