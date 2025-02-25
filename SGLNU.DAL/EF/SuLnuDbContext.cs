﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SGLNU.DAL.Entities;

namespace SGLNU.DAL.EF
{
    public class SuLnuDbContext : IdentityDbContext<AppUser>
    {
        public SuLnuDbContext(DbContextOptions<SuLnuDbContext> options)
            : base(options)
        {
        }
        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Voting> Votings { get; set; }
        public DbSet<Candidate> Candidates{ get; set; }
        public DbSet<Vote> Votes{ get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
