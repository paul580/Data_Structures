using System;
using System.Collections.Generic;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genericts; <>
          List<string> movieNames = new List<string>();

          movieNames.Add("Pulp Fiction");
          movieNames.Add("Harry Potter");
          movieNames.Add("Pacific Rim");

          Console.WriteLine(movieNames[1]);

          //El set no permite valores duplicados
          HashSet<string> movieNames2 = new HashSet<string>();

          movieNames2.Add("Bad Boys");
          movieNames2.Add("Bad Boys");

          movieNames2.Add("The Avengers");
          movieNames2.Add("The Avengers");

          Console.WriteLine(movieNames2.Count);

          HashSet<Movie> moviesSet = new HashSet<Movie>();

          moviesSet.Add(new Movie("Bad Boys", 1983));
          moviesSet.Add(new Movie("Bad Boys", 1995));

          Console.WriteLine(moviesSet.Count);

          Dictionary<string, string>  favoriteColors = new Dictionary<string, string>();

          favoriteColors.Add("Johnny", "Azul");
          favoriteColors.Add("Jack", "Negro");
          favoriteColors.Add("Ruperto", "Gris");

          //Cual es el color favorito de Jack?
          string JackFavoriteColor = favoriteColors.GetValueOrDefault("Jack");
          System.Console.WriteLine($"JackFavoriteColor = {JackFavoriteColor}");

          int[] numbers = new int[3] {1, 2, 3};

          for (int i = 0; i < numbers.Length; i++)
          {
              System.Console.WriteLine(numbers[i]);
          }
 
            foreach (var number in numbers) {
               System.Console.WriteLine(number);
            }
 
             foreach (var key in favoriteColors.Keys) 
             {
                 System.Console.WriteLine(key);
             }

           foreach (var values in favoriteColors.Values)
           {
               System.Console.WriteLine(values);
           } 
         }
    }
}
