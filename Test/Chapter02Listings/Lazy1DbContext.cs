﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore;

namespace Test.Chapter02Listings
{
    /// <summary>
    /// This uses injection of ILazyLoader into class to do lazy loading
    /// </summary>
    public class Lazy1DbContext : DbContext
    {
        public Lazy1DbContext(DbContextOptions<Lazy1DbContext> options)
            : base(options) { }

        public DbSet<BookLazy1> BookLazy1s { get; set; }
        
    }
}