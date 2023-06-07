using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeSteps
    {
        public string info 
        { 
            get; 
        }

        public RecipeSteps(string stepinfo)
        {

            info = stepinfo;
        
        }
    }
}
