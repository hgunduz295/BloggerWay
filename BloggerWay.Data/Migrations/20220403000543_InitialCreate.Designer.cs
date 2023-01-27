﻿// <auto-generated />
using System;
using BloggerWay.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BloggerWay.Data.Migrations
{
    [DbContext(typeof(BloggerWayContext))]
    [Migration("20220403000543_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CommentCount")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("varchar(9999)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("character varying(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ViewCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(1855),
                            Date = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(969),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(2310),
                            Note = "C# .Net5 özellikleri",
                            SeoAuthor = "Ali Veli",
                            SeoDescription = "C#, C#9 ,.NET5 Yenilikleri",
                            SeoTags = "C#, C#9 .NET5 , .NET Framework, .NET Core",
                            Thumbnail = "Default.jpg",
                            Title = "C# .Net5 özellikleri ",
                            UserId = 1,
                            ViewCount = 12
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = " Bir okuyucunun, sayfa düzenine bakarken sayfanın okunabilir içeriği tarafından dikkatinin dağılacağı uzun süredir bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, 'İçerik burada, içerik burada' kullanılmasının aksine, harflerin az çok normal dağılımına sahip olması ve okunabilir İngilizce gibi görünmesini sağlamasıdır. Birçok masaüstü yayıncılık paketi ve web sayfası düzenleyicisi artık varsayılan model metni olarak Lorem Ipsum'u kullanıyor ve 'lorem ipsum' araması, henüz emekleme aşamasında olan birçok web sitesini ortaya çıkaracaktır. Yıllar içinde, bazen tesadüfen, bazen de bilerek (enjekte edilmiş mizah ve benzeri) çeşitli versiyonlar gelişti.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3410),
                            Date = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3408),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3411),
                            Note = "C++ 11 ve 19 özellikleri",
                            SeoAuthor = "Ali Veli",
                            SeoDescription = "C++ 11 ve 19 özellikleri",
                            SeoTags = "C++ 11 ve 19 özellikleri",
                            Thumbnail = "Default.jpg",
                            Title = "C++ 11 ve 19 özellikleri ",
                            UserId = 1,
                            ViewCount = 295
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = " Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham..",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3417),
                            Date = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3415),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 404, DateTimeKind.Local).AddTicks(3418),
                            Note = "JavaScript ES2019 ES2020 özellikleri ",
                            SeoAuthor = "Ali Veli",
                            SeoDescription = "JavaScript ES2019 ES2020 özellikleri ",
                            SeoTags = "JavaScript ES2019 ES2020 özellikleri ",
                            Thumbnail = "Default.jpg",
                            Title = "JavaScript ES2019 ES2020 özellikleri ",
                            UserId = 1,
                            ViewCount = 100
                        });
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("character varying(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5150),
                            Description = "C# Programlama Dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5160),
                            Name = "C#",
                            Note = "C# Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5171),
                            Description = "C++ Programlama Dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5172),
                            Name = "C++",
                            Note = "C++ Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5176),
                            Description = "JavaScript Programlama Dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 406, DateTimeKind.Local).AddTicks(5177),
                            Name = "JavaScript",
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2091),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2102),
                            Note = "C# Makale Yorumu",
                            Text = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2114),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2115),
                            Note = "C++ Makale Yorumu",
                            Text = "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker"
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2118),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 408, DateTimeKind.Local).AddTicks(2119),
                            Note = "JavaScript Makale Yorumu",
                            Text = "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum."
                        });
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 409, DateTimeKind.Local).AddTicks(4784),
                            Description = "Admin Rolü, tüm haklara sahiptir",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InıtialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 409, DateTimeKind.Local).AddTicks(4795),
                            Name = "Admin",
                            Note = "Admin Rolüdür"
                        });
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BYTEA");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 4, 3, 3, 5, 43, 414, DateTimeKind.Local).AddTicks(1753),
                            Description = "Ilk Admin Kullanici",
                            Email = "ali@veli.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Veli",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 4, 3, 3, 5, 43, 414, DateTimeKind.Local).AddTicks(1765),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            UserName = "AliVeli"
                        });
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BloggerWay.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloggerWay.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BloggerWay.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.User", b =>
                {
                    b.HasOne("BloggerWay.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BloggerWay.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
