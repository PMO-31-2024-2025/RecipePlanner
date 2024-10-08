using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("meal")]
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }
        public int FoodPlanId { get; set; }

        [ForeignKey(nameof(FoodPlanId))]
        public FoodPlan FoodPlan { get; set; } = null!;
        public List<DishMeal> DishMeals { get; set; } = null!;

        public override string ToString()
        {
            return $"Title: {Title}; Protein: {Protein}; Carbs: {Carbs}; Fat: {Fat}; Calories: {Calories}";
        }
    }
}
