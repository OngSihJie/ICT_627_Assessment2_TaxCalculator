using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ICT_627_Assessment2_TaxCalculator
{
    class Program
    {

        static void primaryincomeStudentLoan() //function for primary income student loan 
        {
            Console.Write("Do you have a New Zealand student loan? (Yes/No)");
            string e = Console.ReadLine();

            if (string.Equals(e, "yes", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Your tax code is MS L. ");//output
            }
            else if (string.Equals(e, "no", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Your tax code is M. ");//output
            }
        }
        static void SecondaryTaxCode() //function for secondary 
        {
            Console.Write("What is your annual income from all source?");//ask for annual income
            int c = Convert.ToInt32(Console.ReadLine());

            if (c <= 14000)//less than 14000
            {
                Console.Write("Do you have a student loan? (Yes/No)");
                string d = Console.ReadLine();//store the input

                if (string.Equals(d, "yes", StringComparison.InvariantCultureIgnoreCase))//this code can aceept YES, yes, Yes, YEs, yES, yeS, yEs
                {
                    Console.WriteLine("Your tax code is SB SL. ");//output
                }
                else if (string.Equals(d, "no", StringComparison.InvariantCultureIgnoreCase))//accept No, no, NO, nO
                {
                    Console.WriteLine("Your tax code is SB. ");//output
                }
            }
            else if (c > 14000 && c <= 48000)// between 14000 and 48000
            {
                Console.Write("Do you have a student loan? (Yes/No)");//student loan?
                string d = Console.ReadLine();

                if (string.Equals(d, "yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is S SL. ");//output
                }
                else if (string.Equals(d, "no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is S. ");//output
                }
            }
            else if (c > 48000 && c <= 70000)//between 48000 and 70000
            {
                Console.Write("Do you have a student loan? (Yes/No)");//student loan?
                string d = Console.ReadLine();

                if (string.Equals(d, "yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is SH SL. ");//output
                }
                else if (string.Equals(d, "no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is SH. ");//output
                }
            }
            else
            {
                Console.Write("Do you have a student loan? (Yes/No)");//student loan?
                string d = Console.ReadLine();

                if (string.Equals(d, "yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is ST SL. ");//output
                }
                else if (string.Equals(d, "no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your tax code is ST. ");//output
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)//will start over again
            {
                Console.WriteLine("Please select the operation below");
                Console.WriteLine("A- Identify tax code");//first choice for tax code identifying
                Console.WriteLine("B- Calculation take home pay after tax deduction");//second choice for calculation
                string ans = Console.ReadLine();
                if (string.Equals(ans, "a", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("Do you receive an income tested benefit? (Yes/No)");
                    string a = Console.ReadLine();

                    if (string.Equals(a, "yes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write("Is this tax code for the income tested benefit? (Yes/No)");
                        string b = Console.ReadLine();
                        if (string.Equals(b, "yes", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("Your tax code is M ");//output
                        }
                        else if (string.Equals(b, "no", StringComparison.InvariantCultureIgnoreCase))
                        {
                            SecondaryTaxCode();//call function
                        }
                    }
                    else if (string.Equals(a, "no", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write("Is this tax code for your main or highest source of income? (Yes/No)");
                        string c = Console.ReadLine();

                        if (string.Equals(c, "yes", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.Write("Are you a New Zealandtax resident? ");
                            string f = Console.ReadLine();

                            if (string.Equals(f, "yes", StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.Write("Is your annual income likely to be between $24,000 and $48,000? (Yes/No)");
                                string g = Console.ReadLine();

                                if (string.Equals(g, "yes", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    Console.Write("Are you or your partner entitled to Working for Families Tax Credits or an overseas equivalent or do you receive NZ Super, veteran's pension or an overseas equivalent?  (Yes/No)");
                                    string h = Console.ReadLine();

                                    if (string.Equals(h, "yes", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        primaryincomeStudentLoan();//call function
                                    }
                                    else if (string.Equals(h, "no", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Console.Write("Do you have a New Zealand student loan? (Yes/No)");
                                        string e = Console.ReadLine();

                                        if (string.Equals(e, "yes", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Console.WriteLine("Your tax code is ME SL. ");//output
                                        }
                                        else if (string.Equals(e, "no", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Console.WriteLine("Your tax code is ME. ");//output
                                        }
                                    }
                                }
                                else if (string.Equals(a, "no", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    primaryincomeStudentLoan();//call function
                                }
                            }
                            else if (string.Equals(f, "no", StringComparison.InvariantCultureIgnoreCase))
                            {
                                primaryincomeStudentLoan();//call function
                            }
                        }
                        else if (string.Equals(c, "no", StringComparison.InvariantCultureIgnoreCase))
                        {
                            SecondaryTaxCode();//call function
                        }
                    }

                }
                else if (string.Equals(ans, "b", StringComparison.InvariantCultureIgnoreCase))
                {
                    while (true)//will start over again 
                    {
                        try
                        {
                            Console.WriteLine("What is your annual income?");
                            double ai = Convert.ToDouble(Console.ReadLine());
                            double iafterdeduction; double tax; double takehomepay;
                            if (ai <= 14000)
                            {
                                tax = ai * 0.105;
                                iafterdeduction = ai - tax;// calculate income after tax
                                Console.WriteLine($"Your total tax is {tax}");//show tax
                                Console.WriteLine($"Your take-home pay is {iafterdeduction}");//show the take-home pay annually
                                Console.WriteLine("Do you wish to calculate the take-home pay weekly, fornightly or monthly");
                                string doit = Console.ReadLine();

                                if (string.Equals(doit, "weekly", StringComparison.InvariantCultureIgnoreCase))//weekly
                                {
                                    takehomepay = iafterdeduction / 52;
                                    Console.WriteLine($"Your weekly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "fortnightly", StringComparison.InvariantCultureIgnoreCase))//fortnightly
                                {
                                    takehomepay = iafterdeduction / 26;
                                    Console.WriteLine($"Your fortnightly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "monthly", StringComparison.InvariantCultureIgnoreCase))//monthly
                                {
                                    takehomepay = iafterdeduction / 12;
                                    Console.WriteLine($"Your monthly pay is {takehomepay}. ");
                                }
                                else
                                {
                                    Console.WriteLine("Please input properly!");//error message
                                }
                                break;
                            }
                            else if (ai > 14000 && ai <= 48000)
                            {
                                tax = (ai - 14000) * 0.175 + 1470;
                                iafterdeduction = ai - tax;//calculate income after tax
                                Console.WriteLine($"Your total tax is {tax}");
                                Console.WriteLine($"Your take-home pay is {iafterdeduction}");
                                Console.WriteLine("Do you wish to calculate the take-home pay weekly, fornightly or monthly");
                                string doit = Console.ReadLine();

                                if (string.Equals(doit, "weekly", StringComparison.InvariantCultureIgnoreCase))//weekly
                                {
                                    takehomepay = iafterdeduction / 52;
                                    Console.WriteLine($"Your weekly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "fortnightly", StringComparison.InvariantCultureIgnoreCase))//fortnightly
                                {
                                    takehomepay = iafterdeduction / 26;
                                    Console.WriteLine($"Your fortnightly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "monthly", StringComparison.InvariantCultureIgnoreCase))//monthly
                                {
                                    takehomepay = iafterdeduction / 12;
                                    Console.WriteLine($"Your monthly pay is {takehomepay}. ");
                                }
                                else
                                {
                                    Console.WriteLine("Please input properly!");//improper action
                                }
                                break;
                            }
                            else if (ai > 48000 && ai <= 70000)
                            {
                                tax = (ai - 48000) * 0.3 + 1470 + 5950;
                                iafterdeduction = ai - tax;
                                Console.WriteLine($"Your total tax is {tax}");
                                Console.WriteLine($"Your take-home pay is {iafterdeduction}");//show take-home pay
                                Console.WriteLine("Do you wish to calculate the take-home pay weekly, fornightly or monthly");//ask for next calculation
                                string doit = Console.ReadLine();

                                if (string.Equals(doit, "weekly", StringComparison.InvariantCultureIgnoreCase))//weekly
                                {
                                    takehomepay = iafterdeduction / 52;
                                    Console.WriteLine($"Your weekly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "fortnightly", StringComparison.InvariantCultureIgnoreCase))//fortnightly
                                {
                                    takehomepay = iafterdeduction / 26;
                                    Console.WriteLine($"Your fortnightly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "monthly", StringComparison.InvariantCultureIgnoreCase))//monthly
                                {
                                    takehomepay = iafterdeduction / 12;
                                    Console.WriteLine($"Your monthly pay is {takehomepay}. ");
                                }
                                else
                                {
                                    Console.WriteLine("Please input properly!");//show error message
                                }
                                break;
                            }
                            else if (ai > 70000)
                            {
                                tax = (ai - 70000) * 0.33 + 1470 + 5950 + 6600;
                                iafterdeduction = ai - tax;
                                Console.WriteLine($"Your total tax is {tax}");
                                Console.WriteLine($"Your take-home pay is {iafterdeduction}");
                                Console.WriteLine("Do you wish to calculate the take-home pay weekly, fornightly or monthly");
                                string doit = Console.ReadLine();

                                if (string.Equals(doit, "weekly", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    takehomepay = iafterdeduction / 52;
                                    Console.WriteLine($"Your weekly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "fortnightly", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    takehomepay = iafterdeduction / 26;
                                    Console.WriteLine($"Your fortnightly pay is {takehomepay}. ");
                                }
                                else if (string.Equals(doit, "monthly", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    takehomepay = iafterdeduction / 12;
                                    Console.WriteLine($"Your monthly pay is {takehomepay}. ");
                                }
                                else
                                {
                                    Console.WriteLine("Please input properly!");
                                }
                                break;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Please enter your income properly!!");//show error message
                            Console.WriteLine();
                        }
                    
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please input properly! Choose either A or B");//show error message
                    Console.WriteLine();
                }
            }
        }
    }
}
