using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Code
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction Paragraph Maker!!");

            Console.Write("Write your FULL name: ");
            string name = Console.ReadLine();

            Console.Write("Write your age (in numbers): ");
            string age = Console.ReadLine();

            Console.Write("Specify your gender: ");
            string sex = Console.ReadLine();

            Console.Write("Input your date of birth (DD/MM/YYYY): ");
            string dob = Console.ReadLine();

            Console.Write("Your height (Feet'inches): ");
            string height = Console.ReadLine();

            Console.Write("Your weight (in Kgs): ");
            string weight = Console.ReadLine();

            Console.Write("Specify where you live (City): ");
            string city = Console.ReadLine();

            Console.Write("Specify where you live (State): ");
            string state = Console.ReadLine();

            Console.Write("Specify where you live (Country): ");
            string country = Console.ReadLine();

            Console.Write("Enter your Mothers Name (Full): ");
            string mother_name = Console.ReadLine();

            Console.Write("Enter your Fathers Name (Full): ");
            string father_name = Console.ReadLine();

            Console.Write("Specify the name of your colony: ");
            string colony = Console.ReadLine();

            Console.Write("Name of your school (no adress required): ");
            string school = Console.ReadLine();

            Console.Write("Specify favorate subject: ");
            string subject = Console.ReadLine();

            Console.Write("Specify favorate sport: ");
            string sport = Console.ReadLine();

            Console.Write("Which career do you want to persue (Just Specify FEILD name): ");
            string career = Console.ReadLine();


            Console.WriteLine(
                "Though, it is quite hard to write about yourself yet I have tried my best to express all about it."+
                " Hailing from a working class family, My name is " + name +" and I am a "+ age +" year old "+ sex +" and was born on "+ dob +
                ". I am "+ height+" in height and weigh "+ weight +" kgs. My hometown, where I live is "+ city +", a city of "+ state +" in "+ country +". I live with my mother "+ mother_name +"," +
                " and my father "+ father_name +"." +
                " Both my parents are hardworking and try to keep me happy, thats why I want to give them the best life possible when I grow up. "+
                " We are the residents of "+ colony +". It is pretty cool here with people having great minds!" +
                " The school is a place that truly helps shaping one’s personality." +
                " My school is like another Godsend gift for me. It is one of the best school in our entire vicinity." +
                " We are truly cared, rightly educated and well socialized here at our school." +
                " I myself feel proud of being a student of "+ school +
                ". The service of humanity is the best of all services." +
                " What I have learnt myself from my experience and struggles is that one should never cease working hard, be confident, positive and adoptable to all situations." +
                " Being very ambitious and hard working I learnt mid way thorough that my motto in life is to strive for service before self." +
                " I have great interest in "+ subject +" and in my free time i like playing sports like "+ sport +" to stimulate myself both physically and mentally." +
                " Being ambitious and interested in learning new things I want to persue my career in "+ career +
                " I try myself to be humble, passionate, dedicated, hardworking and honest." +
                " I hope this comprehensive auto character sketch has provided you with some insight to my personality and character." +
                "Thanks for reading!");


            Console.ReadLine();
        }
    }
}