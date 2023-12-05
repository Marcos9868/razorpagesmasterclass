using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages
{
  public class Index : PageModel
  {
    public List<Category> Categories { get; set; } = new();
    
    public async Task OnGet()
    {
      await Task.Delay(5000);
      for (int i = 0; i <= 100; i++)
      {
        Categories.Add(
          new Category(i, $"Categoria {i}", 18.95M)
        );
      }
    }

    public void OnPost()
    {
      
    }
  }

  public record Category(int Id, string Title, decimal Price)
  {

  }
}