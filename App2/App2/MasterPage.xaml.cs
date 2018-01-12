using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Mapa",
                IconSource = "contacts.png",
                TargetType = typeof(ContactsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Lista",
                IconSource = "todo.png",
                TargetType = typeof(TodoList)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Salir",
                IconSource = "reminders.png",
                TargetType = typeof(ReminderPage)
            });

           

            listView.ItemsSource = masterPageItems;


        }
    }
}