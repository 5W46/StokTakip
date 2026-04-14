using StokTakip.Models;

namespace StokTakip.Helpers
{
    public static class DatabaseHelper
    {
        public static void EnsureDatabaseCreated()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}