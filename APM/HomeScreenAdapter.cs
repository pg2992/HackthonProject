using System;
using Android.App;
using Android.Widget;
using Android.Views;
using System.Collections.Generic;

namespace APM
{
	public class HomeScreenAdapter : BaseAdapter<Application>
	{ 
		List<Application> items;
		Activity context;
		public HomeScreenAdapter(Activity context, List<Application> items) : base() {
			this.context = context;
			this.items = items;
		}


		#region implemented abstract members of BaseAdapter
		public override long GetItemId(int position)
		{
			return position;
		}

		public override Application this [int index] {
			get{return items [index]; }
		}

		public override int Count {
			get { return items.Count; }
		}

		#endregion


		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView; // re-use an existing view, if one is available
			if (view == null) // otherwise create a new one
				view = context.LayoutInflater.Inflate(APM.Resource.Layout.CustomView, null);
				
			view.FindViewById<TextView>(APM.Resource.Id.Text1).Text = items[position].AppName;
			view.FindViewById<ImageView> (APM.Resource.Id.Image).SetImageDrawable (items [position].Icon);
			view.FindViewById<ImageView> (APM.Resource.Id.PImage1).SetImageResource (APM.Resource.Drawable.Contacts);
			view.FindViewById<ImageView> (APM.Resource.Id.PImage2).SetImageResource (APM.Resource.Drawable.Contacts);
			view.FindViewById<ImageView> (APM.Resource.Id.PImage3).SetImageResource (APM.Resource.Drawable.Contacts);
			view.FindViewById<ImageView> (APM.Resource.Id.PImage4).SetWillNotDraw (true);
			return view;
		}
	}
}

