using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.Scriptures == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Scriptures.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scriptures.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        EntryDate = DateTime.Parse("2023-2-12"),
                        Entry = "I will go and do"
                    },

                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = 9,
                        Verse = 14,
                        EntryDate = DateTime.Parse("2023-2-13"),
                        Entry = "Perfect Knowledge"
                    },

                    new Scripture
                    {
                        Book = "Jacob",
                        Chapter = 6,
                        Verse = 12,
                        EntryDate = DateTime.Parse("2023-2-14"),
                        Entry = "O be wise"
                    },

                    new Scripture
                    {
                        Book = "Enos",
                        Chapter = 1,
                        Verse = 7,
                        EntryDate = DateTime.Parse("2023-2-15"),
                        Entry = "Lord, how is it done"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
