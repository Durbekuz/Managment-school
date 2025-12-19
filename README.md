# # 🎓 Student Management Console App

Bu loyiha C# Console Application bo‘lib, talabalarni qabul qilish va boshqarish uchun mo‘ljallangan.

---

## 🔐 Login tizimi

Dastur ishga tushganda foydalanuvchidan parol kiritish talab qilinadi.

- Noto‘g‘ri parol kiritilsa:
  - Xabar chiqadi: Parol xato, qayta urinib ko‘ring
  - Maksimal 3 ta urinish beriladi
- To‘g‘ri parol kiritilganda:
  - Xush kelibsiz, Elbek! xabari chiqadi

---

## 📋 Mavjud menyu

Login muvaffaqiyatli o‘tgach, quyidagi menyu ochiladi:

### 1️⃣ Yangi talaba qo‘shish
- Foydalanuvchi FullName kiritadi
- Talabaga avtomatik random ID beriladi  
  - Format: AA1234
- Talabalar soni 12 ta bilan cheklangan

### 2️⃣ Talabalar ro‘yxati
- Barcha qo‘shilgan talabalar ro‘yxati ko‘rsatiladi
- Har bir talaba uchun:
  - ID
  - FullName

### 3️⃣ Qabul soni
- Maksimal qabul: 12 ta talaba
- Limit to‘lganda yangi talaba qo‘shib bo‘lmaydi

---

## ⚙️ Texnologiyalar
- C#
- .NET Console Application

---

## 📦 Loyihani ishga tushirish

```bash
dotnet run
