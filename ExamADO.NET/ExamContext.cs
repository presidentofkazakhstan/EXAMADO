namespace ExamADO.NET
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExamContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ExamContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ExamADO.NET.ExamContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ExamContext" 
        // в файле конфигурации приложения.
        public ExamContext()
            : base("name=ExamContext")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Street> Streets { get; set; }
    }

}