using Library.EntityModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Kerberos;

namespace Library.DbContex
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> context) : base(context)
        {

        }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Mkitxveli> Book_Mkitxvelis { get; set; }
        public DbSet<BookInfo> BookInfos { get; set; }
        public DbSet<Mkitxveli> Mkitxvelis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .HasKey(autor => autor.Id);

            modelBuilder.Entity<Autor>()
                .Property(Autor => Autor.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Book>()
                .HasKey(book => book.Id);

            modelBuilder.Entity<Book>()
                .Property(book => book.Id)
                .ValueGeneratedOnAdd();


            //modelBuilder.Entity<Book>()
            //    .HasOne(Autor => Autor.Book_Autor)
            //    .WithMany(Booki => Booki.Autor_Books)
            //    .HasForeignKey(book => book.AutorId);

            modelBuilder.Entity<Autor>()
                .HasMany(booki => booki.Autor_Books)
                .WithOne(autor => autor.Book_Autor)
                .HasForeignKey(x => x.AutorId);

            modelBuilder.Entity<BookInfo>()
                .HasKey(bookinf => bookinf.Id);

            modelBuilder.Entity<BookInfo>()
                .Property(bookinf => bookinf.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<BookInfo>()
                .HasOne(bookinf => bookinf.Booki)
                .WithOne(x => x.Book_Info)
                .HasForeignKey<BookInfo>(x => x.Book_Id);

            modelBuilder.Entity<Mkitxveli>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Mkitxveli>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();



            modelBuilder.Entity<Book_Mkitxveli>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Book_Mkitxveli>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Book_Mkitxveli>()
                .HasOne(x=> x.Book_book)
                .WithMany(x=> x.Mkitxveli_book)
                .HasForeignKey(x=>x.BookID)
                .IsRequired(false);

            modelBuilder.Entity<Book_Mkitxveli>()
                .HasOne(x => x.Mkitxveli_Mkitxveli)
                .WithMany(x => x.Book_mkitxveli)
                .HasForeignKey(x => x.MkitxveliID)
                .IsRequired(false);
        }



    }


}
