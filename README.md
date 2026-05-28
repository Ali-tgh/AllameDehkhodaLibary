# 📚 AllameDehkhoda Library Management System

سیستم مدیریت کتابخانه با معماری Clean Architecture

---

## 🏗️ معماری پروژه

```mermaid
graph TD
    subgraph Presentation["🖥️ Presentation (WinForms)"]
        P1[Form1 - فرم اصلی]
        P2[FrmBook - مدیریت کتاب]
        P3[FrmMember - مدیریت اعضا]
        P4[FrmBorrow - مدیریت امانت]
        P5[FrmReport - گزارش‌گیری]
    end

    subgraph Application["⚙️ Application (Business Logic)"]
        A1[BookService]
        A2[BorrowService]
        A3[MemberService]
        A4[CategoryService]
        A5[DTOs]
        A6[ServiceResult]
    end

    subgraph Infrastructure["🗄️ Infrastructure (EF Core)"]
        I1[AppDbContext]
        I2[BookRepository]
        I3[BorrowRepository]
        I4[MemberRepository]
        I5[CategoryRepository]
        I6[Configs]
    end

    subgraph Domain["🧩 Domain (Core)"]
        D1[Book]
        D2[Member]
        D3[Borrow]
        D4[Category]
        D5[IRepository]
        D6[IBookRepository]
        D7[IBorrowRepository]
        D8[IMemberRepository]
        D9[ICategoryRepository]
    end

    Presentation --> Application
    Application --> Domain
    Infrastructure --> Domain
    Presentation -.->|DI| Infrastructure
```

---

## 📁 ساختار پوشه‌ها

```
AllameDehkhoda/
│   AllameDehkhoda.slnx
│
├── AllameDehkhoda.Domain          # هسته اصلی
│   ├── Entities/
│   │   ├── BaseEntity.cs
│   │   ├── Book.cs
│   │   ├── Borrow.cs
│   │   ├── Category.cs
│   │   └── Member.cs
│   └── Interfaces/
│       ├── IRepository.cs
│       ├── IBookRepository.cs
│       ├── IBorrowRepository.cs
│       ├── ICategoryRepository.cs
│       └── IMemberRepository.cs
│
├── AllameDehkhoda.Application     # منطق کسب‌وکار
│   ├── DTO/
│   ├── Interfaces/
│   ├── Services/
│   └── Common/
│       └── ServiceResult.cs
│
├── AllameDehkhoda.Infrastructure  # EF Core
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   └── AppDbContextFactory.cs
│   ├── Configs/
│   ├── Repository/
│   └── Migrations/
│
└── AllameDehkhoda.Presentation    # WinForms UI
    ├── Program.cs
    ├── Form1.cs
    ├── FrmBook.cs
    ├── FrmMember.cs
    ├── FrmBorrow.cs
    ├── FrmReport.cs
    └── Common/
        ├── DateTimeFuncs.cs
        ├── SaveAsXML.cs
        └── UIHelper.cs
```

---

## 🛠️ تکنولوژی‌ها

| بخش | تکنولوژی |
|-----|-----------|
| زبان | C# / .NET |
| UI | WinForms |
| ORM | Entity Framework Core |
| معماری | Clean Architecture |
| دیتابیس | SQL Server |

---

## 🚀 راه‌اندازی

```bash
# کلون پروژه
git clone https://github.com/YOUR_USERNAME/AllameDehkhoda.git

# اجرای Migration
dotnet ef database update --project AllameDehkhoda.Infrastructure
```
