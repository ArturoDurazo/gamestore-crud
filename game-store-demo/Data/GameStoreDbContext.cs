using game_store_demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_store_demo.Data
{
    public class GameStoreDbContext : DbContext
    {
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options) : base(options)
        {

        }
        //remember to add-migration message and update-migration when
        //adding a new table or making changes
        public DbSet<VideoGame> VideoGame { get; set; }
    }
}
