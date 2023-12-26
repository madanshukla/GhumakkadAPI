create table Articles(ArticleId int identity(1,1) primary key, Title varchar(max), Description text, State int,IsActive int,
CreatedBy int, CreatedDate Date,
UpdatedBy int, UpdatedDate Date

)