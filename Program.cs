var builder = WebApplication.CreateBuilder(args);

// MVC hizmetlerini ekleme
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware ayarlarý
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsayýlan rotayý ayarlama
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Gerekli hizmetler eklenir
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTPS yönlendirme
app.UseHttpsRedirection();

// Statik dosyalar için middleware
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Varsayýlan rotayý ayarlayýn
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Gerekli hizmetler eklenir
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTPS yönlendirme
app.UseHttpsRedirection();
app.UseStaticFiles();

// Routing middleware'i etkinleþtirilir
app.UseRouting();

app.UseAuthorization();

// Varsayýlan rota yapýlandýrmasý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Controller:
// MVC mimarisinde, gelen istekleri iþleyen ve uygun bir yanýt döndüren sýnýflardýr. 
// Controller'lar iþ mantýðýný ve yönlendirme iþlemini gerçekleþtirir.

// Action:
// Controller içinde tanýmlý metodlardýr. Bir HTTP isteði geldiðinde Action çalýþýr 
// ve genellikle bir View veya veri döner. Örneðin, `Index()` gibi bir Action tarayýcýya yanýt döner.

// Model:
// Verilerin temsilini saðlar. Uygulamanýn iþ mantýðý ve veritabaný katmaný ile çalýþýr. 
// Model, genellikle veri yapýsýný ve iþ mantýðýný kapsar (örneðin, bir `Product` sýnýfý).

// View:
// Kullanýcýya gösterilecek olan sayfanýn tasarýmýný ve içeriðini tanýmlayan dosyalardýr.
// Genelde Razor (*.cshtml) dosyalarý olarak bulunur ve kullanýcý arayüzünü oluþturur.

// Razor:
// .NET için bir sayfa þablonlama motorudur. Razor, HTML iþaretlemeleri ile C# kodunun 
// bir arada kullanýlmasýný saðlar. Örneðin, `@model` veya `@foreach` gibi Razor söz dizimiyle iþlem yapýlabilir.

// RazorView:
// Razor ile oluþturulan View dosyalarýnýn tarayýcýya gönderilmeden önce iþlenmiþ halidir.
// Controller'dan gelen veri, RazorView ile birleþtirilerek HTML çýktýsý oluþturulur.

// wwwroot:
// Statik dosyalarýn (CSS, JavaScript, resimler vb.) depolandýðý klasördür. Bu klasördeki dosyalar 
// tarayýcý tarafýndan doðrudan eriþilebilir. Örneðin, bir CSS dosyasý `/css/style.css` olarak çaðrýlabilir.

// builder.Build():
// Uygulama nesnesini oluþturur. `builder` nesnesinde yapýlandýrýlan servisler, middleware ve ayarlar 
// `Build()` çaðrýsýyla bir `WebApplication` nesnesine dönüþtürülür.

// app.Run():
// Uygulamayý baþlatýr ve gelen HTTP isteklerini dinler. 
// Bu metod çaðrýldýðýnda, uygulama sonsuz bir döngüye girer ve istekleri iþlemeye baþlar.



