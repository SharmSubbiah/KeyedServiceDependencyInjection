using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKeyedSingleton<IPaymentProcessor, CreditCardProcessor>("creditCard");
builder.Services.AddKeyedSingleton<IPaymentProcessor, PayPalProcessor>("paypal");
builder.Services.AddKeyedSingleton<IPaymentProcessor, BitcoinProcessor>("bitcoin");
builder.Services.AddSingleton<CreditCardWrapper>();
builder.Services.AddSingleton<PayPalWrapper>();

var app = builder.Build();

app.MapGet("/creditcard",  ([FromKeyedServices("sms")] CreditCardWrapper creditCard) => creditCard.ProcessPaym(12));
app.MapGet("/paypal", (CreditCardWrapper paypal) => paypal.ProcessPaym(12));
    
app.Run();

 