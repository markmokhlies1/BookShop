using Book_Shop.Data.Enums;
using Book_Shop.Data.Static;
using Book_Shop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Data
{
    public class AppDbInitializer
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AppDbContext>>()))
            {
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "morris loblan",
                            Bio = "Maurice Emile Leblanc was born on the 11th of December 1864 AD in Rouen and died on the 6th of November 1941 AD in Perpignan. Writers of detective novels and adventure novels, he is the inventor of the famous character Arsene Lupine, the cute thief.\n",
                            ImageURL= "https://cdn.aseeralkotb.com/images/default-avatar-male.svg",
                        },
                        new Author()
                        {
                            FullName = "dostoievski",
                            Bio = "One of the most famous Russian writers (1821-1881 AD) .. He worked for a period of his literary life as a Russian translator and journalist, but he was known internationally for his texts, especially long novels, including:\nThe Brothers Karamazov, The Idiot, and Crime and Punishment; In it, he adopted a precise analytical method for the psychological state of both the individual and society, shedding light on the mysteries of the human psyche.a",
                            ImageURL= "https://www.aseeralkotb.com/storage/media/174961/conversions/%D8%AF%D9%8A%D8%B3%D8%AA%D9%88%D9%8A%D9%81%D8%B3%D9%83%D9%8A-39-150x150-webp.webp"
                        },
                        new Author()
                        {
                            FullName = "dostoievski",
                            Bio = "One of the most famous Russian writers (1821-1881 AD) .. He worked for a period of his literary life as a Russian translator and journalist, but he was known internationally for his texts, especially long novels, including:\nThe Brothers Karamazov, The Idiot, and Crime and Punishment; In it, he adopted a precise analytical method for the psychological state of both the individual and society, shedding light on the mysteries of the human psyche.a",
                            ImageURL= "https://www.aseeralkotb.com/storage/media/174961/conversions/%D8%AF%D9%8A%D8%B3%D8%AA%D9%88%D9%8A%D9%81%D8%B3%D9%83%D9%8A-39-150x150-webp.webp"
                        },
                        new Author()
                        {
                            FullName = "Nageeb Mahfouz",
                            Bio = "Naguib Mahfouz (December 11, 1911 - August 30, 2006) was an Egyptian novelist, and the first Egyptian to win a Nobel Prize in Literature. Naguib Mahfouz wrote since the thirties and continued until 2004. All of his novels take place in Egypt, and a recurring feature appears in them, which is the warmth that equals the world. Among his most famous works: The Trilogy and Children of Our Neighborhood, which has been banned from publication in Egypt since its publication until recently. While Mahfouz's literature is classified as realistic literature, existential themes appear in it. Mahfouz is the most Arab writer whose works have been transferred to cinema and television.\n\nNaguib Mahfouz was given a compound name in appreciation from his father, Abdel Aziz Ibrahim, to the well-known doctor, Naguib Pasha Mahfouz, who oversaw his difficult birth.",
                            ImageURL= "https://www.aseeralkotb.com/storage/media/175366/conversions/%D9%86%D8%AC%D9%8A%D8%A8-%D9%85%D8%AD%D9%81%D9%88%D8%B8-706-150x150-webp.webp"
                        },
                        new Author()
                        {
                            FullName = "Reem Basiouny",
                            Bio = "An Egyptian novelist, born in Alexandria in 1973, she obtained a Bachelor of Arts in the Department of English in addition to having a doctorate in political discourse analysis from Oxford University. She received several awards, the most recent of which was the Naguib Mahfouz Prize for Literature from the Supreme Council of Culture for the year 2020",
                            ImageURL= "https://www.aseeralkotb.com/storage/media/176323/conversions/%D8%B1%D9%8A%D9%85-%D8%A8%D8%B3%D9%8A%D9%88%D9%86%D9%8A-2311-150x150-webp.webp"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            Name = "Aseer Al-Kotob",
                            Bio = "This is the Publisher Bio",
                            ImageURL= "https://cdn.aseeralkotb.com/storage/media/298977/conversions/%D8%B9%D8%B5%D9%8A%D8%B1-%D8%A7%D9%84%D9%83%D8%AA%D8%A8-%D9%84%D9%84%D8%AA%D8%B1%D8%AC%D9%85%D8%A9-%D9%88%D8%A7%D9%84%D9%86%D8%B4%D8%B1-%D9%88%D8%A7%D9%84%D8%AA%D9%88%D8%B2%D9%8A%D8%B9-2-150x150-webp.webp"
                        },
                        new Publisher()
                        {
                            Name = "Deewan",
                            Bio = "This is the Publisher Bio",
                            ImageURL= "https://cdn.aseeralkotb.com/storage/media/270173/conversions/%D8%AF%D9%8A%D9%88%D8%A7%D9%86-%D9%84%D9%84%D9%86%D8%B4%D8%B1-%D9%88%D8%A7%D9%84%D8%AA%D9%88%D8%B2%D9%8A%D8%B9-800-150x150-webp.webp"
                        },
                        new Publisher()
                        {
                            Name = "Nahdet Masr",
                            Bio = "This is the Publisher Bio",
                            ImageURL= "https://cdn.aseeralkotb.com/storage/media/256331/conversions/نهضة-مصر-51-150x150-webp.webp"
                        },
                        new Publisher()
                        {
                            Name = "Al-Masreya Al-Lobnania",
                            Bio = "This is the Publisher Bio",
                            ImageURL= "https://cdn.aseeralkotb.com/storage/media/256339/conversions/%D8%A7%D9%84%D9%85%D8%B5%D8%B1%D9%8A%D8%A9-%D8%A7%D9%84%D9%84%D8%A8%D9%86%D8%A7%D9%86%D9%8A%D8%A9-%D9%84%D9%84%D9%86%D8%B4%D8%B1-%D9%88%D8%A7%D9%84%D8%AA%D9%88%D8%B2%D9%8A%D8%B9-78-150x150-webp.webp"
                        },
                        new Publisher()
                        {
                            Name = "Al-Karma",
                            Bio = "This is the Publisher Bio",
                            ImageURL= "https://cdn.aseeralkotb.com/images/default-publisher-avatar.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "The Gentlenam thief Lupin",
                            Description = "This novel is the inspiration for the new Netflix series \"Lupin\", starring Omar C. A selection of the best adventures of Arsene Lupin, the noble thief of France. The poor and the innocent have nothing to fear from Lupine, and he is often generous with them. But those with wealth and influence, as well as a detective who seeks to spoil his pleasure, should - all - beware.\n",
                            ImageURL="https://cdn.aseeralkotb.com/storage/media/294025/conversions/%D8%A7%D9%84%D9%84%D8%B5-%D8%A7%D9%84%D9%86%D8%A8%D9%8A%D9%84-23325-200x300-webp.webp",
                            Price=72,
                            ReleaseDate=1907,
                            PagesNumber=200,
                            BookCategory=BookCategory.Action
                        },
                        new Book()
                        {
                            Name = "The Idiot",
                            Description = "A handsome prince, but not like any other prince, sympathetic, tender-hearted, shy, perfect in morals, noble, returns to the homeland with a longing heart, pure in spirit and body ill, his brilliant mind is prey to epileptic fits, sees within human souls, and they only see in him the affliction.",
                            ImageURL="https://cdn.aseeralkotb.com/storage/media/294039/conversions/الأبله-3-أجزاء-23330-200x300-jpg.jpg",
                            Price=263,
                            ReleaseDate=1868,
                            PagesNumber=1136,
                            BookCategory=BookCategory.Drama
                        },
                        new Book()
                        {
                            Name = "The Devils",
                            Description = "In a land where opposites squabble, the winds of hell blow, shake the corners, ominously tamper with dreams, three human demons have come to wreak havoc everywhere. A charming demon, a mysterious aristocrat, with a thousand contradictions inside, a sane madman, swaying between a conscience that ravages him and lusts that captivate him, carrying a secret that might tear his soul",
                            ImageURL="https://cdn.aseeralkotb.com/storage/media/294042/conversions/الشياطين-3-أجزاء-23331-200x300-jpg.jpg",
                            Price=225,
                            ReleaseDate=1871,
                            PagesNumber=1304,
                            BookCategory=BookCategory.Horror
                        },
                        new Book()
                        {
                            Name = "أولاد حارتنا",
                            Description = "أولاد حارتنا\" تُعد إحدى أشهر رواياته وكانت إحدى المؤلفات التي تم التنويه بها عند منحه جائزة نوبل، أثارت الرواية جدلاً واسعًا منذ نشرها مسلسلة في صفحات جريدة الأهرام 1959، وصدرت لأول مرة في كتاب عن دار الآداب ببيروت عام 1962، ولم يتم نشرها في مصر حتى أواخر عام 2006",
                            ImageURL="https://cdn.aseeralkotb.com/storage/media/296649/conversions/أولاد-حارتنا-2-23810-200x300-jpg.jpg",
                            Price=200,
                            ReleaseDate=1959,
                            BookCategory=BookCategory.Drama
                        },
                        new Book()
                        {
                            Name = "الحلواني - ثلاثية الفاطميين",
                            Description = "من خلال ثلاث روايات ... تحكى عن مصر وأهلها وما حدث لهم في ظل حكم جوهر الصقلى ، وبدر الجمالى ، وصلاح الدين الأيوبى. وكيف عاش الناس في مصر العديد من الأحداث من خلال سندس وجوهر بن حسين الصقلى في الرواية الأولى، وفيرون وبدر الجمالى في الرواية الثانية، ورشيدة وإبراهيم الصقلى في الرواية الثالثة",
                            ImageURL="https://cdn.aseeralkotb.com/storage/media/296697/conversions/الحلوانى-ثلاثية-الفاطمين-23826-200x300-jpg.jpg",
                            Price=176,
                            ReleaseDate=2022,
                            BookCategory=BookCategory.Documentary
                        }
                    });
                }
                context.SaveChanges();
            }
        }

        public static async Task SeedUsersAndRolesAsync(IServiceProvider serviceProvider)
        {
            using (var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>())
            {
                //Roles
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            }
            using (var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>())
            {
                //Users
                string adminUserEmail = "admin@ecommerce.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@ecommerce.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
