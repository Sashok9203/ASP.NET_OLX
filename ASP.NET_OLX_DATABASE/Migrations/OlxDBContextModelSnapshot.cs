﻿// <auto-generated />
using System;
using ASP.NET_OLX_DATABASE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NET_OLX_DATABASE.Migrations
{
    [DbContext(typeof(OlxDBContext))]
    partial class OlxDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.ToTable("Adverts", t =>
                        {
                            t.HasCheckConstraint("Description_check", "[Description] <> ''");

                            t.HasCheckConstraint("SellerName_check", "[SellerName] <> ''");

                            t.HasCheckConstraint("Title_check", "[Title] <> ''");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CityId = 1,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 458, DateTimeKind.Local).AddTicks(4253),
                            Description = "Продам телефон Redmi 9A в гарному стані на фото видно що має незначні царини роботі вони не впливають а загалом він як новий .",
                            IsNew = false,
                            Price = 1500m,
                            SellerName = "Олександр",
                            Title = "Телефон REDMI 9A"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CityId = 2,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(288),
                            Description = "Ніяких mdm блокувань немає. Ноутбук без жодних дефектів і повний комплект(зарядка, коробка, шнур, макулатура і наклейки). Фото коробки і інших дрібниць не кидаю але все маю, нічого не викидав.",
                            IsNew = false,
                            Price = 99900m,
                            SellerName = "Михайло",
                            Title = "MacBook M1 Max 14” 64RAM/32GPU/2Tb ssd"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CityId = 3,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(327),
                            Description = "Смарт тв 32” Samsung UE32T4510AUXUA, Smart TV, WiFi, T2. Телевізор білого кольору, 2021 року виробництва.Телевізор в ідеальному стані та повному комплекті, - пульт, ніжнки. Усе в оригіналі, всі функції перевірені та працюють",
                            IsNew = false,
                            Price = 7900m,
                            SellerName = "Микола",
                            Title = "Смарт тв 32” Samsung UE32T4510AUXUA, Smart TV, WiFi, T2"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CityId = 4,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(332),
                            Description = "Продам полностью рабочую в отличном состоянии игровую видеокарту AMD RX 5700XT 8GB GDDR6 ASUS.Температура отличная, без каких либо проблем.Проходит тесты ОССТ/FurMark/3DMark без проблем.Потянет большинство популярных игр на хороших настройках графики!",
                            IsNew = false,
                            Price = 8500m,
                            SellerName = "Олена",
                            Title = "Как новая! Видеокарта AMD RX 5700XT 8GB GDDR6 Гарантия!"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CityId = 5,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(336),
                            Description = "Intel i5 7400, причина продажу апгрейд, комплектаці BOX, любі тести, також можна купити комплектом, дивіться інші мої оголошення)комплектом віддам за 5к",
                            IsNew = false,
                            Price = 1500m,
                            SellerName = "Ольга",
                            Title = "Процессор intel i5 7400"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            CityId = 6,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(339),
                            Description = "Продам оперативну пям'ять SAMSUNG 8 GB. SODIMM. DDR-4. 2400 MHz.Планки по 4GB.Були в роботі 1 рік.",
                            IsNew = false,
                            Price = 1000m,
                            SellerName = "Володимир",
                            Title = "Оперативна пям'ять DDR-4 2400 MHz"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            CityId = 7,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(342),
                            Description = "Продам тихий игровой компьютер, в хорошем исполнении, с качественных комплектующих, с запасом на апгрейд. Любые проверки и тесты , предпочтительно по месту! Компьютер будет радовать своего нового владельца высокой продуктивностью, и ждет именно вас!",
                            IsNew = false,
                            Price = 14700m,
                            SellerName = "Антон",
                            Title = "Silens! Игровой компьютер I5 9400f, z390, gtx 1070 8 gb,16 gb"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 8,
                            CityId = 8,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(345),
                            Description = "Все летает , новые игры без проблем на ультрах! Battlefield 2042, Call of Duty Modern Warfare прошел 3 части!",
                            IsNew = false,
                            Price = 23500m,
                            SellerName = "Іван",
                            Title = "Игровой компютер, комплект! GTX 1080, монитор MSI 244 герц!"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 9,
                            CityId = 9,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(348),
                            Description = "Все летает , новые игры без проблем на ультрах! Battlefield 2042, Call of Duty Modern Warfare прошел 3 части!",
                            IsNew = true,
                            Price = 50m,
                            SellerName = "Роман",
                            Title = "Зовнішня звукова карта USB 5.1 для комп'ютера та ноутбука (Внешняя)"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 10,
                            CityId = 10,
                            Date = new DateTime(2024, 1, 23, 1, 50, 31, 461, DateTimeKind.Local).AddTicks(351),
                            Description = "Продаю свою GoPro 10 так як перейшов на новішу модель . Завжди була в захисних склах і у захиснобу силіконовому чохлі , не топилась (Використовувалась як влогова камера ) можлива зустріч у Києві (правий берег ) або Олх доставка/наложка Торг !!!",
                            IsNew = true,
                            Price = 8000m,
                            SellerName = "Сергій",
                            Title = "Пртдам Gopro 10 black в дуже горошому стані !!!"
                        });
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories", t =>
                        {
                            t.HasCheckConstraint("Category_check", "[Name] <> ''");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Телефони"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ноутбуки"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Телевізори"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Відеокарти"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Процессори"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Оперативна пам'ять"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Компьютери"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Монитори"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Звукові карти"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Екшн-камери"
                        });
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities", t =>
                        {
                            t.HasCheckConstraint("Name_check", "[Name] <> ''");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Київ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Харків"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Одеса"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Дніпро"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Запоріжжя"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Кривий Ріг"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mиколаїв"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Луганськ"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Вінниця"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Чернігів"
                        });
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("Images", t =>
                        {
                            t.HasCheckConstraint("Url_check", "[Url] <> ''");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdvertId = 1,
                            Url = "https://localhost:7203/UsersAdvertsImages/046a6c9cbe3948a388001eff7c842786.webp"
                        },
                        new
                        {
                            Id = 2,
                            AdvertId = 1,
                            Url = "https://localhost:7203/UsersAdvertsImages/6c54c58f313c46b8b08fb276cd89ede1.webp"
                        },
                        new
                        {
                            Id = 3,
                            AdvertId = 1,
                            Url = "https://localhost:7203/UsersAdvertsImages/07a281155d454adb81ad4b170fbd0a03.webp"
                        },
                        new
                        {
                            Id = 4,
                            AdvertId = 2,
                            Url = "https://localhost:7203/UsersAdvertsImages/a366c4b673c4466aae1799e4b417b19b.webp"
                        },
                        new
                        {
                            Id = 5,
                            AdvertId = 2,
                            Url = "https://localhost:7203/UsersAdvertsImages/5f3b586ef071461bbcdf7841cf2ff67c.webp"
                        },
                        new
                        {
                            Id = 6,
                            AdvertId = 2,
                            Url = "https://localhost:7203/UsersAdvertsImages/ba0ff206dacc47d6956d606aef5edd5d.webp"
                        },
                        new
                        {
                            Id = 7,
                            AdvertId = 3,
                            Url = "https://localhost:7203/UsersAdvertsImages/f2855d828be54f93acf0485d7b874cdb.webp"
                        },
                        new
                        {
                            Id = 8,
                            AdvertId = 3,
                            Url = "https://localhost:7203/UsersAdvertsImages/844edaa8c7b8427b9d2b56063ce8977c.webp"
                        },
                        new
                        {
                            Id = 9,
                            AdvertId = 3,
                            Url = "https://localhost:7203/UsersAdvertsImages/54b271dc78fe427fae3a68f07540a8ea.webp"
                        },
                        new
                        {
                            Id = 10,
                            AdvertId = 4,
                            Url = "https://localhost:7203/UsersAdvertsImages/c81082a052484beb8699ff467d1122dc.webp"
                        },
                        new
                        {
                            Id = 11,
                            AdvertId = 4,
                            Url = "https://localhost:7203/UsersAdvertsImages/2b69dadd1dcd40eb94ecc40bd8e66d31.webp"
                        },
                        new
                        {
                            Id = 12,
                            AdvertId = 4,
                            Url = "https://localhost:7203/UsersAdvertsImages/c9e78a957e84442e9cf0915167d62add.webp"
                        },
                        new
                        {
                            Id = 13,
                            AdvertId = 5,
                            Url = "https://localhost:7203/UsersAdvertsImages/d90a8e5655204c0eb035e382c8a293a3.webp"
                        },
                        new
                        {
                            Id = 14,
                            AdvertId = 5,
                            Url = "https://localhost:7203/UsersAdvertsImages/d7229686d2444bf7aad0f9f22b5c671a.webp"
                        },
                        new
                        {
                            Id = 15,
                            AdvertId = 5,
                            Url = "https://localhost:7203/UsersAdvertsImages/fff47682d2db4df9a0a51ac6288eb881.webp"
                        },
                        new
                        {
                            Id = 16,
                            AdvertId = 6,
                            Url = "https://localhost:7203/UsersAdvertsImages/a165f34c4bcf4de28ac3df3e670217d6.webp"
                        },
                        new
                        {
                            Id = 17,
                            AdvertId = 6,
                            Url = "https://localhost:7203/UsersAdvertsImages/7d6097e652cf44b5a5298d1e94db142c.webp"
                        },
                        new
                        {
                            Id = 18,
                            AdvertId = 7,
                            Url = "https://localhost:7203/UsersAdvertsImages/3ba07c21e7b44ef993412fd0b40c3385.webp"
                        },
                        new
                        {
                            Id = 19,
                            AdvertId = 7,
                            Url = "https://localhost:7203/UsersAdvertsImages/0af4ad7eb0a24f45b0008090b1b0a3f6.webp"
                        },
                        new
                        {
                            Id = 20,
                            AdvertId = 7,
                            Url = "https://localhost:7203/UsersAdvertsImages/90cc095ed7134cc78c6af6e2f38b8403.webp"
                        },
                        new
                        {
                            Id = 21,
                            AdvertId = 8,
                            Url = "https://localhost:7203/UsersAdvertsImages/2d49a4fb86c74a79bff1bcedcf8aae24.webp"
                        },
                        new
                        {
                            Id = 22,
                            AdvertId = 8,
                            Url = "https://localhost:7203/UsersAdvertsImages/a92a25d946284f70bfb93866233f8c88.webp"
                        },
                        new
                        {
                            Id = 23,
                            AdvertId = 8,
                            Url = "https://localhost:7203/UsersAdvertsImages/f2f938f084374eebb76be6436e689714.webp"
                        },
                        new
                        {
                            Id = 24,
                            AdvertId = 9,
                            Url = "https://localhost:7203/UsersAdvertsImages/dc521bca678948cca942fa4b029c0905.webp"
                        },
                        new
                        {
                            Id = 25,
                            AdvertId = 10,
                            Url = "https://localhost:7203/UsersAdvertsImages/eafe376a8c994ac282c37a12e8f989c3.webp"
                        },
                        new
                        {
                            Id = 26,
                            AdvertId = 10,
                            Url = "https://localhost:7203/UsersAdvertsImages/75efa1d600fd4e0eb976ab4dddcdacb7.webp"
                        },
                        new
                        {
                            Id = 27,
                            AdvertId = 10,
                            Url = "https://localhost:7203/UsersAdvertsImages/57e5aec69d234333bdc7625a54f96945.webp"
                        });
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Advert", b =>
                {
                    b.HasOne("ASP.NET_OLX_DATABASE.Entities.Category", "Category")
                        .WithMany("Adverts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_OLX_DATABASE.Entities.City", "City")
                        .WithMany("Adverts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Image", b =>
                {
                    b.HasOne("ASP.NET_OLX_DATABASE.Entities.Advert", "Advert")
                        .WithMany("Images")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Advert", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.Category", b =>
                {
                    b.Navigation("Adverts");
                });

            modelBuilder.Entity("ASP.NET_OLX_DATABASE.Entities.City", b =>
                {
                    b.Navigation("Adverts");
                });
#pragma warning restore 612, 618
        }
    }
}
