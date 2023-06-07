using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeName
    {
        public string Name 
        { 
            get; 
            
            set; 
        }

        public Ingredients[] Ingredients 
        { 
            get; 
            
            set; 
        }
        
        public RecipeSteps[] Steps 
        { 
            get; 
           
            set; 
        }

        public int TotalCalories()
        {
            int totalcalories = 0;

            foreach (Ingredients ingredient in Ingredients)
            {

                totalcalories += ingredient.IngredientCalories; // this code calculats the total calories

            }
            return totalcalories;
        }
    }
}
