using ASPLab.Data.Interfaces;
using ASPLab.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPLab
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllDish, MockDish>();
            services.AddTransient<IDishCategory, MockCategory>();
            services.AddMvc(mvcOptions => { mvcOptions.EnableEndpointRouting = false; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseDeveloperExceptionPage();  //����������� �������
            app.UseStatusCodePages();         //����������� ���� �������
            app.UseStaticFiles();             //��� ����������� ����� �����, ����� �� ����������, css-����� �� ����
            app.UseMvcWithDefaultRoute();     //��� ������������� �� ������������
        }
    }
}