CREATE PROCEDURE AuthoLogin @Username NVARCHAR(10),
                            @Password NVARCHAR(10),
                            @Role     NVARCHAR(10)
AS
  BEGIN
      IF ( @Role = 'DG' )
        BEGIN
            IF EXISTS (SELECT *
                       FROM   DOCGIA
                       WHERE  TaiKhoan = @Username
                              AND MatKhau = @Password)
              SELECT 1 AS code
        END
      ELSE IF ( @Role = 'AD' )
        BEGIN
            IF EXISTS (SELECT *
                       FROM   NHANVIEN
                       WHERE  TaiKhoan = @Username
                              AND MatKhau = @Password
                              AND VaiTro = 'AD')
              SELECT 2 AS code
        END
      ELSE IF ( @Role = 'NV' )
        BEGIN
            IF EXISTS (SELECT *
                       FROM   NHANVIEN
                       WHERE  TaiKhoan = @Username
                              AND MatKhau = @Password
                              AND VaiTro = 'NV')
              SELECT 3 AS code
        END
      ELSE
        SELECT 4 AS code
  END 

