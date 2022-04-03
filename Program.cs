using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB2 A

            // VARIABLE 1 (STRING DATATYPE)
            string myName = "Blessing Arowele";
            Console.WriteLine("Line11:" + myName);
            
            // VARIABLE 2 (DOUBLE DATATYPE)
            double GBPtoUSD = 1.31;
            Console.WriteLine("Line15:" + GBPtoUSD);

            // VARIABLE 3 (INTEGER DATATYPE)
            int myAge = 26;
            Console.WriteLine("Line19:" + myAge);

            // VARIABLE 4 (BYTE DATATYPE)
            byte myhouseaddressbytwo = 123*2;
            Console.WriteLine("Line23:" + myhouseaddressbytwo);
            
            // VARIABLE 5 (LONG DATATYPE)
            long ElonMuskWorth = 267300000000;
            Console.WriteLine("Line27:" + ElonMuskWorth);

            // VARIABLE 6 (FLOAT DATATYPE)
            float onethirdofmyshoesize = 40/3F;
            Console.WriteLine("Line31:" + onethirdofmyshoesize);

            // VARIABLE 7 (STRING INTERPOLATION DATATYPE)
            string firstName = "Blessing";
            string secondname = "Clinton";
            string lastName = "Arowele";
            string nickname = "ABC";
            string fullName = $"Mr. {firstName} {secondname} {lastName}, Nickname: {nickname}";
            Console.WriteLine("Line39:" + fullName);

            // VARIABLE 8 (DATETIME DATATYPE)
            DateTime myDOB = new DateTime(1995, 12, 08, 09, 05, 00, DateTimeKind.Utc);
            Console.WriteLine("Line43:" + myDOB);

            // VARIABLE 9 (DYNAMIC DATATYPE)
            dynamic myHobby = "Researching";
            Console.WriteLine("Line47:" + myHobby);

            // VARIABLE 9 (DYNAMIC DATATYPE2)
            dynamic myHobby2 = "Researching";
            Console.WriteLine("Line51:" + myHobby.GetType());

            // VARIABLE 10 (NULLABLE DATATYPE)
            Nullable<int> Mybatterypower = null;
            Console.WriteLine("Line55:" + Mybatterypower);

            // VARIABLE 10 (NULLABLE DATATYPE)
            Mybatterypower = 63;
        	Console.WriteLine("Line58:" + Mybatterypower);    
            

            // LAB2 B
            // IMPLICIT CONVERSION
                // float onethirdofmyshoesize = 40/3F;
            double onethirdofmyshoesizeDouble = onethirdofmyshoesize;
            Console.WriteLine("Line68:" + onethirdofmyshoesizeDouble);


            // EXPLICIT CONVERSION
                // double GBPtoUSD = 1.31;
            int GBPtoUSDInt = (int) GBPtoUSD;
            Console.WriteLine("Line74:" + GBPtoUSDInt);		    

        }
    }
}
