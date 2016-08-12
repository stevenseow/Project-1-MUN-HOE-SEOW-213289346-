using Android.App;
using Android.Widget;
using Android.OS;

namespace Project1_StudyPlanner
{
	[Activity(Label = "Project1_StudyPlanner", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		Button buttonAddNote;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			//Button add to another view
			buttonAddNote = FindViewById<Button>(Resource.Id.buttonAdd);


			if (buttonAddNote != null)
			{
				buttonAddNote.Click += (sender, e) =>
				{
					StartActivity(typeof(NoteTakingActivity));
				} ;
			}

		}
	}
}


