//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//DependencyInjection טיפול בהזרקת התלויות 
//בשלב הפיתוח נזריק את המחלקה הבאה
//builder.Services.AddScoped<IDal_Repository.IDalRepository<Dto_Common_Enteties.ProductDto>, Dal_Repository.BugabooDal>();
//builder.Services.AddScoped<IBll_Services.IBugabooBll, Bll_Services.BugabooBll>();
//להזרקה של מסד הנתונים יש פקודה יעודית מאחר וזו פקודה שימושית ויש לה אופציות נוספות
//ישנם דרכים רבות להזריק מחלקה זו , אנחנו כעת נבחר בשיטה הבאה
//builder.Services.AddDbContext<Dal_Repository.models.ProjectBugabooContext>
//(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("SeminarConnection")));
//.LogTo(Console.WriteLine))



//נזריק את המחלקה הבאהunittest בשלב בדיקות היחידה 
//builder.Services.AddScoped<IDal_Repository.IDalRepository<Dto_Common_Enteties.CourseDto>, Dal_Repository_Mock.CoursesMock>();

//EntityFramework_DbFirst אם נרצה לגשת למסד הנתונים במקום בגישת 
//(לא למדנו)ADO.NETבגישת 
//נזריק ספריה שונה


//builder.Services.AddScoped<IDal_Repository.IDalRepository<Dto_Common_Enteties.CourseDto>, Dal_Repository_Ado.coursesADO>();
//var app = builder.Build();

// Configure the HTTP request pipeline.



//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();











//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",//����� �� ������
//    p => p.AllowAnyOrigin()//����� �� ����
//    .AllowAnyMethod()//�� ����� - �������
//    .AllowAnyHeader()));//��� ����� �������
////��� ����� �� ���� �� ������ ������ ����� ��� ������
//builder.Services.AddControllers()
//           .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

//var app = builder.Build();
//app.UseCors("AllowAll");
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


using Bll_Services;
using Dal_Repository;
using Dal_Repository.models;
using IBll_Services;
using IDal_Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Dependency Injection
builder.Services.AddScoped<IDal_Customer, CustomerDal>();

builder.Services.AddScoped<IBllCustomer, CustomerBll>();

builder.Services.AddScoped<IBugabooBll, BugabooBll>();

builder.Services.AddScoped<IDal_Product, BugabooDal>();

builder.Services.AddScoped<IBllBuy, BuyBll>();

builder.Services.AddScoped<IDalBuy, BuyDal>();

//builder.Services.AddScoped<IbllBuyDeatails,DetailsBll>();

//builder.Services.AddScoped<IdalBuyDeatails,DeatailsDal>();
//builder.Services.AddScoped < IDal_Repository.IDal_Customer < Dto_Common_Enteties.CustomerDto > Dal_Repository.CostumerDal > ();
//builder.Services.AddScoped<IBugabooBll, BugabooBll>();
//builder.Services.AddScoped<IBll_Services.IBllCustomer, Bll_Services.>();
builder.Services.AddDbContext<Dal_Repository.models.ProjectBugabooContext>(options =>
    options.UseSqlServer("Data Source=DESKTOP-E0FAPSB\\SQLEXPRESS;Initial Catalog= projectBugaboo; Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False"));
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll"); // Enable CORS
app.UseAuthorization();
app.MapControllers();
app.Run();