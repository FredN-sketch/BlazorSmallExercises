using BlazorSmallExercises.Client.Pages;

namespace BlazorSmallExercises.Client.Services
{
    public interface IGlobalProductList
    {
        List<ProductForm.Productmodel> Products { get; set; }

        event Action? OnChange;

        void AddProduct(ProductForm.Productmodel product);
    }
}