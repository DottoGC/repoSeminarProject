/*
 * Copyright (c) 2018 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
    // [START sample]
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("DATOS PERSONALES: \n ");
await context.Response.WriteAsync("Nombre: 			Domingo Ottoniel Guarchaj Catinac. \n");
await context.Response.WriteAsync("DPI, No. de CUI:			2059 78339 0705. \n");
await context.Response.WriteAsync("Carne:				2010-20975\n");
	await context.Response.WriteAsync("Edad:				27 años. \n");
await context.Response.WriteAsync("Estado Civil:			Soltero. \n");
await context.Response.WriteAsync("Idioma Materno:		Idioma Maya K’iche’. \n");
await context.Response.WriteAsync("Segundo Idioma:		Idioma Español. \n");
await context.Response.WriteAsync("Tercer Idioma:			Idioma Ingles. \n");

            });
        }
    }
    // [END sample]
}
