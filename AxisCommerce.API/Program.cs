using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Application.Services.Caixa;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Application.Services.Lojas;
using AxisCommerce.Domain.Interfaces.Autenticacao;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using AxisCommerce.Infrastructure.Repositories.Autenticacao;
using AxisCommerce.Infrastructure.Repositories.Caixa;
using AxisCommerce.Infrastructure.Repositories.Clientes;
using AxisCommerce.Infrastructure.Repositories.Loja;
using AxisCommerce.Infrastructure.Services.Autenticacao;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Adicionando o DbContext com a string de conexão
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando os controladores e a documentação do Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});

builder.Services.AddSwaggerGen(options =>
{
    typeof(ApiGroupNames).GetFields().Skip(1).ToList().ForEach(f =>
    {
        var info = f.GetCustomAttributes(typeof(GroupInfoAttribute), false).OfType<GroupInfoAttribute>().FirstOrDefault();
        options.SwaggerDoc(f.Name, new OpenApiInfo
        {
            Title = info?.Title,
            Version = info?.Version,
            Description = info?.Description,
        });
    });

    options.DocInclusionPredicate((docName, apiDescription) =>
    {
        if (docName == "v1")
        {
            return string.IsNullOrEmpty(apiDescription.GroupName);
        }
        else
        {
            return apiDescription.GroupName == docName;
        }
    });
    
    var provider = builder.Services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
    foreach (var description in provider.ApiVersionDescriptions)
    {
        options.SwaggerDoc(description.GroupName, new OpenApiInfo
        {
            Title = $"AxisCommerce API {description.ApiVersion}",
            Version = description.ApiVersion.ToString()
        });
    }
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Insira JWT com portador no campo, exemplo: Bearer {seu token}"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
});

// Registrando o repositório e o serviço de armazenamento de arquivos
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddScoped<ICaixaControleRepository, CaixaControleRepository>();
builder.Services.AddScoped<ICaixaFechamentoRepository, CaixaFechamentoRepository>();
builder.Services.AddScoped<ICaixaLancamentoRepository, CaixaLancamentoRepository>();
builder.Services.AddScoped<ICaixaRecebimentoRepository, CaixaRecebimentoRepository>();
builder.Services.AddScoped<ICaixaRecebimentoPgtoRepository, CaixaRecebimentoPgtoRepository>();
builder.Services.AddScoped<ITipoLancamentoRepository, TipoLancamentoRepository>();

builder.Services.AddScoped<IClienteClassificacaoRepository, ClienteClassificacaoRepository>();
builder.Services.AddScoped<IClienteEscolaridadeRepository, ClienteEscolaridadeRepository>();
builder.Services.AddScoped<IClienteFaixaRendaRepository, ClienteFaixaRendaRepository>();
builder.Services.AddScoped<IClienteProfissaoRepository, ClienteProfissaoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteSubTipoRepository, ClienteSubTipoRepository>();
builder.Services.AddScoped<IClienteTipoRepository, ClienteTipoRepository>();

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<ILojaControleRepository, LojaControleRepository>();
builder.Services.AddScoped<ILojaRepository, LojaRepository>();
builder.Services.AddScoped<ILojaHorarioRepository, LojaHorarioRepository>();
builder.Services.AddScoped<ITerminalRepository, TerminalRepository>();
builder.Services.AddScoped<ITransportadoraRepository, TransportadoraRepository>();
builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();


builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddScoped<ICaixaControleService, CaixaControleService>();
builder.Services.AddScoped<ICaixaFechamentoService, CaixaFechamentoService>();
builder.Services.AddScoped<ICaixaLancamentoService, CaixaLancamentoService>();
builder.Services.AddScoped<ICaixaRecebimentoService, CaixaRecebimentoService>();
builder.Services.AddScoped<ICaixaRecebimentoPgtoService, CaixaRecebimentoPgtoService>();
builder.Services.AddScoped<ITipoLancamentoService, TipoLancamentoService>();

builder.Services.AddScoped<IClienteClassificacaoService, ClienteClassificacaoService>();
builder.Services.AddScoped<IClienteEscolaridadeService, ClienteEscolaridadeService>();
builder.Services.AddScoped<IClienteFaixaRendaService, ClienteFaixaRendaService>();
builder.Services.AddScoped<IClienteProfissaoService, ClienteProfissaoService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IClienteSubTipoService, ClienteSubTipoService>();
builder.Services.AddScoped<IClienteTipoService, ClienteTipoService>();

builder.Services.AddScoped<IFornecedorService, FornecedorService>();
builder.Services.AddScoped<ILojaControleService, LojaControleService>();
builder.Services.AddScoped<ILojaService, LojaService>();
builder.Services.AddScoped<ILojaHorarioService, LojaHorarioService>();
builder.Services.AddScoped<ITerminalService, TerminalService>();
builder.Services.AddScoped<ITransportadoraService, TransportadoraService>();
builder.Services.AddScoped<IVendedorService, VendedorService>();

// Configuração de CORS para permitir o frontend em React
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactAppPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // Substitua pelo endereço correto do frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Configurando a autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var jwtSettings = builder.Configuration.GetSection("JwtSettings");
        var secretKey = jwtSettings.GetValue<string>("SecretKey");

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.GetValue<string>("Issuer"),
            ValidAudience = jwtSettings.GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        typeof(ApiGroupNames).GetFields().Skip(1).ToList().ForEach(f =>
        {
            var info = f.GetCustomAttributes(typeof(GroupInfoAttribute), false).OfType<GroupInfoAttribute>().FirstOrDefault();
            options.SwaggerEndpoint($"/swagger/{f.Name}/swagger.json", info != null ? info.Title : info.Description);
        });
    });
}

app.UseHttpsRedirection();

app.UseCors("ReactAppPolicy"); // Ativando a política de CORS
app.UseAuthentication();        // Adiciona autenticação ao pipeline
app.UseAuthorization();

app.MapControllers();

app.Run();
