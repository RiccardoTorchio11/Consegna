//Author:       Riccardo Torchio
//Created Date: 12/03/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
public static class Program
{
    public static void Main(string[] args)
    {

            string Consegnabile = "\n No match found \n"; ;//final string
            if (args.Length!=0)
        {
            string path1;
            Int32 Posizione;
            string Chiave;
             
            if (args.Length == 3 )
            {
                //getting the elements from console
                    path1 = args[0];
                    Posizione = Int32.Parse(args[1]);
                    Chiave = args[2];
                
                Console.Write("args.Length" + args.Length + "\n");
                    try
                    {
                        using (StreamReader sr = new StreamReader(@"" + path1))
                        {
                            string line;
                            string[] F1;//rows of the csv
                            
                            while ((line = sr.ReadLine()) != null)
                            {
                                F1 = line.Split(';');

                                for (int i = 0; i < F1.Length; i++)
                                {
                                    
                                    string[] F2 = line.Split(',');//columns of the csv
                                    for (int y = 0; y < F2.Length; y++)
                                    {
                                        if (y==Posizione)//this is one of the inputs
                                        {
                                            if (F2[y]==Chiave)//this is the key of the input
                                            {
                                                Consegnabile = F1[i];//got it!
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                    catch (Exception e)
                    {
                        // something went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }

            }
            else
            {//wrong input
                Console.WriteLine("\n Wrong number of arguments.\n");
            }
                
        }//right output
            Console.WriteLine(Consegnabile);
    }

}
}
