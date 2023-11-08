using Microsoft.AspNetCore.Mvc;

namespace Bookify.Web.Core.ViewModels {
    public class CategoryFormViewModel {
        public int Id { get; set; }

        [MaxLength(100 , ErrorMessage = "Max length cannot be more than 5 chr.")]
        [Remote("AllowItem" , null , ErrorMessage = "Category With The Same Name Already Exists")] // Allows Server Side validation from Client Side 
        public string Name { get; set; } = null!;
    }
}