
# THỰC TẬP CHUYÊN MÔN NĂM HỌC 2019-2020
Họ tên: Phan Thành Nên
Mã sinh viên: 5851071044
Lớp:
## Đề tài: Quản lý sinh viên
## Phần 1: Công nghệ sử dụng
- VS 2017, Sql server 2017
- Ngôn ngữ c#, T-SQL
- Framework Guna UI
## Phần 2: Các chức năng đã hoàn thành
- Form tra cứu sinh viên: nhập mã sinh viên để xem bảng điểm, biểu đồ điểm trung qua các kỳ và các môn đang học trong kỳ.
- Form Khoa ngành: thêm sửa xoá khoa và ngành học.
- Form Giảng viên: thêm sửa xoá giảng viên.
- Form Lớp: thêm sửa xoá Lớp học.
- Form Sinh viên: thêm sửa xoá sinh viên, nhập excel và thêm, đăng ký môn học, cho phép học lại.
- Form Môn học: thêm sửa môn học theo ngành và theo kỳ học. Tạo sửa xoá Lớp học phần theo học kỳ.
- Form nhập sửa điểm: thêm sửa điểm theo sv và ngành, Gửi mail, Gửi điểm, Xuất file excel,Điểm danh, chỉnh sửa phần trăm giữa các cột điểm.
- Form thống kê: Thống kê điểm sinh viên theo ngành và lớp, xem sinh viên nợ môn theo lớp, thống kê biểu đồ điểm theo kỳ, sinh viên nợ theo kỳ.
- Cho phép user đổi mật khẩu.
## Phần 3: Các chức năng chưa hoàn thành
- Quản lý và tra cứu thời khoá biểu.

## Hướng dẫn sử dụng
- Khi chạy ứng dụng hahãy kết nối trước bằng cách ấn nút kết nối. Nhập tên server máy và tên database.
- Form tra cứu sinh viên: nhập mã sinh viên để xem bảng điểm, biểu đồ điểm trung qua các kỳ và các môn đang học trong kỳ.
- Đăng ký: tài khoản đăng ký đầu tiên sẽ là admin. Các tài khoản sau sẽ phải nhập mã giảng viên làm tên đăng nhập.
- Đăng nhập: nhập tài khoản và mật khẩu.
- Form Khoa ngành: Nhập thông tin để thêm khoa/ngành. Chức năng sửa xoá nằm trong button mũi tên bên phải.
- Form Giảng viên: Nhập thông tin, chọn khoa để thêm giảng viên.
- Form Lớp: Nhập thông tin và chọn giáo viên chủ nhiệm để thêm lớp.
- Form Sinh viên: Chọn ngành, lớp để thêm sửa xoá sinh viên. Nhập excel: chọn file -> Chọn sheet góc trái dưới -> click vào hàng và ấn nút thêm.
- Form Môn học: Tạo học kì góc trái trên. Chọn ngành, nhập thông tin kỳ học, số tin chỉ để thêm sửa xoá Môn học. Chuyển chế độ môn học và lớp học phần ở góc phải trên. Tạo lớp bằng cách nhấn vào môn học. Có thể lọc môn theo kì bằng số kỳ bên phải trên.
- Form nhập sửa điểm: 
  + Chọn giáo viên, lớp học phần để xem điểm.
  + click vào một hàng để xem điểm và chỉnh sửa. Có thể điều chỉnh phần trăm điểm trên hàng điểm.
  + Điểm danh: Bắt đầu điểm danh -> Click vào cột điểm danh trong bảng để thay đổi có hay ko có mặt.
  + Gửi điểm: chọn lớp và nhập thông tin gmail và mật khẩu -> check vào gửi tất cả để gửi điểm cho cả lớp, ko check sẽ chỉ gửi cho 1 sinh viên đang chọn.
  + Gửi tin nhắn: tương tự như gửi điểm nhưng có thể điều chỉnh nội dung tin nhắn.
  + Xuất excel: Chọn lớp và ấn xuất excel.
- Form thống kê: Chọn ngành và lớp để xem điểm sinh viên trong lớp.
  + Nút sinh viên giỏi và yếu để lọc ra sinh viên theo điểm.
  + Nút sinh viên nợ môn để xem sinh viên nợ môn gì theo kì.
- Đổi mật khẩu: nhập mật khẩu cũ và mới để đổi.
- Form tra cứu sinh viên: Nhập mã sinh viên để tra cứu.
- Các lỗi có thể gặp khi khởi chạy lần đầu:
  + Lỗi ExcelDataReader. cách giải quyết: Truy cập Manage NuGet Packages... và Restore hoặc có thể gỡ và cài lại gói ExcelDataReader.
  + Lỗi trong file Program.cs(Rất hiếm gặp). Cách giải quyết

Xin cám ơn!
