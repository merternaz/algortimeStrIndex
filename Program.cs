using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
         static void Main(string[] args)
        {
            int x=0;
            string s="";
            try{
                Console.WriteLine("Sözcük giriniz: ");
                 s=Console.ReadLine();

            }catch(FormatException e){
                Console.WriteLine("Lütfen sözcük giriniz !");
            }

             try{
                Console.WriteLine("Index giriniz: ");
                 x=Convert.ToInt32(Console.ReadLine());

            }catch(FormatException e){
                Console.WriteLine("Lütfen sayı giriniz !");
                
            }



            Fırlat(x,s);


        }

        public static void Fırlat(int ind,string s){

            s=s.Remove(ind,1);
            Console.WriteLine(" Sonuc: "+s);
        }

    }
}
