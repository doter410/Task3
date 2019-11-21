using System;
using System.Threading.Tasks;
using Android.Content;
using Xamarin.Forms;
using VideoPlayerDemos.Droid;

[assembly: Dependency(typeof(FormsVideoLibrary.Droid.VideoPicker))]

namespace FormsVideoLibrary.Droid
{
    public class VideoPicker : IVideoPicker
    {
        public Task<string> GetVideoFileAsync()
        {
            
            Intent intent = new Intent();
            intent.SetType("video/*");
            intent.SetAction(Intent.ActionGetContent);

            
            MainActivity activity = MainActivity.Current;

            
            activity.StartActivityForResult(
                Intent.CreateChooser(intent, "Select Video"),
                MainActivity.PickImageId);

            
            activity.PickImageTaskCompletionSource = new TaskCompletionSource<string>();

            
            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}