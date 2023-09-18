using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab1.Models;

namespace lab1.Pages;

public class ZodiacModel : PageModel
{
    [BindProperty]
    public int Year {get; set;}
    public bool IsValidYear {get; set;}
    public bool DisplayError {get; set;}
    public string? Zodiac {get; set;}
    public string? ZodiacPath {get; set;}

    public ZodiacModel()
    {
        Year = DateTime.Now.Year;
        IsValidYear = false;
        DisplayError = false;
    }

    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        int nextYear = DateTime.Now.Year + 1;
        if (IsValidYear = Year > 1900 && Year <= nextYear)
        {
            Zodiac = Utils.GetZodiac(Year);
            ZodiacPath = $"/images/{Zodiac}.png";
        }

        DisplayError = !IsValidYear;
    }
}