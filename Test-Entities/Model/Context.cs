using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Proxies;


namespace Test_Entities.Model
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=77.245.159.10;port=3306; database=feysofttest_;user=feyss;password=FeySS2022*;");
            //optionsBuilder.UseLazyLoadingProxies();

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerQuestion> Answer_Questions { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TicketNote> TicketNotes { get; set; }
        public DbSet<TicketChat> TicketChats { get; set; }
        public DbSet<TicketChatAttachment> TicketChatAttachments { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }
        public DbSet<Notify> Notifies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasOne(x => x.Survey).WithOne()
                 .HasForeignKey<Survey>(x => x.TicketId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Survey>().HasMany(x => x.AnswerQuestion).WithOne().HasForeignKey(x => x.SurveyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>().HasMany(x => x.TicketNotes).WithOne().HasForeignKey(x=>x.TicketId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>().HasMany(x => x.TicketChats).WithOne().HasForeignKey(x => x.TicketId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TicketChat>().HasMany(x => x.TicketChatAttachments).WithOne().HasForeignKey(x => x.TicketChatId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notify>().HasOne(x => x.Ticket).WithMany().HasForeignKey(x => x.TicketId);

            modelBuilder.Entity<Notify>().HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Ticket>().HasOne(x => x.Sender).WithMany().HasForeignKey(x => x.SenderId);

            modelBuilder.Entity<Ticket>().HasOne(x => x.Receiver).WithMany().HasForeignKey(x => x.ReceiverId);

            modelBuilder.Entity<Ticket>().HasMany(x => x.TicketAttachments).WithOne().HasForeignKey(x => x.TicketId);





        }

    }
}
