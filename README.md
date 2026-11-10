# 💎 KAHRAMAN — متجر الكهرمان الفاخر

<p align="center">
  <strong>منصة تجارة إلكترونية فاخرة متخصصة في العطور ومنتجات الجمال بنظام التجزئة والجملة</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 9.0" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC-0078D7?style=for-the-badge&logo=microsoft&logoColor=white" alt="ASP.NET Core" />
  <img src="https://img.shields.io/badge/PostgreSQL-Neon%20Serverless-4169E1?style=for-the-badge&logo=postgresql&logoColor=white" alt="PostgreSQL" />
  <img src="https://img.shields.io/badge/EF%20Core-9.0-512BD4?style=for-the-badge&logo=nuget&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/Team-LogiCore-0A66C2?style=for-the-badge" alt="LogiCore Team" />
</p>

---

## 📖 نبذة عن المشروع (About YAGOT)

**الكهرمان (Kahraman)** هو متجر إلكتروني عصري ومتكامل مصمم بأحدث معايير الويب لتقديم تجربة تسوق راقية وفاخرة لمنتجات العطور. يدمج المتجر بين نمط البيع بالقطعة الكاملة ونمط **البيع بالتجزئة (Decants / Samples)** بدقة بالمليمترات، مع نظام سلة وتسوق فوري وإشعارات حجز مؤتمتة عبر الواتساب ولوحة تحكم إدارية متقدمة ونقاط بيع سريعة (POS).

---

## ✨ المميزات الرئيسية (Key Features)

### 🛍️ تجربة المتجر والعميل (Storefront & UX)
* **هوية بصرية فاخرة (Yaqut Emerald & Gold Theme):** تصميم مخصص مع دعم كامل ومريح للوضعين **النهاري والليلي (Light & Dark Mode)** وتوافق تام مع شاشات الجوال.
* **نظام بيع التجزئة (Retail & Decants):** دعم خيارات بيع العطور بالمليمتر (10 مل، 25 مل، 50 مل) بحساب ديناميكي فوري للأسعار والمخزون مع زر «اختر الحجم».
* **شارات الحالة الذكية (Smart Product Badges):** شارة موحدة لكل كارت توضح التوفر («متوفر» الزمردية، «يباع بالتجزئة»، «غير متوفر»).
* **السلة وإتمام الطلب المتقدم (Smart Cart & Checkout):** معالجة التعارضات اللحظية للمخزون، حفظ مسودات الجلسة تلقائياً، وإمكانية تثبيت الحجز بنقرة واحدة عبر الواتساب.
* **البحث والتصفح اللغوي:** عدادات نتائج وفلاتر ديناميكية تراعي قواعد اللغة العربية حسب التصنيف ونوع العطر وتركيزه (EDP, EDT, Parfum).

### 🛠️ لوحة التحكم والإدارة (Admin & POS)
* **لوحة تحكم إحصائية (Dashboard):** تتبع حي للمبيعات، الإيرادات، وأكثر المنتجات طلباً.
* **نقطة البيع السريعة (POS Quick Sales):** تسجيل الطلبات السريعة والفواتير اليدوية وإدارة المخزون بدقة عالية.
* **التحكم بحالة الموقع (Site Status Controller):** التبديل بين وضع التشغيل الكامل (Online)، ووضع الصيانة (Offline)، ووضع التطوير (Development Mode) مع تخصيص صلاحيات الوصول بدقة.

### 🛡️ الأمان والحماية (Security-First Architecture)
* **عزل الأسرار التام:** حماية أسرار قواعد البيانات والمفاتيح عبر `.NET User Secrets` محلياً و`Environment Variables` في السيرفرات السحابية.
* **حماية المتصفح والجلسات:** تطبيق سياسة أمان محتوى صارمة (CSP مع Nonce)، ومنع الـ Clickjacking عبر `X-Frame-Options: DENY`.
* **حماية كلمات المرور والـ APIs:** خوارزمية **PBKDF2** بـ 100,000 دورة مع SHA-256، وحماية مصادقة الـ Webhooks بتوقيعات **HMAC-SHA256**.
* **منع ثغرات IDOR:** تحقق صارم من ملكية الطلبات والفواتير في كل استعلام.

---

## 🛠️ التقنيات المستخدمة (Tech Stack)

| المجال | التقنية المستخدمة |
| :--- | :--- |
| **Backend Framework** | C# 13, ASP.NET Core 9 MVC |
| **Data Access** | Entity Framework Core 9 (Npgsql Provider) |
| **Database** | PostgreSQL (Neon Serverless Cloud DB) |
| **Authentication** | Cookie Authentication + Google OAuth 2.0 |
| **Frontend** | Modern Semantic HTML5, CSS3 Variables, Vanilla JavaScript |
| **UI Components** | Bootstrap 5, Precision Inline SVGs |
| **Integrations** | Discord Webhooks / Bot, Gmail SMTP |
| **Hosting & Deploy** | Render / Docker / Linux Container |

---

## 🚀 دليل البدء والتشغيل للمطورين (Getting Started)

### 1. المتطلبات الأساسية (Prerequisites)
* تثبيت [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).
* محرر أكواد: [Visual Studio 2022](https://visualstudio.microsoft.com/) أو [VS Code](https://code.visualstudio.com/).
* أداة [Git](https://git-scm.com/).

### 2. استنساخ المستودع (Clone Repository)
```bash
git clone https://github.com/LogiCore-Team/YAGOT.git
cd YAGOT
```

### 3. إعداد ملف التكوين المحلي (Configuration Setup)
الملف الأساسي `appsettings.json` مخصص للإنتاج العام وخالٍ تماماً من أي بيانات حساسة أو روابط اتصال.
لتشغيل المشروع محلياً على جهازك، قم بإنشاء ملف `appsettings.Development.json` (المحمي تلقائياً بـ `.gitignore` ولا يُرفع للمستودع) وضع فيه بيانات الاتصال الخاصة ببيئتك المحلية، أو استخدم **.NET User Secrets**.

### 4. بناء وتشغيل المشروع (Build & Run)
```bash
# استعادة الحزم وبناء المشروع
dotnet restore
dotnet build

# تشغيل خادم التطوير المحلي
dotnet run
```
افتح المتصفح وتوجه إلى: `https://localhost:7279`

---

## 🌿 قواعد العمل بالفروع والمساهمة (Git Workflow)

للحفاظ على جودة واستقرار الكود، نتبع القواعد التالية:

1. **حماية فرع `main`:**
   * يُمنع منعاً باتاً الرفع المباشر (`git push origin main`).
   * جميع التعديلات تُدمج حصراً عبر **Pull Requests (PR)**.
2. **إنشاء الفروع الجديدة:**
   * قبل بدء أي ميزة، اسحب آخر تحديثات `main`:
     ```bash
     git checkout main && git pull origin main
     ```
   * سمّ فرعك بوضوح بحسب نوع العمل:
     * `feat/feature-name` (للميزات الجديدة)
     * `fix/bug-fix-name` (للإصلاحات والتحسينات)
3. **تحديث الفرع قبل الدمج:**
   * احرص دائماً على أن يكون فرعك محدثاً بآخر نسخة من `main` لتفادي التعارضات البرمجية.

---

## 👥 فريق العمل (Team)

* **المطور والمالك:** فريق **LogiCore Team**.
* **سيرفر المطورين:** مربوط بـ Discord للإشعارات اللحظية ومتابعة الـ PRs.

---

<p align="center">
  صُنع بشغف بواسطة فريق <strong>LogiCore</strong> © 2026
</p>