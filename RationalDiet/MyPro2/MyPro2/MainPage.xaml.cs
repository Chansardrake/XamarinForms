using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyPro2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> Days;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdatePersonNumber();
        }

        async void UpdatePersonNumber()
        {
            int i = 1;
            List<Person> personList = await App.Database.GetPeopleAsync();
            foreach (var item in personList)
            {
                item.Number = i;
                i++;
                await App.Database.SavePersonAsync(item);
            }

            listView.ItemsSource = CheckListView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text) && !string.IsNullOrWhiteSpace(weightEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Age = ageEntry.Text,
                    Weight = weightEntry.Text
                });

                nameEntry.Text = ageEntry.Text = weightEntry.Text = string.Empty;
                UpdatePersonNumber();
                listView.ItemsSource = CheckListView.ItemsSource = await App.Database.GetPeopleAsync();
            }
            else
            {
                await DisplayAlert("Information", "Please enter all details!", "Ok");
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var personInfo = new IndividualDetails();
            personInfo.BindingContext = e.Item;
            App.Current.MainPage.Navigation.PushAsync(personInfo);
        }

        private void OnDailyDetails(object sender, EventArgs e)
        {
            MainStack.IsVisible = false;
            SecondaryStack.IsVisible = true;
        }

        private void OnBackToHome(object sender, EventArgs e)
        {
            SecondaryStack.IsVisible = false;
            MainStack.IsVisible = true;
        }

        async void ChangeCheckedState(int v, bool value, Person p)
        {
            string reComputeState = "";
            if (value)
            {
                for(int i = 0; i < 4; ++i)
                {
                    if (i != v)
                    {
                        reComputeState += p.CheckboxStatus[i];
                    }
                    else
                    {
                        reComputeState += "t";
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; ++i)
                {
                    if (i != v)
                    {
                        reComputeState += p.CheckboxStatus[i];
                    }
                    else
                    {
                        reComputeState += "f";
                    }
                }
            }

            p.CheckboxStatus = reComputeState;
            await App.Database.SavePersonAsync(p);
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            ChangeCheckedState(0, e.Value, (sender as CheckBox).BindingContext as Person);
        }

        private void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            ChangeCheckedState(1, e.Value, (sender as CheckBox).BindingContext as Person);
        }

        private void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            ChangeCheckedState(2, e.Value, (sender as CheckBox).BindingContext as Person);
        }

        private void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            ChangeCheckedState(3, e.Value, (sender as CheckBox).BindingContext as Person);
        }
    }
}
