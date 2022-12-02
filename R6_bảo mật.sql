use QLBH_HOI
--Bước 1: Tạo nhóm chủ cửa hàng
create role chucuahang
--Bước 2: Cấp quyền cho nhóm chucuahang
grant select, update, delete on BAN to chucuahang
grant select, update, delete on BAN_CHI_TIET to chucuahang
grant select, update, delete on NHAP to chucuahang
grant select, update, delete on NHAP_CHI_TIET to chucuahang
grant select, update, delete on NHACUNGCAP to chucuahang
grant select, update, delete on CONGNO to chucuahang
grant select, update, delete on HANGHOA to chucuahang
grant select, update, delete on NHANVIEN to chucuahang
grant select, update, delete on KHACHHANG to chucuahang
--Bước 3: Thêm user vào nhóm chucuahang
create login chuch with password='123abcde'
create user chuch for login chuch
sp_addrolemember 'chucuahang', 'chuch'

--Bước 1: Tạo nhóm nhân viên
create role nhanvien
--Bước 2: Cấp quyền cho nhóm nhanvien
grant select, update on BAN to nhanvien
grant select, update on BAN_CHI_TIET to nhanvien
grant select, update on NHAP to nhanvien
grant select, update on NHAP_CHI_TIET to nhanvien
grant select, update on HANGHOA to nhanvien
grant select, update on KHACHHANG to nhanvien
--Bước 3: Thêm user vào nhóm nhanvien
create login nvien with password='0987654321'
create user nvien for login nvien
sp_AddRoleMember 'nhanvien', 'nvien'


