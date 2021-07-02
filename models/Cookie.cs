using System;

namespace Classes.models
{
    public class Cookie : Colour
    {
        // template is usally 'public' (so it's callable), 'the name' {get ; set;}
        
        public int Weight {get; set;}
         /* in grams */ 
        public string Shape {get; set;}    

        public Cookie(int weight, string shape, int red, int green, int blue)
        {
            Weight = weight;
            Shape = shape;
            
        }

    }

     // TODO Task 2: Colour Class 
     public class Colour
    {
        public int Red {get; set;}
        public int Green {get; set;}
        public int Blue {get; set;}

        public Colour(int red, int green, int blue)
        {
            Red = red;
            Green = Green;
            Blue = blue;
        }
        
    }
}