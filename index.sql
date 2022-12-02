--Tạo index
CREATE NONCLUSTERED INDEX IX_HANGHOA_TenMH ON HANGHOA (TenMH)
--Select khi Không có index
select *from HANGHOA
with (index(0))
where TenMH=N'Dầu Neptune 1:1:1'
--Select khi có index
select *from HANGHOA
with (index(IX_HANGHOA_TenMH))
where TenMH=N'Dầu Neptune 1:1:1'


