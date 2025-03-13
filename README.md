# 📌 Coding Tasks

## 📝 Overview

This repository contains a collection of simple coding exercises written in C#. Each task is numbered and includes an icon for better readability.

---

### 1️⃣ Freezing Weather ❄️

```csharp
// Display a message if the temperature is freezing

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

```csharp
// Check if a number is even or odd

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

```csharp
// Convert a number (1-9) to its word representation

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

### 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Navigate to the project folder.
3. Compile and run each script in a C# environment.
