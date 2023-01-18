using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            { 
            //    var tag = new Tag {Name = "ASP .NET", Slug = "aspnet"};
            //     context.Tags.Add(tag); //salva no programa
            //     context.SaveChanges(); //para salvar no banco de dados -comitar-

            //     var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
            //     tag.Name = ".NET";
            //     tag.Slug = "dotnet";

            //     context.Update(tag);
            //     context.SaveChanges();

            //     var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
            //     context.Remove(tag);
            //     context.SaveChanges();

            //    var tags = context.Tags.Where(x=> x.Name.Contains(".NET")).ToList();

            //    foreach (var tag in tags)
            //    {
            //     Console.WriteLine(tag.Name);
            //    }

            //    var tag = context
            //    .Tags
            //    .AsNoTracking()
            //    .FirstOrDefault(x=> x.Id == 1);

			//     Console.WriteLine(tag.Name);

            }
        }
    }
}