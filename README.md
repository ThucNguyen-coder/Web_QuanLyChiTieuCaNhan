# Chương trình quản lý tài chính cá nhân

Phần mềm quản lý tài chính cá nhân là công cụ hỗ trợ người dùng theo dõi, lập kế hoạch và quản lý tài chính hàng ngày một cách hiệu quả. Với giao diện thân thiện, các tính năng như ghi chép thu chi, lập ngân sách, theo dõi nợ vay và báo cáo tài chính, phần mềm này giúp người dùng kiểm soát tài chính cá nhân dễ dàng và đưa ra các quyết định tài chính thông minh hơn.

## Các chức năng chính
- Đăng nhập
- Quản lý tài khoản thanh toán
- Quản lý thu chi
- Thống kê chi tiêu và thu nhập
- Cùng các chức năng khác

## Công nghệ sử dụng

![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![MySQL](https://img.shields.io/badge/MySQL-00000F?style=for-the-badge&logo=mysql&logoColor=white)
![JWT](https://img.shields.io/badge/json%20web%20tokens-323330?style=for-the-badge&logo=json-web-tokens&logoColor=pink)

## Cài đặt và sử dụng chương trình

Hướng dẫn chạy dự án (VS Code + Laragon)
Yêu cầu trước khi chạy

Đã cài Visual Studio Code
Đã cài Laragon (để chạy MySQL + phpMyAdmin)
Đã cài .NET SDK 8.0
Đã cài Node.js (để chạy frontend)

1. Chuẩn bị Database (Laragon)

Mở Laragon → Start All (Apache + MySQL)
Mở phpMyAdmin (thường là http://localhost/phpmyadmin)
Tạo một database mới với tên: ef

2. Clone / Tải dự án
```Bash
git clone <link-repo-của-bạn>
cd PersonalFinanceManagement
```
4. Cấu hình Backend (VS Code)

Mở Visual Studio Code
Mở thư mục backend của dự án
Chỉnh sửa file kết nối database:
Vào đường dẫn: backend/WebAPIs/appsettings.Development.json (hoặc appsettings.json)
Sửa phần ConnectionStrings như sau:

```JSON
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;user=root;password=;database=ef;SslMode=None;AllowPublicKeyRetrieval=true"
}
```
Lưu ý: Nếu bạn đã đặt password cho root MySQL thì điền vào phần password=
4. Chạy Backend
Mở Terminal trong VS Code (Ctrl + `) và chạy lần lượt các lệnh sau:
```PowerShell
# Đi đến thư mục backend
cd backend

# Restore và build
dotnet restore
dotnet build

# Chạy Backend
dotnet run --project WebAPIs
```
Backend sẽ chạy ở cổng thường là http://localhost:5000 hoặc https://localhost:5001
5. Chạy Frontend
Mở một Terminal mới (Ctrl + Shift + `), sau đó chạy:
```PowerShell
# Đi đến thư mục frontend
cd frontend

# Cài đặt package
npm install

# Chạy frontend
npm run dev
```
Frontend thường sẽ chạy ở địa chỉ: http://localhost:3000
6. Sử dụng ứng dụng

Truy cập: http://localhost:3000
Đăng ký / Đăng nhập để sử dụng

## Tổng quan ứng dụng thông qua giao diện màn hình

Giao diện trang chủ
![Trang chủ](https://i.imgur.com/zvEZLtc.png)
Giao diện đăng nhập
![Đăng nhập](https://i.imgur.com/cFmDw94.png)
Giao diện quản lý tài khoản giao dịch
![Quản lý tài khoản giao dịch](https://i.imgur.com/971SBvR.png)
Giao diện quản lý giao dịch
![Quản lý giao dịch](https://i.imgur.com/HhPscm7.png)
Giao diện thống kê theo loại giao dịch
![Thống kê theo loại giao dịch](https://i.imgur.com/25N1k26.png)
Giao diện thống kê theo tài khoản giao dịch
![Thống kê theo tài khoản giao dịch](https://i.imgur.com/S1uxgAL.png)

## Danh sách thành viên đã tham gia vào dự án

| STT    | MSSV       | Họ và tên             | Tỷ lệ đóng góp |
| ------ | ---------- | --------------------- | -------------- |
| 1      | 124000698  |	Nguyễn Huỳnh Duy Thức | 25%            |
| 2      | 124000855	| Trần Lê Thiện Trung   | 25%            |
| 3      | 124000259  |	Nguyễn Diệu Hữu       | 25%            |
| 4      | 124000521	| Phan Bảo Anh          | 25%            |
|        |            | Tổng                  | 100%           |

## Liên hệ

Bằng cách tạo issue mới thông qua repo này (thanh menu phía trên) nếu cần hỗ trợ hoặc giải đáp các thắc mắc liên quan đến dự án. Chân thành cám ơn mọi người đã quan tâm!
