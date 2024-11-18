using System.Net;
using System.Runtime.InteropServices;
using ProductCategory.Data;
using ProductCategory.Models;
using static System.Console;

namespace ProductCategory
{
    internal class Program
    {
        static ProductCategoryContext context = new ProductCategoryContext();
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("");
                WriteLine("1. Skapa artikel");
                WriteLine("2. Skapa kategori");
                WriteLine("3. Lägga till artikel till kategori");
                WriteLine("4. Skriv ut kategorier och artikelar");
                WriteLine("5. Registrera artikel");
                WriteLine("5. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);
                Clear();
                switch (keyPressed.Key)
                {
                    // New employee
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CreateArticle();
                        break;
                    // List employees
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //CreateCategory();
                        ReadKey(true);
                        break;
                    // Add department
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        ReadKey(true);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        shouldNotExit = true;
                        break;
                }

                Clear();
            }
        }

        private static void CreateArticle()
        {
            bool isCorrect = false;
            do
            {
                Clear();
                Write("ArticleNumber: ");
                string articleNumber = ReadLine();
                Write("Namn: ");
                string name = ReadLine();
                
                WriteLine();
                WriteLine("Är detta korrekt? (J)a eller (N)ej");
                ConsoleKeyInfo keyPressed;
                bool isValidKey = false;
                do
                {
                    keyPressed = ReadKey(true);
                    isValidKey = keyPressed.Key == ConsoleKey.J ||
                                 keyPressed.Key == ConsoleKey.N;
                } while (!isValidKey);
                if (keyPressed.Key == ConsoleKey.J)
                {
                    //context.Customer.Any(x => x.SocialSecurityNumber == socialSecurityNumber)
                    if (context.Article.FirstOrDefault(x => x.ArticleNumber == articleNumber) != null)
                    {
                        WriteLine("Article finns redan");
                    }
                    else
                    {
                        Article article = new Article(articleNumber, name);

                        context.Article.Add(article);
                        context.SaveChanges();

                        WriteLine("Article registerad");
                    }

                    Thread.Sleep(2000);
                    Clear();

                    isCorrect = true;
                }
            } while (!isCorrect);
        }
    }
}
