using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Class1
    {
        static RecipeName[] recipes; //creates an array for the recipe name

        static int Count;  // declares the count for displaying and scaling the recipe

        public void FirstClass() 
        
        {
            {
                recipes = new RecipeName[100000]; // 

                Count = 0; 

                string AppIsRunning = "yes";  // declares a string which is responsible for terminating and keeping the program running

                while (AppIsRunning == "yes")
                {

                    Console.WriteLine("Menu \n1. Add a Recipe \n2. Display a Recipe " +
                                    "\n3. Scale a Recipe \n" +
                                    "4. Reset Recipe \n5. Close \n");  // asks the user to select an option from the menu.

                    string Option = Console.ReadLine();

                    Console.WriteLine();

                    switch (Option) // calls the modules from the selected option
                    {

                        case "1":

                            AddRecipe();

                            break;

                        case "2":

                            DisplayARecipe();

                            break;

                        case "3":

                            ScaleARecipe(3);

                            break;

                        case "4":

                            ScaleARecipe(4);

                            break;

                        case "5":

                            AppIsRunning = "no"; // ends the program

                            break;


                        default:

                            Console.WriteLine("please select a valid option"); 

                            break;
                    }

                    Console.WriteLine();
                }
            }



        }



        static void AddRecipe() // this code adds a recipe
        {


            RecipeName recipe = new RecipeName(); // creates an object

            Console.Write("Please Enter the Recipe name: "); // asks the user to input the neame of the recipe

            string RecipeName = Console.ReadLine();
            recipe.Name = RecipeName;

            Console.Write("Enter the number of ingredients: "); // asks the user to input the number of ingredients

            int ingredientCount = int.Parse(Console.ReadLine());

            recipe.Ingredients = new Ingredients[ingredientCount];

            for (int i = 0; i < ingredientCount; i++)

            {
                Console.WriteLine("\nEnter Ingredient " + (i + 1) + " :");

                Console.Write("\nEnter the Name of the ingredeint: "); // asks the user to input the number of ingredients
                string ingredientName = Console.ReadLine();

                Console.Write("\nMeasuring Unit of Measurement (tea spoon, table spoon or cup): "); // asks the user to input the Measuring unit
                string Measurementunit = Console.ReadLine();

                Console.Write("\nEnter the Quantity : "); // asks the user to input the quantity
                float MUquantity = float.Parse(Console.ReadLine());

                Console.Write("\nEnter ingredient Calories: "); // asks the user to input the number of calories
                int Ingredientcalories = int.Parse(Console.ReadLine());

                Console.Write("\nEnter the Food Group: ");
                string IngredientfoodGroup = Console.ReadLine();

                Ingredients ingredient = new Ingredients(ingredientName, MUquantity, Measurementunit, Ingredientcalories, IngredientfoodGroup); // this code adds the recipe info to getters and setters 

                recipe.Ingredients[i] = ingredient; // stores the info in an array

            }

            Console.Write("\nEnter the number of steps: ");  // asks the user to enter number for steps
            int numsteps = int.Parse(Console.ReadLine());

            recipe.Steps = new RecipeSteps[numsteps]; 

            for (int i = 0; i < numsteps; i++)
            {

                Console.WriteLine("Step " + i + 1 + " :");
                Console.Write(" \nEnter Steps description: "); // asks the user to enter the steps
                string Stepsdescription = Console.ReadLine();

                RecipeSteps step = new RecipeSteps(Stepsdescription);
                recipe.Steps[i] = step; //stores the steps in an array

            }

            recipes[Count] = recipe;
            Count++;

            Console.WriteLine("\n The recipe has been added");

            Console.Write("------------------------------------------------------------------");
        }




        static void DisplayARecipe() //this code displays the recipe 
        {

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($" {i + 1}. {recipes[i].Name}");
            }

            Console.WriteLine();
            Console.Write("Enter recipe you would like to display: "); // asks the user to select a recipe to display
            int displayRecipe = int.Parse(Console.ReadLine());

            if (displayRecipe >= 1 && displayRecipe <= Count)
            {
                RecipeName chosenRecipe = recipes[displayRecipe - 1];

                Console.WriteLine("Recipe");
                Console.WriteLine($"Name: {chosenRecipe.Name} ");
                Console.WriteLine("Ingredients : ");

                foreach (Ingredients ingredient in chosenRecipe.Ingredients)

                {

                    Console.WriteLine($" {ingredient.IngredientQuantity} {ingredient.IngredientMU} of {ingredient.IngredientName} "); // this code displays the recipe

                }

                Console.WriteLine(" Steps:");

                for (int i = 0; i < chosenRecipe.Steps.Length; i++)

                {

                    Console.WriteLine($"{i + 1}. {chosenRecipe.Steps[i].info}");

                }

                Console.WriteLine($"  Calories: { chosenRecipe.TotalCalories()}"); // displays the number of calories

                if (chosenRecipe.TotalCalories() > 300)

                {
                    Console.WriteLine(" Calories exceed 300!"); // this code displays when the calories exceed 300


                }

            }
            else
            {

                Console.WriteLine("Option is invalid!"); 

            }

            Console.Write("------------------------------------------------------------------");
        }




        static void ScaleARecipe(int option) // this code scales and resets the recipe quantity
        {

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($" {i + 1}. {recipes[i].Name}");
            }

            Console.Write("Enter the number of your selected recipe: "); // asks the user to select a recipe to scale

            int recipeNum = int.Parse(Console.ReadLine());
            double Scale;
            double x;

            if (recipeNum >= 1 && recipeNum <= Count && option == 3) // this code scales the recipe quantity
            {
                

                RecipeName chosenRecipe = recipes[recipeNum - 1];

                Console.Write("How much would you like to scale it by :  \n - 0.5 \n - 2 \n - 3): \n "); // asks the user how much they would like to scale the recipe

                string inpt = Console.ReadLine();
                Scale = Convert.ToDouble(inpt);

                foreach (Ingredients ingredient in chosenRecipe.Ingredients)
                {

                    ingredient.IngredientQuantity *= Scale; // does the calculation to 

                }


            }
            else
            {

                Console.WriteLine("Please Enter a valid number ");

            }



            if (recipeNum >= 1 && recipeNum <= Count && option == 4) // this code resets the recipe quantity
            {
                

                RecipeName chosenRecipe = recipes[recipeNum - 1];

                Console.Write("How much did you scale it by :  \n - 0.5 \n - 2 \n - 3): \n "); 

                string inpt = Console.ReadLine();
                Scale = Convert.ToDouble(inpt);


                foreach (Ingredients ingredient in chosenRecipe.Ingredients)
                {

                    ingredient.IngredientQuantity /= Scale;

                }


            }
            else
            {

                Console.WriteLine(" Enter a valid number ");

            }

            Console.Write("------------------------------------------------------------------");

        }

    }


}


        
    

