using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT_627_Assessment2_TaxCalculator
{
    class Program
    {
        static void primaryincomeStudentLoan()
        {
            Console.Write("Do you have a New Zealand student loan? (Yes/No)");
            string e = Console.ReadLine();

            if (e=="Yes"||e=="yes"||e=="YES")
            {
                Console.Write("Your tax code is MS L. ");
            }
            else if (e == "no" || e == "No" || e == "NO")
            {
                Console.Write("Your tax code is M. ");
            }
        }
        static void SecondaryTaxCode()
        {
           Console.Write("What is your annual income from all source?");
           int c = Convert.ToInt32(Console.ReadLine());

           if (c <= 14000)
           {
              Console.Write("Do you have a student loan?");
              string d = Console.ReadLine();

              if (d == "yes" || d == "Yes"||d == "YES")
              {
                   Console.Write("Your tax code is SB SL. ");
              }
              else if (d == "no" || d == "No" || d == "NO")
              {
                   Console.Write("Your tax code is SB. ");
              }
           }
           else if (c > 14000 && c <= 48000)
           {
               Console.Write("Do you have a student loan?");
               string d = Console.ReadLine();

               if (d == "yes" || d == "Yes" || d == "YES")
               {
                    Console.Write("Your tax code is S SL. ");
               }
               else if (d == "no" || d == "No" || d == "NO")
               {
                    Console.Write("Your tax code is S. ");
               }
           }
           else if (c > 48000 && c <= 70000)
           {
                Console.Write("Do you have a student loan?");
                string d = Console.ReadLine();

                if (d == "yes" || d == "Yes" || d == "YES")
                {
                     Console.Write("Your tax code is SH SL. ");
                }
                   else if (d == "no" || d == "No" || d == "NO")
                   {
                        Console.Write("Your tax code is SH. ");
                   }
           }
           else
           {
                Console.Write("Do you have a student loan?");
                string d = Console.ReadLine();

                if (d == "yes" || d == "Yes" || d == "YES")
                {
                     Console.Write("Your tax code is ST SL. ");
                }
                else if (d == "no" || d == "No" || d == "NO")
                {
                     Console.Write("Your tax code is ST. ");
                }  
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Do you receive an income tested benefit? (Yes/No)");
            string a = Console.ReadLine();

            if (a =="yes"||a=="Yes" || a == "YES")
            {
                Console.Write("Is this tax code for the income tested benefit? (Yes/No)");
                string b = Console.ReadLine();
                if (b == "yes" || b == "Yes" || b == "YES")
                {
                    Console.Write("Your tax code is M ");
                }
                else if (b == "no" || b == "No" || b == "No")
                {
                    SecondaryTaxCode();
                }
            }
            else if (a == "no" || a == "No" || a == "NO")
            {
                Console.Write("Is this tax code for your main or highest source of income? (Yes/No)");
                string c = Console.ReadLine();

                if(c=="yes" ||c=="YES" || c=="Yes")
                {
                    Console.Write("Are you a New Zealandtax resident? ");
                    string f = Console.ReadLine();

                    if (f == "yes" || f == "YES" || f == "Yes")
                    {
                        Console.Write("Is your annual income likely to be between $24,000 and $48,000? (Yes/No)");
                        string g = Console.ReadLine();

                        if (g == "yes" || g== "YES" || g == "Yes")
                        {

                        }
                        else if (a == "no" || a == "No" || a == "NO")
                        {

                        }
                    }
                    else if (f == "no" || f == "No" || f == "No")
                    {
                        primaryincomeStudentLoan();
                    }
                }
            }
            
        }
    }
}
