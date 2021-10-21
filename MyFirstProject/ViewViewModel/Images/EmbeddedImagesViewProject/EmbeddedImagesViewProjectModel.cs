using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModel.Images.EmbeddedImagesViewProject
{
    public class EmbeddedImagesViewProjectModel : BaseViewModel
    {
        public  EmbeddedImagesViewProjectModel()
            {
               Title = Titles.EmbeddedImagesProjectTitle;
               Image = Imager.EmbeddedImagesImage;
            }
    }
}
