# no-flag

function

CREATE FUNCTION F_login (@username NVARCHAR(10),
                         @password NVARCHAR(10),
                         @role     NVARCHAR(10))
returns INT
AS
  BEGIN
      RETURN ( CASE
                 WHEN @role = 'DG'
                      AND EXISTS (SELECT *
                                  FROM   docgia
                                  WHERE  taikhoan = @Username
                                         AND matkhau = @Password) THEN 1
                 WHEN @role = 'AD'
                      AND EXISTS (SELECT *
                                  FROM   nhanvien
                                  WHERE  taikhoan = @Username
                                         AND matkhau = @Password
                                         AND vaitro = 'AD') THEN 2
                 WHEN @role = 'NV'
                      AND EXISTS (SELECT *
                                  FROM   nhanvien
                                  WHERE  taikhoan = @Username
                                         AND matkhau = @Password
                                         AND vaitro = 'NV') THEN 3
                 ELSE 4
               END )
  END
  
select dbo.F_Login('admin', 'admin','AD')
