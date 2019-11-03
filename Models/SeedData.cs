using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Title = "Alma teaches Helaman",
                        EntryDate = DateTime.Parse("2019-2-12"),
                        Book = "The Book of Mormon",
                        ScripturePassage = "Alma 37",
                        Note = "Learn wisdom in thy youth."
                    },

                    new Scripture
                    {
                        Title = "Alma teaches Shiblon",
                        EntryDate = DateTime.Parse("2019-2-12"),
                        Book = "The Book of Mormon",
                        ScripturePassage = "Alma 38",
                        Note = "Learn wisdom in thy youth."
                    },

                    new Scripture
                    {
                        Title = "Alma teaches Coriantum",
                        EntryDate = DateTime.Parse("2019-2-12"),
                        Book = "The Book of Mormon",
                        ScripturePassage = "Alma 40",
                        Note = "The spirits of all men are brought back to God who granted them life."
                    },

                    new Scripture
                    {
                        Title = "Jesus teaches about being a light",
                        EntryDate = DateTime.Parse("2019-2-12"),
                        Book = "The Bible",
                        ScripturePassage = "Mathew 5",
                        Note = "We need to be a light to the world."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
