﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.Parse("FA1DD227-ADEC-4942-9057-195B214B305A"),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec",
                ViewCount = 15,
                CategoryId = Guid.Parse("4C569A9A-5F41-478F-9D17-69AC5B02AE0B"),
                ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                CreatedBy = "Admin Test",
                CreatedDate = new DateTime(2025, 3, 13, 13, 30, 4, 725),
                IsDeleted = false,
                UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
            },
             new Article
             {
                 Id = Guid.Parse("5304C949-5680-45B7-97F9-4A4C108B0B4B"),
                 Title = "Visual Studio Deneme Makalesi 1",
                 Content = "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec",
                 ViewCount = 15,
                 CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                 ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                 CreatedBy = "Admin Test",
                 CreatedDate = new DateTime(2025, 3, 13, 13, 30, 4, 725),
                 IsDeleted = false,
                 UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
             });
        }
    }
}
