1. Tại bài này các bạn qua tâm đến 2 file đóng vai trò khởi tạo 1 ứng dụng
	+ Program.cs : Tạo ra 1 Web Server với Main Methođ
		- Các ứng dụng của Dotnet Core đều là một ứng dụng Console và trong lớp Program.cs thì phải có hàm Main method.
		- Đây là điểm đầu tiên khởi chạy ứng dụng
	+ Startup.cs : Cấu hình dịch vụ và gồm 2 Functions chính
		- ConfigureServices: để định cấu hình các dịch vụ của ứng dụng . Dịch vụ là một thành phần có thể sử dụng lại cung cấp chức năng ứng dụng.
		- Configure: Bao gồm phương pháp Định cấu hình để tạo quy trình xử lý yêu cầu của ứng dụng.
			-IApplicationBuilder app: Dùng để cấu hình request pipeline
			-IWebHostEnvironment env: Dùng để chỉ ra môi trường đang hoạt động là môi trường nào