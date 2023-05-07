using System;

namespace PrivateMultipleObjects
{
    class Club
    {
        private string name;
        private int foundationYear;
        private string country;

        public Club()
        {
            this.name = "";
            this.foundationYear = 0;
            this.country = "";
        }

        public Club(string name, int foundationYear, string country)
        {
            this.name = name;
            this.foundationYear = foundationYear;
            this.country = country;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetFoundationYear()
        {
            return this.foundationYear;
        }

        public void SetFoundationYear(int year)
        {
            this.foundationYear = year;
        }

        public string GetCountry()
        {
            return this.country;
        }

        public void SetCountry(string country)
        {
            this.country = country;
        }

        public virtual void Add()
        {
            Console.WriteLine("Adding a new Club...");
        }

        public virtual void Change()
        {
            Console.WriteLine("Changing an existing Club...");
        }

        public virtual void Display()
        {
            Console.WriteLine("Displaying a Club...");
        }
    }

    class NerdClub : Club
    {
        private string topic;
        private int memberCount;

        public NerdClub()
        {
            this.topic = "";
            this.memberCount = 0;
        }

        public NerdClub(string name, int foundationYear, string country, string topic, int memberCount)
            : base(name, foundationYear, country)
        {
            this.topic = topic;
            this.memberCount = memberCount;
        }

        public string GetTopic()
        {
            return this.topic;
        }

        public void SetTopic(string topic)
        {
            this.topic = topic;
        }

        public int GetMemberCount()
        {
            return this.memberCount;
        }

        public void SetMemberCount(int count)
        {
            this.memberCount = count;
        }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Adding a new Nerd Club...");
        }

        public override void Change()
        {
            base.Change();
            Console.WriteLine("Changing an existing Nerd Club...");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Displaying a Nerd Club...");
        }
    }

    class Program
    {
        static Club[] baseClassArray = new Club[10];
        static NerdClub[] derivedClassArray = new NerdClub[10];
        static int baseClassIndex = 0;
        static int derivedClassIndex = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Base Club");
                Console.WriteLine("2. Add Derived Nerd Club");
                Console.WriteLine("3. Change Base Club");
                Console.WriteLine("4. Change Derived Nerd Club");
                Console.WriteLine("5. Delete Base Club");
                Console.WriteLine("6. Delete Derived Nerd Club");
                Console.WriteLine("7. Display Base Clubs");
                Console.WriteLine("8. Display Derived Nerd Clubs");
                Console.WriteLine("9. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBaseClub();
                        break;
                    case 2:
                        AddDerivedNerdClub();
                        break;
                    case 3:
                        ChangeBaseClub();
                        break;
                    case 4:
                        ChangeDerivedNerdClub();
                        break;
                    case 5:
                        DeleteBaseClub();
                        break;
                    case 6:
                        DeleteDerivedNerdClub();
                        break;
                    case 7:
                        DisplayBaseClubs();
                        break;
                    case 8:
                        DisplayDerivedNerdClubs();
                        break;
                    case 9:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void AddBaseClub()
        {
            Console.Write("Enter Club name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Club foundation year: ");
            int foundationYear = int.Parse(Console.ReadLine());

            Console.Write("Enter Club country: ");
            string country = Console.ReadLine();

            baseClassArray[baseClassIndex++] = new Club(name, foundationYear, country);
            Console.WriteLine("Base Club added successfully.");
        }

        static void AddDerivedNerdClub()
        {
            Console.Write("Enter Nerd Club name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Nerd Club foundation year: ");
            int foundationYear = int.Parse(Console.ReadLine());

            Console.Write("Enter Nerd Club country: ");
            string country = Console.ReadLine();

            Console.Write("Enter Nerd Club topic: ");
            string topic = Console.ReadLine();

            Console.Write("Enter Nerd Club member count: ");
            int memberCount = int.Parse(Console.ReadLine());

            derivedClassArray[derivedClassIndex++] = new NerdClub(name, foundationYear, country, topic, memberCount);
            Console.WriteLine("Derived Nerd Club added successfully.");
        }

        static void ChangeBaseClub()
        {
            Console.Write("Enter the index of the Base Club you want to change: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < baseClassIndex)
            {
                Console.Write("Enter new Club name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new Club foundation year: ");
                int foundationYear = int.Parse(Console.ReadLine());

                Console.Write("Enter new Club country: ");
                string country = Console.ReadLine();
                baseClassArray[index].SetName(name);
                baseClassArray[index].SetFoundationYear(foundationYear);
                baseClassArray[index].SetCountry(country);

                Console.WriteLine("Base Club changed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void ChangeDerivedNerdClub()
        {
            Console.Write("Enter the index of the Derived Nerd Club you want to change: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < derivedClassIndex)
            {
                Console.Write("Enter new Nerd Club name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new Nerd Club foundation year: ");
                int foundationYear = int.Parse(Console.ReadLine());

                Console.Write("Enter new Nerd Club country: ");
                string country = Console.ReadLine();

                Console.Write("Enter new Nerd Club topic: ");
                string topic = Console.ReadLine();

                Console.Write("Enter new Nerd Club member count: ");
                int memberCount = int.Parse(Console.ReadLine());

                derivedClassArray[index].SetName(name);
                derivedClassArray[index].SetFoundationYear(foundationYear);
                derivedClassArray[index].SetCountry(country);
                derivedClassArray[index].SetTopic(topic);
                derivedClassArray[index].SetMemberCount(memberCount);

                Console.WriteLine("Derived Nerd Club changed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DeleteBaseClub()
        {
            Console.Write("Enter the index of the Base Club you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < baseClassIndex)
            {
                for (int i = index; i < baseClassIndex - 1; i++)
                {
                    baseClassArray[i] = baseClassArray[i + 1];
                }

                baseClassIndex--;
                Console.WriteLine("Base Club deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DeleteDerivedNerdClub()
        {
            Console.Write("Enter the index of the Derived Nerd Club you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < derivedClassIndex)
            {
                for (int i = index; i < derivedClassIndex - 1; i++)
                {
                    derivedClassArray[i] = derivedClassArray[i + 1];
                }

                derivedClassIndex--;
                Console.WriteLine("Derived Nerd Club deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DisplayBaseClubs()
        {
            Console.WriteLine("\nBase Clubs:");
            for (int i = 0; i < baseClassIndex; i++)
            {
                Console.WriteLine($"\nBase Club {i + 1}:");
                baseClassArray[i].Display();
            }
        }

        static void DisplayDerivedNerdClubs()
        {
            Console.WriteLine("\nDerived Nerd Clubs:");
            for (int i = 0; i < derivedClassIndex; i++)
            {
                Console.WriteLine($"\nDerived Nerd Club {i + 1}:");
                derivedClassArray[i].Display();
            }
        }
    }
}