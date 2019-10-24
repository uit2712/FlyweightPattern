using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace DrawingImages.UseFlyweight.FlyweightFactories
{
    class MyImagesFactory
    {
        private static MyImagesFactory _instance;
        private Dictionary<string, Image> _lstImages = new Dictionary<string, Image>();

        private MyImagesFactory()
        {
            InitImages();
        }

        private void InitImages()
        {
            var keys = Images.ResourceManager
                .GetResourceSet(CultureInfo.InvariantCulture, true, true)
                .Cast<DictionaryEntry>()
                .Select(entry => entry.Key)
                .Cast<string>();


            foreach (string name in keys)
                _lstImages[name] = Images.ResourceManager.GetObject(name) as Image;
        }

        public static MyImagesFactory Instance()
        {
            if (_instance == null)
                _instance = new MyImagesFactory();

            return _instance;
        }

        public Image GetImage(string name)
        {
            if (_lstImages.ContainsKey(name))
                return _lstImages[name];

            return null;
        }
    }
}
