# 📚 سیستم مدیریت کتابخانه علامه دهخدا

پروژه مدیریت کتابخانه با **WinForms** و **Entity Framework Core** و معماری **Onion Architecture**

---

## ✨ قابلیت‌ها

- مدیریت کتاب‌ها (افزودن، ویرایش، حذف، جستجو)
- مدیریت اعضا (ثبت‌نام، ویرایش، حذف)
- اعتبارسنجی ورودی‌ها
- مدیریت امانت کتاب
- گزارش‌گیری از امانت‌ها، اعضا و کتاب‌ها
- امکان ذخیره گزارشات در اکسل
- جستجوی پیشرفته

---

## 🛠 تکنولوژی‌ها

| تکنولوژی | نسخه |
|---|---|
| .NET | 10 |
| Entity Framework Core | آخرین نسخه |
| SQL Server | - |
| Windows Forms | - |
| معماری | Onion Architecture |



## 📁 ساختار پروژه
AllameDehkhoda/
│   AllameDehkhoda.slnx
│
├───AllameDehkhoda.Domain              # هسته اصلی - موجودیت‌ها و اینترفیس‌ها
│   ├───Entites
│   │       BaseEntity.cs
│   │       Book.cs
│   │       Borrow.cs
│   │       Category.cs
│   │       Member.cs
│   │
│   └───Interfaces
│           IRepository.cs
│           IBookRepository.cs
│           IBorrowRepository.cs
│           ICategoryRepository.cs
│           IMemberRepository.cs
│
├───AllameDehkhoda.Application         # منطق کسب‌وکار - سرویس‌ها و DTO‌ها
│   ├───DTO
│   │       BookDTO.cs / BookReportDTO.cs
│   │       BorrowDTO.cs / BorrowReportDTO.cs
│   │       MemberDTO.cs / MemberReportDTO.cs
│   │       CategoryDTO.cs
│   │
│   ├───Interfaces
│   │       IBookService.cs
│   │       IBorrowService.cs
│   │       ICategoryService.cs
│   │       IMemberService.cs
│   │
│   ├───Services
│   │       BookService.cs
│   │       BorrowService.cs
│   │       CategoryService.cs
│   │       MemberService.cs
│   │
│   └───Common
│           ServiceResult.cs
│           BookMessages.cs / BorrowMessage.cs / MemberMessage.cs
│
├───AllameDehkhoda.Infrastructure      # پیاده‌سازی EF Core و ریپازیتوری‌ها
│   ├───Data
│   │       AppDbContext.cs
│   │       AppDbContextFactory.cs
│   │
│   ├───Configs
│   │       BookConfig.cs / BorrowConfig.cs
│   │       MemberConfig.cs / CategoryConfig.cs
│   │
│   ├───Repository
│   │       BaseRepository.cs
│   │       BookRepository.cs / BorrowRepository.cs
│   │       MemberRepository.cs / CategoryRepository.cs
│   │
│   └───Migrations
│           20260509064512_init.cs
│
├───AllameDehkhoda.Presentation        # رابط کاربری WinForms
│   │   Program.cs
│   │   Form1.cs           (فرم اصلی)
│   │   FrmBook.cs         (مدیریت کتاب‌ها)
│   │   FrmMember.cs       (مدیریت اعضا)
│   │   FrmBorrow.cs       (مدیریت امانت)
│   │   FrmReport.cs       (گزارش‌گیری)
│   │
│   └───Common
│           DateTimeFuncs.cs
│           SaveAsXML.cs
│           UIHelper.cs
│
└───Icons                              # آیکون‌های رابط کاربری

---

## 🚀 نصب و اجرا

### پیش‌نیازها

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server یا SQL Server Express
- Visual Studio 2022 یا بالاتر

### مراحل نصب

1. مخزن را کلون کنید:

```bash
git clone https://github.com/Ali-tgh/AllameDehkhodaLibary.git
cd AllameDehkhodaLibary
```

2. رشته اتصال به دیتابیس را در `AppDbContextFactory.cs` تنظیم کنید:

```csharp
"Server=YOUR_SERVER;Database=AllameDehkhodaDB;Trusted_Connection=True;"
```

3. Migration را اجرا کنید:

```bash
dotnet ef database update --project AllameDehkhoda.Infrastructure --startup-project AllameDehkhoda.Presentation
```

4. پروژه را Build و اجرا کنید.

---

## 🏗 معماری

پروژه بر اساس **Onion Architecture** طراحی شده است:
Presentation  →  Application  →  Domain
Infrastructure  →  Domain

- **Domain**: هیچ وابستگی خارجی ندارد
- **Application**: فقط به Domain وابسته است
- **Infrastructure**: پیاده‌سازی اینترفیس‌های Domain
- **Presentation**: لایه UI که از Application استفاده می‌کند

---

## 👤 توسعه‌دهنده

**علی تقی‌زاده** — [GitHub](https://github.com/Ali-tgh)

