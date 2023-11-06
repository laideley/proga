using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor_exchange
{
    internal class Labor
    {
        private static string[] name = File.ReadAllLines(@"C:\labor_exchange_database\data\name.txt");
        private static string[] company = File.ReadAllLines(@"C:\labor_exchange_database\data\company.txt");
        private static string[] stack = File.ReadAllLines(@"C:\labor_exchange_database\data\stack.txt");
        private static string[] city = File.ReadAllLines(@"C:\labor_exchange_database\data\city.txt");
        private static string[] salary = File.ReadAllLines(@"C:\labor_exchange_database\data\salary.txt");
        private static string path = @"C:\labor_exchange_database\data\";
        public static string[] name_get()
        {
            return Labor.name;
        }

        public static string[] company_get()
        {
            return Labor.company;
        }
        public static string[] city_get()
        {
            return Labor.city;
        }
        public static string[] stack_get()
        {
            return Labor.stack;
        }

        public static string[] salary_get()
        {
            return Labor.salary;
        }

        public static void addElem(string name, string company, string stack, string city, string salary)
        {
            File.AppendAllText(path + "name.txt", name + "\n");
            File.AppendAllText(path + "company.txt", company + "\n");
            File.AppendAllText(path + "stack.txt", stack + "\n");
            File.AppendAllText(path + "city.txt", city + "\n");
            File.AppendAllText(path + "salary.txt", salary + "\n");
            Labor.name = File.ReadAllLines(path + "name.txt");
            Labor.company = File.ReadAllLines(path + "company.txt");
            Labor.stack = File.ReadAllLines(path + "stack.txt");
            Labor.city = File.ReadAllLines(path + "city.txt");
            Labor.salary = File.ReadAllLines(path + "salary.txt");
        }

        public static void removeV(string name)
        {
            int num = Labor.name.ToList().IndexOf(name);
            List<string> list = Labor.name.ToList<string>();
            List<string> list2 = Labor.company.ToList<string>();
            List<string> list3 = Labor.stack.ToList<string>();
            List<string> list4 = Labor.city.ToList<string>();
            List<string> list5 = Labor.salary.ToList<string>();
            list.Remove(name);
            list2.Remove(Labor.name_get()[num]);
            list2.Remove(Labor.company_get()[num]);
            list3.Remove(Labor.stack_get()[num]);
            list4.Remove(Labor.city_get()[num]);
            list4.Remove(Labor.salary_get()[num]);
            Labor.name = list.ToArray();
            Labor.company = list2.ToArray();
            Labor.stack = list3.ToArray();
            Labor.city = list4.ToArray();
            Labor.salary = list5.ToArray();
            File.WriteAllLines(path + "name.txt", Labor.name);
            File.WriteAllLines(path + "company.txt", Labor.company);
            File.WriteAllLines(path + "stack.txt", Labor.stack);
            File.WriteAllLines(path + "city.txt", Labor.city);
            File.WriteAllLines(path + "salary.txt", Labor.salary);
        }
        private static ArrayList responses = new ArrayList();

        public static ArrayList responses_get()
        {
            return Labor.responses;
        }

        public static void responses_add(int quantity)
        {
            Labor.responses.Add(quantity.ToString());
        }

        public static void responses_remove(int index)
        {
            Labor.responses.RemoveAt(index);
        }

        public static void responses_clear()
        {
            Labor.responses.Clear();
        }

    }
}
