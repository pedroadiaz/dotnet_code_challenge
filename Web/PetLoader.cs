using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Properties;

namespace Web
{
    public static class PetLoader
    {
        public static void LoadBreeds()
        {
            LoadBreed("Labrador", Resources.Labrador);
            LoadBreed("Yorkie", Resources.Yorkie);
            LoadBreed("Retriever", Resources.Retriever);
            LoadBreed("Pug", Resources.Pug);
        }

        private static void LoadBreed(string breed, string resource)
        {
            var list = resource.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var image in list)
            {
                //TODO: load data into object context
            }
        }
    }
}