using Microsoft.EntityFrameworkCore;
using SacrementPlanner.Data;
using System.Collections;

namespace SacrementPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacrementPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacrementPlannerContext>>()))
            {
                if (context == null || context.Meeting == null)
                {
                    throw new ArgumentNullException("Null RazorPagesSacrementPlannerContext");
                }

                // Look for any movies.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        Date = DateTime.Parse("2025-4-6"),
                        OpeningHymn = "27 Praise To the Man",
                        OpeningPrayer = "Sister Jones",
                        IntermediateNumber = "124 Where Can I Turn For Peace",
                        Conducting = "Brother Smith",
                        ClosingHymn = "7 Israel, Israel God Is Calling",
                        ClosingPrayer = "Brother Jones",
                        SacramentHymn = "193 I Stand All Amazed",
                        Speakers = [new() { Name = "Sister Brown", Subject = "Repentance"}, new() { Name = "Brother Johnson", Subject = "Faith"}]
                    },
                    new Meeting
                    {
                        Date = DateTime.Parse("2025-4-13"),
                        OpeningHymn = "27 Praise To the Man",
                        OpeningPrayer = "Sister Jones",
                        IntermediateNumber = "124 Where Can I Turn For Peace",
                        Conducting = "Brother Smith",
                        ClosingHymn = "7 Israel, Israel God Is Calling",
                        ClosingPrayer = "Brother Jones",
                        SacramentHymn = "193 I Stand All Amazed",
                        Speakers = [new() { Name = "Brother Brown", Subject = "Baptism"}, new() { Name = "Sister Johnson", Subject = "Enduring"}]
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
