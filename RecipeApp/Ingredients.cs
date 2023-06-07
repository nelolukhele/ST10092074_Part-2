using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Ingredients
    {

        public string IngredientName
        { 
            get; 
        }

        public double IngredientQuantity
        { 
            get;
            
            set; 
        }

        public string IngredientMU
        { 
            get; 
        }

        public int IngredientCalories
        { 
            get; 
        }

        public string IngredientFG
        { 
            get; 
        }

        public Ingredients(string name, double quantity, string unit, int calories, string fg)
        {
            IngredientName = name;

            IngredientMU= unit;

            IngredientQuantity = quantity;

            IngredientCalories = calories;

            IngredientFG = fg;
        }
    }
}
