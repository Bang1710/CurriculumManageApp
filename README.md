# Curriculum Management Application
Chương trình này hỗ trợ quản lý các thực thể khác nhau như khoa, giáo viên, chương trình học, môn học và phân công môn học, đảm bảo lịch trình và phân công giảng dạy được thực hiện một cách chính xác

## Link download file script sql

 - [CurriculumManagementDBFinal.sql](https://drive.google.com/file/d/1NUdlqEsM_kxgcKfaI8-lDm2Pldda7Z4i/view?usp=sharing)

 ## Features
- Quản lý thông tin Khoa, Giáo viên, Chương trình học, Môn học và Chương trình học môn, bao gồm việc thêm, sửa đổi và xóa (nếu cần) các thực thể này.
- Quản lý nhiệm vụ giảng dạy của giáo viên, bao gồm việc thêm, sửa đổi và xóa (nếu cần) các môn học mà mỗi giáo viên đảm nhiệm. Có một số ràng buộc được áp dụng, ví dụ như một giáo viên không được phép đảm nhiệm chính hơn 5 môn học khác nhau. Ngoài ra, mỗi môn học phải có ít nhất 2 giáo viên được phân công, trong đó ít nhất 1 giáo viên là người đảm nhiệm chính.
- Quản lý lịch học và phân công môn học, bao gồm việc thêm, sửa đổi và xóa (nếu cần) các khóa học được cung cấp và được giảng dạy bởi các giáo viên cụ thể. Điều này đảm bảo lịch trình cho mỗi giáo viên hợp lý và chỉ những giáo viên được phân công mới được giảng dạy môn học đó.

## Run Locally

Clone the project

```bash
  git clone https://github.com/Bang1710/CurriculumManagementApplication.git
```

Go to the project directory

```bash
  cd my-project
```
Open the App.config file in your project.

Locate the "ConnectionStrings" section in the App.config file.

Modify the value of the "connectionString" property within the "ConnectionStrings" section to a new connection string that matches your machine. For example:

```bash
  "ConnectionStrings": {
  "QuanLyChuongTrinhHocContext": "data source=YOUR_SERVER_NAME;initial catalog=YOUR_DATABASE_NAME;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework",
  ...
}
```

Run project
```bash
  Select IIS Express on Visual Studio
```
 
## Tech Stack

**Server:** C#, Windows Form, Entity Framework Core, LINQ, SQL Server


## Account demo

- Email: toanhocolympic@gmail.com
- Ps: 17102002


## Demo

link to demo: [demo/](https://ueheduvn-my.sharepoint.com/personal/31201023793_ueh_edu_vn/Documents/B%E1%BA%A3n%20ghi/Meeting%20with%20Nguy%E1%BB%85n%20V%C4%83n%20Bang%20(31201023793)-20230407_102628-Meeting%20Recording.mp4?web=1)

## Authors

- [Văn Bang](https://github.com/Bang1710)


## Feedback

If you have any feedback, please reach out to us at nvbang1710@gmail.com


## 🚀 About Me
I'm a ... loading



