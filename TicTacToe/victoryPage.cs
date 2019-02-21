using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TicTacToe
{
    [Activity(Label = "victoryPage", Theme = "@style/AppTheme", Icon = "@mipmap/icon")]
    public class victoryPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.victoryPage);
            // Create your application here
            TextView text = FindViewById<TextView>(Resource.Id.TextviewVictoire);
            text.Text = this.Intent.Extras.Get("Gagnant").ToString();
            Intent Intent = new Intent(this, typeof(MainActivity));
            FindViewById<Button>(Resource.Id.btnRetour).Click += (e, o) =>
            StartActivity(Intent);
            
        }
    }
}