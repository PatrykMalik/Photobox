using Photobox.Connections;
using Photobox.IServices;
using System;
using System.IO;
using System.Windows.Controls;

namespace Photobox.Helpers
{
    public class AssetsHelper : IAssetsHelper
    {
        public string GetPostPhotoVideo()
        {
            return GetRandStringFromStringTab(Directory.GetFiles(AssetsPaths.PostPhotoVideosPath));
        }

        public string GetPrePhotoVideo()
        {
            return GetRandStringFromStringTab(Directory.GetFiles(AssetsPaths.PrePhotoVideosPath));
        }
        //public int GetVideoLength(string path)
        //{
        //    MediaElement element = new MediaElement();
        //    element.
        //}
        public string GetStandByVideo()
        {
            return GetRandStringFromStringTab(Directory.GetFiles(AssetsPaths.StandByVideosPath));
        }
        private string GetRandStringFromStringTab(string[] paths)
        {
            var rand = new Random();
            return paths[rand.Next(0, paths.Length - 1)];
        }
    }
}
