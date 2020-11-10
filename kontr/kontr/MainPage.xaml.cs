using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kontr
{
    public partial class MainPage : ContentPage
    {
        Picker picker;
        Editor editor;
        DatePicker dpicker;
        Entry entry;
        TimePicker tpicker;
        string hh;
        public MainPage()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
        };
        picker = new Picker
            {
                Title = "Языки"
            };
            picker.Items.Add("C#");
            picker.Items.Add("Python");
            picker.Items.Add("C++");
            picker.Items.Add("VisualBasic");
            picker.Items.Add("Java");
            gr.Children.Add(picker, 0, 0);
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            editor = new Editor { Placeholder = "Выбери язык \nпрограммирования" };
            gr.Children.Add(editor, 1, 0);

            tpicker = new TimePicker()
            {
                Time = new TimeSpan(18, 0, 0)
            };
            tpicker.PropertyChanged += Tpicker_PropertyChanged;
            gr.Children.Add(tpicker, 1, 1);
            entry = new Entry { Text = "Выбери число \nили время" };
            gr.Children.Add(entry, 0, 1);
            Content = gr;
        }
        private void Tpicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                TimeSpan selctTime = tpicker.Time;
                entry.Text = selctTime.ToString();
            }
        }

        private void Dpicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            entry.Text = "Твоя дата:\n" + e.NewDate.ToString("G");
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = "Oli valitud: " + picker.Items[picker.SelectedIndex];
        }
    }
}