using System;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int earth_seconds = 31557600;
            int space_seconds = 631154000;

            float earth_age = space_seconds/earth_seconds;
            //Console.WriteLine(earth_age);

            string [] Planet = {"Venus","Mars","Jupiter","Neptune"};
            float [] planet_time = {0.61519724f,1.8808158f,11.8626615f,164.79132f};
            
            

            for (int i = 0; i < Planet.Length; i++)
            {
                float planet_age = earth_age/planet_time[i];        
                Console.WriteLine("Earth age:" +earth_age+ "Earth-years old- " +Planet[i]+":"+planet_age+" Earth-years old");
                               
            }
             
            
        }
    }
}
