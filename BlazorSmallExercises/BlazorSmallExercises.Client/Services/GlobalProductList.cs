using static BlazorSmallExercises.Client.Pages.ProductForm;

namespace BlazorSmallExercises.Client.Services
{
    public class GlobalProductList : IGlobalProductList
    {
        public List<Productmodel> Products { get; set; } = new List<Productmodel>();
        public event Action? OnChange;
        public void AddProduct(Productmodel product)
        {
            Products.Add(product);
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
