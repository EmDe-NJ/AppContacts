using System;
using Xamarin.Forms;

namespace AppContacts
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Command<Type> navigateCommand =
            new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            });

            this.Title = "My Contacts";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Main Menu")
                    {
                        new TextCell
                        {
                            Text = "Add and Display Contacts",
                            Command = navigateCommand,
                            CommandParameter = typeof(MainDisplayPage)
                        },

                        new TextCell
                        {
                            Text = "Display Selected Contacts",
                            Command = navigateCommand,
                            CommandParameter = typeof(MainPage)
                        },
                    }
                }
            };
        }
    }
}
