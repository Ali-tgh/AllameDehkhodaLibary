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

---

## 🚀 نصب و اجرا

### پیش‌نیازها

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (یا SQL Server Express)
- Visual Studio 2022 یا بالاتر

### مراحل نصب

1. مخزن را کلون کنید:

```bash
git clone https://github.com/Ali-tgh/AllameDehkhodaLibary.git
```

2. وارد پوشه پروژه شوید:

```bash
cd AllameDehkhodaLibary
```

3. رشته اتصال به دیتابیس را در فایل `appsettings.json` یا `App.config` تنظیم کنید:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=AllameDehkhodaDB;Trusted_Connection=True;"
}
```

4. Migration ها را اجرا کنید:

```bash
dotnet ef database update
```

5. پروژه را اجرا کنید:

```bash
dotnet run
```

---

## 📁 ساختار پروژه
