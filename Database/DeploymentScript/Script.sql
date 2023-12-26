dotnet ef dbcontext scaffold "Server=DESKTOP-2VPR9IB\LOCALHOST;Database=Ghumakkad;;User ID=sa;Password=sql;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Database

create table Articles(ArticleId int identity(1,1) primary key, Title varchar(max), Description text, State int,IsActive int,
CreatedBy int, CreatedDate Date,
UpdatedBy int, UpdatedDate Date

)