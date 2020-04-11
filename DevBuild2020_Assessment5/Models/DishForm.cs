using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuild2020_Assessment5.Models
{
    public class DishForm
    {
        private string personName;
        private string phoneNumber;
        private string dishName;
        private string dishDescription;
        private DishSelect selection;

        [DisplayName("Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string PersonName { get => personName; set => personName = value; }

        [DisplayName("Phone")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        [Required]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [Required]
        [DisplayName("Dish")]
        public string DishName { get => dishName; set => dishName = value; }

        [MaxLength(280)]
        [DisplayName("Description")]
        public string DishDescription { get => dishDescription; set => dishDescription = value; }

        [DisplayName("Type")]
        public DishSelect Selection { get => selection; set => selection = value; }

        
    }

    public enum DishSelect
    {
        [Display(Name="Gluten Free")]
        GlutenFree,
        Vegan,
        Vegetarian,
        [Display(Name ="Contains Nuts")]
        ContainsNuts,
        [Display(Name ="None of the Above")]
        NoneOfTheAbove

    }
}
