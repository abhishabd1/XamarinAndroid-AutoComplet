using Android.App;
using Android.Widget;
using Android.OS;

namespace AutoComplete
{
    [Activity(Label = "AutoComplete", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            string[] suggestionString = { "Hello", "Hi", "Canarys", "Xamarin", "Mobile", "Abhishek" };

            var autoText = FindViewById<MultiAutoCompleteTextView>(Resource.Id.autoComplete);

            ArrayAdapter ad = new ArrayAdapter(this, Android.Resource.Layout.SimpleExpandableListItem1, suggestionString);


            autoText.Adapter = ad;
            autoText.Threshold = 1;
            autoText.SetTokenizer(new MultiAutoCompleteTextView.CommaTokenizer());
        }
    }
}

