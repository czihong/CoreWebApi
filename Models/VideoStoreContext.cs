using Microsoft.EntityFrameworkCore;

namespace CoreWebApi.Models
{
    public partial class VideoStoreContext : DbContext
    {
        public virtual DbSet<MicrosoftUser> MicrosoftUser { get; set; }
        public virtual DbSet<WeChatUser> WeChatUser { get; set; }
        public virtual DbSet<WebUser> WebUser { get; set; }
        
        public VideoStoreContext(DbContextOptions<VideoStoreContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MicrosoftUser>(entity =>
            {
                entity.HasIndex(e => e.MicrosoftName)
                    .HasName("IDX_MicrosoftName");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MicrosoftName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<WeChatUser>(entity =>
            {
                entity.HasIndex(e => e.OpenId)
                    .HasName("IDX_OpenId");

                entity.HasIndex(e => e.UnionId)
                    .HasName("IDX_UnionId");

                entity.Property(e => e.City).HasMaxLength(256);

                entity.Property(e => e.Country).HasMaxLength(256);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.OpenId)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Privilege).HasMaxLength(256);

                entity.Property(e => e.Province).HasMaxLength(256);

                entity.Property(e => e.Sex).HasMaxLength(256);

                entity.Property(e => e.UnionId)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<WebUser>(entity =>
            {
                entity.HasIndex(e => e.Mail)
                    .HasName("IDX_Mail");

                entity.HasIndex(e => e.Phone)
                    .HasName("IDX_Phone");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Mail).HasMaxLength(256);

                entity.Property(e => e.MicrosoftId).HasMaxLength(256);

                entity.Property(e => e.OrgId).HasMaxLength(256);

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.QqId).HasMaxLength(256);

                entity.Property(e => e.SinaWeiboId).HasMaxLength(256);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.WeChatId).HasMaxLength(256);
            });
        }
    }
}