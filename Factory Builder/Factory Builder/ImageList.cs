using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Builder
{
    static class ImageList
    {
        static List<Bitmap> _bitmapList = new List<Bitmap>(); 

        static ImageList()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Factory_Builder.Green.png");
            _bitmapList.Add(new Bitmap(myStream));

            myStream = myAssembly.GetManifestResourceStream("Factory_Builder.Red.png");
            _bitmapList.Add(new Bitmap(myStream));
        }

        static public Bitmap GetImage(int index)
        {
            return _bitmapList[index];
        }
    }
}
