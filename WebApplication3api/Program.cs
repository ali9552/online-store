
using Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Extantion;
using OnlineStore.MiddleWares;
using presistences;
using presistences.Data;
using Services;
using ServicesAbstractions;
using Shared.ErrorModels;
using System.Globalization;
using AssemplyReference = Services.AssemplyReference;

namespace WebApplication3api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // ���� �� �� ������� (configuration) ���� null ��� ������� ��� RegisterAllServer
            var builder = WebApplication.CreateBuilder(args);

            // ���� �� �� ������� ����� ��� ����� �������
            builder.Services.RegisterAllServer(builder.Configuration);

            var app = builder.Build();

            // ������� ���������� ��������
            await app.configurationmiddleware();

            app.Run();
        }

    }
}
