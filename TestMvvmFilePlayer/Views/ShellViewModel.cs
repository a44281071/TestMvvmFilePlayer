using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace TestMvvmFilePlayer
{
    public class ShellViewModel : Conductor<FileViewModel>.Collection.AllActive, IShell
    {
        public ShellViewModel()
        {
            // video source from https://gist.github.com/jsturgis/3b19447b304616f18657

            var v1 = new FileViewModel
            {
                Width = 800,
                Height = 600,
                X = 30,
                Y = 20,
                FilePath = @"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
                DisplayName = "Big Buck Bunn"
            };
            var v2 = new FileViewModel
            {
                Width = 800,
                Height = 600,
                X = 90,
                Y = 80,
                FilePath = @"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
                DisplayName = "Elephant Dream"
            };
            var v3 = new FileViewModel
            {
                Width = 800,
                Height = 600,
                X = 270,
                Y = 160,
                FilePath = @"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerBlazes.mp4",
                DisplayName = "For Bigger Blazes"
            };
            var v4 = new FileViewModel
            {
                Width = 800,
                Height = 600,
                X = 810,
                Y = 320,
                FilePath = @"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerFun.mp4",
                DisplayName = "For Bigger Fun"
            };

            Items.Add(v1);
            Items.Add(v2);
            Items.Add(v3);
            Items.Add(v4);
        }
    }
}