﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using BibliotekaKlas;

namespace WarsztatV2
{

    /// <summary>
    /// Klasa zajmująca się obsługą połączenia z bazą danych
    /// </summary>
    internal class databaseConnection : DbContext
    {
        public databaseConnection()
        {
            Configuration.ProxyCreationEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
        }
        
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Warsztat> Warsztaty { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Pojazd> Pojazdy { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Faktura> Faktury { get; set; }
        public DbSet<Naprawa> Naprawy { get; set; }
        public DbSet<Czesc> Czesci { get; set; }
        public DbSet<Uzyte_czesci> Uzyte_czesci { get; set; }
        public DbSet<Dane_logowania> Dane_logowania { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warsztat>().ToTable("warsztat", "public");
            modelBuilder.Entity<Adres>().ToTable("adres", "public");
            modelBuilder.Entity<Pracownik>().ToTable("pracownik", "public");
            modelBuilder.Entity<Pojazd>().ToTable("pojazd", "public");
            modelBuilder.Entity<Klient>().ToTable("klient", "public");
            modelBuilder.Entity<Faktura>().ToTable("faktura", "public");
            modelBuilder.Entity<Naprawa>().ToTable("naprawa", "public");
            modelBuilder.Entity<Czesc>().ToTable("czesc", "public");
            modelBuilder.Entity<Uzyte_czesci>().ToTable("uzyte_czesci", "public");
            modelBuilder.Entity<Dane_logowania>().ToTable("dane_logowania", "public");

            modelBuilder.Conventions.Add<StoreGeneratedIdentityKeyConvention>(); //Obsługa autoinkrementacji indentyfikatorów w tabelach
        }
    }
}