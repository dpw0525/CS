// whole computer 
using System; 
// name of file 
namespace CountingCharacters
{
     class Program
    { // public then static void main string and args for arguements 
       public static void Main(string[] args)
        {
            // string and the value of it which is a sentence
            // foreach is a value of a character 
            const string
            value = "Time will not slow down when something unpleasant lies ahead!";
            foreach (char a in value)
            {
                //tell the console to write the line 
                Console.WriteLine (a);
            }
                   Dictionary<char, int> diclist = new Dictionary< char, int> ();
                Console.WriteLine("Enter string");
                
                foreach (var chr in Console.ReadLine())
          {
            int count = 0;
            if(diclist.ContainsKey(chr))
            {
              count = diclist[chr];
            
            } 
            diclist[chr] = count +1; 
                }
                foreach (KeyValuePair<char, int> pair in diclist)
                {
                    Console.WriteLine(pair.Key + " = " + pair.Value);
                }
            Console.ReadLine();
        }
    }    
}
// PLEASE READ NOTE BELOW 
// when prompt to enter string, you'll need to enter the full STRING: 
// "Time will not slow down when something unpleasant lies ahead!"