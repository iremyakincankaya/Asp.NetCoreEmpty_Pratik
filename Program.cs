var builder = WebApplication.CreateBuilder(args);

// MVC hizmetlerini ekleme
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware ayarlar�
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsay�lan rotay� ayarlama
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Gerekli hizmetler eklenir
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTPS y�nlendirme
app.UseHttpsRedirection();

// Statik dosyalar i�in middleware
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Varsay�lan rotay� ayarlay�n
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Gerekli hizmetler eklenir
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTPS y�nlendirme
app.UseHttpsRedirection();
app.UseStaticFiles();

// Routing middleware'i etkinle�tirilir
app.UseRouting();

app.UseAuthorization();

// Varsay�lan rota yap�land�rmas�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Controller:
// MVC mimarisinde, gelen istekleri i�leyen ve uygun bir yan�t d�nd�ren s�n�flard�r. 
// Controller'lar i� mant���n� ve y�nlendirme i�lemini ger�ekle�tirir.

// Action:
// Controller i�inde tan�ml� metodlard�r. Bir HTTP iste�i geldi�inde Action �al���r 
// ve genellikle bir View veya veri d�ner. �rne�in, `Index()` gibi bir Action taray�c�ya yan�t d�ner.

// Model:
// Verilerin temsilini sa�lar. Uygulaman�n i� mant��� ve veritaban� katman� ile �al���r. 
// Model, genellikle veri yap�s�n� ve i� mant���n� kapsar (�rne�in, bir `Product` s�n�f�).

// View:
// Kullan�c�ya g�sterilecek olan sayfan�n tasar�m�n� ve i�eri�ini tan�mlayan dosyalard�r.
// Genelde Razor (*.cshtml) dosyalar� olarak bulunur ve kullan�c� aray�z�n� olu�turur.

// Razor:
// .NET i�in bir sayfa �ablonlama motorudur. Razor, HTML i�aretlemeleri ile C# kodunun 
// bir arada kullan�lmas�n� sa�lar. �rne�in, `@model` veya `@foreach` gibi Razor s�z dizimiyle i�lem yap�labilir.

// RazorView:
// Razor ile olu�turulan View dosyalar�n�n taray�c�ya g�nderilmeden �nce i�lenmi� halidir.
// Controller'dan gelen veri, RazorView ile birle�tirilerek HTML ��kt�s� olu�turulur.

// wwwroot:
// Statik dosyalar�n (CSS, JavaScript, resimler vb.) depoland��� klas�rd�r. Bu klas�rdeki dosyalar 
// taray�c� taraf�ndan do�rudan eri�ilebilir. �rne�in, bir CSS dosyas� `/css/style.css` olarak �a�r�labilir.

// builder.Build():
// Uygulama nesnesini olu�turur. `builder` nesnesinde yap�land�r�lan servisler, middleware ve ayarlar 
// `Build()` �a�r�s�yla bir `WebApplication` nesnesine d�n��t�r�l�r.

// app.Run():
// Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinler. 
// Bu metod �a�r�ld���nda, uygulama sonsuz bir d�ng�ye girer ve istekleri i�lemeye ba�lar.



