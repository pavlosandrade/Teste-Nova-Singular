using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNovaSingular.Models;

namespace TesteNovaSingular.Views.Shared.Components.Galeria
{
    public class GaleriaViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Galeria = new List<GaleriaViewModel>();
            Galeria.Add(new GaleriaViewModel()
            {
                Image = "/Images/nasa-slide.png",
                Thumb = "/thumbs/nasa-slide.png"
            });

            Galeria.Add(new GaleriaViewModel()
            {
                Image = "/Images/nasa-slide2.jpeg",
                Thumb = "/thumbs/nasa-slide2.jpeg"
            });

            Galeria.Add(new GaleriaViewModel()
            {
                Image = "/Images/nasa-slide3.jpg",
                Thumb = "/thumbs/nasa-slide3.jpg"
            });

            return View(Galeria);
        }
    }
}
