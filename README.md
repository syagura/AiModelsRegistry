# 🤖 AI Model Registry

Aplikasi web CRUD berbasis **ASP.NET Core MVC** untuk mengelola dan melacak AI model beserta eksperimen yang pernah dilakukan. Aplikasi ini mensimulasikan tools yang biasa digunakan tim AI/ML untuk mencatat, memantau, dan mengelola lifecycle machine learning model — mulai dari fase eksperimental hingga production.

---

## 💡 Latar Belakang 

Seorang AI Engineer biasanya mengelola banyak model sekaligus — berbeda versi, algoritma, dan akurasi. Tanpa sistem tracking yang proper, akan mudah sekali kehilangan overview model mana yang ada di production, mana yang masih eksperimen, dan mana yang sudah deprecated.

Aplikasi ini dibuat sebagai solusi sederhana untuk masalah tersebut — registry untuk mencatat dan memantau lifecycle AI model.

---

## 🛠️ Tech Stack
- **ASP.NET Core MVC** (.NET 8)
- **Entity Framework Core 8**
- **SQL Server 2025**
- **Bootstrap 5**

---

## ⚙️ Prasyarat
- .NET 8 SDK
- SQL Server 2025
- Visual Studio 2022

---

## 🚀 Cara Menjalankan Aplikasi

### 1. Clone repository
```bash
git clone https://github.com/syagura/AiModelsRegistry.git
cd AiModelRegistry
```

### 2. Setup Database
Sesuaikan connection string di `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=AiModelRegistryDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Jalankan Migrasi
```bash
dotnet ef database update
```

### 4. Jalankan Aplikasi
```bash
dotnet run
```
Atau tekan **F5** di Visual Studio 2022.

Aplikasi akan berjalan di `https://localhost:xxxx/AiModels`

---

## 📋 Fitur
- [x] Tambah AI model baru
- [x] Lihat daftar semua model beserta status badge
- [x] Lihat detail informasi tiap model
- [x] Edit dan update data model
- [x] Hapus model dengan halaman konfirmasi

---

## 📊 Penjelasan Field

| Field | Keterangan |
|---|---|
| **Model Name** | Nama unik AI model (contoh: `GPT-Sentiment-v1`) |
| **Version** | Nomor versi model (contoh: `1.0.0`) |
| **Algorithm** | Algoritma ML yang digunakan (contoh: `Transformer`, `Random Forest`) |
| **Accuracy (%)** | Skor akurasi model antara 0-100 |
| **Status** | Status lifecycle: `Production`, `Experimental`, atau `Deprecated` |
| **Description** | Deskripsi singkat tujuan model |
| **Created Date** | Waktu entry model dibuat |

---

## 📁 Struktur Project
```
AiModelRegistry/
├── Controllers/
│   └── AiModelsController.cs   # Menangani semua logika CRUD
├── Models/
│   ├── AiModel.cs              # Data model & aturan validasi
│   └── AppDbContext.cs         # Entity Framework DB context
├── Views/
│   └── AiModels/
│       ├── Index.cshtml        # Halaman daftar semua model
│       ├── Create.cshtml       # Form tambah model baru
│       ├── Edit.cshtml         # Form edit model
│       ├── Details.cshtml      # Halaman detail model
│       └── Delete.cshtml       # Halaman konfirmasi hapus
└── appsettings.json            # Konfigurasi & connection string
```

---

## 👨‍💻 Author
Syahrul Gunawan Ramdhani