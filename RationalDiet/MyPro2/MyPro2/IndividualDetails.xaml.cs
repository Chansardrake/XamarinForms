using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPro2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualDetails : ContentPage
    {
        string PersonName;
        List<string> Days;
        public IndividualDetails()
        {
            Days = new List<string>();
            GenerateDays();
            InitializeComponent();
            DayPicker.Title = "Pick a day";
            DayPicker.ItemsSource = Days;
        }

        private void GenerateDays()
        {
            for (int i = 1; i < 46; i++)
            {
                Days.Add($"Day {i}");
            }
        }

        private void DayPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayPicker.SelectedItem == null)
            {
                return;
            }

            int selectedDay = DayPicker.SelectedIndex + 1;
            if (selectedDay < 16)
            {
                if (selectedDay == 1)
                {
                    if ((this.BindingContext as Person).RoutineDay1 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay1);
                    }
                }
                else if (selectedDay == 2)
                {
                    if ((this.BindingContext as Person).RoutineDay2 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay2);
                    }
                }
                else if (selectedDay == 3)
                {
                    if ((this.BindingContext as Person).RoutineDay3 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay3);
                    }
                }
                else if (selectedDay == 4)
                {
                    if ((this.BindingContext as Person).RoutineDay4 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay4);
                    }
                }
                else if (selectedDay == 5)
                {
                    if ((this.BindingContext as Person).RoutineDay5 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay5);
                    }
                }
                else if (selectedDay == 6)
                {
                    if ((this.BindingContext as Person).RoutineDay6 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay6);
                    }
                }
                else if (selectedDay == 7)
                {
                    if ((this.BindingContext as Person).RoutineDay7 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay7);
                    }
                }
                else if (selectedDay == 8)
                {
                    if ((this.BindingContext as Person).RoutineDay8 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay8);
                    }
                }
                else if (selectedDay == 9)
                {
                    if ((this.BindingContext as Person).RoutineDay9 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay9);
                    }
                }
                else if (selectedDay == 10)
                {
                    if ((this.BindingContext as Person).RoutineDay10 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay10);
                    }
                }
                else if (selectedDay == 11)
                {
                    if ((this.BindingContext as Person).RoutineDay11 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay11);
                    }
                }
                else if (selectedDay == 12)
                {
                    if ((this.BindingContext as Person).RoutineDay12 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay12);
                    }
                }
                else if (selectedDay == 13)
                {
                    if ((this.BindingContext as Person).RoutineDay13 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay13);
                    }
                }
                else if (selectedDay == 14)
                {
                    if ((this.BindingContext as Person).RoutineDay14 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay14);
                    }
                }
                else if (selectedDay == 15)
                {
                    if ((this.BindingContext as Person).RoutineDay15 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay15);
                    }
                }
            }
            else if (selectedDay < 31)
            {
                if (selectedDay == 16)
                {
                    if ((this.BindingContext as Person).RoutineDay16 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay16);
                    }
                }
                else if (selectedDay == 17)
                {
                    if ((this.BindingContext as Person).RoutineDay17 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay17);
                    }
                }
                else if (selectedDay == 18)
                {
                    if ((this.BindingContext as Person).RoutineDay18 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay18);
                    }
                }
                else if (selectedDay == 19)
                {
                    if ((this.BindingContext as Person).RoutineDay19 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay19);
                    }
                }
                else if (selectedDay == 20)
                {
                    if ((this.BindingContext as Person).RoutineDay20 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay20);
                    }
                }
                else if (selectedDay == 21)
                {
                    if ((this.BindingContext as Person).RoutineDay21 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay21);
                    }
                }
                else if (selectedDay == 22)
                {
                    if ((this.BindingContext as Person).RoutineDay22 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay22);
                    }
                }
                else if (selectedDay == 23)
                {
                    if ((this.BindingContext as Person).RoutineDay23 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay23);
                    }
                }
                else if (selectedDay == 24)
                {
                    if ((this.BindingContext as Person).RoutineDay24 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay24);
                    }
                }
                else if (selectedDay == 25)
                {
                    if ((this.BindingContext as Person).RoutineDay25 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay25);
                    }
                }
                else if (selectedDay == 26)
                {
                    if ((this.BindingContext as Person).RoutineDay26 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay26);
                    }
                }
                else if (selectedDay == 27)
                {
                    if ((this.BindingContext as Person).RoutineDay27 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay27);
                    }
                }
                else if (selectedDay == 28)
                {
                    if ((this.BindingContext as Person).RoutineDay28 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay28);
                    }
                }
                else if (selectedDay == 29)
                {
                    if ((this.BindingContext as Person).RoutineDay29 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay29);
                    }
                }
                else if (selectedDay == 30)
                {
                    if ((this.BindingContext as Person).RoutineDay30 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay30);
                    }
                }
            }
            else if (selectedDay < 46)
            {
                if (selectedDay == 31)
                {
                    if ((this.BindingContext as Person).RoutineDay31 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay31);
                    }
                }
                else if (selectedDay == 32)
                {
                    if ((this.BindingContext as Person).RoutineDay32 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay32);
                    }
                }
                else if (selectedDay == 33)
                {
                    if ((this.BindingContext as Person).RoutineDay33 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay33);
                    }
                }
                else if (selectedDay == 34)
                {
                    if ((this.BindingContext as Person).RoutineDay34 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay34);
                    }
                }
                else if (selectedDay == 35)
                {
                    if ((this.BindingContext as Person).RoutineDay35 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay35);
                    }
                }
                else if (selectedDay == 36)
                {
                    if ((this.BindingContext as Person).RoutineDay36 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay36);
                    }
                }
                else if (selectedDay == 37)
                {
                    if ((this.BindingContext as Person).RoutineDay37 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay37);
                    }
                }
                else if (selectedDay == 38)
                {
                    if ((this.BindingContext as Person).RoutineDay38 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay38);
                    }
                }
                else if (selectedDay == 39)
                {
                    if ((this.BindingContext as Person).RoutineDay39 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay39);
                    }
                }
                else if (selectedDay == 40)
                {
                    if ((this.BindingContext as Person).RoutineDay40 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay40);
                    }
                }
                else if (selectedDay == 41)
                {
                    if ((this.BindingContext as Person).RoutineDay41 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay41);
                    }
                }
                else if (selectedDay == 42)
                {
                    if ((this.BindingContext as Person).RoutineDay42 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay42);
                    }
                }
                else if (selectedDay == 43)
                {
                    if ((this.BindingContext as Person).RoutineDay43 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay43);
                    }
                }
                else if (selectedDay == 44)
                {
                    if ((this.BindingContext as Person).RoutineDay44 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay44);
                    }
                }
                else if (selectedDay == 45)
                {
                    if ((this.BindingContext as Person).RoutineDay45 != null)
                    {
                        SetValuesForElements((this.BindingContext as Person).RoutineDay45);
                    }
                }
            }

            PersonName = this.Title;
            this.Title += " " + (DayPicker.SelectedItem as string);
            DayDetails.IsVisible = true;
            PickerGrid.IsVisible = false;
        }

        private string SetValuesForElements(string DayRoutine, bool flag = false, bool popDetails = false)
        {
            if (DayRoutine == null)
            {
                return "";
            }

            int idx, idx1;
            idx = idx1 = 0;
            string BF, L, Di, D, R, hh, mm, ss;
            BF = L = Di = D = R = hh = mm = ss = string.Empty;
            TimeSpan BFT, LT, DiT;
            BFT = LT = DiT = new TimeSpan(12, 0, 0);

            idx = DayRoutine.IndexOf("-R-");
            idx1 = DayRoutine.IndexOf("-@-");
            for (int i = idx + 3; i < idx1; ++i)
            {
                R += DayRoutine[i];
            }

            idx = DayRoutine.IndexOf("-Di-");
            idx1 = DayRoutine.IndexOf("-R-");
            for (int i = idx + 4; i < idx1; ++i)
            {
                Di += DayRoutine[i];
            }

            idx = DayRoutine.IndexOf("-DiT-");
            idx1 = DayRoutine.IndexOf("-Di-");
            hh = string.Format("{0}{1}", DayRoutine[idx + 5], DayRoutine[idx + 6]);
            mm = string.Format("{0}{1}", DayRoutine[idx + 8], DayRoutine[idx + 9]);
            ss = string.Format("{0}{1}", DayRoutine[idx + 11], DayRoutine[idx + 12]);
            DiT = new TimeSpan(int.Parse(hh), int.Parse(mm), int.Parse(ss));

            idx = DayRoutine.IndexOf("-L-");
            idx1 = DayRoutine.IndexOf("-DiT-");
            for (int i = idx + 3; i < idx1; ++i)
            {
                L += DayRoutine[i];
            }

            idx = DayRoutine.IndexOf("-LT-");
            idx1 = DayRoutine.IndexOf("-L-");
            hh = string.Format("{0}{1}", DayRoutine[idx + 4], DayRoutine[idx + 5]);
            mm = string.Format("{0}{1}", DayRoutine[idx + 7], DayRoutine[idx + 8]);
            ss = string.Format("{0}{1}", DayRoutine[idx + 10], DayRoutine[idx + 11]);
            LT = new TimeSpan(int.Parse(hh), int.Parse(mm), int.Parse(ss));

            idx = DayRoutine.IndexOf("-BF-");
            idx1 = DayRoutine.IndexOf("-LT-");
            for (int i = idx + 4; i < idx1; ++i)
            {
                BF += DayRoutine[i];
            }

            idx = DayRoutine.IndexOf("-BFT-");
            idx1 = DayRoutine.IndexOf("-BF-");
            hh = string.Format("{0}{1}", DayRoutine[idx + 5], DayRoutine[idx + 6]);
            mm = string.Format("{0}{1}", DayRoutine[idx + 8], DayRoutine[idx + 9]);
            ss = string.Format("{0}{1}", DayRoutine[idx + 11], DayRoutine[idx + 12]);
            BFT = new TimeSpan(int.Parse(hh), int.Parse(mm), int.Parse(ss));

            idx = DayRoutine.IndexOf("-D-");
            idx1 = DayRoutine.IndexOf("-BFT-");
            for (int i = idx + 3; i < idx1; ++i)
            {
                D += DayRoutine[i];
            }

            if (flag)
            {
                return "Day-" + D + " BFT-" + BFT.ToString() + " BF-" + BF + " LT-" + LT.ToString() + " L-" + L + " DT-" + DiT.ToString() + " D-" + Di + " R-" + R + "\n";
            }

            breakFastTime.Time = BFT;
            lunchTime.Time = LT;
            dinnerTime.Time = DiT;
            breakFast.Text = BF;
            lunch.Text = L;
            dinner.Text = Di;
            remarks.Text = R;
            return "";
        }

        async void OnCopyToClipboard(object sender, EventArgs e)
        {
            Person CurrPerson = this.BindingContext as Person;
            string AllRoutines = string.Empty;
            AllRoutines += 
                SetValuesForElements(CurrPerson.RoutineDay1, true) + SetValuesForElements(CurrPerson.RoutineDay2, true) +  
                SetValuesForElements(CurrPerson.RoutineDay3, true) + SetValuesForElements(CurrPerson.RoutineDay4, true) +
                SetValuesForElements(CurrPerson.RoutineDay5, true) + SetValuesForElements(CurrPerson.RoutineDay6, true) +
                SetValuesForElements(CurrPerson.RoutineDay7, true) + SetValuesForElements(CurrPerson.RoutineDay8, true) +
                SetValuesForElements(CurrPerson.RoutineDay9, true) + SetValuesForElements(CurrPerson.RoutineDay10, true) +
                SetValuesForElements(CurrPerson.RoutineDay11, true) + SetValuesForElements(CurrPerson.RoutineDay12, true) + 
                SetValuesForElements(CurrPerson.RoutineDay13, true) + SetValuesForElements(CurrPerson.RoutineDay14, true) + 
                SetValuesForElements(CurrPerson.RoutineDay15, true) + SetValuesForElements(CurrPerson.RoutineDay16, true) + 
                SetValuesForElements(CurrPerson.RoutineDay17, true) + SetValuesForElements(CurrPerson.RoutineDay18, true) + 
                SetValuesForElements(CurrPerson.RoutineDay19, true) + SetValuesForElements(CurrPerson.RoutineDay20, true) +
                SetValuesForElements(CurrPerson.RoutineDay21, true) + SetValuesForElements(CurrPerson.RoutineDay22, true) + 
                SetValuesForElements(CurrPerson.RoutineDay23, true) + SetValuesForElements(CurrPerson.RoutineDay24, true) + 
                SetValuesForElements(CurrPerson.RoutineDay25, true) + SetValuesForElements(CurrPerson.RoutineDay26, true) + 
                SetValuesForElements(CurrPerson.RoutineDay27, true) + SetValuesForElements(CurrPerson.RoutineDay28, true) + 
                SetValuesForElements(CurrPerson.RoutineDay29, true) + SetValuesForElements(CurrPerson.RoutineDay30, true) +
                SetValuesForElements(CurrPerson.RoutineDay31, true) + SetValuesForElements(CurrPerson.RoutineDay32, true) + 
                SetValuesForElements(CurrPerson.RoutineDay33, true) + SetValuesForElements(CurrPerson.RoutineDay34, true) + 
                SetValuesForElements(CurrPerson.RoutineDay35, true) + SetValuesForElements(CurrPerson.RoutineDay36, true) + 
                SetValuesForElements(CurrPerson.RoutineDay37, true) + SetValuesForElements(CurrPerson.RoutineDay38, true) + 
                SetValuesForElements(CurrPerson.RoutineDay39, true) + SetValuesForElements(CurrPerson.RoutineDay40, true) +
                SetValuesForElements(CurrPerson.RoutineDay41, true) + SetValuesForElements(CurrPerson.RoutineDay42, true) + 
                SetValuesForElements(CurrPerson.RoutineDay43, true) + SetValuesForElements(CurrPerson.RoutineDay44, true) + 
                SetValuesForElements(CurrPerson.RoutineDay45, true);

            if(AllRoutines == string.Empty)
            {
                await DisplayAlert("Information", "No entries found!", "Ok");
                return;
            }

            await Clipboard.SetTextAsync("Name: " + CurrPerson.Name + "\nFollowing are the representation\nBreakFastTime-BFT BreakFast-BF LunchTime-LT Lunch-L DinnerTime-DT Dinner-D Remarks-R\n" + AllRoutines);
        }

        async void OnSaveDetails(object sender, EventArgs e)
        {
            int selectedDay = DayPicker.SelectedIndex + 1;
            if (selectedDay < 16)
            {
                if (selectedDay == 1)
                {
                    (this.BindingContext as Person).RoutineDay1 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 2)
                {
                    (this.BindingContext as Person).RoutineDay2 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 3)
                {
                    (this.BindingContext as Person).RoutineDay3 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 4)
                {
                    (this.BindingContext as Person).RoutineDay4 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 5)
                {
                    (this.BindingContext as Person).RoutineDay5 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 6)
                {
                    (this.BindingContext as Person).RoutineDay6 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 7)
                {
                    (this.BindingContext as Person).RoutineDay7 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 8)
                {
                    (this.BindingContext as Person).RoutineDay8 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 9)
                {
                    (this.BindingContext as Person).RoutineDay9 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 10)
                {
                    (this.BindingContext as Person).RoutineDay10 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 11)
                {
                    (this.BindingContext as Person).RoutineDay11 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 12)
                {
                    (this.BindingContext as Person).RoutineDay12 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 13)
                {
                    (this.BindingContext as Person).RoutineDay13 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 14)
                {
                    (this.BindingContext as Person).RoutineDay14 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 15)
                {
                    (this.BindingContext as Person).RoutineDay15 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
            }
            else if (selectedDay < 31)
            {
                if (selectedDay == 16)
                {
                    (this.BindingContext as Person).RoutineDay16 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 17)
                {
                    (this.BindingContext as Person).RoutineDay17 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 18)
                {
                    (this.BindingContext as Person).RoutineDay18 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 19)
                {
                    (this.BindingContext as Person).RoutineDay19 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 20)
                {
                    (this.BindingContext as Person).RoutineDay20 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 21)
                {
                    (this.BindingContext as Person).RoutineDay21 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 22)
                {
                    (this.BindingContext as Person).RoutineDay22 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 23)
                {
                    (this.BindingContext as Person).RoutineDay23 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 24)
                {
                    (this.BindingContext as Person).RoutineDay24 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 25)
                {
                    (this.BindingContext as Person).RoutineDay25 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 26)
                {
                    (this.BindingContext as Person).RoutineDay26 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 27)
                {
                    (this.BindingContext as Person).RoutineDay27 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 28)
                {
                    (this.BindingContext as Person).RoutineDay28 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 29)
                {
                    (this.BindingContext as Person).RoutineDay29 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 30)
                {
                    (this.BindingContext as Person).RoutineDay30 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
            }
            else if (selectedDay < 46)
            {
                if (selectedDay == 31)
                {
                    (this.BindingContext as Person).RoutineDay31 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 32)
                {
                    (this.BindingContext as Person).RoutineDay32 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 33)
                {
                    (this.BindingContext as Person).RoutineDay33 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 34)
                {
                    (this.BindingContext as Person).RoutineDay34 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 35)
                {
                    (this.BindingContext as Person).RoutineDay35 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 36)
                {
                    (this.BindingContext as Person).RoutineDay36 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 37)
                {
                    (this.BindingContext as Person).RoutineDay37 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 38)
                {
                    (this.BindingContext as Person).RoutineDay38 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 39)
                {
                    (this.BindingContext as Person).RoutineDay39 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 40)
                {
                    (this.BindingContext as Person).RoutineDay40 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 41)
                {
                    (this.BindingContext as Person).RoutineDay41 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 42)
                {
                    (this.BindingContext as Person).RoutineDay42 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 43)
                {
                    (this.BindingContext as Person).RoutineDay43 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 44)
                {
                    (this.BindingContext as Person).RoutineDay44 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
                else if (selectedDay == 45)
                {
                    (this.BindingContext as Person).RoutineDay45 = $"-D-{selectedDay.ToString()}-BFT-{breakFastTime.Time.ToString()}-BF-{breakFast.Text}-LT-{lunchTime.Time.ToString()}-L-{lunch.Text}-DiT-{dinnerTime.Time.ToString()}-Di-{dinner.Text}-R-{remarks.Text}-@-";
                }
            }


            await App.Database.SavePersonAsync(this.BindingContext as Person);
            
            await DisplayAlert("Details added!", $"{(this.BindingContext as Person).Name} Day{selectedDay.ToString()}\nBFT-{breakFastTime.Time.ToString()}\nBF-{breakFast.Text}\nLT-{lunchTime.Time.ToString()}\nL-{lunch.Text}\nDT-{dinnerTime.Time.ToString()}\nD-{dinner.Text}\nR-{remarks.Text}", "Ok");

            this.Title = PersonName;
            breakFast.Text = lunch.Text = dinner.Text = remarks.Text = string.Empty;
            breakFastTime.Time = new TimeSpan(12, 0, 0);
            lunchTime.Time = new TimeSpan(12, 0, 0);
            dinnerTime.Time = new TimeSpan(12, 0, 0);
            DayDetails.IsVisible = false;
            PickerGrid.IsVisible = true;
            DayPicker.SelectedItem = null;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.Title = PersonName;
            breakFast.Text = lunch.Text = dinner.Text = remarks.Text = string.Empty;
            breakFastTime.Time = new TimeSpan(12, 0, 0);
            lunchTime.Time = new TimeSpan(12, 0, 0);
            dinnerTime.Time = new TimeSpan(12, 0, 0);
            DayDetails.IsVisible = false;
            PickerGrid.IsVisible = true;
            DayPicker.SelectedItem = null;
        }

        async void OnDeleteUser(object sender, EventArgs e)
        {
            bool status = await DisplayAlert("Warning!",$"Are you sure to delete '{(this.BindingContext as Person).Name}' details?","Yes","No");
            if (status)
            {
                var person = this.BindingContext as Person;
                await App.Database.DeleteItemAsync(person);
                await App.Current.MainPage.Navigation.PopAsync();
            }
        }

        private void OnEditUser(object sender, EventArgs e)
        {
            nameEntry.Text = (this.BindingContext as Person).Name;
            ageEntry.Text = (this.BindingContext as Person).Age;
            wgtEntry.Text = (this.BindingContext as Person).Weight;
            PickerGrid.IsVisible = false;
            EditDetails.IsVisible = true;
        }

        async void OnSaveChanges(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text) && !string.IsNullOrWhiteSpace(wgtEntry.Text))
            {
                this.Title = (this.BindingContext as Person).Name = nameEntry.Text;
                (this.BindingContext as Person).Age = ageEntry.Text;
                (this.BindingContext as Person).Weight = wgtEntry.Text;
                await App.Database.SavePersonAsync(this.BindingContext as Person);
                nameEntry.Text = ageEntry.Text = wgtEntry.Text = string.Empty;
            }
            else
            {
                await DisplayAlert("Information", "Please enter all details!", "Ok");
                return;
            }

            EditDetails.IsVisible = false;
            PickerGrid.IsVisible = true;
        }

        private void OnCancelChanges(object sender, EventArgs e)
        {
            EditDetails.IsVisible = false;
            PickerGrid.IsVisible = true;
        }
    }
}