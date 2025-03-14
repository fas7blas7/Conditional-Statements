# 📌 Coding Tasks

## 📝 Overview

This repository contains a collection of simple coding exercises written in C#. Each task is numbered and includes an icon for better readability.

---

### 1️⃣ Freezing Weather ❄️

// This program checks if the entered temperature is freezing (≤ 0°C) and prints a message if true.

```csharp
namespace _1_FreezingWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }        
        }
    }
}
```

---

### 2️⃣ Even or Odd 🔢

// Determines whether the given number is even or odd.

```csharp
namespace _2_EvenOrOdd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
```

---

### 3️⃣ Numbers as Words 📝

// Converts a number between 1 and 9 to its corresponding word.

```csharp
namespace _3_NumbersAsWords
{
    internal class NumbersAsWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 1 && number < 10)
            {
                Console.WriteLine("one");
            }
            else if (number == 2 && number < 10)
            {
                Console.WriteLine("two");
            }
            else if (number == 3 && number < 10)
            {
                Console.WriteLine("three");
            }
            else if (number == 4 && number < 10)
            {
                Console.WriteLine("four");
            }
            else if (number == 5 && number < 10)
            {
                Console.WriteLine("five");
            }
            else if (number == 6 && number < 10)
            {
                Console.WriteLine("six");
            }
            else if (number == 7 && number < 10)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8 && number < 10)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9 && number < 10)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
```

---

### 4️⃣ Greater Number 🔢

// Compares two numbers and prints the greater one.

```csharp
namespace _4_GreaterNumber
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Greater number: {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Greater number: {secondNumber}");
            }
        }
    }
}
```

---

### 5️⃣ Guess The Password 🔑

// Checks if the entered password matches "s3cr3t!".

```csharp
namespace _5_GuessThePassword
{
    internal class GuessThePassword
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
```

---

### 6️⃣ Boiling Water 💧

// Determines if the water temperature is above 100°C.

```csharp
namespace _6_BoilingWater
{
    internal class BoilingWater
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());

            if (temperature > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}
```

---

### 7️⃣ Speed Info 🚗

// Classifies a given speed as "Slow" or "Fast" based on a threshold.

```csharp
namespace _7_SpeedInfo
{
    internal class SpeedInfo
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 30)
            {
                Console.WriteLine("Slow");
            }
            else
            {
                Console.WriteLine("Fast");
            }
        }
    }
}
```

---

### 8️⃣ Ticket Price 🎟️

// Determines the ticket price based on whether the user is a student or regular customer.

```csharp
namespace _8_TicketPrice
{
    internal class TicketPrice
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            double studentTicketPrice = 1.00;
            double regularTicketPrice = 1.60;

            if(ticketType == "student")
            {
                Console.WriteLine($"${studentTicketPrice:F2}");
            }
            else if (ticketType == "regular")
            {
                Console.WriteLine($"${regularTicketPrice:F2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}
```

---

### 9️⃣ Valid Triangle 🔺

// Checks if three given side lengths can form a valid triangle.

```csharp
namespace _9_Valid_Triangle
{
    internal class ValidTriangle
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }
        }
    }
}
```

---

### 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Navigate to the project folder.
3. Compile and run each script in a C# environment.
