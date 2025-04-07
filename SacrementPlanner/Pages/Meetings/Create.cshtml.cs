using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacrementPlanner.Models;

namespace SacrementPlanner.Pages.Meetings
{
   public class CreateModel : PageModel
   {
      private readonly SacrementPlanner.Data.SacrementPlannerContext _context;

      public CreateModel(SacrementPlanner.Data.SacrementPlannerContext context)
      {
         _context = context;
      }

      [BindProperty]
      public Meeting Meeting { get; set; } = new Meeting();

      public IActionResult OnGet()
      {
         // Initialize with at least one empty speaker if not already populated
         if (Meeting.Speakers.Count == 0)
         {
            Meeting.Speakers.Add(new Speaker());
         }
         return Page();
      }

      public IActionResult OnPostAddSpeaker()
      {
         // Add a new blank speaker to the list
         Meeting.Speakers.Add(new Speaker());
         return Page();
      }

      public async Task<IActionResult> OnPostSubmitAsync()
      {
         if (!ModelState.IsValid)
         {
            return Page();
         }

         // Save meeting and speakers to database
         _context.Meeting.Add(Meeting);
         await _context.SaveChangesAsync();

         return RedirectToPage("./Index");
      }
   }
}