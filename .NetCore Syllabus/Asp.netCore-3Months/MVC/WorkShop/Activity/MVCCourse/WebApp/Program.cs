using Microsoft.AspNetCore.Builder;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//1.app.MapGet("/", () => "Hello World!");
//first thing is that the application maps the root url(() => "Hello World!"))basically this the function
//()- this function doest have any parameter if you have any parameter it will go over here and the function return a s
//string hello world
////this is the first thing that it is does right it maps the request to this function
///// second thing this function process the request by simply return the string
///third the string  return the part of http response to the browser and it is renders on the browser
app.MapGet("/", (HttpContext context) => {
    string html = @"<html>
<head></head>
<body>
<h1>Hello World</h1>
<p>this is the first thing </p></body></html>";
    writeHtml(context, html);
});
void writeHtml(HttpContext context,string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength =Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}
app.Run();
