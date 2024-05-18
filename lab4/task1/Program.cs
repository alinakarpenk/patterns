using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SupportMenu mainMenu = new SupportMenu("Main Menu", new List<SupportMenu>
            {
                new SupportMenu("Technical problems", new List<SupportMenu>
                {
                    new SupportMenu("Problems with the Internet", null, () => HandleTechnicalProblem("Internet")),
                    new SupportMenu("Problems with the phone", null, () => HandleTechnicalProblem("Phone")),
                    new SupportMenu("Return to the main menu", null)
                }),
                new SupportMenu("Service questions", new List<SupportMenu>
                {
                    new SupportMenu("Tariff change", null, () => HandleServiceQuestion("Tariff")),
                    new SupportMenu("Promotions and offers", null, () => HandleServiceQuestion("Promotions")),
                    new SupportMenu("Return to the main menu", null)
                }),
                new SupportMenu("Billing questions", new List<SupportMenu>
                {
                    new SupportMenu("Errors in the account", null, () => HandleBillingQuestion("Errors")),
                    new SupportMenu("Questions about payment", null, () => HandleBillingQuestion("Payment")),
                    new SupportMenu("Return to the main menu", null)
                }),
                new SupportMenu("Other questions", new List<SupportMenu>
                {
                    new SupportMenu("Registration questions", null, () => HandleOtherQuestion("Registration")),
                    new SupportMenu("Other questions", null, () => HandleOtherQuestion("Others")),
                    new SupportMenu("Return to the main menu", null)
                })
            });

            while (true)
            {
                mainMenu.Display();
            }
        }
        static void HandleTechnicalProblem(string problem)
        {
            Console.WriteLine($"Handling technical problem: {problem}");
        }
        static void HandleServiceQuestion(string question)
        {
            Console.WriteLine($"Handling service question: {question}");
        }
        static void HandleBillingQuestion(string question)
        {
            Console.WriteLine($"Handling billing question: {question}");
        }
        static void HandleOtherQuestion(string question)
        {
            Console.WriteLine($"Handling other question: {question}");
        }
    }
}
