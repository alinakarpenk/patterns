using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class SupportMenu
    {
        public string Title { get; set; }
        public List<SupportMenu> SubMenus { get; set; }
        public Action Action { get; set; }
        public SupportMenu(string title, List<SupportMenu> subMenus, Action action = null)
        {
            Title = title;
            SubMenus = subMenus;
            Action = action;
        }
        public void Display()
        {
            Console.WriteLine(Title);
            if (SubMenus != null && SubMenus.Count > 0)
            {
                for (int i = 0; i < SubMenus.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {SubMenus[i].Title}");
                }
                Console.WriteLine("Enter number choosed:");
                int choice = GetChoice(SubMenus.Count);
                if (choice > 0 && choice <= SubMenus.Count)
                {
                    if (SubMenus[choice - 1].Title == "Return to main menu")
                    {
                        return;
                    }
                    SubMenus[choice - 1].Display();
                }
            }
            else if (Action != null)
            {
                Action.Invoke();
            }
        }
        public int GetChoice(int optionsCount)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > optionsCount)
            {
                Console.WriteLine("Wrong choice");
            }
            return choice;
        }
    }
}
