using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class AZULContext : DbContext
    {
        public AZULContext()
        {
        }

        public AZULContext(DbContextOptions<AZULContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutUsPage> AboutUsPage { get; set; }
        public virtual DbSet<AttendanceReport> AttendanceReport { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Charge> Charge { get; set; }
        public virtual DbSet<ContactPage> ContactPage { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerServices> CustomerServices { get; set; }
        public virtual DbSet<DepartmentType> DepartmentType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HomePage> HomePage { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Meal> Meal { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Rate> Rate { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServicesPage> ServicesPage { get; set; }
        public virtual DbSet<SharedPage> SharedPage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=FARAHHMEDAN291\\SQLEXPRESS;Initial Catalog=AZUL;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutUsPage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescHeader)
                    .HasColumnName("descHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescHeader2)
                    .HasColumnName("descHeader2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage)
                    .HasColumnName("descImage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage2)
                    .HasColumnName("descImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescParagraph)
                    .HasColumnName("descParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescParagraph2)
                    .HasColumnName("descParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesHeader)
                    .HasColumnName("featuresHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImage1)
                    .HasColumnName("featuresImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImage2)
                    .HasColumnName("featuresImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImage3)
                    .HasColumnName("featuresImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint1)
                    .HasColumnName("featuresImagePoint1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint2)
                    .HasColumnName("featuresImagePoint2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint3)
                    .HasColumnName("featuresImagePoint3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint4)
                    .HasColumnName("featuresImagePoint4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint5)
                    .HasColumnName("featuresImagePoint5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint6)
                    .HasColumnName("featuresImagePoint6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint7)
                    .HasColumnName("featuresImagePoint7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint8)
                    .HasColumnName("featuresImagePoint8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturesImagePoint9)
                    .HasColumnName("featuresImagePoint9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderImage)
                    .HasColumnName("headerImage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RateHeader)
                    .HasColumnName("rateHeader")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RateImage1)
                    .HasColumnName("rateImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RateImage2)
                    .HasColumnName("rateImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RateName1)
                    .HasColumnName("rateName1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateName2)
                    .HasColumnName("rateName2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateParagraph1)
                    .HasColumnName("rateParagraph1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateParagraph2)
                    .HasColumnName("rateParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.EnterHour)
                    .HasColumnName("enterHour")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitHour)
                    .HasColumnName("exitHour")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AttendanceReport)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Attendanc__emplo__75A278F5");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Charge>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ChargeDate)
                    .HasColumnName("chargeDate")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Charge)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Charge__customer__72C60C4A");
            });

            modelBuilder.Entity<ContactPage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HeaderImage)
                    .HasColumnName("headerImage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceAddress1)
                    .HasColumnName("placeAddress1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceAddress2)
                    .HasColumnName("placeAddress2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceAddress3)
                    .HasColumnName("placeAddress3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceEmail1)
                    .HasColumnName("placeEmail1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceEmail2)
                    .HasColumnName("placeEmail2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceEmail3)
                    .HasColumnName("placeEmail3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceHeader1)
                    .HasColumnName("placeHeader1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceHeader2)
                    .HasColumnName("placeHeader2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceHeader3)
                    .HasColumnName("placeHeader3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceParagraph1)
                    .HasColumnName("placeParagraph1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceParagraph2)
                    .HasColumnName("placeParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceParagraph3)
                    .HasColumnName("placeParagraph3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlacePhone1)
                    .HasColumnName("placePhone1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlacePhone2)
                    .HasColumnName("placePhone2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlacePhone3)
                    .HasColumnName("placePhone3")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birthDate")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NationalNumber).HasColumnName("nationalNumber");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerServices>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerServices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CustomerS__custo__6B24EA82");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.CustomerServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CustomerS__servi__6C190EBB");
            });

            modelBuilder.Entity<DepartmentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birthDate")
                    .HasColumnType("date");

                entity.Property(e => e.DeptType).HasColumnName("deptType");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Losses).HasColumnName("losses");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NationalNumber).HasColumnName("nationalNumber");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.DeptTypeNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DeptType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__deptTy__403A8C7D");
            });

            modelBuilder.Entity<HomePage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactAddress)
                    .HasColumnName("contactAddress")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("contactEmail")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHeader)
                    .HasColumnName("contactHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactParagraph)
                    .HasColumnName("contactParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasColumnName("contactPhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescHeader)
                    .HasColumnName("descHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage1)
                    .HasColumnName("descImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage2)
                    .HasColumnName("descImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage3)
                    .HasColumnName("descImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescParagraph)
                    .HasColumnName("descParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescPoint1)
                    .HasColumnName("descPoint1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescPoint2)
                    .HasColumnName("descPoint2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PoolHeader)
                    .HasColumnName("poolHeader")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PoolImage)
                    .HasColumnName("poolImage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PoolParagraph)
                    .HasColumnName("poolParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoomHeader)
                    .HasColumnName("roomHeader")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImage1)
                    .HasColumnName("roomImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImage2)
                    .HasColumnName("roomImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImage3)
                    .HasColumnName("roomImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageHeader1)
                    .HasColumnName("roomImageHeader1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageHeader2)
                    .HasColumnName("roomImageHeader2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageHeader3)
                    .HasColumnName("roomImageHeader3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageParagraph1)
                    .HasColumnName("roomImageParagraph1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageParagraph2)
                    .HasColumnName("roomImageParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoomImageParagraph3)
                    .HasColumnName("roomImageParagraph3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoomParagraph)
                    .HasColumnName("roomParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoomPrice1)
                    .HasColumnName("roomPrice1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomPrice2)
                    .HasColumnName("roomPrice2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomPrice3)
                    .HasColumnName("roomPrice3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SlideHeader1)
                    .HasColumnName("slideHeader1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlideHeader2)
                    .HasColumnName("slideHeader2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlideHeader3)
                    .HasColumnName("slideHeader3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlideImage1)
                    .HasColumnName("slideImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SlideImage2)
                    .HasColumnName("slideImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SlideImage3)
                    .HasColumnName("slideImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SlideParagraph1)
                    .HasColumnName("slideParagraph1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlideParagraph2)
                    .HasColumnName("slideParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlideParagraph3)
                    .HasColumnName("slideParagraph3")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnName("rate");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DeptType).HasColumnName("deptType");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Login__customerI__5165187F");

                entity.HasOne(d => d.DeptTypeNavigation)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.DeptType)
                    .HasConstraintName("FK__Login__deptType__5070F446");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Login__employeeI__52593CB8");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Meal)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Meal__categoryId__5EBF139D");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageText)
                    .HasColumnName("messageText")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arrive)
                    .HasColumnName("arrive")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MealId).HasColumnName("mealId");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__customer__22751F6C");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MealId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__mealId__236943A5");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountOfMoney).HasColumnName("amountOfMoney");

                entity.Property(e => e.CardNumber).HasColumnName("cardNumber");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("expDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Payment__custome__5535A963");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateText)
                    .HasColumnName("rateText")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChargeId).HasColumnName("chargeId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.CustomerserviceId).HasColumnName("customerserviceId");

                entity.Property(e => e.OrdersId).HasColumnName("ordersId");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("paymentType")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationId).HasColumnName("reservationId");

                entity.HasOne(d => d.Charge)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ChargeId)
                    .HasConstraintName("FK__Reports__chargeI__29221CFB");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Reports__custome__2645B050");

                entity.HasOne(d => d.Customerservice)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CustomerserviceId)
                    .HasConstraintName("FK__Reports__custome__2739D489");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("FK__Reports__ordersI__2A164134");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReservationId)
                    .HasConstraintName("FK__Reports__reserva__282DF8C2");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("checkInDate")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("checkOutDate")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.ResDate)
                    .HasColumnName("resDate")
                    .HasColumnType("date");

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Reservati__custo__656C112C");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Reservati__roomI__66603565");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FloorNumber).HasColumnName("floorNumber");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");

                entity.Property(e => e.SpecialDetails)
                    .HasColumnName("specialDetails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.RoomTypeId)
                    .HasConstraintName("FK__Room__roomTypeId__398D8EEE");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<ServicesPage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescHeader)
                    .HasColumnName("descHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage1)
                    .HasColumnName("descImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage2)
                    .HasColumnName("descImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescImage3)
                    .HasColumnName("descImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescParagraph)
                    .HasColumnName("descParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubHeader1)
                    .HasColumnName("descSubHeader1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubHeader2)
                    .HasColumnName("descSubHeader2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubHeader3)
                    .HasColumnName("descSubHeader3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubParagraph1)
                    .HasColumnName("descSubParagraph1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubParagraph2)
                    .HasColumnName("descSubParagraph2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescSubParagraph3)
                    .HasColumnName("descSubParagraph3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderImage)
                    .HasColumnName("headerImage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesHeader6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesParagraph6)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SharedPage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FooterCopyRight)
                    .HasColumnName("footerCopyRight")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.FooterHeader)
                    .HasColumnName("footerHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterParagraph)
                    .HasColumnName("footerParagraph")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .HasColumnName("hotelName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
