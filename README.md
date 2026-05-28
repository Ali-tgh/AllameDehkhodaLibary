<div align="center">

# 📚 سیستم مدیریت کتابخانه علامه دهخدا

**یک سیستم جامع مدیریت کتابخانه ساخته‌شده با .NET 10 و معماری Onion Architecture**

[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-Latest-512BD4?style=flat-square&logo=dotnet)](https://learn.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![WinForms](https://img.shields.io/badge/WinForms-0078D4?style=flat-square&logo=windows)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)

</div>

---

## ✨ قابلیت‌ها

| بخش | امکانات |
|-----|---------|
| 📖 **کتاب‌ها** | افزودن، ویرایش، حذف، جستجوی پیشرفته |
| 👤 **اعضا** | ثبت‌نام، ویرایش، حذف، اعتبارسنجی اطلاعات |
| 🔄 **امانت** | ثبت امانت، برگشت کتاب، پیگیری وضعیت |
| 📊 **گزارش‌گیری** | گزارش کتاب‌ها، اعضا و امانت‌ها با export به **Excel** |
| 🔍 **جستجو** | جستجوی پیشرفته در تمام بخش‌ها |

---

## 🏗️ معماری پروژه

پروژه از **Onion Architecture** استفاده می‌کنه — هر لایه فقط به لایه داخلی‌تر وابسته‌ست:

```
┌─────────────────────────────────────────┐
│         Presentation (WinForms)         │
│  Form1 · FrmBook · FrmMember · FrmBorrow│
├─────────────────────────────────────────┤
│              Application                │
│     Services · DTOs · ServiceResult     │
├──────────────────┬──────────────────────┤
│  Infrastructure  │                      │
│  EF Core · Repos │      Domain          │
│  AppDbContext    │  Entities · IRepos   │
└──────────────────┴──────────────────────┘
```

---

## 📂 ساختار پوشه‌ها

```
AllameDehkhoda/
│   AllameDehkhoda.slnx
│
├── 🧩 AllameDehkhoda.Domain              # هسته — بدون هیچ وابستگی خارجی
│   ├── Entities/
│   │   ├── BaseEntity.cs                 # کلاس پایه با Id
│   │   ├── Book.cs
│   │   ├── Borrow.cs
│   │   ├── Category.cs
│   │   └── Member.cs
│   └── Interfaces/
│       ├── IRepository.cs                # Generic CRUD Contract
│       ├── IBookRepository.cs
│       ├── IBorrowRepository.cs
│       ├── ICategoryRepository.cs
│       └── IMemberRepository.cs
│
├── ⚙️ AllameDehkhoda.Application         # منطق کسب‌وکار
│   ├── DTO/
│   │   ├── BookDTO.cs / BookReportDTO.cs
│   │   ├── BorrowDTO.cs / BorrowReportDTO.cs
│   │   ├── MemberDTO.cs / MemberReportDTO.cs
│   │   └── CategoryDTO.cs
│   ├── Interfaces/
│   │   ├── IBookService.cs
│   │   ├── IBorrowService.cs
│   │   ├── ICategoryService.cs
│   │   └── IMemberService.cs
│   ├── Services/
│   │   ├── BookService.cs
│   │   ├── BorrowService.cs
│   │   ├── CategoryService.cs
│   │   └── MemberService.cs
│   └── Common/
│       ├── ServiceResult.cs              # Wrapper نتیجه عملیات
│       ├── BookMessages.cs
│       ├── BorrowMessage.cs
│       └── MemberMessage.cs
│
├── 🗄️ AllameDehkhoda.Infrastructure      # EF Core
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   └── AppDbContextFactory.cs
│   ├── Configs/                          # Fluent API Configuration
│   │   ├── BookConfig.cs
│   │   ├── BorrowConfig.cs
│   │   ├── MemberConfig.cs
│   │   └── CategoryConfig.cs
│   ├── Repository/
│   │   ├── BaseRepository.cs
│   │   ├── BookRepository.cs
│   │   ├── BorrowRepository.cs
│   │   ├── MemberRepository.cs
│   │   └── CategoryRepository.cs
│   └── Migrations/
│       └── 20260509064512_init.cs
│
└── 🖥️ AllameDehkhoda.Presentation        # WinForms UI
    ├── Program.cs
    ├── Form1.cs                          # فرم اصلی
    ├── FrmBook.cs
    ├── FrmMember.cs
    ├── FrmBorrow.cs
    ├── FrmReport.cs
    └── Common/
        ├── DateTimeFuncs.cs              # تبدیل تاریخ شمسی/میلادی
        ├── SaveAsXML.cs
        └── UIHelper.cs
```

---

## 🔍 توضیح لایه‌ها

### 🧩 Domain

مستقل‌ترین لایه — **هیچ** وابستگی به EF Core، WinForms یا هیچ فریم‌ورک خارجی ندارد.

- **`BaseEntity`** — کلاس پایه با `Id` که همه موجودیت‌ها از آن ارث می‌برند
- **`IRepository<T>`** — قرارداد Generic شامل `Add`, `Update`, `Delete`, `GetById`, `GetAll`

---

### ⚙️ Application

فقط به `Domain` وابسته است. تمام منطق کسب‌وکار اینجاست.

**جریان یک عملیات:**
```
UI (Presentation)
    │  DTO
    ▼
Service.cs (Application)
    │  Validate + Business Logic
    ▼
IRepository (Domain Interface)
    │  Implemented by Infrastructure
    ▼
SQL Server
```

**`ServiceResult<T>`** — تمام سرویس‌ها این wrapper را برمی‌گردانند:
```csharp
public class ServiceResult
{
    public bool IsSuccess { get; set; }
    public string Message  { get; set; }
}

public class ServiceResult<T> : ServiceResult
{
    public T Data { get; set; }
}
```

---

### 🗄️ Infrastructure

اینترفیس‌های `Domain` را با **Entity Framework Core** پیاده‌سازی می‌کند.

- **`AppDbContext`** — DbContext اصلی پروژه
- **`AppDbContextFactory`** — برای اجرای `dotnet ef` از CLI
- **Configs** — تنظیمات Fluent API (روابط، ایندکس‌ها، محدودیت‌ها)
- **`BaseRepository<T>`** — پیاده‌سازی Generic از `IRepository<T>`

---

### 🖥️ Presentation

رابط کاربری WinForms که از طریق **Dependency Injection** به سرویس‌ها دسترسی دارد.

| فرم | مسئولیت |
|-----|---------|
| `Form1` | منوی اصلی و ناوبری |
| `FrmBook` | CRUD کتاب + جستجوی پیشرفته |
| `FrmMember` | مدیریت اعضا + اعتبارسنجی |
| `FrmBorrow` | ثبت امانت و برگشت |
| `FrmReport` | گزارش‌گیری + export به Excel |

---

## 🛠️ تکنولوژی‌ها

| | تکنولوژی | نسخه |
|---|-----------|-------|
| زبان | C# | 13 |
| فریم‌ورک | .NET | 10 |
| رابط کاربری | Windows Forms | — |
| ORM | Entity Framework Core | Latest |
| دیتابیس | SQL Server | — |
| معماری | Onion Architecture | — |
| الگوها | Repository · DTO · Service Layer | — |

---

## 🚀 راه‌اندازی و نصب

### پیش‌نیازها

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [SQL Server](https://www.microsoft.com/sql-server) یا SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (پیشنهادی)

### مراحل

**۱. کلون پروژه**
```bash
git clone https://github.com/Ali-tgh/AllameDehkhodaLibary.git
cd AllameDehkhodaLibary
```

**۲. تنظیم Connection String**

در پروژه `Presentation` فایل `App.config` یا `appsettings.json` را ویرایش کن:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=AllameDehkhoda;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

**۳. اجرای Migration**
```bash
dotnet ef database update \
  --project AllameDehkhoda.Infrastructure \
  --startup-project AllameDehkhoda.Presentation
```

**۴. اجرا**
```bash
dotnet run --project AllameDehkhoda.Presentation
```
یا در Visual Studio پروژه `Presentation` را به عنوان Startup Project تنظیم کرده و `F5` بزن.

---

## 📋 لیست امکانات

- [x] مدیریت کامل کتاب‌ها (CRUD)
- [x] مدیریت اعضای کتابخانه با اعتبارسنجی
- [x] سیستم امانت‌دهی و برگشت کتاب
- [x] جستجوی پیشرفته در تمام بخش‌ها
- [x] گزارش‌گیری از کتاب‌ها، اعضا و امانت‌ها
- [x] ذخیره گزارشات در **Excel**
- [x] پشتیبانی از تاریخ شمسی
- [x] معماری لایه‌بندی‌شده (Onion Architecture)

---

<div align="center">

ساخته‌شده با ❤️ توسط [Ali-tgh](https://github.com/Ali-tgh)

</div>
