using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Text;
using SASS.Views.Authentication;
using SASS.Views.Main;
using SASS.Views.Notification;
using SASS.Views.Profile;
using SASS.Views.Settings;

namespace SASS.ViewModels
{
   public class TabViewModel
    {
        public TabItemCollection sfTabItems { get; set; }


        public TabViewModel()
        {
            getTabs();
        }

        void getTabs()
        {
            sfTabItems = new TabItemCollection();

            SfTabItem item1 = new SfTabItem
            {
                ImageSource = "home.png",
                Content = new MainPage().Content,

            };
            SfTabItem item2 = new SfTabItem
            {
                ImageSource = "bell.png",
                Content = new NotificationPage().Content
            };
            SfTabItem item3 = new SfTabItem
            {
                ImageSource = "search.png",
                Content = new NotificationPage().Content
            };
            SfTabItem item4 = new SfTabItem
            {
                ImageSource = "avata.png",
                Content = new ProfilePage().Content
            };
            SfTabItem item5 = new SfTabItem
            {
                ImageSource = "cog.png",
                Content = new SettingsPage().Content
            };

            sfTabItems.Add(item1);
            sfTabItems.Add(item2);
            sfTabItems.Add(item3);
            sfTabItems.Add(item4);
            sfTabItems.Add(item5);

        }

    }
}
