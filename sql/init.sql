use DuLieu_NhanSu;
go
create table NhanVien(
	MaNhanVien nvarchar(10) NOT NULL,
	TenNhanVien nText NOT NULL,
	LuongCoBan nvarchar(12) NOT NULL,
	constraint PK_NhanVien primary key (MaNhanVien)
);
go