using System;
using Application.Interface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Domain.Entities;

namespace DataAccess.Identity
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Các bảng của bạn
        public class AppUser : IdentityUser
        {
            public string Name { get; set; }
        }
        public DbSet<AppUser> Users { get; }
        public DbSet<GiaoDich> GiaoDich { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<LoaiTaiKhoan> LoaiTaiKhoan { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<Token> Tokens { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);   // ← Rất quan trọng cho Identity

            // Nếu bạn có cấu hình thêm cho các entity khác, thêm vào đây
        }
    }
}