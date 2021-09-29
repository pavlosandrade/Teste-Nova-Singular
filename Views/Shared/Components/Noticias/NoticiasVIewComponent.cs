using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNovaSingular.Models;

namespace TesteNovaSingular.Views.Shared.Components.Noticias
{
    public class NoticiasVIewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Noticias = new List<NoticiasViewModel>();
            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja mais"
            });

            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja Mais"
            });

            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja Mais"
            });
            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja mais"
            });

            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja Mais"
            });

            Noticias.Add(new NoticiasViewModel()
            {
                Title = "Espaço",
                Descricao = "NASA testará técnica para reduzir o estresse em plantas cultivadas no espaço.",
                Img = "/thumbs/news2.png",
                Link = "Veja Mais"
            });
            return View(Noticias);
        }
    }
}
