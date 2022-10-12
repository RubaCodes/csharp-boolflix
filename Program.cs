var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Editor}/{action=Index}/{id?}");

app.Run();

/*
 *  TODO:
 *  
 *  ENTITA' (MODEL)
 * - Profili: l'utente ch sfoglia il catalogo e riproduce i *contenuti*
 * - Account: contiene le informazioni di pagamento e il numero di profili identificati
 * -contenuto multimediale:
 *      -anno:
 *      -qualita'
 *      -novita: true\false
     *  -Tipologia: 
     *      -serie:
     *          -n episodi
     *          -lista episodi
     *          -stagioni
     *              -episodi per stagione
     *      -film:
     *  -cast:lista attori
     *  -generi:lista di parole che identificano un genere
     *  -caratteristiche
 * 
 * -INTERAZIONI (CONTROLLER)
 * 
 * ELEMENTI GRAFICI(VIEWS)
 * -header: e logo con barra di navigazione_L(home, serie tv, nuovi e poloari, la mia lista , sfoglia per lingua), header_R (ricerca, bambini,notifiche,profilo)
 * -hero centrale(renderBody):
 *      -in evidenza
 *      -lista di contenuti (*playlist*) divise per *categoria*
 * -footer:
 *      -riga social
 *      - 4 colonne
 *      -riga codice servizio
 *      -copyright
 *      
 *      ##component o partial */
 