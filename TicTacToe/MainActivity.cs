using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace TicTacToe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", Icon = "@mipmap/icon", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        int phase;
        string[,] tab;
        Intent intent;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            intent = new Intent(this, typeof(victoryPage));
            phase = 1;
            tab = new string[3,3];
            
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            Initial();


        }

        private void Play(string tag,TextView text)
        {
            text.Text = Game.Play(phase,tag,tab);
            text.SetTextColor(Android.Content.Res.ColorStateList.ValueOf(Game.GetColor(text.Text)));
            text.TextSize = 50;
            phase++;

            if (Game.Win(tab))
            {
                intent.PutExtra("Gagnant", "Le " + Game.Winner(phase - 1) + " gagne");
                StartActivity(intent);
            }
            if (Game.Tie(tab))
            {
                intent.PutExtra("Gagnant", "Match nul");
                StartActivity(intent);
            }
            
            
        }

        private void Initial()
        {
            FindViewById<TextView>(Resource.Id.Textview1).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview1).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview1));

            FindViewById<TextView>(Resource.Id.Textview2).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview2).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview2));
            
            FindViewById<TextView>(Resource.Id.Textview3).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview3).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview3));

            FindViewById<TextView>(Resource.Id.Textview4).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview4).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview4));
            FindViewById<TextView>(Resource.Id.Textview5).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview5).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview5));
            FindViewById<TextView>(Resource.Id.Textview6).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview6).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview6));

            FindViewById<TextView>(Resource.Id.Textview7).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview7).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview7));
            FindViewById<TextView>(Resource.Id.Textview8).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview8).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview8));
            FindViewById<TextView>(Resource.Id.Textview9).Click += (e, o) => Play(FindViewById<TextView>(Resource.Id.Textview9).Tag.ToString(), FindViewById<TextView>(Resource.Id.Textview9));
        }

       
    }
}